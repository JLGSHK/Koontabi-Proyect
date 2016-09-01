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
using Koontabi.BusinessLogic.CustomerBL;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Koontabi.BusinessLogic.PaidAccountsBL;
using KoonException;

namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    public partial class CustomerListRadForm : Telerik.WinControls.UI.RadForm
    {
        private ICustomerBL _serviceCustomerBL = null;
        private RadForm _currentParentForm;
        private IPaidAccountsBL _servicePaidAccountsBL = null;
        public CustomerListRadForm(RadForm parent)
        {
            InitializeComponent();
            this._serviceCustomerBL = new CustomerBL();
            this._currentParentForm = parent;
            this._servicePaidAccountsBL = new PaidAccountsBL();
        }

        private void SearchingRadTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        
        private void CustomerListRadForm_Load(object sender, EventArgs e)
        {
            this.CustomersRadGridView.EnableGrouping = false;
            this.CustomersRadGridView.TableElement.Text = "Cargando Datos..";
            this.CustomersRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
            this.SearchingRadTextBox.Focus();
            this.SearchingRadTextBox.TextChanged += SearchingRadTextBox_TextChanged;
            SelectingRadButton.Enabled = false;
            SearchingRadTextBox.Focus();

        }

        private void SearchingRadTextBox_TextChanged(object sender, EventArgs e)
        {

            
            CustomersRadGridView.FilterDescriptors.Clear();
            CustomersRadGridView.FilterDescriptors.Add(new FilterDescriptor("CompanyName", FilterOperator.Contains, SearchingRadTextBox.Text.Trim()));
            CustomersRadGridView.FilterDescriptors.Add(new FilterDescriptor("ContactName", FilterOperator.Contains, SearchingRadTextBox.Text.Trim()));

            if (SearchingRadTextBox.Text == string.Empty)
            {
                ClearSelectionRadGridView();
            }
            EnableSelectingRadButton();

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            
            this.CustomersRadGridView.TableElement.Text = string.Empty;
            this.CustomersRadGridView.TableElement.BackgroundImage = null;
            FillProductsRadGridView();
            MyTimer.Stop();

        }
        private void ClearSelectionRadGridView()
        {
            if (this.CustomersRadGridView.Rows.Count > 0)
            {
                for(var item = 0; item < this.CustomersRadGridView.Rows.Count;item++)
                {
                    this.CustomersRadGridView.Rows[item].IsCurrent = false;
                }
               
            }
            this.CustomersRadGridView.ClearSelection();
            ;
        }

        public void FillProductsRadGridView()
        {
            if (this.CustomersRadGridView.Rows.Count > 0)
            {
                this.CustomersRadGridView.DataSource = null;
            }
            var result = this._serviceCustomerBL.Sp_GetAllCustomerToSearch();
            CustomersRadGridView.DataSource = result;

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
                    _customerCodeColumn.Width = 100;

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
                _address1Column.HeaderText = "Dirección";
                _address1Column.Width = 250;

                //Phone1 Column
                GridViewDataColumn _phone1Column = columns["Phone1"];
                    _phone1Column.IsVisible = false;

                    //Province Column
                    GridViewDataColumn _provinceColumn = columns["Province"];
                _provinceColumn.HeaderText = "Provincia";
                _provinceColumn.Width = 250;

                //Municipality Column
                GridViewDataColumn _municipalityColumn = columns["Municipality"];
                _municipalityColumn.HeaderText = "Municipio";
                _municipalityColumn.Width = 250;



            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }

                #endregion
                ClearSelectionRadGridView();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerListRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            //this.DialogResult = System.Windows.Forms.DialogResult.OK
        }

        private void SelectingRadButton_Click(object sender, EventArgs e)
        {
            if (CustomersRadGridView.CurrentRow != null)
            {
                if (_currentParentForm is PaidAccountsRadForm) {
                   
                   try
                   {
                       var customerid = Convert.ToInt32(CustomersRadGridView.CurrentRow.Cells["CustomerID"].Value);
                       var result = this._servicePaidAccountsBL.FindPaidAccountByCondition(x => x.Invoice.Customer.CustomerID == customerid);
                       if (result.Count > 0)
                       {
                           if (_currentParentForm is PaidAccountsRadForm)
                           {
                               ((PaidAccountsRadForm)_currentParentForm).CurrentPaidAccountList = result;
                               this.Close();
                           }
                       }
                       else
                       {
                           throw new PaidAccountsNotFoundException("Cliente no tiene factura a creditos.");
                       }
                       
                   }
                   catch (PaidAccountsNotFoundException ex)
                   {
                       RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                       return;

                   }
                   
                }
            }
           
        }

        private void CustomersRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            EnableSelectingRadButton();
        }

        private void EnableSelectingRadButton()
        {
            if (CustomersRadGridView.CurrentRow != null)
            {
                SelectingRadButton.Enabled = true;
            }
            else
            {
                SelectingRadButton.Enabled = false;
            }
        }
    }
}
