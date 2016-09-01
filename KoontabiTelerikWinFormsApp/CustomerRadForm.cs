using Koontabi.BusinessLogic;
using Koontabi.BusinessLogic.CustomerBL;
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

namespace KoontabiTelerikWinFormsApp
{
    public partial class CustomerRadForm : Telerik.WinControls.UI.RadForm
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


        private ICustomerBL _serviceCustomer = null;
        public static CustomerRadForm _myCurrentForm;
        public CustomerRadForm()
        {
            try
            {
                InitializeComponent();
                this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
                _serviceCustomer = new CustomerBL();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
                //throw;
            }


        }
        public void FillCustomersRadGridView()
        {
            if (this.CustomersRadGridView.Rows.Count > 0)
            {
                this.CustomersRadGridView.DataSource = null;
            }
            this.CustomersRadGridView.DataSource = _serviceCustomer.FillGridView();

            #region Columns of the GridView
            try
            {
                GridViewColumnCollection columns = this.CustomersRadGridView.Columns;


                //CustomerID Column
                GridViewDataColumn _customerIDColumn = columns["CustomerID"];
                _customerIDColumn.IsVisible = false;

                //CustomerCode Column
                GridViewDataColumn _customerCodeColumn = columns["CustomerCode"];
                _customerCodeColumn.HeaderText = "Código";
                _customerCodeColumn.Width = 80;

                //CompanyName Column
                GridViewDataColumn _companyNameColumn = columns["CompanyName"];
                _companyNameColumn.HeaderText = "Empresa";
                _companyNameColumn.Width = 200;

                //ContactName Column
                GridViewDataColumn _contactNameColumn = columns["ContactName"];
                _contactNameColumn.HeaderText = "Contacto";
                _contactNameColumn.Width = 200;

                //Phone1 Column
                GridViewDataColumn _phone1Column = columns["Phone1"];
                _phone1Column.HeaderText = "Teléfono";
                _phone1Column.Width = 100;

                //Addresses Column
                GridViewDataColumn _addressesColumn = columns["Addresses"];
                _addressesColumn.HeaderText = "Dirección";
                _addressesColumn.Width = 500;


                //Province Column
                GridViewDataColumn _provinceColumn = columns["Province"];
                _provinceColumn.HeaderText = "Provincia";
                _provinceColumn.Width = 200;

                //Municipality Column
                GridViewDataColumn _municipalityColumn = columns["Municipality"];
                _municipalityColumn.HeaderText = "Municipio";
                _municipalityColumn.Width = 200;

                //Zone Column
                GridViewDataColumn _zoneColumn = columns["Zone"];
                _zoneColumn.HeaderText = "Zona";
                _zoneColumn.Width = 200;

                //Clear Selection
                ClearSelectionRadGridView();
            }
            catch (Exception) { }

            #endregion

        }
        private void CustomerRadForm_Load(object sender, EventArgs e)
        {
            this.CustomersRadGridView.EnableGrouping = false;
            this.CustomersRadGridView.TableElement.Text = "Cargando Datos..";
            this.CustomersRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
        }
        private void ClearSelectionRadGridView()
        {
            this.CustomersRadGridView.ClearSelection();
            this.CustomersRadGridView.Rows[0].IsCurrent = false;
        }
        private void NewCustomerRadButton_Click(object sender, EventArgs e)
        {
            NewCustomerRadForm _newCustomerRadForm = new NewCustomerRadForm(this, StateForm.NEW);
            if (!isOpenForm(_newCustomerRadForm))
            {
                _newCustomerRadForm.ShowDialog();
            }
        }
        private void EditCustomerRadButton_Click(object sender, EventArgs e)
        {
            
            if (this.CustomersRadGridView.SelectedRows.Count == 0)
            {

                RadMessageBox.Show(null, "Debe seleccionar un cliente para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            else
            {
                selectedRow = (Int32)this.CustomersRadGridView.CurrentRow.Cells["CustomerID"].Value;
                NewCustomerRadForm _newCustomerRadForm = new NewCustomerRadForm(this, StateForm.EDIT);
                if (!isOpenForm(_newCustomerRadForm))
                {
                    if (selectedRow.HasValue)
                    {
                        var customerToEdit = _serviceCustomer.Find(selectedRow.Value);
                        _newCustomerRadForm.CustomerToEdit = customerToEdit;
                    }
                    _newCustomerRadForm.ShowDialog();
                }
            }
        }
        private void DeleteCustomerRadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CustomersRadGridView.SelectedRows.Count == 0)
                {

                    RadMessageBox.Show(null, "Debe seleccionar un cliente para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                    return;
                }
                else
                {
                    selectedRow = (Int32)this.CustomersRadGridView.CurrentRow.Cells["CustomerID"].Value;
                    DialogResult result = RadMessageBox.Show(null, "¿Usted quiere eliminar el cliente seleccionado?", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OKCancel, RadMessageIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        _serviceCustomer.Delete(selectedRow.Value);
                        FillCustomersRadGridView();
                        RadMessageBox.Show(null, "Cliente eliminado correctamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    }

                }
            }
            catch (Exception ee)
            {
                RadMessageBox.Show(null, string.Format("Se ha producido un error: {0}",ee.Message), "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }
        private void CustomersRadGridView_Click(object sender, EventArgs e)
        {

        }

        Int32? selectedRow = 0;
        private void CustomersRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedRow = (Int32)this.CustomersRadGridView.Rows[e.RowIndex].Cells["CustomerID"].Value;

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            FillCustomersRadGridView();
            this.CustomersRadGridView.TableElement.Text = string.Empty;
            this.CustomersRadGridView.TableElement.BackgroundImage = null;
            this.MyTimer.Stop();
        }
    }
}
