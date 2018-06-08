using FriendOrganizer.UI.ViewModel;
using System.Windows;

namespace FriendOrganizer.UI
{
    public partial class MainWindow
    {
        private MainViewModel _viewModel;
        
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            _viewModel = viewModel;

            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.Load();
        }
    }
}
