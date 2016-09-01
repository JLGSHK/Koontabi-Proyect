using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Koontabi.BusinessLogic.DBInitializerBL;
using Koontabi.BusinessLogic.PaidAccountsBL;

namespace KoontabiTelerikWinFormsApp
{
    public partial class MainRadRibbonForm : Telerik.WinControls.UI.RadRibbonForm
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


        public Employee CurrentEmployee { get; set; }
        private DBContextInitializerBL initContext = null;
        private IPaidAccountsBL _servicePaidAccountBL = null;
        public MainRadRibbonForm(Employee currentEmp)
        {
            InitializeComponent();
            initContext = new DBContextInitializerBL();
            this._servicePaidAccountBL = new PaidAccountsBL();
            initContext.InitDb();
            this.CurrentEmployee = currentEmp;
            GetDateTime();
            timer1.Start();
            timer2.Start();
        }

        private void MainRadRibbonForm_Load(object sender, EventArgs e)
        {
            //Set Size Image 16X16
            this.radRibbonBar1.StartButtonImage = KoontabiTelerikWinFormsApp.Properties.Resources.LogoPequenio;
            
            SetSizeScreen();
            CustomerRadButtonElement.Click += CustomerRadButtonElement_Click;
            BodegaRadButtonElement.Click += BodegaRadButtonElement_Click;
            CategoriesRadButtonElement.Click += CategoriesRadButtonElement_Click;
            ProductRadButtonElement.Click += ProductRadButtonElement_Click;
            InvoiceRadButtonElementActive.Click += InvoiceRadButtonElementActive_Click;
            KardexRadButtonElement.Click += StoreRadButtonElement_Click;
            ReportRadButtonElement.Click += ReportRadButtonElement_Click;
            PaidAccountsRadButtonElement.Click += PaidAccountsRadButtonElement_Click;
            UnitRadButtonElement.Click += UnitRadButtonElement_Click;
            //Set Data 
            this.radLabelElement1.Text = String.Format("Usuario Online: {0}/{1}", CurrentEmployee.FullName, System.Windows.Forms.SystemInformation.ComputerName); ;

        }

        private void UnitRadButtonElement_Click(object sender, EventArgs e)
        {
            UnitRadForm _form = new UnitRadForm();
            if (!isOpenForm(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }

        private void PaidAccountsRadButtonElement_Click(object sender, EventArgs e)
        {
            PaidAccountsRadForm _paidAccountsRadForm = new PaidAccountsRadForm();
            if (!isOpenForm(_paidAccountsRadForm))
            {
                _paidAccountsRadForm.MdiParent = this;
                _paidAccountsRadForm.Show();
            }
        }

        private void ReportRadButtonElement_Click(object sender, EventArgs e)
        {
            InventoryReportRadForm _inventoryReportRadForm = new InventoryReportRadForm();
            if (!isOpenForm(_inventoryReportRadForm))
            {
                _inventoryReportRadForm.MdiParent = this;
                _inventoryReportRadForm.Show();
            }
        }

        private void StoreRadButtonElement_Click(object sender, EventArgs e)
        {
            KardexRadForm _storeRadForm = new KardexRadForm();
            if (!isOpenForm(_storeRadForm))
            {
                _storeRadForm.MdiParent = this;
                _storeRadForm.Show();
            }
        }

        void InvoiceRadButtonElementActive_Click(object sender, EventArgs e)
        {
            InvoiceRadForm _invoiceRadForm = new InvoiceRadForm();
            if (!isOpenForm(_invoiceRadForm))
            {
                _invoiceRadForm.MdiParent = this;
                _invoiceRadForm.Show();
            }
        }

        private void ProductRadButtonElement_Click(object sender, EventArgs e)
        {
            ProductRadForm _productRadForm = new ProductRadForm();
            if (!isOpenForm(_productRadForm))
            {
                _productRadForm.MdiParent = this;
                _productRadForm.Show();
            }
        }

        private void CategoriesRadButtonElement_Click(object sender, EventArgs e)
        {
            CategoryRadForm _categoryRadForm = new CategoryRadForm();
            if (!isOpenForm(_categoryRadForm))
            {
                _categoryRadForm.MdiParent = this;
                _categoryRadForm.Show();
            }
        }

        private void BodegaRadButtonElement_Click(object sender, EventArgs e)
        {
            BodegaRadForm _bodegaRadForm = new BodegaRadForm();
            if (!isOpenForm(_bodegaRadForm))
            {
                _bodegaRadForm.MdiParent = this;
                _bodegaRadForm.Show();
            }
        }

        private void CustomerRadButtonElement_Click(object sender, EventArgs e)
        {
            CustomerRadForm _customerRadForm = new CustomerRadForm();
            if (!isOpenForm(_customerRadForm))
            {
                _customerRadForm.MdiParent = this;
                _customerRadForm.Show();
            }
        }

        private void GetDateTime()
        {
            HourRadLabelElement.Text = String.Format("{0:F}", DateTime.Now);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDateTime();
            
            
            
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var count = this._servicePaidAccountBL.CountAllInvoiceOverDue();
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Actualmente existen {0} Cliente(s) con factura vencida(s).");
                
                sb.AppendLine("Para ver más detalles sobre el cliente y la factura ir al modulo de [Ventas] - [Factura] - [Factura Vencida].");
                MyRadDesktopAlert.CaptionText = "JOSIAS INDUSTRIAL SRL || NOTIFICACION";
                MyRadDesktopAlert.ContentText = String.Format(sb.ToString(), count);
                MyRadDesktopAlert.Show();

            }
            timer2.Stop();
        }
    }
}
