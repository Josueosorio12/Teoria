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
    /// Interaction logic for Ejercicio_4.xaml
    /// </summary>
    public partial class Ejercicio_4 : Window
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int numero = Convert.ToInt32(Numero.Text);

            for (int i = numero; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            MessageBox.Show($"El factorial de {numero} es {factorial}");
        }
    }
}
