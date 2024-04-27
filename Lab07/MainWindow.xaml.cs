using Business;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomerBusiness business = new CustomerBusiness();
            GetCustomerName.ItemsSource = business.GetCostumers("");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerBusiness business = new CustomerBusiness();
            GetCustomerName.ItemsSource = business.GetCostumersByName("");
        }
    }
}