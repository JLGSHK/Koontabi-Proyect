using KoontabiTelerikWinFormsApp.ReportViewForm;
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

namespace KoontabiTelerikWinFormsApp
{
    public partial class ReportSalesDateRadForm : Telerik.WinControls.UI.RadForm
    {
        public ReportSalesDateRadForm()
        {
            InitializeComponent();
            DisplayMsgRadLabel.Text = String.Empty;
            InitRadDateTimePicker.Value = DateTime.Now;
            EndRadDateTimePicker.Value = DateTime.Now;

        }

        private void GetReportRadButton_Click(object sender, EventArgs e)
        {
            var InitDate = InitRadDateTimePicker.Value.Date;
            var EndDate = EndRadDateTimePicker.Value.Date;
            DisplayMsgRadLabel.ForeColor = Color.Black;
            if (InitDate == EndDate)
            {
                //SAME'S DATE
                DisplayMsgRadLabel.ForeColor = Color.Red;
                DisplayMsgRadLabel.Text = "* Las fechas son iguales";
                return;
            }
            else if (InitDate > EndDate)
            {
                //InitDate is more grather EndDate
                DisplayMsgRadLabel.ForeColor = Color.Red;
                DisplayMsgRadLabel.Text = "* La fecha inicio no puede ser mayor que la fecha fin";
                return;
            }
            else
            {
                DisplayMsgRadLabel.Text = String.Empty;
                DisplayMsgRadLabel.ForeColor = Color.Black;
            }
            try
            {
                var _serviceReportBL = new Koontabi.BusinessLogic.ReportBL.ReportBL();
                var datasourceAllSales = _serviceReportBL.DisplayAllSalesToReport(InitRadDateTimePicker.Value.Date, EndRadDateTimePicker.Value.Date);

                DisplayAllSalesRadForm report = new DisplayAllSalesRadForm(datasourceAllSales);
                report.ShowDialog();
            }
            catch (Exception ex)
            {
                
                RadMessageBox.Show(ex.Message, "JOSIAS INDUSTRAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }

        }
    }
}
