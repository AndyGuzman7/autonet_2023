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
using DAO.Model;
using DAO.Implementacion;
using System.Data;

namespace Univalle.AutoNetWPF.PartsAdmin
{
    /// <summary>
    /// Lógica de interacción para AddParts.xaml
    /// </summary>
    /// 
   
    public partial class AddParts : Window
    {
        Spare spare;
        SpareImpl spareImpl;
        public event RecargarPagina recargarPagina;
        public AddParts()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuadar_Click(object sender, RoutedEventArgs e)
        {
            AñadirProducto();
            this.Close();
        }

        public void AñadirProducto()
        {
            try
            {
                spare = new Spare(txtDescripcion.Text, txtNombreProducto.Text, int.Parse(txtSaldoActual.Text), double.Parse(txtPrecioBase.Text), double.Parse(txtPeso.Text), txtCodigoProducto.Text, int.Parse(txtMarca.Text), int.Parse(txtTipo.Text), 1);
                spareImpl = new SpareImpl();
                int res = spareImpl.Insert(spare);
                if(res > 0)
                {
                    MessageBox.Show("Registro Insertado con exito");
                }
                if(recargarPagina != null)
                {
                    recargarPagina();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
