using System.Windows;

namespace PresenterCommands {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {

        DinnerPresenter _presenter = new DinnerPresenter();

        public Window1() {
            InitializeComponent();
            DataContext = _presenter.presentation_model;
        }

        void HookUpToPresenter(object sender, RoutedEventArgs e)
        {
            _presenter.HookupHandlers();
        }
    }
}
