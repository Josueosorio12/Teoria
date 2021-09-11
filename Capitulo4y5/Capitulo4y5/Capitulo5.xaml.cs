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
    /// Interaction logic for Capitulo5.xaml
    /// </summary>
    public partial class Capitulo5 : Window
    {
        public Capitulo5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_4 ejercicio = new Ejercicio_4();
            ejercicio.Owner = this;
            ejercicio.ShowDialog();
        }
    }
}
