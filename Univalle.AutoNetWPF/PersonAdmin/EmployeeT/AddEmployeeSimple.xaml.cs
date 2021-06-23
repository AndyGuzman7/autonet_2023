using DAO.Implementacion;
using DAO.Model;
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
using Univalle.AutoNetWPF.PersonasAdmin.EmployeeT;

namespace Univalle.AutoNetWPF.PersonAdmin.EmployeeT
{
    /// <summary>
    /// Lógica de interacción para AddEmployeeSimple.xaml
    /// </summary>
    public partial class AddEmployeeSimple : Window
    {
        public AddEmployeeSimple()
        {
            InitializeComponent();
        }
        Employeee employeee;
        EmployeeImpl employeeImpl;
        public event RecargarPaginaEmpleado recargarPaginaEmpleado;
      

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuadar_Click(object sender, RoutedEventArgs e)
        {
            AñadirEmpleado();
            EmailService.EnviarCorreoContrañaNameUser(txtPassword.Password, txtNombreUusuario.Text, txtCorreo.Text);
            this.Close();
        }

        public void AñadirEmpleado()
        {
            try
            {
                employeee = new Employeee(txtNombreUusuario.Text,
                                            txtPassword.Password,
                                            cmbTipoUsuario.Text, txtNombres.Text,
                                            txtPrimerApellido.Text + " " + txtSegundoApellido.Text,
                                            dtpFechaNacimiento.DisplayDate,
                                            txtDireccion.Text,
                                            int.Parse(txtTelefono.Text),
                                            (cmbGenero.Text == "Masculino") ? "M" : "F",
                                            txtCorreo.Text,
                                            txtCi.Text);
                employeeImpl = new EmployeeImpl();
                int res = employeeImpl.Insert(employeee);
                if (res > 0)
                {
                    MessageBox.Show("Registro Insertado con exito");
                }
                if (recargarPaginaEmpleado != null)
                {
                    recargarPaginaEmpleado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCombobox();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombres.Text != " " && txtPrimerApellido.Text != " " && txtSegundoApellido.Text != " ")
            {
                txtNombreUusuario.Text = UserName.GenerarNameUser(txtNombres.Text, txtPrimerApellido.Text, txtSegundoApellido.Text);
                txtPassword.Password = Password.GenerarPassword(7);
            }
            else
            {
                MessageBox.Show("Ingrese los datos no vacios");
            }
        }
        public void CargarCombobox()
        {

            List<string> listaTypeusers = new List<string>() { "Administrador", "Vendedor", "Editor" };
            for (int i = 0; i < listaTypeusers.Count; i++)
            {
                cmbTipoUsuario.Items.Insert(i, listaTypeusers[i]);
            }
            cmbGenero.Items.Insert(0, "Masculino");
            cmbGenero.Items.Insert(1, "Femenino");
        }


    }

}
