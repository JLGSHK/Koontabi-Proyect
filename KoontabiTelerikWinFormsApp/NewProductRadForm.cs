using Koontabi.BusinessLogic.CategoryBL;
using Koontabi.BusinessLogic.ProductBL;
using Koontabi.BusinessLogic.TaxBL;
using Koontabi.BusinessLogic.UnitBL;
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
using System.Linq;

namespace KoontabiTelerikWinFormsApp
{
    public partial class NewProductRadForm : Telerik.WinControls.UI.RadForm
    {

        private StateForm _stateForm;
        private IProductBL _serviceProductBL;
        private ICategoryBL _serviceCategoryBL;
        private IUnitBL _serviceUnitBL;
        private ITaxBL _serviceTaxBL;
        private ProductRadForm _currentParentForm;
        private Boolean isExitProductCode = false;
        private Product _currentProductToEdit = null;

        public NewProductRadForm(ProductRadForm currentParentForm, StateForm stateForm)
        {
            InitializeComponent();
            this._stateForm = stateForm;
            this._serviceProductBL = new ProductBL();
            this._serviceCategoryBL = new CategoryBL();
            this._serviceUnitBL = new UnitBL();
            this._serviceTaxBL = new TaxBL();
            this._currentParentForm = currentParentForm;
            this.CategoryIDComboBox.DataSource = this._serviceCategoryBL.GetCategories();
            this.CategoryIDComboBox.DisplayMember = "CategoryName";
            this.CategoryIDComboBox.ValueMember = "CategoryID";

            this.UnitIDComboBox.DataSource = this._serviceUnitBL.Sp_GetUnits();
            this.UnitIDComboBox.DisplayMember = "UnitDescription";
            this.UnitIDComboBox.ValueMember = "UnitID";

            this.TaxIDComboBox.DataSource = this._serviceTaxBL.Sp_Taxes();
            this.TaxIDComboBox.DisplayMember = "TaxDescription";
            this.TaxIDComboBox.ValueMember = "TaxID";
        }
        protected void DisableBenefitRadMaskedEditBox()
        {
            Benefit1RadMaskedEditBox.Enabled = false;
            Benefit2RadMaskedEditBox.Enabled = false;
            Benefit3RadMaskedEditBox.Enabled = false;
        }
        private void NewProductRadForm_Load(object sender, EventArgs e)
        {

            DisableBenefitRadMaskedEditBox();
            if (_stateForm == StateForm.NEW)
            {
                this.Text = "Nuevo Producto";
                this.RegisterRadButton.Text = "Registrar";
                this.RegisterRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.Save;
                this.RegisterRadButton.Click += RegisterRadButton_RegisterNewProduct;
            }
            else if (_stateForm == StateForm.EDIT)
            {
                this.RegisterRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.Update;
                this.Text = "Editando Producto";
                this.RegisterRadButton.Text = "Actualizar";
                this.RegisterRadButton.Click += RegisterRadButton_UpdateCurrentProduct;
                this.ProductCodeRadTextBoxControl.Enabled = false;
                this.ProductCostRadMaskedEditBox.Enabled = false;
                this.InitialStockRadMaskedEditBox.Enabled = false;
                var _idProductSelected = this._currentParentForm._currentProductIDSelected;

                SearchProductByID(_idProductSelected);


            }
            else if (_stateForm == StateForm.SEE_MORE)
            {
                DisableAllComponents();
                this.RegisterRadButton.Visible = false;
                this.Text = "Detalle Producto";
                var _idProductSelected = this._currentParentForm._currentProductIDSelected;

                SearchProductByID(_idProductSelected);

            }
        }

