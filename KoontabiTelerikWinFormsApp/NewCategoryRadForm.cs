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
using System.Linq;
using Koontabi.BusinessLogic.CategoryBL;
using Koontabi.Domain;

namespace KoontabiTelerikWinFormsApp
{
    public partial class NewCategoryRadForm : Telerik.WinControls.UI.RadForm
    {
        private StateForm state;
        private ICategoryBL _serviceCategoryBL = null;
        private RadForm _currentParentForm = null;
        private Category _currentCategorySelected = null;
        public NewCategoryRadForm(RadForm form ,StateForm state)
        {
            InitializeComponent();
            this.state = state;
            this._serviceCategoryBL = new CategoryBL();
            this._currentParentForm = form;
        }




        private void ProcessState(StateForm state)
        {
            switch (state)
            {
                case StateForm.NEW:
                    SetUpFormName("Nueva Categoria", "Registrar");
                    
                    break;
                case StateForm.EDIT:
                    this.RegisterRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.Update;
                    SetUpFormName("Editar Categoria", "Actualizar");
                    GetAndLoadCategoryFromDB();

                    break;
                case StateForm.SEE_MORE:
                    GetAndLoadCategoryFromDB();
                    CodeCategoryRadTextBox.Enabled = false;
                    CategoryRadTextBox.Enabled = false;
                    DescriptionRadRichTextEditor.Enabled = false;
                    SetUpFormName("Ver Categoria", "Aceptar", "Cerrar");
                    break;
            }
        }
        private void GetAndLoadCategoryFromDB()
        {
            CategoryRadForm cat = this._currentParentForm as CategoryRadForm;
            var result = (Int32)cat._currentRowSeleted.Cells["CategoryID"].Value;
            _currentCategorySelected = this._serviceCategoryBL.Find(result);
            if (_currentCategorySelected != null)
            {
                CodeCategoryRadTextBox.Text = _currentCategorySelected.CategoryCode;
                CategoryRadTextBox.Text = _currentCategorySelected.CategoryName;
                DescriptionRadRichTextEditor.Text = _currentCategorySelected.Description;

            }
        }
        private void RegisterRadButton_Click(object sender, EventArgs e)
        {
            RadButton currentButton = sender as RadButton;
            CategoryRadForm cat = this._currentParentForm as CategoryRadForm;
            switch (currentButton.Text)
            {
                case "Registrar":
                    #region Register Category
                    if (ValidateForm())
                    {
                        try
                        {
                            Category _c = new Category()
                            {
                                CategoryCode = CodeCategoryRadTextBox.Text.ToUpper(),
                                CategoryName = CategoryRadTextBox.Text.ToUpper()
                            };
                            if (DescriptionRadRichTextEditor.Text != String.Empty)
                            {
                                _c.Description = DescriptionRadRichTextEditor.Text.ToUpper();
                            }
                            this._serviceCategoryBL.Add(_c);
                            RadMessageBox.Show("Categoría creada satisfactoriamente", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                            cat.FillCategoryRadGridView();
                            this.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Message").AppendLine(ex.Message)
                                   .AppendLine("StackTrace").AppendLine(ex.StackTrace.ToString());


                            RadMessageBox.Show("Error ocurrido, presione el botón para desplegarlo", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Error,sb.ToString());
                            return;
                        }
                    }
                    #endregion
                    break;
                case "Actualizar":
                    #region Update Category
                    if (ValidateForm())
                    {
                        try
                        {
                            _currentCategorySelected.CategoryCode = CodeCategoryRadTextBox.Text.ToUpper();
                            _currentCategorySelected.CategoryName = CategoryRadTextBox.Text.ToUpper();
                            _currentCategorySelected.Description = DescriptionRadRichTextEditor.Text.ToUpper();
                         
                            this._serviceCategoryBL.Update(_currentCategorySelected);
                            RadMessageBox.Show("Categoría actualizada satisfactoriamente", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                            cat.FillCategoryRadGridView();
                            this.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Message").AppendLine(ex.Message)
                                   .AppendLine("StackTrace").AppendLine(ex.StackTrace.ToString());
                            RadMessageBox.Show("Error ocurrido, presione el botón para desplegarlo", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Error, sb.ToString());
                            return;
                        }

                    }
                    #endregion
                    break;
                case "Aceptar":
                    this.Close();
                    break;
            }
        }





        private bool ValidateForm()
        {
            if(CodeCategoryRadTextBox.Text == string.Empty)
            {
                DisplayError("Debe ingresar un codigo.");
                CodeCategoryRadTextBox.Focus();
                return false;
            }
            MsgErrorLabel.Text = String.Empty;

            if(state == StateForm.NEW)
            {
                if (this._serviceCategoryBL.ExitCategoryCode(CodeCategoryRadTextBox.Text))
                {
                    DisplayError("Código ingresado ya existe.");
                    CodeCategoryRadTextBox.Focus();
                    return false;
                }
            }
            
            MsgErrorLabel.Text = string.Empty;

            if (CategoryRadTextBox.Text == string.Empty)
            {
                DisplayError("Debe ingresar una categoría.");
                CategoryRadTextBox.Focus();
                return false;
            }
            MsgErrorLabel.Text = String.Empty;
            return true;
        }

        private void DisplayError(String error)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nota:").
                Append(error);
            MsgErrorLabel.Text = sb.ToString();
        }
        private void SetUpFormName(String formName,String fistButton,String secondButton="Cancelar")
        {
            this.Text = formName;
            this.RegisterRadButton.Text = fistButton;
            this.CancelRadButton.Text = secondButton;
        }

        private void NewCategoryRadForm_Load(object sender, EventArgs e)
        {
            MsgErrorLabel.Text = String.Empty;
            ProcessState(this.state);
            CodeCategoryRadTextBox.Focus();
            this.RegisterRadButton.Click += RegisterRadButton_Click;

        }

        private void CodeCategoryRadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
                return;
            }

            if (CodeCategoryRadTextBox.Text.Length <= 14 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                return;
            }

            
        }

        private void CategoryRadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CodeCategoryRadTextBox.Text.Length <= 29 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                return;
            }
        }
               
        private void NewCategoryRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void DescriptionRadRichTextEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DescriptionRadRichTextEditor.Text.Length <= 90 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                return;
            }
        }
    }
}
