using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
            txtHello.Text = "Stopped";
            btnRun.Content = "Start";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                btnRun.Content = "Start";
                txtHello.Text = "Stopped";
                btnRun.Background = Brushes.Red;
            }
            else
            {
                btnRun.Content = "Stop";
                txtHello.Text = "Running";
                btnRun.Background = Brushes.Green;
            }
            running = !running;
        }
    }
}