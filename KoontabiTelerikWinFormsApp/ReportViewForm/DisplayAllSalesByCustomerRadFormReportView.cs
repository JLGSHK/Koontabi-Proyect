using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;

namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    public partial class DisplayAllSalesByCustomerRadFormReportView : Telerik.WinControls.UI.RadForm
    {
        public DisplayAllSalesByCustomerRadFormReportView(IEnumerable<V_DisplayAllInvoicesByZone> sales)
        {
            InitializeComponent();
            this.CancelButton = this.CloseRadButton;
            reportViewer1.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
            reportViewer1.Resources.NoPageToDisplay = "Contactar al administrador de sistema";
            displayAllSalesByCustomerReport.DataSource = sales;
            reportViewer1.RefreshReport();

        }

        private void DisplayAllSalesByCustomerRadFormReportView_cs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
