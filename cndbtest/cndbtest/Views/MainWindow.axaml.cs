using Avalonia.Controls;
using cndbtest.ViewModels;

namespace cndbtest.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