        private void SearchProductByID(int _idProductSelected)
        {
            _currentProductToEdit = this._serviceProductBL.SpGetProductByID(_idProductSelected)
                                        .ConvertToProduct();

            //Set Value to Form
            this.ProductCodeRadTextBoxControl.Text = _currentProductToEdit.ProductCode;
            this.ProductNameRadTextBoxControl.Text = _currentProductToEdit.ProductName;

            var objProductDetail = this._currentProductToEdit.ProductDetails.FirstOrDefault();
            this.ProductCostRadMaskedEditBox.Text = objProductDetail.ProductCost.ToString();
            //this.InitialStockRadMaskedEditBox.Text = this._currentProductToEdit.Kardexes.FirstOrDefault().KardexIn.Value.ToString();


            this.CategoryIDComboBox.SelectedValue = this._currentProductToEdit.CategoryID != null ? this._currentProductToEdit.CategoryID : 0;
            this.UnitIDComboBox.SelectedValue = this._currentProductToEdit.UnitID != null ? this._currentProductToEdit.UnitID : 0;

            this.UnitPrice1RadMaskedEditBox.Text = objProductDetail.UnitPrice1.ToString();
            this.UnitPrice2RadMaskedEditBox.Text = objProductDetail.UnitPrice2.ToString();
            this.UnitPrice3RadMaskedEditBox.Text = objProductDetail.UnitPrice3.ToString();

            this.StateRadCheckBox.Checked = this._currentProductToEdit.State;
            this.TaxIDComboBox.SelectedValue = objProductDetail.TaxID != null ? objProductDetail.TaxID : 0;

            switch (this._currentProductToEdit.InvoiceWithPrice)
            {
                case 1:
                    this.InvoiceWithPrecio1RadRadioButton.IsChecked = true;
                    break;
                case 2:
                    this.InvoiceWithPrecio1RadRadioButton.IsChecked = true;
                    break;
                case 3:
                    this.InvoiceWithPrecio1RadRadioButton.IsChecked = true;
                    break;
            }
            this.InvoiceWithoutStockRadCheckBox.Checked = this._currentProductToEdit.InvoiceWithoutStock;
            this.DescriptionRadTextBoxControl.Text = this._currentProductToEdit.Description;
        }

