using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_App1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _count = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            PrintToConsole("Some message text from business layer should come here. If nothing comes then empty text must be print. This text will be logged too.");
        }

        private void PrintToConsole(string message)
        {
            txt_Output.Text += $"{_count}. {message} \n";
            _count++;
        }
    }
}
