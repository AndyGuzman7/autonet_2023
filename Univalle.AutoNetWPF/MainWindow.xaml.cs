using DAO.Implementacion;
using System;
using System.Collections.Generic;
using System.Data;
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
using Univalle.AutoNetWPF.Login;

namespace Univalle.AutoNetWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PartsAdmin.uscParts.activar += ActivarVentanaEdicion;
            PersonasAdmin.uscClient.añadirCliente += ActivarVentanaEdicionEmpleado;

            //MaterialDesignThemes.Wpf.ShadowDepth.Depth5
            //MaterialDesignThemes.Wpf.ShadowDepth s = new MaterialDesignThemes.Wpf.ShadowDepth();

            //gridMain.DataContext = MaterialDesignThemes.Wpf.ShadowDepth.Depth5;
            //MaterialDesignThemes.Wpf.PackIcon packIcon = new MaterialDesignThemes.Wpf.PackIcon();
            //packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Home;


            //menuItemRepuesto.Header = $"{MaterialDesignThemes.Wpf.PackIconKind.Home} Home";
        }





       public void metrodget()
        {/*
            try
            {
                DataRowView data = (DataRowView)dgvDatos.SelectedItem;
                byte id = byte.Parse(data.Row.ItemArray[0].ToString());

            }
            catch (Exception)
            {

                MessageBox.Show("");
            }*/
        }

        private void ActivarVentanaEdicionEmpleado()
        {
            //UserControl usc = null;
            //gridMain.Children.Clear();
            //usc = new PersonasAdmin.EditEmployee();
            //if (usc != null)
            //{
            //    gridMain.Children.Add(usc);
            //}
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*private void btnCollapseMenu_Click(object sender, RoutedEventArgs e)
        {
            //btnCollapseMenu.Visibility = Visibility.Collapsed;
            //imgLogo.Visibility = Visibility.Collapsed;
            //imgLogoLetra.Visibility = Visibility.Collapsed;
            //btnOpenMenu.Visibility = Visibility.Visible;
        }*/

       /*/ private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnCollapseMenu.Visibility = Visibility.Visible;
            imgLogo.Visibility = Visibility.Visible;
            imgLogoLetra.Visibility = Visibility.Visible;
            btnOpenMenu.Visibility = Visibility.Collapsed;

        }*/

        //private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    UserControl usc = null;
        //    gridMain.Children.Clear();

            

        //    switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
        //    {
        //        case "itemHome":
        //            break;
        //        case "itemParts":
        //            usc = new PartsAdmin.uscParts();
        //            break;
        //    }
        //    if (usc != null)
        //    {
        //        gridMain.Children.Add(usc);
        //    }
        //}

        private void btnInicioL_Click(object sender, RoutedEventArgs e)
        {
          
            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new HomeAdmin.uscHome(); 
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(1);
            }
        }

        private void CambiarBotones(int num)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#FF175CC1");
            Color color2 = (Color)ColorConverter.ConvertFromString("#1E2E3B");
            switch (num)
            {
                case 1:
                    btnInicioL.Background = new SolidColorBrush(color);
                    btnEmpleados.Background = new SolidColorBrush(color2);
                    btnClientesL.Background = new SolidColorBrush(color2);
                    btnRegistros.Background = new SolidColorBrush(color2);
                    MenuRepuestos.Background = new SolidColorBrush(color2);
                    break;
                case 2:
                    btnInicioL.Background = new SolidColorBrush(color2);
                    btnEmpleados.Background = new SolidColorBrush(color);
                    btnClientesL.Background = new SolidColorBrush(color2);
                    btnRegistros.Background = new SolidColorBrush(color2);
                    MenuRepuestos.Background = new SolidColorBrush(color2);
                    break;
                case 3:
                    btnInicioL.Background = new SolidColorBrush(color2);
                    btnEmpleados.Background = new SolidColorBrush(color2);
                    btnClientesL.Background = new SolidColorBrush(color);
                    btnRegistros.Background = new SolidColorBrush(color2);
                    MenuRepuestos.Background = new SolidColorBrush(color2);
                    break;
                case 4:
                    btnInicioL.Background = new SolidColorBrush(color2);
                    btnEmpleados.Background = new SolidColorBrush(color2);
                    btnClientesL.Background = new SolidColorBrush(color2);
                    btnRegistros.Background = new SolidColorBrush(color2);
                    MenuRepuestos.Background = new SolidColorBrush(color2);
                    break;
                case 5:
                    btnInicioL.Background = new SolidColorBrush(color2);
                    btnEmpleados.Background = new SolidColorBrush(color2);
                    btnClientesL.Background = new SolidColorBrush(color2);
                    btnRegistros.Background = new SolidColorBrush(color2);
                    MenuRepuestos.Background = new SolidColorBrush(color);
                    break;
            }
        }

        private void btnRepuestosL_Click(object sender, RoutedEventArgs e)
        {


        }

        public void ActivarVentanaEdicion()
        {
            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new PartsAdmin.uscPartsEdit();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
            }

        }

        private void btnClientesL_Click(object sender, RoutedEventArgs e)
        {
           
            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new PersonasAdmin.uscClient();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(3);
            }
        }

        private void btnRegistros_Click(object sender, RoutedEventArgs e)
        {
            CambiarBotones(4);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mtAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new AboutAdmin.uscAbout1();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
            }
        }

        private void Menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("comida");
        }

        private void Menu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("comida");
        }

        private void MenuItem_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("comida");
        }

        private void MenuItem_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("comida");
        }

        private void card_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comdia");
        }

        private void card_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comdia");
        }

        private void card_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Comdia");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void mITodoLosRepuestos_Click(object sender, RoutedEventArgs e)
        {
         
            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new PartsAdmin.uscParts();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(5);
            }
        }

        private void mITipoRepuesto_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            usc = new PartsAdmin.uscPartsType();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(5);
            }
        }

        private void btnEmpleadosL_Click(object sender, RoutedEventArgs e)
        {

            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new PersonasAdmin.uscEmployee();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(2);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*EmployeeImpl employeeImpl = new EmployeeImpl();
            DataTable dt = employeeImpl.GetId(Session.IdSession);*/

            menuItemHeader.Header = "Usuario: " + Session.SessionUserName + " - Rol: " + Session.SessionRole;
            /*if(dt.Rows[0][0].ToString() == dt.Rows[0][1].ToString())
            {

            }*/

            UserControl usc = null;
            gridMain.Children.Clear();
            usc = new HomeAdmin.uscHome();
            if (usc != null)
            {
                gridMain.Children.Add(usc);
                CambiarBotones(1);
            }

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void mtAdministrarCuenta_Click(object sender, RoutedEventArgs e)
        {
            DataUser dataUser = new DataUser();
            dataUser.Show();
        }
    }
}
