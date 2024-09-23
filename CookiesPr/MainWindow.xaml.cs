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

namespace CookiesPr
{
    public partial class MainWindow : Window
    {
        private int cookiecount = 0; /// First number of cookies

        public MainWindow()
        {
            InitializeComponent();
        }
       private void CookieDisplay_Click (object sender, RoutedEventArgs e)
        {
            /// this event is triggered when the button is clicked 
            cookiecount ++;
            CookieMeter.Text = cookiecount.ToString(); 
        }

        private void UpgradePower_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AutoClickUnlock_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AutoClickSpeed_Click(object sender, RoutedEventArgs e)
        {

        }

        private void A_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}