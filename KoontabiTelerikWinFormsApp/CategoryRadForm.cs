using Koontabi.BusinessLogic.CategoryBL;
using Koontabi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace KoontabiTelerikWinFormsApp
{
    public partial class CategoryRadForm : Telerik.WinControls.UI.RadForm
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

        private ICategoryBL _serviceCategoryBL;
        public CategoryRadForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.SetSizeScreen(SizeOfScreen.WIDTH, SizeOfScreen.HEIGHT);
            _serviceCategoryBL = new CategoryBL();
        }
        public GridViewRowInfo _currentRowSeleted = null;
        private void CategoryRadForm_Load(object sender, EventArgs e)
        {
            
            this.CategoryRadGridView.EnableGrouping = false;
            this.CategoryRadGridView.TableElement.Text = "Cargando Datos..";
            this.CategoryRadGridView.TableElement.BackgroundImage = KoontabiTelerikWinFormsApp.Properties.Resources.loader;
            MyTimer.Start();
        }
        private void ClearSelectionRadGridView()
        {
            this.CategoryRadGridView.ClearSelection();
            
            if (this.CategoryRadGridView.Rows.Count > 0)
            {
                for(var item =0; item < this.CategoryRadGridView.Rows.Count;item++)
                    this.CategoryRadGridView.Rows[item].IsCurrent = false;
            }
        }

        public void FillCategoryRadGridView()
        {
            if (this.CategoryRadGridView.Rows.Count > 0)
            {
                this.CategoryRadGridView.DataSource = null;
            }
            this.CategoryRadGridView.DataSource = _serviceCategoryBL.GetAllCategories();
            ClearSelectionRadGridView();

            GridViewColumnCollection columns = this.CategoryRadGridView.Columns;

            //CategoryID Column
            GridViewDataColumn _categoryIDColumn = columns["CategoryID"];
            _categoryIDColumn.IsVisible = false;

            //CategoryCode Column
            GridViewDataColumn _categoryCodeColumn = columns["CategoryCode"];
            _categoryCodeColumn.HeaderText = "Código";
            _categoryCodeColumn.Width = 100;

            //CategoryName Column
            GridViewDataColumn _categoryNameColumn = columns["CategoryName"];
            _categoryNameColumn.HeaderText = "Categoría";
            _categoryNameColumn.Width = 100;

            //Description Column
            GridViewDataColumn _descriptionColumn = columns["Description"];
            _descriptionColumn.HeaderText = "Descripción";
            _descriptionColumn.Width = 300;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            FillCategoryRadGridView();
            this.CategoryRadGridView.TableElement.Text = string.Empty;
            this.CategoryRadGridView.TableElement.BackgroundImage = null;
            this.MyTimer.Stop();
        }

        private void NewCategoryRadButton_Click(object sender, EventArgs e)
        {
            NewCategoryRadForm _form = new NewCategoryRadForm(this,StateForm.NEW);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog();
            }

        }

        private void EditCategoryRadButton_Click(object sender, EventArgs e)
        {
            if(this._currentRowSeleted == null)
            {
                RadMessageBox.Show("Debe seleccionar una categoría para esta operación");
                return;
                
            }

            NewCategoryRadForm _form = new NewCategoryRadForm(this,StateForm.EDIT);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog();
            }

        }

        private void LookCategoryRadButton_Click(object sender, EventArgs e)
        {
            if (this._currentRowSeleted == null)
            {
                RadMessageBox.Show("Debe seleccionar una categoría para esta operación");
                return;

            }
            NewCategoryRadForm _form = new NewCategoryRadForm(this,StateForm.SEE_MORE);
            if (!isOpenForm(_form))
            {
                _form.ShowDialog();
            }

        }

        private void DeleteCategoryRadButton_Click(object sender, EventArgs e)
        {
            if (this._currentRowSeleted == null)
            {
                RadMessageBox.Show("Debe seleccionar una categoría para esta operación", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;

            }
            
            DialogResult result = RadMessageBox.Show("Usted está seguro de eliminar este registro ?", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    var _categoryIDToDelete = Convert.ToInt32(this._currentRowSeleted.Cells["CategoryID"].Value);
                    this._serviceCategoryBL.Delete(_categoryIDToDelete);
                    RadMessageBox.Show("Categoría eliminada satisfactoriamente", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Info);
                    FillCategoryRadGridView();
                    return;
                }
                catch (Exception ex)
                {
                    
                    RadMessageBox.Show("No se puede eliminar esta categoría ", "JOSIAS INDUSTRIAL SRL", MessageBoxButtons.OK, RadMessageIcon.Error,ex.Message);
                    return ;
                }
            }

        }

        private void CategoryRadGridView_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            this._currentRowSeleted = this.CategoryRadGridView.CurrentRow;
        }
    }
}
