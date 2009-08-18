using System;
using System.Windows;

namespace PresenterCommands
{
    public class DinnerPresentationModel
    {
        public DinnerPresentationModel()
        {
            DinnerCommand = new ParameterisedCommand<string>();
        }

        public ParameterisedCommand<string> DinnerCommand { get; private set; }
    }
}