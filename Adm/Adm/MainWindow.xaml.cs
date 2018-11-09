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

namespace Adm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NominaEntities db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Pruebas de conexion*/

            /*Pueden ver el siguiente tutorial que les puede:
             https://www.csharp-console-examples.com/wpf/wpf-entity-framework-select-insert-update-delete/
             */

            db = new NominaEntities();


            //Concepto c = new Concepto();
            //c.Descripcion = "Premio";
            //c.Tipo = "+";

            //db.Concepto.Add(c);
            //db.SaveChanges();

            //lstConceptos.ItemsSource = db.Concepto.ToList();

            dgPrueba.ItemsSource = db.Concepto.ToList();
        }

        private void dgPrueba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgPrueba.SelectedItem.GetType() == typeof(Concepto))
            {
                Concepto c = (Concepto)dgPrueba.SelectedItem;
            }
            else
            {
                MessageBox.Show("Nada Seleccionado");
            }
        }
    }
}
