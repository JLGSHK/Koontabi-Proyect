
using Koontabi.Domain;
using Koontabi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Koontabi.BusinessLogic.ProductBL;
namespace KoontabiTelerikWinFormsApp
{
    public partial class ProductRadForm : Telerik.WinControls.UI.RadForm
    {
        public int _currentProductIDSelected { get; set; }
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
        private IProductBL _serviceProduct;
        
        public ProductRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            this._serviceProduct = new ProductBL();
        }
        private void ProductRadForm_Load(object sender, EventArgs e)
        {
            this.ProductsRadGridView.EnableGrouping = false;
            this.ProductsRadGridView.TableElement.Text = "Cargando Datos..";
            this.ProductsRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
        }
        public void FillProductsRadGridView()
        {
            if (this.ProductsRadGridView.Rows.Count > 0)
            {
                this.ProductsRadGridView.DataSource = null;
            }
            this.ProductsRadGridView.DataSource = this._serviceProduct.SpGetAllProducts();

            #region Columns of the GridView
            try
            {
                GridViewColumnCollection columns = this.ProductsRadGridView.Columns;


                //ProductID Column
                GridViewDataColumn _productIDColumn = columns["ProductID"];
                _productIDColumn.IsVisible = false;

                //ProductCode Column
                GridViewDataColumn _productCodeColumn = columns["ProductCode"];
                _productCodeColumn.HeaderText = "Código";
                _productCodeColumn.Width = 150;

                //ProductName Column
                GridViewDataColumn _productNameColumn = columns["ProductName"];
                _productNameColumn.HeaderText = "Nombre Producto";
                _productNameColumn.Width = 350;

                //CategoryName Column
                GridViewDataColumn _categoryNameColumn = columns["CategoryName"];
                _categoryNameColumn.HeaderText = "Categoría";
                _categoryNameColumn.Width = 200;

                //UnitPrice1 Column
                GridViewDataColumn _unitPrice1Column = columns["UnitPrice1"];
                _unitPrice1Column.HeaderText = "Precio 1 RD$";
                _unitPrice1Column.FormatString = "{0:C}";
                _unitPrice1Column.Width = 200;

                //ProductCost Column
                GridViewDataColumn _productCostColumn = columns["ProductCost"];
                _productCostColumn.HeaderText = "Costo";
                _productCostColumn.FormatString = "{0:C}";
                _productCostColumn.Width = 150;

                //KardexStock Column
                GridViewDataColumn _kardexStockColumn = columns["Stock"];
                _kardexStockColumn.HeaderText = "Existencia";
                _kardexStockColumn.FormatString = "{0:0,0.00}";
                _kardexStockColumn.Width = 150;

                
                //Clear Selection
                ClearSelectionRadGridView();

            }
            catch (Exception) { }

            #endregion
            ClearSelectionRadGridView();
        }
        private void ClearSelectionRadGridView()
        {
            if (this.ProductsRadGridView.Rows.Count > 0)
            {
                this.ProductsRadGridView.Rows[0].IsCurrent = false;
            }
            this.ProductsRadGridView.ClearSelection();
            ;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.ProductsRadGridView.TableElement.Text = string.Empty;
            this.ProductsRadGridView.TableElement.BackgroundImage = null;
            FillProductsRadGridView();
           if (ProductsRadGridView.Rows.Count == 0)
            {
                this.ProductsRadGridView.TableElement.Text = "Producto(s) no encontrado(s)..";
            }
            this.MyTimer.Stop();
            ConditionalFormattingObject objFormat = 
                new ConditionalFormattingObject("MyCondiction",ConditionTypes.Equal,"0","",true);
            objFormat.CellForeColor = Color.Red;
            objFormat.RowBackColor = Color.SkyBlue;
            this.ProductsRadGridView.Columns["Stock"]
                .ConditionalFormattingObjectList
                .Add(objFormat);
            GridViewSummaryItem summaryItem = new GridViewSummaryItem("ProductCode","Producto(s) Reg. {0}",GridAggregateFunction.Count);
            
            

            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);

            ProductsRadGridView.SummaryRowsTop.Add(summaryRowItem);



        }

        private void NewProductRadButton_Click(object sender, EventArgs e)
        {

            NewProductRadForm _newProductRadForm = new NewProductRadForm(this, StateForm.NEW);
            if (!isOpenForm(_newProductRadForm))
            {
                _newProductRadForm.ShowDialog();
            }
        }

        private void EditProductRadButton_Click(object sender, EventArgs e)
        {
            
            if(this.ProductsRadGridView.CurrentRow != null)
            {
                NewProductRadForm _newProductRadForm = new NewProductRadForm(this, StateForm.EDIT);
                if (!isOpenForm(_newProductRadForm))
                {
                    _newProductRadForm.ShowDialog();
                }
            }
            else
            {
                RadMessageBox.Show("Debe seleccionar un producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK,RadMessageIcon.Exclamation);
            }
            
        }

        private void SeeMoreProductRadButton_Click(object sender, EventArgs e)
        {
            if (this.ProductsRadGridView.SelectedRows.Count == 1)
            {
                this._currentProductIDSelected = (Int32)this.ProductsRadGridView.CurrentRow.Cells["ProductID"].Value;
                NewProductRadForm _newProductRadForm = new NewProductRadForm(this, StateForm.SEE_MORE);
                if (!isOpenForm(_newProductRadForm))
                {
                    _newProductRadForm.ShowDialog();
                }
            }
            else
            {
                RadMessageBox.Show("Debe seleccionar un producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
            
        }

        private void ProductsRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            this._currentProductIDSelected = (Int32)this.ProductsRadGridView.Rows[e.RowIndex].Cells["ProductID"].Value;


        }

        private void DeleteProductRadButton_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("No se puede Eliminar Producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
            return;
        }
    }
}
