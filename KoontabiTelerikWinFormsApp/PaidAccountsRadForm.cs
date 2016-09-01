using KoontabiTelerikWinFormsApp.PaidAccountSubModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;
using Telerik.WinControls.UI;
using KoonException;
using Koontabi.Helpers;
using Koontabi.BusinessLogic.PaidAccountsBL;
using System.Linq;
namespace KoontabiTelerikWinFormsApp
{
    public enum ActionButton
    {
        InvoiceNumSelected, DocumentIDSelected

    }
    public partial class PaidAccountsRadForm : Telerik.WinControls.UI.RadForm
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

        private List<PaidAccount> _currentPaidAccountsList;

        public List<PaidAccount> CurrentPaidAccountList
        {
            get { return _currentPaidAccountsList; }
            set { _currentPaidAccountsList = value; }
        }

        private IPaidAccountsBL _servicePaidAccountsBL = null;
        public ActionButton ActionButtonSelected { get; set; }
        public PaidAccountsRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            this.CustomerNameRadLabel.Text = String.Empty;
            this.DocumentIDRadLabel.Text = String.Empty;
            this.ProvinceAndMunicpalityRadLabel.Text = String.Empty;
            this._servicePaidAccountsBL = new PaidAccountsBL();
        }

        private void PaidAccountsRadForm_Load(object sender, EventArgs e)
        {
            MyTimer.Start();

            DoPayRadButton.Enabled = false;
            this.PaidAccountsRadGridView.EnableGrouping = false;
            this.PaidAccountsRadGridView.TableElement.Text = String.Empty;

            this.PaidAccountsDetailsRadGridView.EnableGrouping = false;



        }

        private void InvoiceNumRadButton_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceNumberRadForm _form = new InvoiceNumberRadForm(this);
                _form.ShowDialog();
                SetUpBasicData();
                ActionButtonSelected = ActionButton.InvoiceNumSelected;
                PaidAccountsDetailsRadGridView.DataSource = null;
                DayDelayRadLabel.ForeColor = Color.Black;

            }
            catch (PaidAccountsNotFoundException ex)
            {
                RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private void DocumentIDRadButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerListRadForm _form = new CustomerListRadForm(this);
                _form.ShowDialog();
                SetUpBasicData();
                ActionButtonSelected = ActionButton.DocumentIDSelected;
                PaidAccountsDetailsRadGridView.DataSource = null;
                DayDelayRadLabel.ForeColor = Color.Black;
            }
            catch (PaidAccountsNotFoundException ex)
            {
                RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
        }

        private void SetUpBasicData()
        {
            if (_currentPaidAccountsList != null)
            {
                if (_currentPaidAccountsList.Count > 0)
                {
                    this.CustomerNameRadLabel.Text = _currentPaidAccountsList[0].Invoice.Customer.CompanyName;
                    this.DocumentIDRadLabel.Text = _currentPaidAccountsList[0].Invoice.Customer.DocumentID;
                    FillPaidAccountingRadGridViewRad();

                }
            }
            else
            {
                FillPaidAccountingRadGridViewRad();

            }
            DoPayRadButton.Enabled = false;
        }

        private void ClearSelectionPaidAccountDetailsRadGridView()
        {
            this.PaidAccountsDetailsRadGridView.ClearSelection();
            for (var item = 0; item < this.PaidAccountsDetailsRadGridView.Rows.Count; item++)
            {
                this.PaidAccountsDetailsRadGridView.Rows[item].IsCurrent = false;
            }

        }

        private void ClearSelectionRadGridView()
        {
            this.PaidAccountsRadGridView.ClearSelection();
            for (var item = 0; item < this.PaidAccountsRadGridView.Rows.Count; item++)
            {
                this.PaidAccountsRadGridView.Rows[item].IsCurrent = false;
            }

        }

        public void FillPaidAccountingRadGridViewRad()
        {
            if (this.PaidAccountsRadGridView.Rows.Count > 0)
            {
                this.PaidAccountsRadGridView.Rows.Clear();
            }

            #region Columns of the GridView
            try
            {
                foreach (PaidAccount pa in this._currentPaidAccountsList)
                {
                    GridViewDataRowInfo row = new GridViewDataRowInfo(this.PaidAccountsRadGridView.MasterView);
                    row.Cells["PaidAccountID"].Value = pa.PaidAccountID;
                    row.Cells["InvoiceNumber"].Value = pa.Invoice.InvoiceNumber.GetInvoiceNumberExt();
                    row.Cells["DateEmit"].Value = pa.DateEmit;
                    row.Cells["ExpirationDate"].Value = pa.ExpirationDate;
                    row.Cells["Amount"].Value = pa.Amount;
                    row.Cells["DayDelay"].Value = pa.DayDelay;
                    row.Cells["AmountPending"].Value = pa.AmountPending;
                    row.Cells["State"].Value = pa.State;

                    this.PaidAccountsRadGridView.Rows.Add(row);

                }
                DisplayOtherData();
                ClearSelectionRadGridView();
            }
            catch (Exception) { }

            #endregion

        }
        public GridViewRowInfo _CurrentRowSelected { get; set; }
        private void PaidAccountsRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                GetDate();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void DisplayOtherData(String TextStateRadLabel = "",
                                      String TextDayDelayRadLabel = "",
                                      String TextPaidNumberRadLabel = "",
                                      String TextLastPaidDateRadLabel = "")
        {
            
            StateRadLabel.Text = String.Format("Estado de la cuenta: {0}", TextStateRadLabel);
            DayDelayRadLabel.Text = String.Format("Días de atraso: {0}", TextDayDelayRadLabel);
            PaidNumberRadLabel.Text = String.Format("Num. de pago realizado : {0}", TextPaidNumberRadLabel);
            LastPaidDateRadLabel.Text = String.Format("Última fecha de pago: {0}", TextLastPaidDateRadLabel);
            
        }

        private void DoPayRadButton_Click(object sender, EventArgs e)
        {

            if (PaidAccountsRadGridView.CurrentRow == null)
            {
                RadMessageBox.Show("Seleccione cuenta para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            DoingPaymentRadForm _form = new DoingPaymentRadForm(this);
            _form.ShowDialog();
            PaidAccountsDetailsRadGridView.DataSource = null;
            DayDelayRadLabel.ForeColor = Color.Black;



        }

        public void RefreshGrid()
        {
            if (ActionButtonSelected == ActionButton.InvoiceNumSelected)
            {
                var invoiceNumber = this._currentPaidAccountsList[0].Invoice.InvoiceNumber;
                this._currentPaidAccountsList = _servicePaidAccountsBL.FindPaidAccountByCondition(p => p.Invoice.InvoiceNumber == invoiceNumber);
                SetUpBasicData();
            }
            else if (ActionButtonSelected == ActionButton.DocumentIDSelected)
            {
                //this._servicePaidAccountsBL.FindPaidAccountByCondition(x => x.Invoice.Customer.CustomerID == customerid);
                var customerid = this._currentPaidAccountsList[0].Invoice.Customer.CustomerID;
                this._currentPaidAccountsList = _servicePaidAccountsBL.FindPaidAccountByCondition(
                    p => p.Invoice.Customer.CustomerID == customerid);
                SetUpBasicData();
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //UpdateGrid();
                MyTimer.Stop();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void PaidAccountsRadGridView_KeyUp(object sender, KeyEventArgs e)
        {

            GetDate();
        }

        private void GetDate() {

            if (PaidAccountsRadGridView.CurrentRow != null)
            {
                _CurrentRowSelected = PaidAccountsRadGridView.CurrentRow;
                var _paidAccountIDSelected = Convert.ToInt32(_CurrentRowSelected.Cells[0].Value);
                
                var resultList = this._servicePaidAccountsBL.ListPayAccountDetail(x => x.PaidAccountID == _paidAccountIDSelected);
                if (resultList.Count > 0)
                {
                    PaidAccountsDetailsRadGridView.DataSource = resultList.OrderByDescending(o=>o.DatePayment);
                    DisplayOtherData(
                    TextStateRadLabel: _CurrentRowSelected.Cells[7].Value.ToString(),
                    TextDayDelayRadLabel: _CurrentRowSelected.Cells[5].Value.ToString(),
                    TextPaidNumberRadLabel: resultList.Count.ToString(),
                    TextLastPaidDateRadLabel: resultList.Max(x => x.DatePayment).ToString("dd/MM/yyyy"));
                    ClearSelectionPaidAccountDetailsRadGridView();
                    
                }
                else
                {
                    DisplayOtherData(
                   TextStateRadLabel: _CurrentRowSelected.Cells[7].Value.ToString(),
                   TextDayDelayRadLabel: _CurrentRowSelected.Cells[5].Value.ToString());
                    PaidAccountsDetailsRadGridView.DataSource = null;
                }

                if (Convert.ToInt32(_CurrentRowSelected.Cells[5].Value) > 0)
                {
                    DayDelayRadLabel.ForeColor = Color.Red;
                }
                else
                {
                    DayDelayRadLabel.ForeColor = Color.Black;
                }


                if (Convert.ToDecimal(_CurrentRowSelected.Cells[6].Value) == 0)
                {
                    DoPayRadButton.Enabled = false;
                }
                else
                {
                    DoPayRadButton.Enabled = true;
                }


            }
        }
    }
}
