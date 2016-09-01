using Koontabi.BusinessLogic.InvoiceBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Koontabi.Helpers;
using Koontabi.Domain;
using KoontabiTelerikWinFormsApp.FormDialogToReport;
using System.Linq;
using Koontabi.BusinessLogic.PaidAccountsBL;
using System.Threading;

namespace KoontabiTelerikWinFormsApp
{
    public partial class InvoiceRadForm : Telerik.WinControls.UI.RadForm
    {

        private IInvoiceBL _serviceInvoiceBL = null;
        private IPaidAccountsBL _servicePaidAccountsBL = null;
        protected enum SizeOfScreen
        {
            WIDTH = 900, HEIGHT = 600
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
        public InvoiceRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            this._serviceInvoiceBL = new InvoiceBL();
            this._servicePaidAccountsBL = new PaidAccountsBL();
           
        }
        Bitmap currentStatus = KoontabiTelerikWinFormsApp.Properties.Resources.status;
        private void InvoiceRadForm_Load(object sender, EventArgs e)
        {
            this.InvoiceRadGridView.EnableGrouping = false;
            this.InvoiceRadGridView.TableElement.Text = "Cargando Datos..";
            this.InvoiceRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            //MyTimer.Start();
            
            //Thread loadData = new Thread(new ThreadStart(LoadDataFromDB));
            //loadData.Start();
            InvoiceRadPageViewPage.Image = currentStatus;
            backgroundWorker.RunWorkerAsync();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* FillInvoiceDetailsRadGridView();
             if (this.InvoiceRadGridView.Rows.Count <= 0)
             {
                 this.InvoiceRadGridView.TableElement.Text = "Fáctura(s) no encontrada(s)";
             }

             this.InvoiceRadGridView.TableElement.BackgroundImage = null;
             this.MyTimer.Stop();
             */
           
            //MyTimer.Stop()
        }

        private delegate void MIDELEGATE();
        private MIDELEGATE midele;
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = false;
            midele = new MIDELEGATE(LoadDataFromDB);
            Thread.Sleep(1000);
            this.Invoke(midele);
        }

        private void LoadDataFromDB() {
            
            FillInvoiceDetailsRadGridView();
            if (this.InvoiceRadGridView.Rows.Count <= 0)
            {
                this.InvoiceRadGridView.TableElement.Text = "Fáctura(s) no encontrada(s)";
            }

            this.InvoiceRadGridView.TableElement.BackgroundImage = null;
        }
      
        public void FillInvoiceDetailsRadGridView()
        {
            if (this.InvoiceRadGridView.Rows.Count > 0)
            {
                this.InvoiceRadGridView.DataSource = null;
            }
            this.InvoiceRadGridView.DataSource = _serviceInvoiceBL.VDisplayAllInvoices();




            #region Columns of the GridView

            //GridViewDataColumn column1 = new GridViewDataColumn("InvoiceID");

            try
            {
                GridViewColumnCollection columns = this.InvoiceRadGridView.Columns;


                //InvoiceID Column
                GridViewDataColumn _InvoiceIDColumn = columns["InvoiceID"];
                _InvoiceIDColumn.IsVisible = false;

                //InvoiceNumber Column
                GridViewDataColumn _InvoiceNumberColumn = columns["InvoiceNumber"];
                _InvoiceNumberColumn.FormatString = "{0:0000}";
                _InvoiceNumberColumn.HeaderText = "Código Fáctura";
                _InvoiceNumberColumn.TextAlignment = ContentAlignment.MiddleCenter;
                _InvoiceNumberColumn.Width = 100;

                //InvoiceDate Column
                GridViewDataColumn _InvoiceDateColumn = columns["InvoiceDate"];
                _InvoiceDateColumn.HeaderText = "Fecha";
                _InvoiceDateColumn.FormatString = "{0:MM/dd/yyyy}";
                _InvoiceDateColumn.Width = 100;

                //CompanyName Column
                GridViewDataColumn _CompanyNameColumn = columns["CompanyName"];
                _CompanyNameColumn.HeaderText = "Vendido a:";
                _CompanyNameColumn.Width = 400;

                //TypeOfP Column
                GridViewDataColumn _TypeOfPColumn = columns["TypeOfP"];
                _TypeOfPColumn.HeaderText = "Pago";
                _TypeOfPColumn.Width = 200;

                //Total Column
                GridViewDataColumn _TotalColumn = columns["Total"];
                _TotalColumn.HeaderText = "Total";
                _TotalColumn.FormatString = "{0:C}";
                _TotalColumn.Width = 150;

                //Clear Selection
                ClearSelectionRadGridView();

            }
            catch (Exception) { }

            #endregion

        }
        private void ClearSelectionRadGridView()
        {
            this.InvoiceRadGridView.ClearSelection();
            this.InvoiceRadGridView.Rows[0].IsCurrent = false;
        }

