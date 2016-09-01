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
namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    public partial class ProductsInventoryRadFormReportView : Telerik.WinControls.UI.RadForm
    {
        public ProductsInventoryRadFormReportView(IEnumerable<ProductInventory> datasource)
        {
            InitializeComponent();
            inventoryValueReport1.DataSource = datasource;
            this.ProductsInventoryReportViewer.RefreshReport();
            this.FormClosing += ProductsInventoryRadFormReportView_FormClosing;
            this.ProductsInventoryReportViewer.Resources.ProcessingReportMessage = "Generando Reporte - Josias Industrial SRL";
        }

        private void ProductsInventoryRadFormReportView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
