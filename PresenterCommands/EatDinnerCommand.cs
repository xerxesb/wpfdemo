using System;
using System.Windows.Input;

namespace PresenterCommands
{
    public class EatDinnerCommand : ICommand
    {
        void ICommand.Execute(object parameter)
        {
            OnEatDinner((string)parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            foreach (Func<bool> target in _canEatDinner.GetInvocationList())
            {
                _canExecute = _canExecute || target();
            }
            return _canExecute;
        }

        void OnEatDinner(string message)
        {
            var evt = EatDinner;
            if (evt != null) EatDinner(message);
        }

        public event Action<string> EatDinner;
        public event Func<bool> CanEatDinner
        {
            add 
            { 
                _canEatDinner += value;
                CanExecuteChanged(this, EventArgs.Empty);
            }
            remove 
            {
                _canEatDinner -= value;
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler CanExecuteChanged;

        Func<bool> _canEatDinner = () => false;
        bool _canExecute;
    }
}