using System;
using System.Windows;

namespace PresenterCommands
{
    public class DinnerPresenter
    {
        public DinnerPresenter()
        {
            presentation_model = new DinnerPresentationModel();
        }

        public DinnerPresentationModel presentation_model { get; set; }

        public void HookupHandlers()
        {
            presentation_model.DinnerCommand.ExecuteCommand += SomeMethodToExecuteWhenWeEatDinner_ThisWouldIdeallyNotBeOnThePresenter;
            presentation_model.DinnerCommand.CanExecuteCommand += SomeMethodToExecuteWhenWeCanEatDinner_ThisChangesTheStateOfTheCommand;
        }

        void SomeMethodToExecuteWhenWeEatDinner_ThisWouldIdeallyNotBeOnThePresenter(string message)
        {
            MessageBox.Show("Eating dinner: " + message);
        }

        bool SomeMethodToExecuteWhenWeCanEatDinner_ThisChangesTheStateOfTheCommand()
        {
            return true;
        }
    }
}