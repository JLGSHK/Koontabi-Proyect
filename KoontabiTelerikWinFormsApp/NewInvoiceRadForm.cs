using Koontabi.BusinessLogic.CustomerBL;
using Koontabi.BusinessLogic.EmployeeBL;
using Koontabi.BusinessLogic.InvoiceBL;
using Koontabi.BusinessLogic.TaxBL;
using Koontabi.BusinessLogic.TypeOfPayBL;
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
using Koontabi.Helpers;
using System.Linq;
using Koontabi.BusinessLogic.ProductBL;

namespace KoontabiTelerikWinFormsApp
{
    public enum TYPE_OF_SAVE_ENUM
    {
        SAVE_PRINT, SAVE_EXIT
    }

    public partial class NewInvoiceRadForm : Telerik.WinControls.UI.RadForm
    {
        private List<InvoiceDetailGridModel> _invoiceDetailGridModel = null;
        private ITaxBL _serviceTaxBL = null;
        private ITypeOfPayBL _serviceTypeOfPayBL = null;
        private ICustomerBL _serviceCustomerBL = null;
        private IEmployeeBL _serviceEmployeeBL = null;
        private IInvoiceBL _serviceInvoiceBL = null;
        private IProductBL _serviceProductBL = null;
        public bool IsClosedForm { get; set; }
        StringBuilder _sbErrores = null;
        private InvoiceRadForm _currentParentForm = null;
        public Invoice _currentInvoiceToEdit { get; set; }
        public StateForm _stateForm;
        private Invoice InvoiceSave { get; set; }
        public List<Sp_GetCustomerByParam> listOfCustomeresToComboBox = new List<Sp_GetCustomerByParam>();
        public List<ProductToSearch> listOfProducts = new List<ProductToSearch>();
        public NewInvoiceRadForm(InvoiceRadForm parentForm, Invoice currentInvoiceToEdit, StateForm stateForm)
        {
            this._stateForm = stateForm;
            InitForm();
            this._currentParentForm = parentForm;
            this._currentInvoiceToEdit = currentInvoiceToEdit;
           
        }

        public NewInvoiceRadForm(InvoiceRadForm parentForm, StateForm stateForm)
        {
            InitForm();
            this._currentParentForm = parentForm;
            this._stateForm = stateForm;
        }

        private void InitForm()
        {
            InitializeComponent();

            _invoiceDetailGridModel = new List<InvoiceDetailGridModel>();
            this._serviceTaxBL = new TaxBL();
            this._serviceTypeOfPayBL = new TypeOfPayBL();
            this._serviceCustomerBL = new CustomerBL();
            this._serviceEmployeeBL = new EmployeeBL();
            this._serviceInvoiceBL = new InvoiceBL();
            this._serviceProductBL = new ProductBL();
            _sbErrores = new StringBuilder();
            var listOfEmployeeToComboBox = this._serviceEmployeeBL.SpGetEmployeeToComboBox();
            EmployeesComboBox.DataSource = listOfEmployeeToComboBox;
            EmployeesComboBox.DisplayMember = "FullName";
            EmployeesComboBox.ValueMember = "EmployeeID";
            EmployeesComboBox.SelectedIndex = 1;

            listOfCustomeresToComboBox = this._serviceCustomerBL.Sp_GetAllCustomerToSearch();
            SearchCustomerComboBox.DataSource = listOfCustomeresToComboBox;
            SearchCustomerComboBox.DisplayMember = "CompanyName";
            SearchCustomerComboBox.ValueMember = "CustomerID";
            SearchCustomerComboBox.SelectedIndex = -1;
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (var item in listOfCustomeresToComboBox)
            {
                ac.Add(item.CompanyName);

            }
            SearchCustomerComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchCustomerComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchCustomerComboBox.AutoCompleteCustomSource = ac;
            SearchCustomerComboBox.Focus();

            listOfProducts = this._serviceProductBL.ProductToSearching();
            SearchProductComboBox.DataSource = listOfProducts;
            SearchProductComboBox.DisplayMember = "ProductName";
            SearchProductComboBox.ValueMember = "ProductID";
            SearchProductComboBox.SelectedIndex = -1;
            AutoCompleteStringCollection acproducts = new AutoCompleteStringCollection();
            foreach (var item in listOfProducts)
            {
                acproducts.Add(item.ProductName);

            }
            SearchProductComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchProductComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchProductComboBox.AutoCompleteCustomSource = acproducts;

            SearchProductComboBox.SelectedIndexChanged += SearchProductComboBox_SelectedIndexChanged;
            //SearchProductComboBox.SelectedValueChanged += new System.EventHandler(this.SearchProductComboBox_SelectedValueChanged);

            SearchCustomerComboBox.SelectedIndexChanged += SearchCustomerComboBox_SelectedIndexChanged;
            SearchCustomerComboBox.SelectedValueChanged += new System.EventHandler(this.SearchCustomerComboBox_SelectedValueChanged);

            

            this.TypeOfPayComboBox.DataSource = this._serviceTypeOfPayBL.SpTypeOfPay();
            this.TypeOfPayComboBox.DisplayMember = "Description";
            this.TypeOfPayComboBox.ValueMember = "TypeOfPayID";
            this.TypeOfPayComboBox.SelectedValue = 2;


            this.InvoiceDateRadDateTimePicker.ValueChanged += new System.EventHandler(this.InvoiceDateRadDateTimePicker_ValueChanged);

            InvoiceDateRadDateTimePicker.Value = DateTime.Now;
            

            

            

            this.TaxIDComboBox.DataSource = this._serviceTaxBL.Sp_Taxes();
            this.TaxIDComboBox.DisplayMember = "TaxDescription";
            this.TaxIDComboBox.ValueMember = "TaxID";

            this.TaxIDComboBox.TextChanged += new System.EventHandler(this.TaxIDComboBox_TextChanged);
            this.TypeOfPayComboBox.TextChanged += TypeOfPayComboBox_TextChanged;

            
            
            if (this._stateForm == StateForm.NEW)
            {
                InvoiceNumberRadTextBox.Text = this._serviceInvoiceBL.SpGetLastInvoiceNumber().Value.GetInvoiceNumberExt();
            }
            

        }