        private void radPageView1_SelectedPageChanging(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            
           switch(e.Page.Name){
               case "InvoiceRadPageViewPage":
                   e.Page.Image = currentStatus;
                   OverdueInvoiceReportRadPageViewPageRadPageViewPage.Image = null;
                   ReportRadPageViewPage.Image = null;
                   break;
               case "OverdueInvoiceReportRadPageViewPageRadPageViewPage":
                    
                    Object[] result = this._servicePaidAccountsBL.GetAllInvoiceOverDue();
                    OverdueInvoiceradGridView.DataSource = result[0];
                    this.gridViewTemplate1.DataSource = result[1];
                    if(this.OverdueInvoiceradGridView.Rows.Count > 0)
                    {
                        this.OverdueInvoiceradGridView.ClearSelection();
                        this.OverdueInvoiceradGridView.Rows[0].IsCurrent = false;
                    }
                    else
                    {
                        this.OverdueInvoiceradGridView.TableElement.Text = "No hay factura(s) vencida(S)"; ;
                    }
                    

                    e.Page.Image = currentStatus;
                   InvoiceRadPageViewPage.Image = null;
                   ReportRadPageViewPage.Image = null;
                   break;
               case "ReportRadPageViewPage":
                   e.Page.Image = currentStatus;
                   InvoiceRadPageViewPage.Image = null;
                   OverdueInvoiceReportRadPageViewPageRadPageViewPage.Image = null;
                   break;
               default:
                   break;

           }
        }

        private void CreateInvoiceRadButton_Click(object sender, EventArgs e)
        {
            NewInvoiceRadForm _createInvoiceRadForm = new NewInvoiceRadForm(this,StateForm.NEW);
            _createInvoiceRadForm.ShowDialog();
        }

        private void DeleteInvoiceRadButton_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("No puede eliminar fáctura, Contactar al administrador de sistema", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
            return;
        }
        Int32? _idInvoiceToEdit = null;
        
        private void EditInvoiceRadButton_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Proceso en mantenimiento...", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK,RadMessageIcon.Info);
            /*var _currentInvoiceToEdit = this._serviceInvoiceBL.Find(_idInvoiceToEdit.Value);
            NewInvoiceRadForm _createInvoiceRadForm = new NewInvoiceRadForm(this,_currentInvoiceToEdit,StateForm.EDIT);
            _createInvoiceRadForm.ShowDialog();
            */
        }

        private void InvoiceRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            _idInvoiceToEdit = Convert.ToInt32(e.Row.Cells["InvoiceID"].Value);
            return;
        }

        private void PrintRadButton_Click(object sender, EventArgs e)
        {

            if(this.InvoiceRadGridView.SelectedRows.Count == 0)
            {
              
                RadMessageBox.Show(null, "Debe seleccionar una factura para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            else
            {
                ;
                _idInvoiceToEdit = Convert.ToInt32(InvoiceRadGridView.CurrentRow.Cells["InvoiceID"].Value);
               
                ReportViewForm.InvoiceReportView invoiceReportForm = new ReportViewForm.InvoiceReportView(this._serviceInvoiceBL.FindInvoiceToReport(iv=>iv.InvoiceID == _idInvoiceToEdit.Value));
                invoiceReportForm.ShowDialog();
            }
            
            /*
            ;
    */
        }

        private void SeeInvoiceRadButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.InvoiceRadGridView.SelectedRows.Count == 0)
            {
                RadMessageBox.Show(null, "Debe seleccionar una factura para realizar esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            else
            {
                _idInvoiceToEdit = Convert.ToInt32(InvoiceRadGridView.CurrentRow.Cells["InvoiceID"].Value);
                var _currentInvoiceToEdit = this._serviceInvoiceBL.Find(_idInvoiceToEdit.Value);
                if (_currentInvoiceToEdit != null)
                {
                    NewInvoiceRadForm _createInvoiceRadForm = new NewInvoiceRadForm(this, _currentInvoiceToEdit, StateForm.SEE_MORE);
                    _createInvoiceRadForm.ShowDialog();
                }
            }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show("Ocurrió un error, Contactar al Administrador de Soporte", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info, ex.Message.ToString());
                return;
            }
            
            
        }

        private void GetReportByDateRadButton_Click(object sender, EventArgs e)
        {
            ReportSalesDateRadForm _rSDRF = new ReportSalesDateRadForm();
           
            _rSDRF.ShowDialog();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            ReportMonthSalesRadForm _rMSRF = new ReportMonthSalesRadForm();
            _rMSRF.ShowDialog();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            GetInvoiceByZoneRadForm _zone = new GetInvoiceByZoneRadForm();
            _zone.ShowDialog();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            DisplayAllSalesByCustomerRadForm _customer = new DisplayAllSalesByCustomerRadForm();
            _customer.ShowDialog();
        }

        private void InvoiceRadForm_Shown(object sender, EventArgs e)
        {

            
        }
    }
}
