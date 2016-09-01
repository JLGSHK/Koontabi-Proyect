using Koontabi.BusinessLogic.CustomerBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Koontabi.Domain;
using Koontabi.BusinessLogic.ProductBL;
namespace KoontabiTelerikWinFormsApp
{
    public enum SearchEnum
    {
        SEARCH_CUSTOMER,
        SEARCH_PRODUCT
    }
    
    public partial class SearchRadForm : Telerik.WinControls.UI.RadForm
    {
        protected SearchEnum _seachForm;
        private ICustomerBL _serviceCustomerBL = null;
        private IProductBL _serviceProductBL = null;
        private List<Sp_GetCustomerByParam> listOfCustomer = null;
        private List<ProductToSearch> listOfProduct = null;
        public NewInvoiceRadForm _actualFormParent;

        public SearchRadForm(SearchEnum search,NewInvoiceRadForm actual)
        {
            InitializeComponent();
            this._seachForm = search;
            this._serviceCustomerBL = new CustomerBL();
            this._serviceProductBL = new ProductBL();

            listOfCustomer = new List<Sp_GetCustomerByParam>();
            listOfProduct = new List<ProductToSearch>();
            this._actualFormParent = actual;
        }

        private void SearchRadForm_Load(object sender, EventArgs e)
        {
            this.ItemsRadGridView.EnableGrouping = false;
            this.ItemsRadGridView.TableElement.Text = "Cargando Datos..";
            this.ItemsRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
            switch (_seachForm) { 
            
                case SearchEnum.SEARCH_CUSTOMER:
                    this.Text = "Buscar Cliente";                  
                    break;
                case SearchEnum.SEARCH_PRODUCT:
                    this.Text = "Buscar Producto";
                    break;
                default:
                    break;
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.ItemsRadGridView.TableElement.Text = string.Empty;
            this.ItemsRadGridView.TableElement.BackgroundImage = null;
            FillProductsRadGridView();
            if (ItemsRadGridView.Rows.Count == 0)
            {
                if (this._seachForm == SearchEnum.SEARCH_CUSTOMER)
                {
                    this.ItemsRadGridView.TableElement.Text = "Cliente(s) no encontrado(s)..";
                }
                else {
                    this.ItemsRadGridView.TableElement.Text = "Producto(s) no encontrado(s)..";
                }

                
            }
            this.MyTimer.Stop();

        }
        private void ClearSelectionRadGridView()
        {
            if (this.ItemsRadGridView.Rows.Count > 0)
            {
                this.ItemsRadGridView.Rows[0].IsCurrent = false;
            }
            this.ItemsRadGridView.ClearSelection();
            ;
        }
        public void FillProductsRadGridView()
        {
            if (this.ItemsRadGridView.Rows.Count > 0)
            {
                this.ItemsRadGridView.DataSource = null;
            }
            

            //SEARCH CUSTOMER
            if (this._seachForm == SearchEnum.SEARCH_CUSTOMER)
            {

                #region Columns of the GridView
                try
                {
                    listOfCustomer =  this._serviceCustomerBL.Sp_GetAllCustomerToSearch();
                    this.ItemsRadGridView.DataSource = listOfCustomer;
                    
                    GridViewColumnCollection columns = this.ItemsRadGridView.Columns;


                    //CustomerID Column
                    GridViewDataColumn _customerIDColumn = columns["CustomerID"];
                    _customerIDColumn.IsVisible = false;

                    //CustomerCode Column
                    GridViewDataColumn _customerCodeColumn = columns["CustomerCode"];
                    _customerCodeColumn.HeaderText = "Código";
                    _customerCodeColumn.Width = 150;

                    //CompanyName Column
                    GridViewDataColumn _companyNameColumn = columns["CompanyName"];
                    _companyNameColumn.HeaderText = "Empresa";
                    _companyNameColumn.Width = 250;

                    //ContactName Column
                    GridViewDataColumn _contactNameColumn = columns["ContactName"];
                    _contactNameColumn.HeaderText = "Contacto";
                    _contactNameColumn.Width = 150;

                    //Address1 Column
                    GridViewDataColumn _address1Column = columns["Address1"];
                    _address1Column.IsVisible = false;

                    //Phone1 Column
                    GridViewDataColumn _phone1Column = columns["Phone1"];
                    _phone1Column.IsVisible = false;

                    //Province Column
                    GridViewDataColumn _provinceColumn = columns["Province"];
                    _provinceColumn.IsVisible = false;

                    //Municipality Column
                    GridViewDataColumn _municipalityColumn = columns["Municipality"];
                    _municipalityColumn.IsVisible = false;



                }
                catch (Exception ex) {
                    MessageBox.Show(ex.InnerException.ToString());
                }

                #endregion
                ClearSelectionRadGridView();
            }

            //SEARCH PRODUCT
            if (this._seachForm == SearchEnum.SEARCH_PRODUCT)
            {
                #region Columns of the GridView
                try
                {
                    listOfProduct = this._serviceProductBL.ProductToSearching();
                    this.ItemsRadGridView.DataSource = listOfProduct;
                    GridViewColumnCollection columns = this.ItemsRadGridView.Columns;


                    //ProductDetailID Column
                    GridViewDataColumn _productDetailIDColumn = columns["ProductDetailID"];
                    _productDetailIDColumn.IsVisible = false;

                    //ProductID Column
                    GridViewDataColumn _productIDColumn = columns["ProductID"];
                    _productIDColumn.IsVisible = false;

                    //ProductCode Column
                    GridViewDataColumn _productCodeColumn = columns["ProductCode"];
                    _productCodeColumn.HeaderText = "Código";
                    _productCodeColumn.Width = 150;

                    //ProductName Column
                    GridViewDataColumn _productNameColumn = columns["ProductName"];
                    _productNameColumn.HeaderText = "Producto";
                    _productNameColumn.Width = 150;

                    //UnitPrice1 Column
                    GridViewDataColumn _unitPrice1Column = columns["UnitPrice1"];
                    _unitPrice1Column.HeaderText = "Precio 1 RD$";
                    _unitPrice1Column.FormatString = "{0:C}";
                    _unitPrice1Column.Width = 200;

                    //UnitPrice2 Column
                    GridViewDataColumn _unitPrice2Column = columns["UnitPrice2"];
                    _unitPrice2Column.HeaderText = "Precio 2 RD$";
                    _unitPrice2Column.FormatString = "{0:C}";
                    _unitPrice2Column.IsVisible = false;
                    _unitPrice2Column.Width = 150;

                    //UnitPrice3 Column
                    GridViewDataColumn _unitPrice3Column = columns["UnitPrice3"];
                    _unitPrice3Column.HeaderText = "Precio 3 RD$";
                    _unitPrice3Column.IsVisible = false;
                    _unitPrice3Column.FormatString = "{0:C}";
                    _unitPrice3Column.Width = 150;

                    //Stock Column
                    GridViewDataColumn _stock = columns["Stock"];
                    _stock.HeaderText = "Existencia";
                    _stock.Width = 150;


                }
                catch (Exception) { }

                #endregion
                ClearSelectionRadGridView();
            }
        }

        private void AceptRadButton_Click(object sender, EventArgs e)
        {
            if (this._seachForm == SearchEnum.SEARCH_CUSTOMER) {
                if (_currentCustomer != null)
                {
                    this._actualFormParent.CurrentCustomerToSelected = _currentCustomer;
                    this.Hide();
                }
                else {
                    RadMessageBox.Show("Debe seleccionar un cliente.", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    return;
                }
            }
            else if (this._seachForm == SearchEnum.SEARCH_PRODUCT) {

                if (_currentProduct != null)
                {
                    this._actualFormParent.CurrentProductToSelected = _currentProduct;
                    this.Hide();
                }
                else {
                    RadMessageBox.Show("Debe seleccionar un producto.", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    return;
                }

            }
            this._actualFormParent.IsClosedForm = false;
        }


        protected Sp_GetCustomerByParam _currentCustomer = null;
        protected ProductToSearch _currentProduct = null;
        private void ItemsRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (this._seachForm == SearchEnum.SEARCH_CUSTOMER)
            {
                int valor = (Int32)ItemsRadGridView.Rows[e.RowIndex].Cells["CustomerID"].Value;
                foreach (var item in listOfCustomer) {
                    if (item.CustomerID == valor) {
                        _currentCustomer = item;
                        break;
                    }
                }

            }
            else if(this._seachForm == SearchEnum.SEARCH_PRODUCT){
                int valor = (Int32)ItemsRadGridView.Rows[e.RowIndex].Cells["ProductID"].Value;
                foreach (var item in listOfProduct)
                {
                    if (item.ProductID == valor)
                    {
                        _currentProduct = item;
                        break;
                    }
                }
            }
            //this.ItemsRadGridView.Rows[e.RowIndex].Cells["ProductID"].Value;
        }

        private void CancelRadButton_Click(object sender, EventArgs e)
        {
            this._actualFormParent.IsClosedForm = true;
            this.Close();
        }

        private void SearchRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
