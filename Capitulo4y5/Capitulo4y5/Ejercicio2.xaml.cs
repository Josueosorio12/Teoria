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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public static int NumeroEntero = 0, PotenciaEntero = 0;
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularPotencia_Click(object sender, RoutedEventArgs e)
        {
            int Resultado = 1, contenedor = 1;
            String numero;
            String potencia;
            potencia = this.Numero2.Text;
            numero = this.Numero.Text;
            int.TryParse(numero, out NumeroEntero);
            int.TryParse(potencia, out PotenciaEntero);

            for (int i = 0; i < PotenciaEntero; i++)
            {
                contenedor = Resultado;
                Resultado = NumeroEntero * contenedor;

            }

            if (Numero.Text != "" && Numero2.Text != "")
            {
                MessageBox.Show($"{Resultado}", "El Resultado Es",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Ingrese un numero", "", MessageBoxButton.OK, MessageBoxImage.Error);
                Numero.Focus();
            }
            this.Numero2.Clear();
            this.Numero.Clear();
        }
    }
    }
