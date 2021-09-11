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
using System.Windows.Shapes;

namespace Capitulo4y5
{
    /// <summary>
    /// Interaction logic for Capitulo4.xaml
    /// </summary>
    public partial class Capitulo4 : Window
    {
        public Capitulo4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Owner = this;
            ejercicio.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejercicio = new Ejercicio2();
            ejercicio.Owner = this;
            ejercicio.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio = new Ejercicio5();
            ejercicio.Owner = this;
            ejercicio.ShowDialog();
        }
    }
}
