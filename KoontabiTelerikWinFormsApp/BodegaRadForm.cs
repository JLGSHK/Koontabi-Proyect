using Koontabi.BusinessLogic.BodegaBL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace KoontabiTelerikWinFormsApp
{
    public partial class BodegaRadForm : Telerik.WinControls.UI.RadForm
    {
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
        private IBodegaBL _serviceBodegaBL;
        public BodegaRadForm()
        {
            InitializeComponent();
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);

            _serviceBodegaBL = new BodegaBL();
        }

        private void BodegaRadForm_Load(object sender, EventArgs e)
        {
            this.BodegaRadGridView.EnableGrouping = false;
            this.BodegaRadGridView.TableElement.Text = "Cargando Datos..";
            this.BodegaRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
            


        }
        private void ClearSelectionRadGridView()
        {
            this.BodegaRadGridView.ClearSelection();
            if (this.BodegaRadGridView.Rows.Count > 0)
            {
                this.BodegaRadGridView.Rows[0].IsCurrent = false;
            }
            
        }
        public void FillBodegaRadGridView()
        {
            if (this.BodegaRadGridView.Rows.Count > 0)
            {
                this.BodegaRadGridView.DataSource = null;
            }
            this.BodegaRadGridView.DataSource = _serviceBodegaBL.GetAllBodega();
            ClearSelectionRadGridView();

            GridViewColumnCollection columns = this.BodegaRadGridView.Columns;

            //BodegaID Column
            GridViewDataColumn _bodegaIDColumn = columns["BodegaID"];
            _bodegaIDColumn.IsVisible = false;

            //BodegaName Column
            GridViewDataColumn _bodegaNameColumn = columns["BodegaName"];
            _bodegaNameColumn.HeaderText = "Empresa";
            _bodegaNameColumn.Width = 200;

            //BodegaAddress Column
            GridViewDataColumn _bodegaAddressColumn = columns["BodegaAddress"];
            _bodegaAddressColumn.HeaderText = "Dirección";
            _bodegaAddressColumn.Width = 300;

            //Phone Column
            GridViewDataColumn _phoneColumn = columns["Phone"];
            _phoneColumn.HeaderText = "Teléfono";
            _phoneColumn.Width = 100;

            //IndustrialRegistration Column
            GridViewDataColumn _industrialRegistrationColumn = columns["IndustrialRegistration"];
            _industrialRegistrationColumn.HeaderText = "Registro Industrial";
            _industrialRegistrationColumn.Width = 100;

            //Email Column
            GridViewDataColumn _emailColumn = columns["Email"];
            _emailColumn.HeaderText = "Correo Electrónico";
            _emailColumn.Width = 150;

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

            FillBodegaRadGridView();
            this.BodegaRadGridView.TableElement.Text = string.Empty;
            this.BodegaRadGridView.TableElement.BackgroundImage = null;
            this.MyTimer.Stop();
        }
    }
}
