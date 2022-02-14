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
using Capitulo8y9.Capitulo8;
using Capitulo8y9.Capitulo9;

namespace Capitulo8y9
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

        private void ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3 ejercicio3= new Ejercicio3();
            ejercicio3.Show();
        }

        private void ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5= new Ejercicio5();
            ejercicio5.Show();
            
        }

         private void ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejercicio1= new Ejercicio1();
            ejercicio1.Show();
            
        }
         private void ejercicio31_Click(object sender, RoutedEventArgs e)
        {
            ejercicio3 ejercicio3e= new ejercicio3();
            ejercicio3e.Show();
            
        }

         private void ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4= new Ejercicio4();
            ejercicio4.Show();
            
        }
    }
}
