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
    /// Interaction logic for W_RegistrarTurno.xaml
    /// </summary>
    public partial class W_RegistrarTurno : Window
    {

        NominaEntities db;
        Turno turnoseleccionado;

        public W_RegistrarTurno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new NominaEntities();

            lstTurnos.ItemsSource = db.Turno.ToList();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            Turno nuevoTurno =  new Turno();
            if (txtHEntrada.Text != "")
            {
                if (txtHSalida.Text != "")
                {
                    if (txtObserv.Text != "")
                    {
                        nuevoTurno.Hora_Entrada = txtHEntrada.Text;
                        nuevoTurno.Hora_Salida = txtHSalida.Text;
                        nuevoTurno.Observaciones = txtObserv.Text;
                        db.Turno.Add(nuevoTurno);
                        db.SaveChanges();
                        MessageBox.Show("Horario agregado exitosamente");
                        txtHEntrada.Text = txtHSalida.Text = txtObserv.Text = "";
                        lstTurnos.ItemsSource = db.Turno.ToList();
                    }
                    else MessageBox.Show("Debe ingresar alguna Observación");                    
                }
                else MessageBox.Show("Debe ingresar Hora de Salida");                
            }
            else MessageBox.Show("Debe ingresar Hora de Entrada");     
                  
                       
        }

        private void lstTurnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstTurnos.SelectedItem != null)
            {
                turnoseleccionado = (Turno)lstTurnos.SelectedItem;
            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (turnoseleccionado != null)
            {
                db.Turno.Remove(turnoseleccionado);
                db.SaveChanges();
                MessageBox.Show("Horario eliminado exitosamente");
                lstTurnos.ItemsSource = db.Turno.ToList();
            }
            else MessageBox.Show("Debe seleccionar el turno que quiere eliminar");
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (turnoseleccionado != null)
            {

                if (txtHEntrada.Text != "")
                {
                    if (txtHSalida.Text != "")
                    {
                        if (txtObserv.Text != "")
                        {
                            turnoseleccionado.Hora_Entrada = txtHEntrada.Text;
                            turnoseleccionado.Hora_Salida = txtHSalida.Text;
                            turnoseleccionado.Observaciones = txtObserv.Text;
                            db.SaveChanges();
                            MessageBox.Show("Horario modificado exitosamente");
                            txtHEntrada.Text = txtHSalida.Text = txtObserv.Text = "";
                            lstTurnos.ItemsSource = db.Turno.ToList();
                        }
                        else MessageBox.Show("Debe ingresar alguna Observación");
                    }
                    else MessageBox.Show("Debe ingresar Hora de Salida");
                }
                else MessageBox.Show("Debe ingresar Hora de Entrada");               
            }
            else MessageBox.Show("Debe seleccionar el turno que quiere modificar");
        }
    }
  
}
