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

namespace Capitulo8y9.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public string[] cadenas = new string[6];
        public int indice = 0;
        public Ejercicio5()
        {
            InitializeComponent();
        }
        private void agregar_Click(object sender, RoutedEventArgs e)
        {



            if (indice < 6)
            {
                cadenas[indice] = cadenatext.Text;
                cadenatext.Text = " ";
                indice = indice + 1;
            }
            else
            {
                MessageBox.Show("No se permite mas calificacion", "Calificaciones llenas");
            }

        }



        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            

           
                IEnumerable<string> Orden = 
                from cadena in cadenas
                                            
                orderby cadena
                select cadena;

               
                foreach (string s in Orden)

                {

                   pantalla.Items.Add(s);
                }
            

        }
    }
}