       private void SetUpdateDate()
        {
            var resultdate = InvoiceDateRadDateTimePicker.Value;
            if (((int)TypeOfPayComboBox.SelectedValue) == 2)
            {

                
                ExpirationInvoiceDateRadDateTimePicker.Value = resultdate;
                ExpirationInvoiceDateRadDateTimePicker.Value = resultdate.AddDays(45);

            }
            else
            {
                ExpirationInvoiceDateRadDateTimePicker.Value = resultdate;
            }
        }

        private void InvoiceDateRadDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetUpdateDate();
        }

        private void TypeOfPayComboBox_TextChanged(object sender, EventArgs e)
        {
            SetUpdateDate();
        }

        private void NewInvoiceRadForm_Load(object sender, EventArgs e)
        {
            this.InvoiceDetailsRadGridView.EnableGrouping = false;
            this.InvoiceDetailsRadGridView.TableElement.Text = "No hay Producto agregado";
            if (this._stateForm == StateForm.NEW)
            {
                this.Text = "Nueva Fáctura";
                this.SearchCustomerComboBox.Enabled = true;
            }
            else if (this._stateForm == StateForm.EDIT)
            {
                this.Text = String.Format("Editando Fáctura - {0} ",this._currentInvoiceToEdit.InvoiceNumber.GetInvoiceNumberExt());
                this.SearchCustomerComboBox.Enabled = false;

                StringBuilder sb = new StringBuilder();
                //SearchCustomerComboBox.Text = this._currentInvoiceToEdit.Customer.CustomerCode;

                var _customer = this._currentInvoiceToEdit.Customer;
                sb.AppendLine(_customer.CompanyName + " || " + _customer.ContactName)
                  .AppendLine(_customer.Phone1)
                  .AppendLine(_customer.Address1)
                  .AppendLine(_customer.Province.Name + ", " + _customer.Municipality.Name);
                CustomerPersonalDataRadTextBox.Text = sb.ToString();

                
                EmployeesComboBox.SelectedValue = this._currentInvoiceToEdit.Employee.EmployeeID;
                TypeOfPayComboBox.SelectedValue = this._currentInvoiceToEdit.TypeOfPay.TypeOfPayID;
                InvoiceDateRadDateTimePicker.Value = this._currentInvoiceToEdit.InvoiceDate;
                ExpirationInvoiceDateRadDateTimePicker.Value = this._currentInvoiceToEdit.ExpirationInvoiceDate;
                InvoiceNumberRadTextBox.Text = this._currentInvoiceToEdit.InvoiceNumber.GetInvoiceNumberExt();
                RefInvoiceRadMaskedEditBox.Text = this._currentInvoiceToEdit.ReferenceInvoice;

                if (this._currentInvoiceToEdit.DisCount.HasValue)
                {
                    DiscountRadMaskedEditBox.Value = this._currentInvoiceToEdit.DisCount.Value;
                }

                if (this._currentInvoiceToEdit.TaxID.HasValue)
                {
                    TaxIDComboBox.SelectedValue = this._currentInvoiceToEdit.TaxID.Value;
                }
                

                foreach (var item in this._currentInvoiceToEdit.InvoiceDetails)
                {
                    InvoiceDetailGridModel linea = new InvoiceDetailGridModel()
                    {
                        ProductCode = item.Kardex.ProductDetail.Product.ProductCode,
                        ProductDetailID = item.ProductDetailID,
                        ProductID = item.Kardex.ProductDetail.Product.ProductID,
                        ProductName = item.Kardex.ProductDetail.Product.ProductName,
                        UnitPrice = item.UnitPrice,
                        Quantity = item.Quantity
                    };
                    _invoiceDetailGridModel.Add(linea);
                }
                FillProductRadGridView();
                CalculateSubTotalAndMore();
                //ProductCodeRadMaskedEditBox.Focus();

            }
            else if (this._stateForm == StateForm.SEE_MORE)
            {
                this.Text = String.Format("Detalle de Fáctura - {0} ", this._currentInvoiceToEdit.InvoiceNumber.GetInvoiceNumberExt());
                this.SearchCustomerComboBox.Enabled = false;
                DeleteLineaRadButton.Enabled = false;
                UpdateListRadButton.Enabled = false;
                SaveToPrintRadButton.Enabled = false;
                SaveToExitRadButton.Enabled = false;
                AmountMaskedEditBox.Enabled = false;
                UnitPriceRadMaskedEditBox.Enabled = false;
                AddProductRadButton.Enabled = false;
                EmployeesComboBox.Enabled = false;
                TypeOfPayComboBox.Enabled = false;
                InvoiceDateRadDateTimePicker.Enabled = false;
                ExpirationInvoiceDateRadDateTimePicker.Enabled = false;
                RefInvoiceRadMaskedEditBox.Enabled = false;
                DiscountRadMaskedEditBox.Enabled = false;
                TaxIDComboBox.Enabled = false;


                StringBuilder sb = new StringBuilder();
                SearchCustomerComboBox.SelectedValue = this._currentInvoiceToEdit.Customer.CustomerID;

                var _customer = this._currentInvoiceToEdit.Customer;
                sb.AppendLine(_customer.CompanyName + " || " + _customer.ContactName)
                  .AppendLine(_customer.Phone1)
                  .AppendLine(_customer.Address1)
                  .AppendLine(_customer.Province.Name + ", " + _customer.Municipality.Name);
                CustomerPersonalDataRadTextBox.Text = sb.ToString();


                EmployeesComboBox.SelectedValue = this._currentInvoiceToEdit.Employee.EmployeeID;
                TypeOfPayComboBox.SelectedValue = this._currentInvoiceToEdit.TypeOfPay.TypeOfPayID;
                InvoiceDateRadDateTimePicker.Value = this._currentInvoiceToEdit.InvoiceDate;
                ExpirationInvoiceDateRadDateTimePicker.Value = this._currentInvoiceToEdit.ExpirationInvoiceDate;
                InvoiceNumberRadTextBox.Text = this._currentInvoiceToEdit.InvoiceNumber.GetInvoiceNumberExt();
                RefInvoiceRadMaskedEditBox.Text = this._currentInvoiceToEdit.ReferenceInvoice;

                if (this._currentInvoiceToEdit.DisCount.HasValue)
                {
                    DiscountRadMaskedEditBox.Value = this._currentInvoiceToEdit.DisCount.Value;
                }

                if (this._currentInvoiceToEdit.TaxID.HasValue)
                {
                    TaxIDComboBox.SelectedValue = this._currentInvoiceToEdit.TaxID.Value;
                }


                foreach (var item in this._currentInvoiceToEdit.InvoiceDetails)
                {
                    InvoiceDetailGridModel linea = new InvoiceDetailGridModel()
                    {
                        ProductCode = item.Kardex.ProductDetail.Product.ProductCode,
                        ProductDetailID = item.ProductDetailID,
                        ProductID = item.Kardex.ProductDetail.Product.ProductID,
                        ProductName = item.Kardex.ProductDetail.Product.ProductName,
                        UnitPrice = item.UnitPrice,
                        Quantity = item.Quantity
                    };
                    _invoiceDetailGridModel.Add(linea);
                }
                FillProductRadGridView();
                CalculateSubTotalAndMore();
                //ProductCodeRadMaskedEditBox.Focus();
              
            }
        }

