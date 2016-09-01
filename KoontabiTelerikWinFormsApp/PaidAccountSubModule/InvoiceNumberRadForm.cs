using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;
using Koontabi.BusinessLogic.PaidAccountsBL;
using Telerik.WinControls.UI;
using KoonException;
using System.Threading;

namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    public partial class InvoiceNumberRadForm : Telerik.WinControls.UI.RadForm
    {
        private IPaidAccountsBL _servicePaidAccountsBL = null;
        private RadForm _currentParentForm = null;
        public InvoiceNumberRadForm(RadForm form)
        {
            this._servicePaidAccountsBL = new PaidAccountsBL();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this._currentParentForm = form;
        }

        private void InvoiceNumberRadForm_Load(object sender, EventArgs e)
        {
            DocumentIDMaskedTextBox.Focus();
            
            this.DisplayMsgRadLabel.Text = string.Empty;


        }
       

        private void SearchingRadButton_Click(object sender, EventArgs e)
        {
            if (!DocumentIDMaskedTextBox.MaskFull)
            {
                RadMessageBox.Show(this, "Numero de factura inválido", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                DocumentIDMaskedTextBox.Focus();
                return;
            }
            try
            {
                var invoiceNumber = Convert.ToInt32(DocumentIDMaskedTextBox.Text);
                var result = this._servicePaidAccountsBL.FindPaidAccountByCondition(x=>x.Invoice.InvoiceNumber == invoiceNumber);
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
                    throw new PaidAccountsNotFoundException("Numero de factura no encontrado");
                }
                this.DisplayMsgRadLabel.Text = string.Empty;
            }
            catch (PaidAccountsNotFoundException ex)
            {
                RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;

            }
            
        }

        private void InvoiceNumberRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

       
        
    }
}
