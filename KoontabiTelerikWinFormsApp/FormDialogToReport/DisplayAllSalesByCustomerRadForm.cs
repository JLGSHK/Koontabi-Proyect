using System;
using System.Globalization;
using System.Linq;
using Koontabi.BusinessLogic.ReportBL;
using KoontabiTelerikWinFormsApp.ReportViewForm;

namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
    public partial class DisplayAllSalesByCustomerRadForm : Telerik.WinControls.UI.RadForm
    {
        private IReportBL _serviceReportBL = null;
        public DisplayAllSalesByCustomerRadForm()
        {
            InitializeComponent();
            _serviceReportBL = new ReportBL();
        }

        private void DisplayAllSalesByCustomerRadForm_Load(object sender, EventArgs e)
        {

            IndividualCustomerRadRadioButton.CheckStateChanged += new EventHandler(RadRadioButton_CheckedChanged);
            AllCustomersRadRadioButton.CheckStateChanged += new EventHandler(RadRadioButton_CheckedChanged);
            AllSalesRdCheckBox.CheckStateChanged += new EventHandler(CheckStateChanged);

            var result = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1);
            YearSalesCmboBox.DataSource = result.ToList();
            YearSalesCmboBox.SelectedIndex = -1;
            DisplayMsgRadLabel.Text = String.Empty;
            DisplayComponents();

        }



        private void CheckStateChanged(object sender, EventArgs e)
        {
            if (AllSalesRdCheckBox.Checked)
            {
                YearSalesCmboBox.SelectedIndex = -1;
                YearSalesCmboBox.Enabled = false;
            }
            else
            {
                YearSalesCmboBox.SelectedIndex = -1;
                YearSalesCmboBox.Enabled = true;
            }
        }
        private void RadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisplayComponents();
        }
        private void DisplayComponents()
        {
            if (IndividualCustomerRadRadioButton.IsChecked)
            {
                ThridRadGroupBox.Visible = true;
                DocumentIDMaskedTextBox.Text = string.Empty;
            }
            else if (AllCustomersRadRadioButton.IsChecked)
            {
                ThridRadGroupBox.Visible = false;
            }
        }

        private Int32 GetYear()
        {
            return DateTime.ParseExact(YearSalesCmboBox.SelectedValue.ToString(), "yyyy", CultureInfo.CurrentCulture).Year;
        }

        private void GetDataFromDB()
        {

        }

        private void GetReportRadButton_Click(object sender, EventArgs e)
        {
            bool isAll = false;
            if (IndividualCustomerRadRadioButton.IsChecked)
            {
                //Si es un cliente
                if (AllSalesRdCheckBox.Checked)
                {
                    isAll = true;
                }
                else if(YearSalesCmboBox.SelectedIndex != -1)
                {
                    isAll = false;
                }
                else
                {
                    DisplayMsgRadLabel.Text = "Debe seleccionar un año o todos.";
                    return;
                }

                if(DocumentIDMaskedTextBox.Text == String.Empty || DocumentIDMaskedTextBox.Text.Length < 11)
                {
                    DisplayMsgRadLabel.Text = "Debe ingresar un número de cedula.";
                    return;
                }
                DisplayMsgRadLabel.Text = String.Empty;
                if (!isAll)
                {
                    
                    var year = GetYear();
                    var documentid = DocumentIDMaskedTextBox.Text;
                    var result = this._serviceReportBL.DisplayAllSalesByCustomer(c => c.DocumentID == documentid &&
                    System.Data.Entity.DbFunctions.TruncateTime(c.InvoiceDate).Value.Year == year);

                    DisplayAllSalesByCustomerRadFormReportView _report = new DisplayAllSalesByCustomerRadFormReportView(result);
                    _report.ShowDialog();

                }
                else
                {
                    var documentid = DocumentIDMaskedTextBox.Text;
                    var result = this._serviceReportBL.DisplayAllSalesByCustomer(c => c.DocumentID == documentid);

                    DisplayAllSalesByCustomerRadFormReportView _report = new DisplayAllSalesByCustomerRadFormReportView(result);
                    _report.ShowDialog();
                }

            }
            else
            {
                //Si es un cliente
                if (AllSalesRdCheckBox.Checked)
                {
                    isAll = true;
                }
                else if (YearSalesCmboBox.SelectedIndex != -1)
                {
                    isAll = false;
                }
                else
                {
                    DisplayMsgRadLabel.Text = "Debe seleccionar un año o todos.";
                    return;
                }

                DisplayMsgRadLabel.Text = String.Empty;
                if (!isAll)
                {

                    var year = GetYear();
                   
                    var result = this._serviceReportBL.DisplayAllSalesByCustomer(c =>System.Data.Entity.DbFunctions.TruncateTime(c.InvoiceDate).Value.Year == year);

                    DisplayAllSalesByCustomerRadFormReportView _report = new DisplayAllSalesByCustomerRadFormReportView(result);
                    _report.ShowDialog();

                }
                else
                {
                    var result = this._serviceReportBL.DisplayAllSalesByCustomer(null,true);

                    DisplayAllSalesByCustomerRadFormReportView _report = new DisplayAllSalesByCustomerRadFormReportView(result);
                    _report.ShowDialog();
                }
            }

        }
    }
}
