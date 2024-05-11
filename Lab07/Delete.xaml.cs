using Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;

namespace Lab07
{
    /// <summary>
    /// Lógica de interacción para Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            CustomerBusiness business = new CustomerBusiness();
            GetCustomerName.ItemsSource = business.GetCostumers("");
        }

        private void BtnBorrarCliente_Click(object sender, RoutedEventArgs e)
        {

            CustomerBusiness business = new CustomerBusiness();
            business.DeleteCustomer(1);
            CargarDatos();
        }
    }
}
