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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

 

        private void multiplicar_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(Numero.Text);
            Tabla.Items.Clear();

            for(int j = 1; j <= 10; j++)
            {
                Tabla.Items.Add(i + "x" + j + "=" + i * j);
            }
        }

        private void nuevo_Click(object sender, RoutedEventArgs e)
        {
            Tabla.Items.Clear();
            Tabla.Focus();
        }
    }
}
