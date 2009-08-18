using System;
using System.Windows.Input;

namespace PresenterCommands
{
    public class ParameterisedCommand<T> : ICommand
    {
        Func<bool> _canExecuteCommand = () => false;
        bool _canExecute;

        void ICommand.Execute(object parameter)
        {
            OnExecuteCommand((T)parameter);
        }

        private void OnExecuteCommand(T arg)
        {
            var evt = ExecuteCommand;
            if (evt != null) ExecuteCommand(arg);
        }

        bool ICommand.CanExecute(object parameter)
        {
            foreach (Func<bool> target in _canExecuteCommand.GetInvocationList())
            {
                _canExecute = _canExecute || target();
            }
            return _canExecute;
        }

        public event Action<T> ExecuteCommand;
        public event Func<bool> CanExecuteCommand
        {
            add 
            { 
                _canExecuteCommand += value;
                CanExecuteChanged(this, EventArgs.Empty);
            }
            remove 
            {
                _canExecuteCommand -= value;
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}