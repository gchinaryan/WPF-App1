using System.Windows;
using MVVM_WpfApp1.ViewModel;


namespace MVVM_WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserViewModel model;

        public MainWindow()
        {
            model = new UserViewModel();
            model.Username = "Alex";
            DataContext = model;

            InitializeComponent();
        }

        private void btn_ChangeUsername_Click(object sender, RoutedEventArgs e)
        {
            model.Username = "Gg1-1";
        }
    }
}
