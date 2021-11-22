using CrystalDecisions.CrystalReports.Engine;
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

namespace Univalle.AutoNetWPF.Reports
{
    /// <summary>
    /// Lógica de interacción para UserReport.xaml
    /// </summary>
    public partial class UserReport : UserControl
    {
       

        public UserReport()
        {
            InitializeComponent();
        }

        public ReportDocument InitCrystalReport( string nameRpt)
        {
           
            string path = $@"E:\Archivos Andy\UNIVERSIDAD\3ER-SEMESTRE\BASE DE DATOS II\proyecto\PBDD_AUTONET\PBDD_AUTONET\Univalle.AutoNet\Univalle.AutoNetWPF\Reports\{nameRpt}";
            string nameBase = "BDDAUTONET";
            string nameUserBD = "root";
            string passwordBD = "Univalle";
            string nameServerBD = @"ANDYHP\SQLEXPRESS";
            ReportDocument report = new ReportDocument();
            report.Load(path);
            report.SetDatabaseLogon(nameUserBD, passwordBD, nameServerBD, nameBase);
            return report;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

 
        }

       

      

        private void btnReportOne_Click(object sender, RoutedEventArgs e)
        {
            DialogoHostTime.IsOpen = true;
            DialogoHostTime.Visibility = Visibility.Visible;
        }

      

        private void btnCancelarReporteOne_Click_1(object sender, RoutedEventArgs e)
        {
            DialogoHostTime.IsOpen = false;
        }

        private void btnReporteOne_Click(object sender, RoutedEventArgs e)
        {
            gridGif.Visibility = Visibility.Collapsed;
            DialogoHostTime.IsOpen = false;

            DateTime fechaInicio = fechaInicioDT.SelectedDate.Value;
            DateTime fechaFinal = fechaFinalDT.SelectedDate.Value;

            string nameRpt = "CrystalReport_reportOne.rpt";
            ReportDocument report = InitCrystalReport(nameRpt);
            report.SetParameterValue("@inicio", Convert.ToString(fechaInicio));
            report.SetParameterValue("@final", Convert.ToString(fechaFinal));
            //report.Refresh();
            VisorDelReporte.ViewerCore.ReportSource = report;
        }
    }
}
