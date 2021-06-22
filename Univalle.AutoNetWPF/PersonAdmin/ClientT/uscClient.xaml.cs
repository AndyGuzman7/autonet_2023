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

namespace Univalle.AutoNetWPF.PersonasAdmin
{
    /// <summary>
    /// Lógica de interacción para uscClient.xaml
    /// </summary>

    public delegate void AñadirCliente();
    public partial class uscClient : UserControl
    {
        public static event  AñadirCliente añadirCliente;
        public uscClient()
        {
            InitializeComponent();
        }

        private void btnAñadirCliente_Click(object sender, RoutedEventArgs e)
        {
            if(añadirCliente != null)
            {
                añadirCliente();
            }
        }
    }
}