        public Sp_GetCustomerByParam CurrentCustomerToSelected { get; set; }
        public ProductToSearch CurrentProductToSelected { get; set; }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {

            SearchRadForm _search = new SearchRadForm(SearchEnum.SEARCH_CUSTOMER, this);
            _search.ShowDialog();

            if (!IsClosedForm)
            {
                StringBuilder sb = new StringBuilder();
                //SearchCustomerComboBox.Text = CurrentCustomerToSelected.CustomerCode;

                sb.AppendLine(CurrentCustomerToSelected.CompanyName + " || " + CurrentCustomerToSelected.ContactName).AppendLine(CurrentCustomerToSelected.Phone1)
                    .AppendLine(CurrentCustomerToSelected.Address1)
                    .AppendLine(CurrentCustomerToSelected.Province + ", " + CurrentCustomerToSelected.Municipality);
                CustomerPersonalDataRadTextBox.Text = sb.ToString();
            }



        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            //SearchRadForm _search = new SearchRadForm(SearchEnum.SEARCH_PRODUCT, this);
            //_search.ShowDialog();
            //if (!IsClosedForm)
            //{
            //    ProductCodeRadMaskedEditBox.Text = CurrentProductToSelected.ProductCode;
            //    DescriptionRadTextBox.Text = CurrentProductToSelected.ProductName;
            //    UnitPriceRadMaskedEditBox.Text = CurrentProductToSelected.UnitPrice1.ToString();
            //    AmountMaskedEditBox.Focus();
            //}


        }

