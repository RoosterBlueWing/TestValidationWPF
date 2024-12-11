using System;
using System.Windows;

namespace TestValidation {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        MainWindowViewModel mainWindowViewModel;

        public MainWindow() {

            InitializeComponent();

            mainWindowViewModel = new MainWindowViewModel();

            DataContext = mainWindowViewModel;

            Dispatcher.BeginInvoke(new Action(() => {

                mainWindowViewModel.Init();
            }), System.Windows.Threading.DispatcherPriority.ApplicationIdle);
        }
    }
}
