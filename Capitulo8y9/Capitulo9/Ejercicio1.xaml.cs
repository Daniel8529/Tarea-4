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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    struct Productos
    {
        public int Productoid { get; set; }

    
        public string Descricion  { get; set; }

        public int Costo { get; set; }

        public int Exitencia { get; set; }


       public Productos(int productoid , string descricion,int costo,int exitencia ){

         this.Productoid=productoid;
         this.Descricion=descricion;
         this.Costo=costo;
         this.Exitencia=exitencia;
       }
        public override string ToString()
            {
                StringBuilder imprimir = new StringBuilder();
                imprimir.AppendFormat($"ProductoID:{ Productoid}\n Nombre:{Descricion}\n Cantidad:{Costo}\n Precio:{Exitencia}");
                return imprimir.ToString();
         }


    }


    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
          
            
            Productos producto = new Productos(int.Parse(Productoidtxt.Text),descriciontxt.Text,int.Parse(costotxt.Text), int.Parse(existenciatxt.Text));
           


        }

        private void imprimir_Click(object sender, RoutedEventArgs e)
        {



           Productos producto = new Productos(int.Parse(Productoidtxt.Text),descriciontxt.Text,int.Parse(costotxt.Text), int.Parse(existenciatxt.Text));
           pantalla.Items.Add(producto);
      
        }
    }
}