        private void AddProductRadButton_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            if (ToValidateAddProductoToGrid())
            {
                InvoiceDetailGridModel _p = new InvoiceDetailGridModel()
                {
                    ProductDetailID = CurrentProductToSelected.ProductDetailID,
                    ProductID = CurrentProductToSelected.ProductID,
                    ProductCode = CurrentProductToSelected.ProductCode,
                    ProductName = CurrentProductToSelected.ProductName,
                    UnitPrice = Convert.ToDecimal(UnitPriceRadMaskedEditBox.Value),
                    Quantity = Convert.ToInt32(AmountMaskedEditBox.Value)

                };

                foreach (InvoiceDetailGridModel active in _invoiceDetailGridModel)
                {
                    if (active.ProductID == _p.ProductID)
                    {
                        isAdded = true;
                        RadMessageBox.Show("Este producto ya ha sido agregado a la venta", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                        SearchProductComboBox.SelectedIndex = -1;
                        SearchProductComboBox.Focus();
                        break;
                    }
                }
                if (!isAdded)
                {
                    _invoiceDetailGridModel.Add(_p);
                    FillProductRadGridView();
                    CalculateSubTotalAndMore();
                    SearchProductComboBox.SelectedIndex = -1;
                    SearchProductComboBox.Focus();
                }
                ClearProductFields();
                return;

            }
        }
        private void CalculateSubTotalAndMore()
        {
            decimal subTotal = 0;
            decimal discount = 0;
            decimal Itbis = 0;
            foreach (var item in _invoiceDetailGridModel)
            {
                subTotal += item.SubTotal;

            }
            if (Convert.ToInt32(TaxIDComboBox.SelectedValue) != 0)
            {
                var taxSelected = this._serviceTaxBL.GetTaxValue(Convert.ToInt32(TaxIDComboBox.SelectedValue));
                Itbis = subTotal * taxSelected / 100;
                ItbisResultRadMaskedEditBox.Text = Itbis.ToString();
            }
            else
            {
                ItbisResultRadMaskedEditBox.Text = string.Empty;
            }
            if (Convert.ToDecimal(DiscountRadMaskedEditBox.Value) > 0)
            {
                discount = subTotal * (Convert.ToDecimal(DiscountRadMaskedEditBox.Value) * 100) / 100;
                DiscountResultRadMaskedEditBox.Text = discount.ToString();
            }
            else
            {
                DiscountResultRadMaskedEditBox.Text = string.Empty;
            }
            SubTotalRadMaskedEditBox.Text = subTotal.ToString();
            TotalRadMaskedEditBox.Text = ((subTotal - discount) + Itbis).ToString();

        }
        public void FillProductRadGridView()
        {
            if (this.InvoiceDetailsRadGridView.Rows.Count >= 0)
            {
                this.InvoiceDetailsRadGridView.DataSource = null;
                this.InvoiceDetailsRadGridView.Rows.Clear();
            }
            this.InvoiceDetailsRadGridView.DataSource = _invoiceDetailGridModel;

            #region Columns of the GridView
            try
            {
                GridViewColumnCollection columns = this.InvoiceDetailsRadGridView.Columns;

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
                _productNameColumn.Width = 350;

                //UnitPrice Column
                GridViewDataColumn _unitPriceColumn = columns["UnitPrice"];
                _unitPriceColumn.HeaderText = "Precio por Unidad";
                _unitPriceColumn.FormatString = "{0:C}";
                _unitPriceColumn.TextAlignment = ContentAlignment.MiddleRight;
                _unitPriceColumn.Width = 200;

                //Quantity Column
                GridViewDataColumn _quantityColumn = columns["Quantity"];
                _quantityColumn.HeaderText = "Cantidad";
                _quantityColumn.Width = 200;

                //SubTotal Column
                GridViewDataColumn _subTotalColumn = columns["SubTotal"];
                _subTotalColumn.HeaderText = "SubTotal";
                _subTotalColumn.FormatString = "{0:C}";
                _subTotalColumn.Width = 150;

                //Clear Selection
                ClearSelectionRadGridView();

            }
            catch (Exception) { }

            #endregion



        }
        private void ClearSelectionRadGridView()
        {
            this.InvoiceDetailsRadGridView.ClearSelection();
            this.InvoiceDetailsRadGridView.Rows[0].IsCurrent = false;
        }
        private void ClearProductFields()
        {
            //ProductCodeRadMaskedEditBox.Text = string.Empty;
            
            AmountMaskedEditBox.Text = string.Empty;
            UnitPriceRadMaskedEditBox.Text = string.Empty;

        }
        private Boolean ToValidateAddProductoToGrid()
        {
            //ProductDetailID
            //UnitPrice
            //Quantity
            if (SearchProductComboBox.SelectedIndex == -1)
            {
                RadMessageBox.Show("Debe seleccionar un producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                SearchProductComboBox.Focus();
                return false;
            }
            if(Convert.ToInt32(AmountMaskedEditBox.Value) > CurrentProductToSelected.Stock)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("La cantidad ingresada excede de la disponibilidad en almacén.")
                   .AppendLine("")
                  .AppendLine("Disponible " + CurrentProductToSelected.Stock + " " + CurrentProductToSelected.ProductName);
                RadMessageBox.Show(sb.ToString(), "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                AmountMaskedEditBox.Focus();
                return false;
            }
            if (Convert.ToInt32(AmountMaskedEditBox.Value) == 0)
            {
                RadMessageBox.Show("Debe seleccionar agregar una cantidad a facturar", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                AmountMaskedEditBox.Focus();
                return false;
            }
            if (Convert.ToInt32(AmountMaskedEditBox.Value) < 0)
            {
                RadMessageBox.Show("Debe seleccionar agregar una cantidad sin signo negativo a facturar", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                AmountMaskedEditBox.Focus();
                return false;
            }

            if (Convert.ToDouble(UnitPriceRadMaskedEditBox.Value) == 0.00)
            {
                RadMessageBox.Show("Debe seleccionar agregar el valor del producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                UnitPriceRadMaskedEditBox.Focus();
                return false;
            }
            if (Convert.ToDouble(UnitPriceRadMaskedEditBox.Value) < 0.00)
            {
                RadMessageBox.Show("Debe seleccionar agregar el valor sin signo negativo del producto", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                UnitPriceRadMaskedEditBox.Focus();
                return false;
            }





            return true;
        }

        private void AmountMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                UnitPriceRadMaskedEditBox.Focus();
            }
        }

        private void UnitPriceRadMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AddProductRadButton.Focus();
            }
        }

        private void DiscountRadMaskedEditBox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubTotalAndMore();
        }

