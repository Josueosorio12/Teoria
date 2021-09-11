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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public static int MAyor = 1, MEnor = 1, age = 1;
        public static int Contador = 0;
        public static float Promedio = 0, Acumulador = 0;

        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Promedio_Click(object sender, RoutedEventArgs e)
        {
           

            Tabla.Items.Add("La Edad MAyor es: ");
            Tabla.Items.Add(MAyor);

            Tabla.Items.Add("La Edad Menor es: ");
            Tabla.Items.Add(MEnor);

            Tabla.Items.Add("El promedio es: ");
            Tabla.Items.Add(Promedio);
           
        }    
        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            if (Edad.Text != "")
            {
                string str = Edad.Text;
                int.TryParse(str, out numero);

                this.Tabla.Items.Add(numero);
                Edad.Text = "";
                Contador++;
                Acumulador += numero;
                Edad.Focus();
                 Promedio = (Acumulador / Contador);
            }
            else
            {
                MessageBox.Show("Error", "",MessageBoxButton.OK, MessageBoxImage.Error);
                 Edad.Focus();             
            }
            age = numero;
            MAyor = MEnor = age;
            for (int x = 0; x < Tabla.Items.Count; x++)
            {

                if (MAyor < Convert.ToInt32(Tabla.Items[x]))
                {
                    MAyor = Convert.ToInt32(Tabla.Items[x]);

                }
                else if (MEnor > Convert.ToInt32(Tabla.Items[x]))
                {
                    MEnor = Convert.ToInt32(Tabla.Items[x]);
                }

            }

        }
    }
}