        /// <summary>
        /// Register a new Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RegisterRadButton_RegisterNewProduct(object sender, EventArgs e)
        {
            try
            {

                //Validate a new product to register

                #region Validate ProductCodeRadTextBoxControl
                if (String.IsNullOrEmpty(ProductCodeRadTextBoxControl.Text))
                {
                    errorProductProvider.SetError(ProductCodeRadTextBoxControl, "Introduzca un código.");
                    ProductCodeRadTextBoxControl.Focus();
                    return;
                }
                errorProductProvider.Clear();
                if (isExitProductCode)
                {
                    errorProductProvider.SetError(ProductCodeRadTextBoxControl, "Código existe en la base de datos");
                    return;
                }
                errorProductProvider.Clear();
                #endregion
                #region Validate ProductNameRadTextBoxControl
                if (String.IsNullOrEmpty(ProductNameRadTextBoxControl.Text))
                {
                    errorProductProvider.SetError(ProductNameRadTextBoxControl, "Introduzca un nombre para el producto.");
                    ProductNameRadTextBoxControl.Focus();
                    return;
                }
                errorProductProvider.Clear();
                #endregion
                #region Validate ProductCostRadMaskedEditBox
                if (Convert.ToDouble(ProductCostRadMaskedEditBox.Value) == 0.00)
                {
                    errorProductProvider.SetError(ProductCostRadMaskedEditBox, "Introduzca el costo por unidad.");
                    ProductCostRadMaskedEditBox.Focus();
                    return;
                }
                errorProductProvider.Clear();
                #endregion
                #region Validate InitialStockRadMaskedEditBox
                if (Convert.ToInt32(InitialStockRadMaskedEditBox.Value) == 0)
                {
                    errorProductProvider.SetError(InitialStockRadMaskedEditBox, "Introduzca la cantidad Inicial.");
                    InitialStockRadMaskedEditBox.Focus();
                    return;
                }
                errorProductProvider.Clear();
                #endregion

                //Create Product            
                Product _p = new Product()
                {
                    ProductCode = ProductCodeRadTextBoxControl.Text,
                    ProductName = ProductNameRadTextBoxControl.Text,
                    Description = DescriptionRadTextBoxControl.Text != string.Empty ? DescriptionRadTextBoxControl.Text : null,
                    State = StateRadCheckBox.Checked,
                    InvoiceWithoutStock = InvoiceWithoutStockRadCheckBox.Checked,
                    InvoiceWithPrice = GetInvoiceWithPrice(),
                };
                if (CategoryIDComboBox.SelectedIndex != 0)
                {
                    _p.CategoryID = (int)CategoryIDComboBox.SelectedValue;
                }

                if (UnitIDComboBox.SelectedIndex != 0)
                {
                    _p.UnitID = (int)UnitIDComboBox.SelectedValue;
                }
                //Create Product Details
                ProductDetail _pd = new ProductDetail()
                {
                    ProductCost = Convert.ToDecimal(ProductCostRadMaskedEditBox.Value),
                    BodegaID = 1,
                };
                if (Convert.ToDouble(UnitPrice1RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice1 = Convert.ToDecimal(UnitPrice1RadMaskedEditBox.Value);
                }
                if (Convert.ToDouble(UnitPrice2RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice2 = Convert.ToDecimal(UnitPrice2RadMaskedEditBox.Value);
                }
                if (Convert.ToDouble(UnitPrice3RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice3 = Convert.ToDecimal(UnitPrice3RadMaskedEditBox.Value);
                }
                if (TaxIDComboBox.SelectedIndex != 0)
                {
                    _pd.TaxID = (int)TaxIDComboBox.SelectedValue;
                }
                               
                var InitialStock = Convert.ToInt32(InitialStockRadMaskedEditBox.Value);
                _pd.Stock = InitialStock;

                //Create Kardex
                Kardex _k = new Kardex()
                {
                    
                    RegisterDate = DateTime.Now,
                    TypeOfMove = "Inventario Inicial",
                    KardexIn = InitialStock,
                    KardexStock = InitialStock
                };

                _pd.Kardexes.Add(_k);
                _p.ProductDetails.Add(_pd);
                this._serviceProductBL.Add(_p);
                this._currentParentForm.FillProductsRadGridView();
                RadMessageBox.Show(null, "Producto registrado satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(null, string.Format("Error : {0}", ex.InnerException), "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private Int32 GetInvoiceWithPrice()
        {
            var result = 0;
            if (InvoiceWithPrecio1RadRadioButton.IsChecked)
            {
                result = Convert.ToInt32(InvoiceWithPrecio1RadRadioButton.Text);
            }
            else if (InvoiceWithPrecio2RadRadioButton.IsChecked)
            {
                result = Convert.ToInt32(InvoiceWithPrecio2RadRadioButton.Text);
            }
            else if (InvoiceWithPrecio3RadRadioButton.IsChecked)
            {
                result = Convert.ToInt32(InvoiceWithPrecio3RadRadioButton.Text);
            }
            return result;
        }

        /// <summary>
        /// Update a current Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RegisterRadButton_UpdateCurrentProduct(object sender, EventArgs e)
        {
            //MessageBox.Show("Update Product");
            try
            {
                #region Validate ProductNameRadTextBoxControl
                if (String.IsNullOrEmpty(ProductNameRadTextBoxControl.Text))
                {
                    errorProductProvider.SetError(ProductNameRadTextBoxControl, "Introduzca un nombre para el producto.");
                    ProductNameRadTextBoxControl.Focus();
                    return;
                }
                errorProductProvider.Clear();
                #endregion

                //Update Product            
                //Create Product            
                Product _p = new Product()
                {
                    ProductID = this._currentProductToEdit.ProductID,
                    ProductCode = ProductCodeRadTextBoxControl.Text,
                    ProductName = ProductNameRadTextBoxControl.Text,
                    Description = DescriptionRadTextBoxControl.Text != string.Empty ? DescriptionRadTextBoxControl.Text : null,
                    State = StateRadCheckBox.Checked,
                    InvoiceWithoutStock = InvoiceWithoutStockRadCheckBox.Checked,
                    InvoiceWithPrice = GetInvoiceWithPrice(),
                };
                if (CategoryIDComboBox.SelectedIndex != 0)
                {
                    _p.CategoryID = (int)CategoryIDComboBox.SelectedValue;
                }

                if (UnitIDComboBox.SelectedIndex != 0)
                {
                    _p.UnitID = (int)UnitIDComboBox.SelectedValue;
                }
                //Create Product Details
                ProductDetail _pd = new ProductDetail()
                {
                    ProductID = _p.ProductID,
                    ProductDetailsID = this._currentProductToEdit.ProductDetails.FirstOrDefault().ProductDetailsID,
                    ProductCost = Convert.ToDecimal(ProductCostRadMaskedEditBox.Value),
                    BodegaID = 1,
                    Stock = this._currentProductToEdit.ProductDetails.FirstOrDefault().Stock,
                };
                if (Convert.ToDouble(UnitPrice1RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice1 = Convert.ToDecimal(UnitPrice1RadMaskedEditBox.Value);
                }
                if (Convert.ToDouble(UnitPrice2RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice2 = Convert.ToDecimal(UnitPrice2RadMaskedEditBox.Value);
                }
                if (Convert.ToDouble(UnitPrice3RadMaskedEditBox.Value) != 0.00)
                {
                    _pd.UnitPrice3 = Convert.ToDecimal(UnitPrice3RadMaskedEditBox.Value);
                }
                if (TaxIDComboBox.SelectedIndex != 0)
                {
                    _pd.TaxID = (int)TaxIDComboBox.SelectedValue;
                }
                /*
                var InitialStock = Convert.ToInt32(InitialStockRadMaskedEditBox.Value);
                _pd.Stock = InitialStock;
                */
               
                _p.ProductDetails.Add(_pd);

                this._serviceProductBL.Update(_p);
                RadMessageBox.Show(null, "Producto actualizado satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(null, string.Format("Error : {0}", ex.Message), "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        
        }

        private void DisableAllComponents()
        {
            ProductCodeRadTextBoxControl.Enabled = false;
            ProductNameRadTextBoxControl.Enabled = false;
            ProductCostRadMaskedEditBox.Enabled = false;
            InitialStockRadMaskedEditBox.Enabled = false;
            CategoryIDComboBox.Enabled = false;
            UnitIDComboBox.Enabled = false;
            UnitPrice1RadMaskedEditBox.Enabled = false;
            UnitPrice2RadMaskedEditBox.Enabled = false;
            UnitPrice3RadMaskedEditBox.Enabled = false;
            Benefit1RadMaskedEditBox.Enabled = false; ;
            Benefit2RadMaskedEditBox.Enabled = false;
            Benefit3RadMaskedEditBox.Enabled = false;
            InvoiceWithPrecio1RadRadioButton.Enabled = false;
            InvoiceWithPrecio2RadRadioButton.Enabled = false;
            InvoiceWithPrecio3RadRadioButton.Enabled = false;
            InvoiceWithoutStockRadCheckBox.Enabled = false;
            DescriptionRadTextBoxControl.Enabled = false;
            StateRadCheckBox.Enabled = false;
            TaxIDComboBox.Enabled = false;
        }

        private void ProductCodeRadTextBoxControl_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (this.ProductCodeRadTextBoxControl.Text.Length == 30)
            {
                e.Handled = true;
                return;
            }
        }

        private void ProductCodeRadTextBoxControl_TextChanged(object sender, EventArgs e)
        {
            //Validate ProductNameRadTextBoxControl.Text in the database if is it exist.

            if (this._stateForm == StateForm.NEW)
            {
                if (_serviceProductBL.ValidateProductCodeIfExit(ProductCodeRadTextBoxControl.Text))
                {
                    isExitProductCode = true;
                    errorProductProvider.SetError(ProductCodeRadTextBoxControl, "Código existe en la base de datos");
                    return;
                }
                errorProductProvider.Clear();
                isExitProductCode = false;
            }
        }

        private void ProductNameRadTextBoxControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ProductNameRadTextBoxControl.Text.Length == 100)
            {
                e.Handled = true;
                return;
            }
        }

        private void UnitPrice1RadMaskedEditBox_TextChanged(object sender, EventArgs e)
        {

            CalculateBenefit(UnitPrice1RadMaskedEditBox, ProductCostRadMaskedEditBox, Benefit1RadMaskedEditBox);

        }

        private void UnitPrice2RadMaskedEditBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBenefit(UnitPrice2RadMaskedEditBox, ProductCostRadMaskedEditBox, Benefit2RadMaskedEditBox);
        }
        private void UnitPrice3RadMaskedEditBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBenefit(UnitPrice3RadMaskedEditBox, ProductCostRadMaskedEditBox, Benefit3RadMaskedEditBox);
        }

        protected void CalculateBenefit(RadMaskedEditBox unitPrice, RadMaskedEditBox productCost,RadMaskedEditBox benefit)
        {
            var result = 0.00;

            if (Convert.ToDouble(productCost.Value) == 0.00)
            {
                errorProductProvider.SetError(ProductCostRadMaskedEditBox, "Introduzca el costo por unidad.");
                ProductCostRadMaskedEditBox.Focus();
                return;
            }
            errorProductProvider.Clear();

            var _productCost = Convert.ToDecimal(productCost.Value);
            var _unitprice = Convert.ToDecimal(unitPrice.Value);

            result = (double)(((_unitprice - _productCost) * 100) / _productCost);

            if (result != 0 & result > 1)
            {
                benefit.Text = string.Format("{0}", result);
            }
            else
            {
                benefit.Text = string.Format("{0}", 0);
            }
        }

        private void ClearForm()
        {

        }
        
    }
}
