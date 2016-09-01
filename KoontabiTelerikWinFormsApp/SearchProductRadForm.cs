using Koontabi.BusinessLogic.ProductBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace KoontabiTelerikWinFormsApp
{
    public partial class SearchProductRadForm : Telerik.WinControls.UI.RadForm
    {
        private RadForm _currentForm = null;
        private IProductBL _serviceProductBL = null;
        public SearchProductRadForm(RadForm currentForm)
        {
            InitializeComponent();
            this._currentForm = currentForm;
            _serviceProductBL = new ProductBL();
        }

        private void SearchProductRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        public void FillKardexRadGridView()
        {

            if (this.ProductsRadGridView.Rows.Count >= 0)
            {
                this.ProductsRadGridView.DataSource = null;
            }
            //Fill KardexGridView DataSource
            this.ProductsRadGridView.DataSource = this._serviceProductBL.ProductToSearching();


            #region Columns of the GridView
            try
            {

                GridViewColumnCollection columns = this.ProductsRadGridView.Columns;


                //ProductDetailID Column
                GridViewDataColumn _productDetailIDColumn = columns["ProductDetailID"];
                _productDetailIDColumn.IsVisible = false;

                //ProductID Column
                GridViewDataColumn _productIDColumn = columns["ProductID"];
                _productIDColumn.IsVisible = false;


                //ProductCode Column
                GridViewDataColumn _productCodeColumn = columns["ProductCode"];
                _productCodeColumn.HeaderText = "Código";
                _productCodeColumn.Width = 100;

                //ProductName Column
                GridViewDataColumn _productNameColumn = columns["ProductName"];
                _productNameColumn.HeaderText = "Producto";
                _productNameColumn.Width = 200;

                //UnitPrice1 Column
                GridViewDataColumn _unitPrice1Column = columns["UnitPrice1"];
                _unitPrice1Column.IsVisible = false;

                //UnitPrice2 Column
                GridViewDataColumn _unitPrice2Column = columns["UnitPrice2"];
                _unitPrice2Column.IsVisible = false;

                //UnitPrice3 Column
                GridViewDataColumn _unitPrice3Column = columns["UnitPrice3"];
                _unitPrice3Column.IsVisible = false;

                //Stock Column
                GridViewDataColumn _stock = columns["Stock"];
                _stock.IsVisible = false;

                ClearSelectionRadGridView();
            }
            catch (Exception) { }

            #endregion
        }
        private void ClearSelectionRadGridView()
        {
            this.ProductsRadGridView.ClearSelection();
            this.ProductsRadGridView.Rows[0].IsCurrent = false;
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            FillKardexRadGridView();
            if (this.ProductsRadGridView.Rows.Count <= 0)
            {
                this.ProductsRadGridView.TableElement.Text = "Producto(s) no encontrado(s)";
                AceptRadButton.Enabled = false;
            }

            this.ProductsRadGridView.TableElement.BackgroundImage = null;
            this.MyTimer.Stop();
        }

        private void SearchProductRadForm_Load(object sender, EventArgs e)
        {
            this.ProductsRadGridView.EnableGrouping = false;
            this.ProductsRadGridView.TableElement.Text = "Cargando Datos..";
            this.ProductsRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
        }

        private void AceptRadButton_Click(object sender, EventArgs e)
        {
            if (CodeProductTemp != null) {
                ((KardexRadForm)this._currentForm).ProductCodeSelected = CodeProductTemp;
                this.Close();
            }
            
        }
        private String CodeProductTemp = null;
        private void ProductsRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            CodeProductTemp = e.Row.Cells["ProductCode"].Value.ToString();
        }
    }
}