        private void TaxIDComboBox_TextChanged(object sender, EventArgs e)
        {
            CalculateSubTotalAndMore();
        }
        Int32 selectedRow;
        private void InvoiceDetailsRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedRow = (Int32)this.InvoiceDetailsRadGridView.Rows[e.RowIndex].Cells["ProductID"].Value;

        }

        //Delete Line of InvoiceDetailsRadGridView
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (this.InvoiceDetailsRadGridView.SelectedRows.Count == 0)
            {

                RadMessageBox.Show(null, "Debe seleccionar la linea para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                var result = _invoiceDetailGridModel.Find(x => x.ProductID == selectedRow);
                int indexElement = _invoiceDetailGridModel.IndexOf(result);
                _invoiceDetailGridModel.RemoveAt(indexElement);
                FillProductRadGridView();
                CalculateSubTotalAndMore();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CalculateSubTotalAndMore();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewInvoiceRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsClosingForm(sender, e);
        }

        private void IsClosingForm(object sender, FormClosingEventArgs e)
        {
            if (isInvoiceSave)
            {
                e.Cancel = false;
            }
            else
            {
                if (this.InvoiceDetailsRadGridView.Rows.Count >= 1)
                {

                    DialogResult rs = RadMessageBox.Show(null, "¿Está segudo que desea salir?", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    switch (rs)
                    {
                        case DialogResult.Yes:
                            e.Cancel = false;
                            break;
                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                    }
                    return;
                }
                else
                {
                    e.Cancel = false;
                }
            }

        }

        private void UpdateListRadButton_Click(object sender, EventArgs e)
        {
            FillProductRadGridView();
            CalculateSubTotalAndMore();
            RadMessageBox.Show(null, "Datos Actualizado", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);

        }

        private void SaveToPrintRadButton_Click(object sender, EventArgs e)
        {
            ValidateToSave(TYPE_OF_SAVE_ENUM.SAVE_PRINT);

        }
        private void SaveToExitRadButton_Click(object sender, EventArgs e)
        {
            ValidateToSave(TYPE_OF_SAVE_ENUM.SAVE_EXIT);
        }
        bool isInvoiceSave = false;

        private void ValidateToSave(TYPE_OF_SAVE_ENUM type)
        {
            _sbErrores.Clear();
            bool isError = false;
            if (SearchCustomerComboBox.SelectedIndex == -1)
            {
                AddError("Introduzca cliente");
                isError = true;
            }
            if (EmployeesComboBox.SelectedIndex == 0)
            {
                AddError("Seleccione un vendedor");
                isError = true;
            }
            if (TypeOfPayComboBox.SelectedIndex == 0)
            {
                AddError("Seleccione método de pago");
                isError = true;
            }
            if (RefInvoiceRadMaskedEditBox.Value.ToString().Equals("00000"))
            {
                AddError("Introduzca la factura de referencia");
                isError = true;
            }
            //Validate with Database
            if (this._stateForm == StateForm.NEW)
            {
                if (this._serviceInvoiceBL.isExitReferenceInvoice(RefInvoiceRadMaskedEditBox.Value.ToString()))
                {
                    AddError("La factura de referencia ya está registrada");
                    isError = true;
                }
            }
            if (InvoiceDetailsRadGridView.Rows.Count <= 0)
            {
                AddError("Introduzca un producto minimo para realizar la fáctura");
                isError = true;
            }


            //Grabando la cabezera de la factura
            if (isError)
            {
                DisplayError();
            }
            else
            {
                if(this._stateForm == StateForm.NEW) { 
                    #region Create a new Invoice
                try
                {
                    var _invoiceTemp = new Invoice();
                    _invoiceTemp.InvoiceNumber = Convert.ToInt32(InvoiceNumberRadTextBox.Text);
                    _invoiceTemp.CustomerID = this.CurrentCustomerToSelected.CustomerID;
                    _invoiceTemp.EmployeeID = Convert.ToInt32(EmployeesComboBox.SelectedValue);
                    _invoiceTemp.InvoiceDate = InvoiceDateRadDateTimePicker.Value;
                    _invoiceTemp.BodegaID = 1;
                    _invoiceTemp.TypeOfPayID = Convert.ToInt32(TypeOfPayComboBox.SelectedValue);
                    _invoiceTemp.ReferenceInvoice = RefInvoiceRadMaskedEditBox.Value.ToString();
                    _invoiceTemp.ExpirationInvoiceDate = ExpirationInvoiceDateRadDateTimePicker.Value;

                    if (CommentRadTextBox.Text != string.Empty)
                    {
                        _invoiceTemp.Comments = CommentRadTextBox.Text;
                    }
                    //TAXID AND DISCOUNT
                    if (TaxIDComboBox.SelectedIndex != 0)
                    {
                        _invoiceTemp.TaxID = Convert.ToInt32(TaxIDComboBox.SelectedValue);
                    }

                    if (Convert.ToDouble(DiscountRadMaskedEditBox.Value) != 0)
                    {
                        _invoiceTemp.DisCount = Convert.ToDouble(DiscountRadMaskedEditBox.Value);
                    }

                    //Grabando el Kardex
                    foreach (InvoiceDetailGridModel item in this._invoiceDetailGridModel)
                    {

                        var ActualStock = this._serviceProductBL.GetStockByProductIDAndBodegaID(item.ProductID, 1);
                        var kardexVenta = new Kardex();
                        kardexVenta.RegisterDate = InvoiceDateRadDateTimePicker.Value;
                        kardexVenta.TypeOfMove = String.Format("Venta-{0}", InvoiceNumberRadTextBox.Text);
                        kardexVenta.KardexOut = item.Quantity;
                        kardexVenta.KardexStock = (ActualStock.Value - item.Quantity);
                        kardexVenta.ProductDetailsID = item.ProductDetailID;

                        var _invoiceDetails = new InvoiceDetail();
                        _invoiceDetails.InvoiceID = _invoiceTemp.InvoiceID;
                        _invoiceDetails.ProductDetailID = item.ProductDetailID;
                        _invoiceDetails.UnitPrice = item.UnitPrice;
                        _invoiceDetails.Quantity = item.Quantity;
                        _invoiceDetails.Kardex = kardexVenta;
                        
                        _invoiceTemp.InvoiceDetails.Add(_invoiceDetails);
                            this._serviceProductBL.UpdateStockByProductIDAndBodegaID((ActualStock.Value - item.Quantity), item.ProductID, 1);
                    }
                        InvoiceSave= this._serviceInvoiceBL.Add(_invoiceTemp);
                    isInvoiceSave = true;
                    RadMessageBox.Show("Fáctura procesada satisfactoriamente, Pulse Ok para continuar.", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this._currentParentForm.FillInvoiceDetailsRadGridView();
                    if (type == TYPE_OF_SAVE_ENUM.SAVE_PRINT)
                    {
                            //RadMessageBox.Show("Imprimiento documentoooo");
                            if(InvoiceSave != null)
                            {

                                ReportViewForm.InvoiceReportView invoiceReportForm = new ReportViewForm.InvoiceReportView(this._serviceInvoiceBL.FindInvoiceToReport(iv => iv.InvoiceID == InvoiceSave.InvoiceID));
                                invoiceReportForm.ShowDialog();
                            }
                            
                            this.Close();
                    }
                    else if (type == TYPE_OF_SAVE_ENUM.SAVE_EXIT)
                    {
                        this.Close();
                    }

                    return;
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show("Error Ocurrido : Contactar al administrador de Sistema", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    isInvoiceSave = false;
                    return;
                }
                    #endregion
                }else if(this._stateForm == StateForm.EDIT)
                {
                    #region Fragmento de codigo para editar Factura
                    //Revisar el flujo de Modificar una factura.
                    try
                    {
                        if (CommentRadTextBox.Text != string.Empty)
                        {
                            this._currentInvoiceToEdit.Comments = CommentRadTextBox.Text;
                        }
                        //TAXID AND DISCOUNT
                        if (TaxIDComboBox.SelectedIndex != 0)
                        {
                            this._currentInvoiceToEdit.TaxID = Convert.ToInt32(TaxIDComboBox.SelectedValue);
                        }

                        if (Convert.ToDouble(DiscountRadMaskedEditBox.Value) != 0)
                        {
                            this._currentInvoiceToEdit.DisCount = Convert.ToDouble(DiscountRadMaskedEditBox.Value);
                        }
                        //Edit
                        //Grabando el Kardex
                        ICollection<InvoiceDetail> listInvoiceDetail = new List<InvoiceDetail>();
                        foreach (InvoiceDetailGridModel item in this._invoiceDetailGridModel)
                        {
                            var kardexVenta = new Kardex();
                            kardexVenta.RegisterDate = InvoiceDateRadDateTimePicker.Value;
                            kardexVenta.TypeOfMove = String.Format("Venta-{0}", InvoiceNumberRadTextBox.Text);
                            kardexVenta.KardexOut = item.Quantity;
                            kardexVenta.KardexStock = 0;
                            kardexVenta.ProductDetailsID = item.ProductDetailID;

                            var _invoiceDetails = new InvoiceDetail();
                            _invoiceDetails.InvoiceID = this._currentInvoiceToEdit.InvoiceID;
                            _invoiceDetails.ProductDetailID = item.ProductDetailID;
                            _invoiceDetails.UnitPrice = item.UnitPrice;
                            _invoiceDetails.Quantity = item.Quantity;
                            _invoiceDetails.Kardex = kardexVenta;

                            listInvoiceDetail.Add(_invoiceDetails);
                        }





                        //APPLY UPDATE
                        this._serviceInvoiceBL.Update(this._currentInvoiceToEdit,listInvoiceDetail);
                        isInvoiceSave = true;
                        RadMessageBox.Show("Fáctura procesada satisfactoriamente, Pulse Ok para continuar.", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                        this._currentParentForm.FillInvoiceDetailsRadGridView();
                        if (type == TYPE_OF_SAVE_ENUM.SAVE_PRINT)
                        {
                            RadMessageBox.Show("Imprimiento documentoooo");
                            this.Close();
                        }
                        else if (type == TYPE_OF_SAVE_ENUM.SAVE_EXIT)
                        {
                            this.Close();
                        }

                        return;
                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show("Error Ocurrido : Contactar al administrador de Sistema", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                        isInvoiceSave = false;
                        return;

                       
                    }
        
                #endregion
                }else if (this._stateForm == StateForm.SEE_MORE)
                {
                    
                }
            }






        }
        private void AddError(string error)
        {
            _sbErrores.AppendLine(error);
        }
        private void DisplayError()
        {
            RadMessageBox.Show("Para mostrar errores dar click en el boton Details", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, _sbErrores.ToString());
        }

        private void radGroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void SearchCustomerComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                if(SearchCustomerComboBox.SelectedValue != null)
                {
                    SetCustomerPersonalData(Convert.ToInt32(SearchCustomerComboBox.SelectedValue));
                }
                else
                {
                    CustomerPersonalDataRadTextBox.Text = String.Empty;
                }
            }
            else
            {
                CustomerPersonalDataRadTextBox.Text = String.Empty;
            }
        }
        private void SearchCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchCustomerComboBox.SelectedIndex != -1)
            {
                SetCustomerPersonalData(Convert.ToInt32(SearchCustomerComboBox.SelectedValue));
            }
            else
            {
                CustomerPersonalDataRadTextBox.Text = String.Empty;
            }
        }

        private void SearchCustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SearchCustomerComboBox.SelectedIndex != -1)
            {
                SetCustomerPersonalData(Convert.ToInt32(SearchCustomerComboBox.SelectedValue));
            }
            else
            {
                CustomerPersonalDataRadTextBox.Text = String.Empty;
            }
        }
        private void SetCustomerPersonalData(int selectedValue)
                {
                    if(selectedValue > -1)
                    {
                        CurrentCustomerToSelected = (from c in listOfCustomeresToComboBox
                                               where c.CustomerID == selectedValue
                                               select c).FirstOrDefault();
                        StringBuilder sb = new StringBuilder();
                

                        sb.AppendLine(String.Format("{0} ({1})", CurrentCustomerToSelected.ContactName, CurrentCustomerToSelected.Phone1))
                                    .AppendLine(CurrentCustomerToSelected.Address1)
                                    .AppendLine(CurrentCustomerToSelected.Province + ", " + CurrentCustomerToSelected.Municipality);
                        CustomerPersonalDataRadTextBox.Text = sb.ToString();

                    }
                }

       
        private void SearchProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchProductComboBox.SelectedValue != null)
            {

                CurrentProductToSelected = (from c in listOfProducts
                                            where c.ProductID == Convert.ToInt32(SearchProductComboBox.SelectedValue)
                                            select c).FirstOrDefault();
                UnitPriceRadMaskedEditBox.Text = CurrentProductToSelected.UnitPrice1.ToString();
                AmountMaskedEditBox.Focus();

            }
            else
            {
                SearchProductComboBox.Focus();
                return;
            }
        }

        private void SearchProductComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
            {
                if(SearchProductComboBox.SelectedValue != null)
                {
                    
                    CurrentProductToSelected = (from c in listOfProducts
                                               where c.ProductID == Convert.ToInt32(SearchProductComboBox.SelectedValue)
                                               select c).FirstOrDefault();
                    UnitPriceRadMaskedEditBox.Text = CurrentProductToSelected.UnitPrice1.ToString();
                    AmountMaskedEditBox.Focus();

                }
                else
                {
                    SearchProductComboBox.Focus();
                    return;
                }


            }
            
        }

        
    }
}
