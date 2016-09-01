using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Domain;
using Koontabi.BusinessLogic.UnitBL;
using Telerik.WinControls.UI;
using Koontabi.Helpers;

namespace KoontabiTelerikWinFormsApp
{
    public partial class UnitRadForm : Telerik.WinControls.UI.RadForm
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

        private IUnitBL _serviceUnitBL = null;
        public GridViewRowInfo _currentRowSelected = null;
        public UnitRadForm()
        {
            InitializeComponent();
            this._serviceUnitBL = new UnitBL();
            
        }

        private void UnitRadForm_Load(object sender, EventArgs e)
        {
            this.UnitsRadGridView.EnableGrouping = false;
            this.UnitsRadGridView.TableElement.Text = "Cargando Datos..";
            this.UnitsRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
        }

        private void ClearSelectionRadGridView()
        {
            this.UnitsRadGridView.ClearSelection();

            if (this.UnitsRadGridView.Rows.Count > 0)
            {
                for (var item = 0; item < this.UnitsRadGridView.Rows.Count; item++)
                    this.UnitsRadGridView.Rows[item].IsCurrent = false;
            }
        }
        public void FillUnitRadGridView()
        {
            if (this.UnitsRadGridView.Rows.Count > 0)
            {
                this.UnitsRadGridView.DataSource = null;
            }
            this.UnitsRadGridView.DataSource = this._serviceUnitBL.GetAll(); ;
            ClearSelectionRadGridView();
            this._currentRowSelected = null;

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            FillUnitRadGridView();
            this.UnitsRadGridView.TableElement.Text = string.Empty;
            this.UnitsRadGridView.TableElement.BackgroundImage = null;
            this.MyTimer.Stop();
        }
        
        private void UnitsRadGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            this._currentRowSelected = this.UnitsRadGridView.CurrentRow;

        }

        private void NewUnitRadButton_Click(object sender, EventArgs e)
        {
            NewUnitRadForm _form = new NewUnitRadForm(this, StateForm.NEW);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog(this);
            }
            
        }

        private void EditUnitRadButton_Click(object sender, EventArgs e)
        {
            if(this._currentRowSelected == null)
            {
                RadMessageBox.Show(this, "Debe seleccionar un elemento para realizar esta operación", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            NewUnitRadForm _form = new NewUnitRadForm(this, StateForm.EDIT);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog(this);
            }
        }

        private void LookUnitRadButton_Click(object sender, EventArgs e)
        {
            if (this._currentRowSelected == null)
            {
                RadMessageBox.Show(this, "Debe seleccionar un elemento para realizar esta operación", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            NewUnitRadForm _form = new NewUnitRadForm(this, StateForm.SEE_MORE);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog(this);
            }
        }

        private void DeleteUnitRadButton_Click(object sender, EventArgs e)
        {
            if (this._currentRowSelected == null)
            {
                RadMessageBox.Show(this, "Debe seleccionar un elemento para realizar esta operación", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            DialogResult result = RadMessageBox.Show("Usted está seguro de eliminar este registro ?", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var _unitIDToDelete = Convert.ToInt32(this._currentRowSelected.Cells["UnitID"].Value);
                    this._serviceUnitBL.Delete(_unitIDToDelete);
                    RadMessageBox.Show("Unidad de medida eliminada satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    FillUnitRadGridView();
                    return;
                }
                catch (Exception ex)
                {

                    RadMessageBox.Show("No se puede eliminar esta Unidad de medida ", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message);
                    return;
                }
            }
        }
    }
}
