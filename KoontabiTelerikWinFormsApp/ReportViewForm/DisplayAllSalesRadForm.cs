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
    public partial class DisplayAllSalesRadForm : Telerik.WinControls.UI.RadForm
    {
        
        public DisplayAllSalesRadForm(IEnumerable<V_DisplayAllSales> allSales)
        {
            InitializeComponent();
            displayAllSalesReport.DataSource = allSales;
            reportViewer.RefreshReport();
            this.FormClosing += DisplayAllSalesRadForm_FormClosing;
            reportViewer.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
            reportViewer.Resources.NoPageToDisplay = "Contactar al administrador de sistema";
        }

        private void DisplayAllSalesRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void CloseRadButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
