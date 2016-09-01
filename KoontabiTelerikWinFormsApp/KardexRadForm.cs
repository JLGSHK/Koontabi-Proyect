using Koontabi.BusinessLogic.KardexBL;
using Koontabi.BusinessLogic.ProductBL;
using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
namespace KoontabiTelerikWinFormsApp
{
    public partial class KardexRadForm : Telerik.WinControls.UI.RadForm
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

        private IKardexBL _serviceKardexBL = null;
        private IProductBL _serviceProduct = null;
        
        
        public KardexRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            this._serviceKardexBL = new KardexBL();
            this._serviceProduct = new ProductBL();
        }

        private void StoreRadForm_Load(object sender, EventArgs e)
        {
            CodeProductRadMaskedEditBox.NullText = "Código Producto";
            UpdateProductStockRadMaskedEditBox.NullText = "Código Producto";
            this.KardexRadGridView.EnableGrouping = false;
            this.KardexRadGridView.TableElement.Text = string.Empty;
            UpdateProductStockRadGroupBox.Visible = false;

        }
        
      
        private void ClearSelectionRadGridView()
        {
            this.KardexRadGridView.ClearSelection();
            this.KardexRadGridView.Rows[0].IsCurrent = false;
        }
        private void CodeProductRadMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if( Convert.ToInt32(Keys.Space) == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = true;
            }
            if(Convert.ToInt32(Keys.Back) == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Convert.ToInt32(Keys.Enter) == Convert.ToInt32(e.KeyChar))
            {
                SearchRadButton_Click(sender, e);
            }
        }

        public String ProductCodeSelected { get; set; }
        private void SearchRadButton_Click(object sender, EventArgs e)
        {
            //OutputRadLabel
            if (CodeProductRadMaskedEditBox.Text.Equals(String.Empty))
            {
                SearchProductRadForm _searchingProduct = new SearchProductRadForm(this);
                _searchingProduct.ShowDialog();
                if (ProductCodeSelected != null)
                {
                    SearchingKardexProduct(ProductCodeSelected, 1);
                }
            }
            else
            {
                
                SearchingKardexProduct(CodeProductRadMaskedEditBox.Text, 1);
               
                
            }
            
        }
        public void SearchingKardexProduct(String ProductCodeSelected,int idBodega)
        {
            //Searching product from DB
            this.KardexRadGridView.TableElement.Text = "Cargando Datos..";
            this.KardexRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            FillKardexRadGridView(ProductCodeSelected,idBodega);
            CodeProductRadMaskedEditBox.Text = ProductCodeSelected;
            if (this.KardexRadGridView.Rows.Count <= 0)
            {
                this.KardexRadGridView.TableElement.Text = "Kardex(s) no encontrado(s)";
                OutputRadLabel.Text = "Producto no encontrado";
            }
            else
            {
                OutputRadLabel.Text = String.Empty;
            }
            this.KardexRadGridView.TableElement.BackgroundImage = null;
            
        }
        public void FillKardexRadGridView(string productCode, int bodegaID)
        {

            if (this.KardexRadGridView.Rows.Count >= 0)
            {
                this.KardexRadGridView.DataSource = null;
            }
            //Fill KardexGridView DataSource
            this.KardexRadGridView.DataSource = this._serviceKardexBL.GetAllKardexGridModel(productCode, bodegaID);
            


            #region Columns of the GridView

            //GridViewDataColumn column1 = new GridViewDataColumn("InvoiceID");

            try
            {
                GridViewColumnCollection columns = this.KardexRadGridView.Columns;


                //RegisterDate Column
                GridViewDataColumn _RegisterDateColumn = columns["RegisterDate"];
                _RegisterDateColumn.FormatString = "{0:MM/dd/yyyy}";
                _RegisterDateColumn.HeaderText = "Fecha";
                _RegisterDateColumn.TextAlignment = ContentAlignment.MiddleCenter;
                _RegisterDateColumn.Width = 100;

                //TypeOfMove Column
                GridViewDataColumn _TypeOfMoveColumn = columns["TypeOfMove"];
                _TypeOfMoveColumn.HeaderText = "Movimiento";
                _TypeOfMoveColumn.TextAlignment = ContentAlignment.MiddleCenter;
                _TypeOfMoveColumn.Width = 100;

                //ProductCode Column
                GridViewDataColumn _ProductCodeColumn = columns["ProductCode"];
                _ProductCodeColumn.HeaderText = "Código Producto";
                _ProductCodeColumn.TextAlignment = ContentAlignment.MiddleCenter;
                _ProductCodeColumn.Width = 100;

                //ProductName Column
                GridViewDataColumn _ProductNameColumn = columns["ProductName"];
                _ProductNameColumn.HeaderText = "Producto";
                _ProductNameColumn.TextAlignment = ContentAlignment.MiddleLeft;
                _ProductNameColumn.Width = 200;

                //KardexIn Column
                GridViewDataColumn _KardexInColumn = columns["KardexIn"];
                _KardexInColumn.HeaderText = "Entrada";
                _KardexInColumn.FormatString = "{0:0,0.00}";
                _KardexInColumn.TextAlignment = ContentAlignment.MiddleRight;
                _KardexInColumn.Width = 100;

                //KardexOut Column
                GridViewDataColumn _KardexOutColumn = columns["KardexOut"];
                _KardexOutColumn.HeaderText = "Salida";
                _KardexOutColumn.FormatString = "{0:0,0.00}";
                _KardexOutColumn.TextAlignment = ContentAlignment.MiddleRight;
                _KardexOutColumn.Width = 100;

                //KardexStock Column
                GridViewDataColumn _KardexStockColumn = columns["KardexStock"];
                _KardexStockColumn.HeaderText = "Existencia";
                _KardexStockColumn.FormatString = "{0:0,0.00}";
                _KardexStockColumn.TextAlignment = ContentAlignment.MiddleRight;
                _KardexStockColumn.Width = 100;


                //Clear Selection
                ClearSelectionRadGridView();

            }
            catch (Exception) { }

            #endregion
          
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
     
        }
        bool isExistProduct = false;
        Product productToSelected = null;
        private void SearchToProductUpdateStockRadButton_Click(object sender, EventArgs e)
        {
            if (!isExistProduct)
            {
                //Look for the product in Database with ProductCode
                if(((String)UpdateProductStockRadMaskedEditBox.Text) != String.Empty)
                {
                    productToSelected = this._serviceProduct.GetProductByProductCode(((String)UpdateProductStockRadMaskedEditBox.Text));
                    if(productToSelected != null)
                    {
                        ProductSearchedTextBox.Text = productToSelected.ProductName;
                        ActualStockRadMaskedEditBox.Text = productToSelected.ProductDetails.Where(x => x.ProductID == productToSelected.ProductID).First().Stock.ToString();
                        UpdateProductStockRadGroupBox.Visible = true;
                        isExistProduct = true;
                        SearchToProductUpdateStockRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.delete;
                        UpdateProductStockRadMaskedEditBox.Enabled = false;
                        return;
                    }
                    else
                    {
                        RadMessageBox.Show("Producto no encontrado", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                        UpdateProductStockRadMaskedEditBox.Focus();
                        return;

                    }
                    
                }
                else
                {
                    RadMessageBox.Show("Introduzca un código producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    UpdateProductStockRadMaskedEditBox.Focus();
                    return;
                }
                
            }
            else
            {
                UpdateProductStockRadGroupBox.Visible = false;
                isExistProduct = false;
                SearchToProductUpdateStockRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.search;
                UpdateProductStockRadMaskedEditBox.Enabled = true;
                UpdateProductStockRadMaskedEditBox.Focus();
            }
            
        }

        private void UpdateProductStockRadGroupBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStockToDBRadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var actualStock = Convert.ToInt32(ActualStockRadMaskedEditBox.Value);
                var NewStock =Convert.ToInt32(NewStockRadMaskedEditBox.Value);

                actualStock += NewStock;
                ActualStockRadMaskedEditBox.Value = actualStock;
                NewStockRadMaskedEditBox.Value = 0;
                
                if(productToSelected != null)
                {
                    //Register in Kardex
                    Kardex _k = new Kardex()
                    {

                        RegisterDate = DateTime.Now,
                        TypeOfMove = "Actualizando Stock",
                        KardexIn = NewStock,
                        KardexStock = actualStock,
                        ProductDetailsID = productToSelected.ProductDetails.FirstOrDefault().ProductDetailsID,

                    };
                    var KardexID = this._serviceKardexBL.AddKardex(_k);
                    this._serviceProduct.UpdateStockByProductIDAndBodegaID(actualStock, productToSelected.ProductID, 1);
                    RadMessageBox.Show("Producto Actualizado satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    NewStockRadMaskedEditBox.Focus();
                    
                    return;
                }
                
                


            }
            catch (InvalidCastException ex)
            {
                RadMessageBox.Show("Error, Consultar con el Administrador", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                return;
            }
        }

        private void UpdateProductStockRadMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(Keys.Space) == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Convert.ToInt32(Keys.Back) == Convert.ToInt32(e.KeyChar))
            {
                e.Handled = false;
            }
            if (Convert.ToInt32(Keys.Enter) == Convert.ToInt32(e.KeyChar))
            {
                SearchToProductUpdateStockRadButton_Click(sender, e);
            }
        }

        private void KardexRadGridView_RowFormatting(object sender, RowFormattingEventArgs e)
        {
           
        }

        private void KardexRadGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
        }
    }
}
