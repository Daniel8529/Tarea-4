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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class ejercicio3 : Window
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        struct Mascota
        {
            public string Nombremascotas { get; set; }



            public Mascota(string nombremascotas)
            {

                this.Nombremascotas =nombremascotas;
                
             
            }
           public override string ToString()
            {
                StringBuilder imprimir = new StringBuilder();
                imprimir.AppendFormat($"Nombre de la mascota:{Nombremascotas}");
                return imprimir.ToString();
            }
            


        }

          struct Dueno
        {
            public string Nombre { get; set; }

        

            public Dueno(string nombre,string Nombremascotas )
            {

                this.Nombre =nombre;
                Mascota mascota=new Mascota(Nombremascotas);
             
            }
           public override string ToString()
            {
                StringBuilder imprimir = new StringBuilder();
                imprimir.AppendFormat($"Nombre de duena:{Nombre }");
                return imprimir.ToString();
            }
        


        }






        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {


            Dueno p = new Dueno(duenotxt.Text,mascotatxt.Text);
            Mascota m = new Mascota(mascotatxt.Text);



        }

        private void imprimir_Click(object sender, RoutedEventArgs e)
        {

           
            Dueno p = new Dueno(duenotxt.Text,mascotatxt.Text);
            Mascota m=new Mascota(mascotatxt.Text);
            pantalla.Items.Add(p);
            pantalla.Items.Add(m);

        

        }

    }
}
