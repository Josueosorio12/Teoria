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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Capitulo4y5
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
            Capitulo4 capitulo4 = new Capitulo4();
            capitulo4.Owner = this;
            capitulo4.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Capitulo5 capitulo5 = new Capitulo5();
            capitulo5.Owner = this;
            capitulo5.ShowDialog();
        }
    }
}
