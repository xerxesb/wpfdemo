using System;
using System.Windows;

namespace PresenterCommands
{
    public class DinnerPresentationModel// : DependencyObject
    {
//        static public readonly DependencyProperty DinnerCommandProperty = DependencyProperty.Register("CookDinnerCommand", typeof (EatDinnerCommand), typeof (DinnerPresentationModel));

        public DinnerPresentationModel()
        {
            DinnerCommand = new EatDinnerCommand();
        }


        public EatDinnerCommand DinnerCommand { get; set; }
        //{
        //    get { return (EatDinnerCommand)GetValue(DinnerCommandProperty); }
        //    set { SetValue(DinnerCommandProperty, value); }
        //}


        //public class SimpleViewPresentationModel : DependencyObject {
        //    public SimpleViewPresentationModel() {
        //        CookDinnerCommand = new StringDelegateCommand();
        //    }
        //    public static readonly DependencyProperty CookDinnerCommandProperty = DependencyProperty.Register("CookDinnerCommand", typeof(StringDelegateCommand), typeof(SimpleViewPresentationModel));

        //    public StringDelegateCommand CookDinnerCommand {
        //        // IMPORTANT: To maintain parity between setting a property in XAML and procedural code, do not touch the getter and setter inside this dependency property!
        //        get {
        //            return (StringDelegateCommand)GetValue(CookDinnerCommandProperty);
        //        }
        //        set {
        //            SetValue(CookDinnerCommandProperty, value);
        //        }
        //    }

        //}

    }
}