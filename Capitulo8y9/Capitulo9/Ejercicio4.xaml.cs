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

namespace Capitulo8y9.Capitulo9
{
    /// <summary>
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        enum TipoNeumatico
        {
           NeumaticoDeportivo=30,
            NeumaticoPista=20,
          
        };
        private void imprimir_Click(object sender, RoutedEventArgs e)
        {
           

           neumatico();
        }

        public void neumatico()
        {
            TipoNeumatico mineumatico1 = TipoNeumatico.NeumaticoDeportivo;
            TipoNeumatico mineumatico2 = TipoNeumatico.NeumaticoPista;
         

          
            pantalla.Items.Add(mineumatico1);
            pantalla.Items.Add(mineumatico2);
        }
    }

}
