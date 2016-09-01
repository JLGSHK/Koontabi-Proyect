using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Koontabi.Helpers;
using Telerik.WinControls.UI;
using Koontabi.Domain;
using Koontabi.BusinessLogic.UnitBL;
namespace KoontabiTelerikWinFormsApp
{
    public partial class NewUnitRadForm : Telerik.WinControls.UI.RadForm
    {
        private RadForm parentForm = null;
        private StateForm stateForm = StateForm.NONE;
        private Unit _currentUnit = null;
        private IUnitBL _serviceUnitBL = null;
        public NewUnitRadForm(RadForm parent, StateForm state)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.stateForm = state;
            this._serviceUnitBL = new UnitBL();
        }

        private void NewUnitRadForm_Load(object sender, EventArgs e)
        {
            MsgErrorLabel.Text = String.Empty;
            ProcessState(this.stateForm);
            this.RegisterRadButton.Click += RegisterRadButton_Click;

        }

        private void RegisterRadButton_Click(object sender, EventArgs e)
        {
            RadButton currentButton = sender as RadButton;
            UnitRadForm unitForm = this.parentForm as UnitRadForm;
            switch (currentButton.Text)
            {
                case "Registrar":
                    #region Register Category
                    if (ValidateForm())
                    {
                        try
                        {
                            Unit _u = new Unit()
                            {
                                UnitDescription = UnitDescriptionRadTextBox.Text.ToUpper(),
                                Abbreviation = AbbreviationRadTextBox.Text.ToUpper()
                            };
                            
                            this._serviceUnitBL.Add(_u);
                            RadMessageBox.Show(this,"Unidad de medida creada satisfactoriamente.", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                            unitForm.FillUnitRadGridView();
                            this.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Message").AppendLine(ex.Message)
                                   .AppendLine("StackTrace").AppendLine(ex.StackTrace.ToString());


                            RadMessageBox.Show("Error ocurrido, presione el botón para desplegarlo.", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Error, sb.ToString());
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
                            _currentUnit.UnitDescription = UnitDescriptionRadTextBox.Text.ToUpper();
                            _currentUnit.Abbreviation = AbbreviationRadTextBox.Text.ToUpper();

                            this._serviceUnitBL.Update(_currentUnit);
                            RadMessageBox.Show(this,"Unidad de medida actualizada satisfactoriamente.", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Info);
                            unitForm.FillUnitRadGridView();
                            this.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Message").AppendLine(ex.Message)
                                   .AppendLine("StackTrace").AppendLine(ex.StackTrace.ToString());
                            RadMessageBox.Show("Error ocurrido, presione el botón para desplegarlo.", "JOSIAS INDUSTRIAL", MessageBoxButtons.OK, RadMessageIcon.Error, sb.ToString());
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

        private void ProcessState(StateForm state)
        {
            switch (state)
            {
                case StateForm.NEW:
                    SetUpFormName("Nueva Unidad de Medida", "Registrar");

                    break;
                case StateForm.EDIT:
                    GetAndLoadUnitFromDB();
                    this.RegisterRadButton.Image = KoontabiTelerikWinFormsApp.Properties.Resources.Update;
                    SetUpFormName("Editar Unidad de Medida", "Actualizar");
                   

                    break;
                case StateForm.SEE_MORE:
                    GetAndLoadUnitFromDB();
                    UnitDescriptionRadTextBox.Enabled = false;
                    AbbreviationRadTextBox.Enabled = false;
                    SetUpFormName("Ver Unidad de Medida", "Aceptar", "Cerrar");
                    break;
            }
        }

        private void GetAndLoadUnitFromDB()
        {
            UnitRadForm _parent = this.parentForm as UnitRadForm;
            var idResult = (Int32)_parent._currentRowSelected.Cells["UnitID"].Value;
            _currentUnit = this._serviceUnitBL.Find(idResult);
            if (_currentUnit != null)
            {
                UnitDescriptionRadTextBox.Text= _currentUnit.UnitDescription;
                AbbreviationRadTextBox.Text = _currentUnit.Abbreviation;
              
               
            }
        }
        private void SetUpFormName(String formName, String fistButton, String secondButton = "Cancelar")
        {
            this.Text = formName;
            this.RegisterRadButton.Text = fistButton;
            this.CancelRadButton.Text = secondButton;
        }
        private void DisplayError(String error)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nota:").
                Append(error);
            MsgErrorLabel.Text = sb.ToString();
        }
        private bool ValidateForm()
        {
            if (UnitDescriptionRadTextBox.Text == string.Empty)
            {
                DisplayError("Debe ingresar una unidad.");
                UnitDescriptionRadTextBox.Focus();
                return false;
            }
            MsgErrorLabel.Text = String.Empty;

            if (AbbreviationRadTextBox.Text == string.Empty)
            {
                DisplayError("Debe ingresar una abreviatura.");
                AbbreviationRadTextBox.Focus();
                return false;
            }
            MsgErrorLabel.Text = String.Empty;
            return true;
        }
        private void UnitDescriptionRadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (UnitDescriptionRadTextBox.Text.Length <= 99 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void AbbreviationRadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
                return;
            }

            if (AbbreviationRadTextBox.Text.Length <= 5 || e.KeyChar == (char)Keys.Back)
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
