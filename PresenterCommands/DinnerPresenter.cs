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
            presentation_model.DinnerCommand.EatDinner += SomeMethodToExecuteWhenWeEatDinner_ThisWouldIdeallyNotBeOnThePresenter;
            presentation_model.DinnerCommand.CanEatDinner += SomeMethodToExecuteWhenWeCanEatDinner_ThisChangesTheStateOfTheCommand;
        }

        void SomeMethodToExecuteWhenWeEatDinner_ThisWouldIdeallyNotBeOnThePresenter(object sender, EventArgs e)
        {
            MessageBox.Show("Eating dinner: ");
        }

        bool SomeMethodToExecuteWhenWeCanEatDinner_ThisChangesTheStateOfTheCommand()
        {
            return true;
        }
    }
}