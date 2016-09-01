using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;
using System.Linq;
namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    public partial class DisplayAllInvoiceByMonthRadForm : Telerik.WinControls.UI.RadForm
    {
        public DisplayAllInvoiceByMonthRadForm(IEnumerable<V_DisplayAllSales> sales)
        {
            InitializeComponent();
            this.CancelButton = this.CloseRadButton;
            reportViewer.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
            reportViewer.Resources.NoPageToDisplay = "Contactar al administrador de sistema";

           
            this.displayAllInvoicesByMonthsReport.DataSource = sales;
            this.reportViewer.RefreshReport();
        }

        private void DisplayAllInvoiceByMonthRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
