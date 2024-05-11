using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Lógica de interacción para Opciones.xaml
    /// </summary>
    public partial class Opciones : Window
    {
        public Opciones()
        {
            InitializeComponent();
        }
        private void ListarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow listar = new MainWindow();
            listar.Show();
            Close();
        }

        private void EliminarBtn_Click(object sender, RoutedEventArgs e)
        {
            Delete eliminar = new Delete();
            eliminar.Show();
            Close();
        }

        private void InsertarBtn_Click(object sender, RoutedEventArgs e)
        {
            Insert crear = new Insert();
            crear.Show();
            Close();
        }
    }
}
