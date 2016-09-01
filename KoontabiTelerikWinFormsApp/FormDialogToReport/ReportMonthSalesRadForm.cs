using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using Telerik.WinControls.UI;
using Koontabi.Domain;
using Koontabi.BusinessLogic;
using Koontabi.BusinessLogic.ReportBL;

namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
   
    public partial class ReportMonthSalesRadForm : Telerik.WinControls.UI.RadForm
    {
        private IReportBL _serviceReportBL = null;
       
        public ReportMonthSalesRadForm()
        {
            InitializeComponent();

            this._serviceReportBL = new ReportBL();

        }

        private void ReportMonthSalesRadForm_Load(object sender, EventArgs e)
        {
            var Initmonths = from m in DateTimeFormatInfo.CurrentInfo.MonthNames
                             where m != string.Empty
                             select m.ToUpper();
            var Endmonths = from m in DateTimeFormatInfo.CurrentInfo.MonthNames
                            where m != string.Empty
                            select m.ToUpper();
            
            var result = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1);
            YearComboBox.DataSource =result.ToList();
            
            InitMonthComboBox.DataSource = Initmonths.ToArray();
            EndMonthComboBox.DataSource = Endmonths.ToList();

            DisplayComponents();
            MonthlyRadRadioButton.CheckStateChanged += new EventHandler(RadRadioButton_CheckedChanged);
            OthersRadRadioButton.CheckStateChanged += new EventHandler(RadRadioButton_CheckedChanged);
            DisplayMsgRadLabel.Text = string.Empty;
          
        }

      
        
        private void RadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //RadRadioButton radio = sender as RadRadioButton;
            DisplayComponents();
        }

        private void GetReportRadButton_Click(object sender, EventArgs e)
        {
            if (MonthlyRadRadioButton.IsChecked)
            {

                try
                {
                    var result = this._serviceReportBL.DisplayAllInvoiceByMonth(GetInitMonthToNumber(), GetYear());
                    ReportViewForm.DisplayAllInvoiceByMonthRadForm month = new ReportViewForm.DisplayAllInvoiceByMonthRadForm(result);
                    month.ShowDialog();
                }
                catch (Exception ex)
                {

                    RadMessageBox.Show("Presione details para visualizar el error", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    return;
                }
            }
            else if (OthersRadRadioButton.IsChecked)
            {
                if (GetInitMonthToNumber() == GetEndMonthToNumber()) {
                    DisplayMsgRadLabel.Text = "* Los periodo son iguales, debe seleccionarlo diferentes";
                    return;
                }
                else if (GetInitMonthToNumber() > GetEndMonthToNumber())
                {
                    DisplayMsgRadLabel.Text = "* El periodo inicial debe ser menor que el final";
                    return;
                }
                DisplayMsgRadLabel.Text = string.Empty;
                try
                {
                    var result = this._serviceReportBL.DisplayAllInvoiceByMonth(GetInitMonthToNumber(), GetYear(),GetEndMonthToNumber());
                    ReportViewForm.DisplayAllInvoiceByMonthRadForm month = new ReportViewForm.DisplayAllInvoiceByMonthRadForm(result);
                    month.ShowDialog();
                }
                catch (Exception ex)
                {

                    RadMessageBox.Show("Presione details para visualizar el error", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    return;
                }
            }
        }

        private void DisplayComponents()
        {
            if (MonthlyRadRadioButton.IsChecked)
            {
                InitMonthRadLabel.Text = "Inicial";
                EndMonthRadLabel.Visible = false;
                EndMonthComboBox.Visible = false;
            }
            else if (OthersRadRadioButton.IsChecked)
            {
                InitMonthRadLabel.Text = "Inicial";
                EndMonthRadLabel.Visible = true;
                EndMonthRadLabel.Text = "Final";
                EndMonthComboBox.Visible = true;
            }
        }

        private Int32 GetInitMonthToNumber() {

            return DateTime.ParseExact(InitMonthComboBox.SelectedValue.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;
        }
        private Int32 GetEndMonthToNumber()
        {

            return DateTime.ParseExact(EndMonthComboBox.SelectedValue.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;
        }

        private Int32 GetYear()
        {
            return DateTime.ParseExact(YearComboBox.SelectedValue.ToString(), "yyyy", CultureInfo.CurrentCulture).Year;
        }
    }
}
