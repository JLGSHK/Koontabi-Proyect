using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.BusinessLogic;
using Koontabi.Domain;
using Koontabi.BusinessLogic.ReportBL;
namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
    public partial class GetInvoiceByZoneRadForm : Telerik.WinControls.UI.RadForm
    {
        private IReportBL _serviceReportBL = null;
        public GetInvoiceByZoneRadForm()
        {
            InitializeComponent();
            this._serviceReportBL = new ReportBL();
        }

        


        private void GetInvoiceByZoneRadForm_Load(object sender, EventArgs e)
        {
            DisplayMsgRadLabel.Text = String.Empty;
            ZoneComboBox.DataSource = this._serviceReportBL.GetAllZone();
            ZoneComboBox.DisplayMember = "Zone";
            ZoneComboBox.ValueMember = "Zone";
            ZoneComboBox.SelectedIndex = -1;
               
        }

        private void GetReportRadButton_Click(object sender, EventArgs e)
        {
            if (ZoneComboBox.SelectedIndex == -1){
                DisplayMsgRadLabel.Text = "Debe seleccionar un valor";
                ZoneComboBox.Focus();
                return;
            }
            DisplayMsgRadLabel.Text = String.Empty;
            try
            {
                var result = this._serviceReportBL.DisplayAllInvoiceByZone(ZoneComboBox.SelectedValue.ToString());
                ReportViewForm.GetInvoiceByZoneRadFormReport zoneReport = new ReportViewForm.GetInvoiceByZoneRadFormReport(result);
                zoneReport.ShowDialog();

            }
            catch (Exception ex)
            {
                RadMessageBox.Show("Presione Details para visualizar el error ocurrido", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                return;
            }
            
        }

        
    }
}
