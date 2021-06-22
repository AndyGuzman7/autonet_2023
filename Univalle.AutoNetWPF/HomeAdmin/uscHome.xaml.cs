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

namespace Univalle.AutoNetWPF.HomeAdmin
{
    /// <summary>
    /// Lógica de interacción para uscHome.xaml
    /// </summary>
    public partial class uscHome : UserControl
    {
        public uscHome()
        {
            InitializeComponent();
        }

        private void ButtonsDemoChip_OnDeleteClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonsDemoChip_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Card_TouchEnter(object sender, TouchEventArgs e)
        {
           
        }

        private void Card_MouseEnter(object sender, MouseEventArgs e)
        {
          
        }

        private void Card_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Card_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Card_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Card_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("funciona");
        }

        private void Card_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Card_MouseLeave(object sender, MouseEventArgs e)
        {
            MessageBox.Show("fuera");
        }

        private void card2_MouseLeave(object sender, MouseEventArgs e)
        {
            card2.Margin = new Thickness(10);
        }

        private void card2_MouseEnter(object sender, MouseEventArgs e)
        {
            card2.Margin = new Thickness(5);
        }

        private void card3_MouseEnter(object sender, MouseEventArgs e)
        {
            card3.Margin = new Thickness(5);
        }

        private void card3_MouseLeave(object sender, MouseEventArgs e)
        {
            card3.Margin = new Thickness(10);
        }

        private void card4_MouseEnter(object sender, MouseEventArgs e)
        {
            card4.Margin = new Thickness(5);
        }

        private void card4_MouseLeave(object sender, MouseEventArgs e)
        {
            card4.Margin = new Thickness(10);
        }

        private void card1_MouseLeave(object sender, MouseEventArgs e)
        {
            card1.Margin = new Thickness(10);
        }

        private void card1_MouseEnter(object sender, MouseEventArgs e)
        {
            card1.Margin = new Thickness(5);
        }
    }
}
