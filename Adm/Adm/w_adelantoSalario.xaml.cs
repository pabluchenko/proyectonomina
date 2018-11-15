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

namespace Adm
{
    /// <summary>
    /// Lógica de interacción para w_adelantoSalario.xaml
    /// </summary>
    public partial class w_adelantoSalario : Window
    {
        NominaEntities db; //Con eso, declaras una variable de tipo del Modelo

        public w_adelantoSalario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //llamamos a los datos de la bd
            db = new NominaEntities(); //...pero aca recien estas creando la instancia al invocar a su constructor...

            var datos = db.Anticipo.ToList(); //aca estas usando db, para traer de la entidad Anticipo, todos haciendo el ToList

            //falta esto
            //PLAN A
            dtgDatos.ItemsSource = datos; //En primera instancia, proba si funciona asi... si no te funciona asi (puede que no funcione, porque definiste las cabeceras.. si no te funca, plan B..

            //recorres tu coleccion de datos y vas metiendo en tu datagrid..
            //PLAN B
            //foreach(var d in datos)
            //{
            //    dtgDatos.Items.Add(d);
            //}


        }

        private void txtFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            var anticipos = db.Anticipo.ToList();

            var filtro = from c in anticipos
                         where c.Estado.ToUpper().Equals(txtFiltro.Text.ToUpper())
                         select c;


        }

        private void btnAprobar_Click(object sender, RoutedEventArgs e)
        {
          

        }

        private void btnrechazar_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
