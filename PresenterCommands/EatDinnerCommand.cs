using System;
using System.Windows.Input;

namespace PresenterCommands
{
    public class EatDinnerCommand : ICommand
    {
        void ICommand.Execute(object parameter)
        {
            OnEatDinner();
        }

        bool ICommand.CanExecute(object parameter)
        {
            foreach (Func<bool> target in _canEatDinner.GetInvocationList())
            {
                _canExecute = _canExecute || target();
            }
            return _canExecute;
        }

        void OnEatDinner()
        {
            var evt = EatDinner;
            if (evt != null) EatDinner(this, EventArgs.Empty);
        }

        public event EventHandler EatDinner;
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