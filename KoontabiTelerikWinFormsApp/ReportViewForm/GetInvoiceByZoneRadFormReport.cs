using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;
using Koontabi.BusinessLogic;
using System.Linq;
namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    public partial class GetInvoiceByZoneRadFormReport : Telerik.WinControls.UI.RadForm
    {
        public GetInvoiceByZoneRadFormReport(IEnumerable<V_DisplayAllInvoicesByZone> zones)
        {
            InitializeComponent();
            reportViewer.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
      
            this.displayAllInvoicesByZoneReport1.DataSource = zones;
            this.reportViewer.RefreshReport();
            this.CancelButton = this.CloseRadButton;
        }

        private void GetInvoiceByZoneRadFormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }
    }
}
