using Koontabi.BusinessLogic.ProductBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace KoontabiTelerikWinFormsApp
{
    public partial class InventoryReportRadForm : Telerik.WinControls.UI.RadForm
    {
        protected enum SizeOfScreen
        {
            WIDTH = 900, HEIGHT = 600
        }
        protected void SetSizeScreen(SizeOfScreen width, SizeOfScreen height)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = (Int32)width;
            this.Height = (Int32)height;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }
        protected Boolean isOpenForm(Form f)
        {

            FormCollection fc = Application.OpenForms;
            foreach (Form temform in fc)
            {
                if (temform.Name.Equals(f.Name))
                {

                    return true;
                }
            }
            return false;
        }
        private IProductBL _serviceProductBL = null;
        public InventoryReportRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            this.Text = "Reportes";
            this._serviceProductBL = new ProductBL();
        }

        private void ProductsInventoryRadButton_Click(object sender, EventArgs e)
        {
            ReportViewForm.ProductsInventoryRadFormReportView inventory = new ReportViewForm.ProductsInventoryRadFormReportView(this._serviceProductBL.ProductsInventory());
            inventory.ShowDialog();
        }
    }
}
