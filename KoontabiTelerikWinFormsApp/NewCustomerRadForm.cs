using Koontabi.BusinessLogic;
using Koontabi.BusinessLogic.CustomerBL;
using Koontabi.BusinessLogic.MunicipalityBL;
using Koontabi.BusinessLogic.ProvinceBL;
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

namespace KoontabiTelerikWinFormsApp
{

    public partial class NewCustomerRadForm : Telerik.WinControls.UI.RadForm
    {



        protected enum SizeOfScreen
        {
            WIDTH = 900, HEIGHT = 600
        }
        /// <summary>
        /// Method sets the properties to adjust the screen to an appropriate size.
        /// </summary>
        protected void SetSizeScreen()
        {
            this.Left = 0;
            this.Top = 0;

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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


        private IProvinceBL _serviceProvince;
        private IMunicipalityBL _serviceMunicipality;
        private ICustomerBL _serviceCustomer;
        private CustomerRadForm _currentParentForm;
        private StateForm _stateForm;

        public Customer CustomerToEdit { get; set; }

        public NewCustomerRadForm(CustomerRadForm _currentForm, StateForm stateForm)
        {
            InitComponentAndData();
            this._currentParentForm = _currentForm;
            this._stateForm = stateForm;

        }

        public void InitComponentAndData()
        {
            try
            {
                _serviceProvince = new ProvinceBL();
                _serviceMunicipality = new MunicipalityBL();
                _serviceCustomer = new CustomerBL();
                InitializeComponent();
                ProvinceIDComboBox.DataSource = _serviceProvince.GetAllProvinces();
                ProvinceIDComboBox.DisplayMember = "Name";
                ProvinceIDComboBox.ValueMember = "ProvinceID";
                MunicipalityIDComboBox.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void NewCustomerRadForm_cs_Load(object sender, EventArgs e)
        {
            try
            {
                StateComboBox.DataSource = Enum.GetValues(typeof(CustomerState));
                this.ProvinceIDComboBox.SelectionChangeCommitted += ProvinceIDComboBox_SelectionChangeCommitted;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            if (_stateForm == StateForm.NEW)
            {
                try
                {
                    this.CustomerCodeRadTextBox.Text = this._serviceCustomer.GetLastCustomerCode();
                    RegisterCustomerRadButton.Text = "Registrar";
                    this.Text = "Nuevo Cliente";
                    this.CustomerCodeRadTextBox.ReadOnly = false;
                    this.DocumentIDRadTextBox.ReadOnly = false;
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
            }
            else if (_stateForm == StateForm.EDIT)
            {
                this.CustomerCodeRadTextBox.ReadOnly = true;
                this.DocumentIDRadTextBox.ReadOnly = true;
                
                RegisterCustomerRadButton.Text = "Actualizar";
                this.Text = "Actualizar Cliente";
                CustomerCodeRadTextBox.Text = CustomerToEdit.CustomerCode;
                CompanyNameRadTextBox.Text = CustomerToEdit.CompanyName;
               
                EmailRadTextBox.Text = CustomerToEdit.Email;
                ContactNameRadTextBox.Text = CustomerToEdit.ContactName;
                DocumentIDRadTextBox.Value = CustomerToEdit.DocumentID;
                Address1RadTextBox.Text = CustomerToEdit.Address1;
                Address2RadTextBox.Text = CustomerToEdit.Address2;
                Phone1RadMaskedEditBox.Value = CustomerToEdit.Phone1;

                CellphoneRadMaskedEditBox.Value = CustomerToEdit.Cellphone;
                BusinessRegistrationRadTextBox.Text = CustomerToEdit.BusinessRegistration;
                TaxRegistrationRadTextBox.Text = CustomerToEdit.TaxRegistration;

                StateComboBox.SelectedIndex = StateComboBox.FindStringExact(CustomerToEdit.State.ToString());

                ProvinceIDComboBox.SelectedValue = CustomerToEdit.ProvinceID;
                ProvinceIDComboBox_SelectionChangeCommitted(null, null);
                MunicipalityIDComboBox.SelectedValue = CustomerToEdit.MunicipalityID;
                DateAdmissionRadDateTimePicker.Value = CustomerToEdit.DateAdmission.HasValue ? CustomerToEdit.DateAdmission.Value : DateTime.Now;
                BirthdayRadDateTimePicker.Value = CustomerToEdit.Birthday.HasValue ? CustomerToEdit.Birthday.Value : DateTime.Now;

            }


        }

        private void CancelCustomerRadButton_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();

        }

        private void ProvinceIDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if ((int)this.ProvinceIDComboBox.SelectedValue == 0)
            {
                this.MunicipalityIDComboBox.Enabled = false;
                this.MunicipalityIDComboBox.DataSource = null;
                this.MessageErrorProvider.SetError(MunicipalityIDComboBox, String.Empty);
                return;
            }
            else
            {
                this.MunicipalityIDComboBox.DataSource = this._serviceMunicipality.GetAllMunicipalitiesById((Int32)this.ProvinceIDComboBox.SelectedValue);
                this.MunicipalityIDComboBox.DisplayMember = "Name";
                this.MunicipalityIDComboBox.ValueMember = "MunicipalityID";
                this.MunicipalityIDComboBox.Enabled = true;
                this.MessageErrorProvider.SetError(ProvinceIDComboBox, String.Empty);
            }
        }

        private void RegisterCustomerRadButton_Click(object sender, EventArgs e)
        {
            if (ValidateComponent())
            {
                if (this._stateForm == StateForm.NEW)
                {
                    #region Create a New Customer
                    Customer _customerNew = Customer.CreateNewInstance();
                    _customerNew.CustomerCode = CustomerCodeRadTextBox.Text;
                    _customerNew.CompanyName = CompanyNameRadTextBox.Text;
                    
                    _customerNew.Email = EmailRadTextBox.Text;
                    _customerNew.ContactName = ContactNameRadTextBox.Text;
                    _customerNew.DocumentID = DocumentIDRadTextBox.Value.ToString();
                    _customerNew.Address1 = Address1RadTextBox.Text;
                    _customerNew.Address2 = Address2RadTextBox.Text;
                    _customerNew.Phone1 = Phone1RadMaskedEditBox.Value.ToString();
                    
                    _customerNew.Cellphone = CellphoneRadMaskedEditBox.Value.ToString();
                    _customerNew.BusinessRegistration = BusinessRegistrationRadTextBox.Text;
                    _customerNew.TaxRegistration = TaxRegistrationRadTextBox.Text;
                    _customerNew.State = (CustomerState)Enum.ToObject(typeof(CustomerState), (int)StateComboBox.SelectedValue);

                    _customerNew.ProvinceID = (int)ProvinceIDComboBox.SelectedValue; ;
                    _customerNew.MunicipalityID = (int)MunicipalityIDComboBox.SelectedValue;

                    _customerNew.DateAdmission = DateAdmissionRadDateTimePicker.Value;
                    _customerNew.Birthday = BirthdayRadDateTimePicker.Value;
                    #endregion
                    try
                    {
                        _serviceCustomer.Add(_customerNew);
                        RadMessageBox.Show(null, "Cliente registrado satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                        ClearForm();
                        _currentParentForm.FillCustomersRadGridView();
                    }
                    catch (Exception ee)
                    {
                        //RadMessageBox.Show("Cliente registrado", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.AbortRetryIgnore, " Sistema prueba");
                        MessageBox.Show(ee.Message);

                    }
                }
                else if (this._stateForm == StateForm.EDIT)
                {
                    #region Update a Customer

                    CustomerToEdit.CustomerCode = CustomerCodeRadTextBox.Text;
                    CustomerToEdit.CompanyName = CompanyNameRadTextBox.Text;
                   
                    CustomerToEdit.Email = EmailRadTextBox.Text;
                    CustomerToEdit.ContactName = ContactNameRadTextBox.Text;
                    CustomerToEdit.DocumentID = DocumentIDRadTextBox.Value.ToString();
                    CustomerToEdit.Address1 = Address1RadTextBox.Text;
                    CustomerToEdit.Address2 = Address2RadTextBox.Text;
                    CustomerToEdit.Phone1 = Phone1RadMaskedEditBox.Value.ToString();
                    CustomerToEdit.Cellphone = CellphoneRadMaskedEditBox.Value.ToString();
                    CustomerToEdit.BusinessRegistration = BusinessRegistrationRadTextBox.Text;
                    CustomerToEdit.TaxRegistration = TaxRegistrationRadTextBox.Text;
                    CustomerToEdit.State = (CustomerState)Enum.ToObject(typeof(CustomerState), (int)StateComboBox.SelectedValue);

                    CustomerToEdit.ProvinceID = (int)ProvinceIDComboBox.SelectedValue; ;
                    CustomerToEdit.MunicipalityID = (int)MunicipalityIDComboBox.SelectedValue;

                    CustomerToEdit.DateAdmission = DateAdmissionRadDateTimePicker.Value;
                    CustomerToEdit.Birthday = BirthdayRadDateTimePicker.Value;
                    #endregion
                    try
                    {
                        _serviceCustomer.Update(CustomerToEdit);
                        RadMessageBox.Show(null, "Cliente actualizado satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                        CustomerToEdit = null;
                        ClearForm();
                        _currentParentForm.FillCustomersRadGridView();
                    }
                    catch (Exception ee)
                    {
                        RadMessageBox.Show(ee.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ee.StackTrace);
                    }
                }
            }



        }

        /// <summary>
        /// This method is used to validate all component in this form
        /// </summary>
        private Boolean ValidateComponent()
        {

            #region Validate CustomerCodeRadTextBox
            //Validate CustomerCodeRadTextBox's Component
            if (String.IsNullOrWhiteSpace(CustomerCodeRadTextBox.Text))
            {
                MessageErrorProvider.SetError(CustomerCodeRadTextBox, "Introduzca un código cliente correcto. \n Ej. 010101AB5DDAD20");
                CustomerCodeRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(CustomerCodeRadTextBox, String.Empty);

            if(_stateForm == StateForm.NEW)
            {
                if (_serviceCustomer.IsExitCustomerCode(CustomerCodeRadTextBox.Text))
                {
                    MessageErrorProvider.SetError(CustomerCodeRadTextBox, string.Format("Código cliente ingresado ya existe, Introduzca otro."));
                    CustomerCodeRadTextBox.Focus();
                    return false;
                }
            }
            #endregion

            #region Validate CompanyNameRadTextBox
            //Validate CompanyNameRadTextBox's Component
            if (String.IsNullOrWhiteSpace(CompanyNameRadTextBox.Text))
            {
                MessageErrorProvider.SetError(CompanyNameRadTextBox, "Introduzca el nombre de la empresa.");
                CompanyNameRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(CompanyNameRadTextBox, String.Empty);
            if (CompanyNameRadTextBox.Text.Length > 50)
            {
                MessageErrorProvider.SetError(CompanyNameRadTextBox, string.Format("El nombre de la empresa Introducido es demasiado largo,\n Introduzca un nombre con menos o igual a 50 caracteres"));
                CompanyNameRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(CompanyNameRadTextBox, String.Empty);
            #endregion

            

            #region Validate EmailRadTextBox
            //Validate EmailRadTextBox's Component

            #endregion

            #region Validate ContactNameRadTextBox
            //Validate ContactNameRadTextBox's Component
            if (String.IsNullOrWhiteSpace(ContactNameRadTextBox.Text))
            {
                MessageErrorProvider.SetError(ContactNameRadTextBox, "Introduzca el nombre del contacto.");
                ContactNameRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(ContactNameRadTextBox, String.Empty);
            if (ContactNameRadTextBox.Text.Length > 50)
            {
                MessageErrorProvider.SetError(ContactNameRadTextBox, string.Format("El nombre del contacto Introducido es demasiado largo, Introduzca un nombre con menos o igual a 50 caracteres"));
                ContactNameRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(ContactNameRadTextBox, String.Empty);
            #endregion

            #region Validate DocumentIDRadTextBox
            //Validate DocumentIDRadTextBox's Component
            if (String.IsNullOrWhiteSpace((string)DocumentIDRadTextBox.Value))
            {
                MessageErrorProvider.SetError(DocumentIDRadTextBox, "Introduzca la cédula de identidad y electoral.");
                DocumentIDRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(DocumentIDRadTextBox, String.Empty);
            if (((string)DocumentIDRadTextBox.Value).Length < 11)
            {
                MessageErrorProvider.SetError(DocumentIDRadTextBox, string.Format("Cédula de identidad y electoral esta incompleta."));
                DocumentIDRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(DocumentIDRadTextBox, String.Empty);

            if (this._serviceCustomer.IsExitCustomerDocumentID((string)DocumentIDRadTextBox.Value))
            {
                MessageErrorProvider.SetError(DocumentIDRadTextBox, "La cédula ya existe en la base de de datos.");
                DocumentIDRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(DocumentIDRadTextBox, String.Empty);
            #endregion

            #region Validate Address1RadTextBox
            //Validate Address1RadTextBox's Component
            if (String.IsNullOrWhiteSpace(Address1RadTextBox.Text))
            {
                MessageErrorProvider.SetError(Address1RadTextBox, "Introduzca una dirección.");
                Address1RadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(Address1RadTextBox, String.Empty);
            #endregion

            #region Validate ProvinceIDComboBox
            //Validate ProvinceIDComboBox's Component
            if (ProvinceIDComboBox.SelectedIndex == 0)
            {
                MessageErrorProvider.SetError(ProvinceIDComboBox, string.Format("Debe seleccionar una Provincia"));
                ProvinceIDComboBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(ProvinceIDComboBox, String.Empty);

            #endregion

            #region Validate MunicipalityIDComboBox
            //Validate MunicipalityIDComboBox's Component
            if (MunicipalityIDComboBox.SelectedIndex == 0)
            {
                MessageErrorProvider.SetError(MunicipalityIDComboBox, string.Format("Debe seleccionar un Municipio"));
                MunicipalityIDComboBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(MunicipalityIDComboBox, String.Empty);
            //Validate Phone1RadMaskedEditBox's Component 
            if (String.IsNullOrWhiteSpace(Phone1RadMaskedEditBox.Text) || Phone1RadMaskedEditBox.Text.Length < 12)
            {
                MessageErrorProvider.SetError(Phone1RadMaskedEditBox, "Introduzca un número de teléfono valido.");
                Phone1RadMaskedEditBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(Phone1RadMaskedEditBox, String.Empty);
            #endregion

            #region Validate Phone1RadMaskedEditBox
            //Validate Phone1RadMaskedEditBox's Component
            if (String.IsNullOrWhiteSpace((string)Phone1RadMaskedEditBox.Value))
            {
                MessageErrorProvider.SetError(Phone1RadMaskedEditBox, "Introduzca un teléfono residencial.");
                Phone1RadMaskedEditBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(Phone1RadMaskedEditBox, String.Empty);
            if (((string)Phone1RadMaskedEditBox.Value).Length < 10)
            {
                MessageErrorProvider.SetError(Phone1RadMaskedEditBox, string.Format("Teléfono residencial esta incompleto."));
                Phone1RadMaskedEditBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(Phone1RadMaskedEditBox, String.Empty);
            #endregion

            #region Validate CellphoneRadMaskedEditBox

            //Validate CellphoneRadMaskedEditBox's Component
            if (((string)CellphoneRadMaskedEditBox.Value).Length >= 1)
            {
                if (((string)CellphoneRadMaskedEditBox.Value).Length < 10)
                {
                    MessageErrorProvider.SetError(CellphoneRadMaskedEditBox, string.Format("Teléfono celular esta incompleto."));
                    CellphoneRadMaskedEditBox.Focus();
                    return false;
                }

            }
            MessageErrorProvider.SetError(CellphoneRadMaskedEditBox, String.Empty);
            #endregion

            #region Validate BusinessRegistrationRadTextBox
            //Validate BusinessRegistrationRadTextBox's Component
            if (BusinessRegistrationRadTextBox.Text.Length > 20)
            {
                MessageErrorProvider.SetError(BusinessRegistrationRadTextBox, string.Format("El registro empresarial Introducido es demasiado largo, Introduzca un registro empresarial correcto"));
                BusinessRegistrationRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(BusinessRegistrationRadTextBox, String.Empty);
            #endregion

            #region Validate TaxRegistrationRadTextBox
            //Validate TaxRegistrationRadTextBox's Component
            if (TaxRegistrationRadTextBox.Text.Length > 20)
            {
                MessageErrorProvider.SetError(TaxRegistrationRadTextBox, string.Format("El registro tributario Introducido es demasiado largo, Introduzca un registro tributario correcto"));
                TaxRegistrationRadTextBox.Focus();
                return false;
            }
            MessageErrorProvider.SetError(TaxRegistrationRadTextBox, String.Empty);
            #endregion
            return true;

        }

        private void ClearForm()
        {
            this.CustomerCodeRadTextBox.Text = string.Empty;
            this.CompanyNameRadTextBox.Text = string.Empty;
            
            this.EmailRadTextBox.Text = string.Empty;
            this.ContactNameRadTextBox.Text = string.Empty;

            this.Address1RadTextBox.Text = string.Empty;
            this.Address2RadTextBox.Text = string.Empty;
            this.ProvinceIDComboBox.SelectedIndex = 0;
            this.MunicipalityIDComboBox.Enabled = false;
            this.MunicipalityIDComboBox.DataSource = null;


            this.BusinessRegistrationRadTextBox.Text = string.Empty;
            this.TaxRegistrationRadTextBox.Text = string.Empty;
            this.StateComboBox.SelectedIndex = 0;
            this.DateAdmissionRadDateTimePicker.Value = DateTime.Now; ;
            this.BirthdayRadDateTimePicker.Value = DateTime.Now;

            this.DocumentIDRadTextBox.Clear();
            this.DocumentIDRadTextBox.Text = "___-_______-_";
            this.DocumentIDRadTextBox.Value = string.Empty;

            this.Phone1RadMaskedEditBox.Clear();
            this.Phone1RadMaskedEditBox.Text = "___-___-____";
            this.Phone1RadMaskedEditBox.Value = string.Empty;

            this.CellphoneRadMaskedEditBox.Clear();
            this.CellphoneRadMaskedEditBox.Text = "___-___-____";
            this.CellphoneRadMaskedEditBox.Value = string.Empty;


            this.CustomerCodeRadTextBox.Focus();


        }

        private void CustomerCodeRadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CustomerCodeRadTextBox.Text.Length <= 15 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                return;
            }
           

        }
    }
}
