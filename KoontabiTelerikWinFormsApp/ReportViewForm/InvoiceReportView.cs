using Koontabi.Domain;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    public partial class InvoiceReportView : Telerik.WinControls.UI.RadForm
    {
        public InvoiceReportView(IEnumerable<GetInvoiceByIDView> invoiceToDisplay)
        {
            InitializeComponent();
            invoiceReport1.DataSource = invoiceToDisplay;
            this.reportViewer.RefreshReport();
            reportViewer.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
        }

        private void InvoiceReportView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        
    }
}
