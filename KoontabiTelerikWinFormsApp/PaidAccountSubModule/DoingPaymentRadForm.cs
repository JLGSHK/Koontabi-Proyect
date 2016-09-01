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
using Koontabi.BusinessLogic.PaidAccountsBL;
using Koontabi.Helpers;
namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    public partial class DoingPaymentRadForm : Telerik.WinControls.UI.RadForm
    {
        private RadForm _currentParentForm = null;
        private IPaidAccountsBL _servicePaidAccountsBL = null;
        public DoingPaymentRadForm(RadForm parent)
        {
            InitializeComponent();
            this._currentParentForm = parent;
            this._servicePaidAccountsBL = new PaidAccountsBL();
        }

        private void DoingPaymentRadForm_Load(object sender, EventArgs e)
        {
            if (this._currentParentForm is PaidAccountsRadForm)
            {
                var result = ((PaidAccountsRadForm)this._currentParentForm).CurrentPaidAccountList;
                var currentCustomer = result[0].Invoice.Customer;
                CustomerNameRadLabel.Text = String.Format("Cliente: {0} / {0}", currentCustomer.CompanyName.ToUpper(), currentCustomer.ContactName.ToUpper());
                DocumentIDRadLabel.Text = String.Format("Cedula: {0}", currentCustomer.DocumentID);
            }
            DatePayRadDateTimePicker.Value = DateTime.Now;
            AmountPayRadMaskedEditBox.Focus();
        }

        private void AmountPayRadMaskedEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 45)
            {
                e.Handled = true;
                return;
            }
            
        }

        private void PayProcessRadButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {
                if (PaymentRadRadioButton.IsChecked)
                {
                    var parentForm = ((PaidAccountsRadForm)this._currentParentForm);
                    var paidAccountsID = parentForm.CurrentPaidAccountList[parentForm._CurrentRowSelected.Index].PaidAccountID;
                    var concept = ConceptRichTextBox.Text;
                    var amountPay = Convert.ToDecimal(AmountPayRadMaskedEditBox.Value);
                    var datePayment = DatePayRadDateTimePicker.Value;
                    var receiptRef = ReceiptRefMaskedTextBox.Text;

                    PaidAccountDetail _paidDetail = new PaidAccountDetail()
                    {
                        PaidAccountID = paidAccountsID,
                        Concept = concept.ToUpper(),
                        Payment = amountPay,
                        DatePayment = datePayment,
                        RefNumberInvoicePay = receiptRef
                    };

                    bool result = this._servicePaidAccountsBL.AddPaidAccountDetail(_paidDetail);
                    ResetComponent();
                    String outPutString = String.Format("El pago a  la factura no. {0} se ha procesado satisfactoriamente", parentForm.CurrentPaidAccountList[parentForm._CurrentRowSelected.Index].Invoice.InvoiceNumber.GetInvoiceNumberExt());
                    parentForm.RefreshGrid();
                    RadMessageBox.Show(outPutString,"JOSIAS INDUSTRIAL SRL",MessageBoxButtons.OK,RadMessageIcon.Info);
                    this.Close();
                }
            }
        }

        private void ResetComponent()
        {
            AmountPayRadMaskedEditBox.Value = string.Empty;
            ReceiptRefMaskedTextBox.Text = string.Empty;
            ConceptRichTextBox.Text = string.Empty;
            DatePayRadDateTimePicker.Value = DateTime.Now;
            PaymentRadRadioButton.IsChecked = true;
            TotalPayRadRadioButton.IsChecked = false;
            PrintReciptRadCheckBox.Checked = false;
        }

        private bool ValidateForm()
        {
            var parentForm = ((PaidAccountsRadForm)this._currentParentForm);
            var result = parentForm.CurrentPaidAccountList.Find(x => x.Invoice.InvoiceNumber == Convert.ToInt32(parentForm._CurrentRowSelected.Cells["InvoiceNumber"].Value));

            var resulInvoiceNumber = this._servicePaidAccountsBL.ValidateInvoiceOldByPay(result.Invoice.Customer.CustomerID, result.DateEmit);

            if (resulInvoiceNumber.HasValue && resulInvoiceNumber.Value > 0)
            {
                var output = String.Format("Existe un factura más antigua por saldar. Referencia [{0}]", resulInvoiceNumber.Value.GetInvoiceNumberExt());
                RadMessageBox.Show(output, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return false;
            }

            var amountPay = Convert.ToDouble(AmountPayRadMaskedEditBox.Value);
            if(amountPay == 0.00)
            {
                errorProvider.SetError(AmountPayRadMaskedEditBox, "Ingrese un monto");
                AmountPayRadMaskedEditBox.Focus();
                return false;
            }
            errorProvider.Clear();

            if (this._currentParentForm is PaidAccountsRadForm)
            {
                
                if (amountPay > (double)result.AmountPending)
                {
                    errorProvider.SetError(AmountPayRadMaskedEditBox, "El monto ingresado es mayor que el monto pendiente a saldar");
                    AmountPayRadMaskedEditBox.Focus();
                    return false;
                }
            }
            
            if (!ReceiptRefMaskedTextBox.MaskFull)
            {
                errorProvider.SetError(ReceiptRefMaskedTextBox, "Ingrese un recibo de referencia");
                ReceiptRefMaskedTextBox.Focus();
                return false;
            }
            errorProvider.Clear();

            if (!validateReceiptRefInvoice())
            {
                return false;
            }

            if (ConceptRichTextBox.TextLength < 10)
            {
                errorProvider.SetError(ConceptRichTextBox, "Ingrese un concepto al pago a realizar");
                ConceptRichTextBox.Focus();
                return false;
            }
            errorProvider.Clear();
            
            if(DatePayRadDateTimePicker.Value.Date.CompareTo(result.DateEmit.Date) == -1)
            {
                errorProvider.SetError(DatePayRadDateTimePicker, "La fecha de pago no puede ser menor que la fecha de emisión de la factura");
                DatePayRadDateTimePicker.Focus();
                return false;
            }
              return true; ;
        }

        private void ReceiptRefMaskedTextBox_TextChanged(object sender, EventArgs e)
        {

            validateReceiptRefInvoice();
        }

        private bool validateReceiptRefInvoice()
        {
            var result = this._servicePaidAccountsBL.SpValidateRefNumberInvoicePay
              (ReceiptRefMaskedTextBox.Text);
            if (result)
            {
                errorProvider.SetError(ReceiptRefMaskedTextBox, "Referncia ingresada ya ha sido relacionanda con un pago previo a este.");
                ReceiptRefMaskedTextBox.Focus();
                return false;
            }
            errorProvider.Clear();
            return true;
            
        }

        private void DoingPaymentRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
