using Koontabi.BusinessLogic.EmployeeBL;
using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace KoontabiTelerikWinFormsApp.Login
{
    public partial class LoginRadForm : Telerik.WinControls.UI.RadForm
    {
        private IEmployeeBL _serviceEmployeeBL = null;
        public LoginRadForm()
        {
            InitializeComponent();
            this._serviceEmployeeBL = new EmployeeBL();
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            BtnPictureBoxInitSession.Image = KoontabiTelerikWinFormsApp.Properties.Resources.buttonHover;
        }

        private void BtnPictureBoxInitSession_MouseLeave(object sender, EventArgs e)
        {
            BtnPictureBoxInitSession.Image = KoontabiTelerikWinFormsApp.Properties.Resources.button;
        }
        Employee CurrentEmployee = null;
        private void BtnPictureBoxInitSession_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if(UserTextBox.Text == string.Empty)
            {
                isOk = false;
            }
            if(PasswordTextBox.Text == string.Empty)
            {
                isOk = false;
            }

            if (isOk)
            {
                CurrentEmployee = this._serviceEmployeeBL.ValidateUserAndPass(UserTextBox.Text, PasswordTextBox.Text);
               if(CurrentEmployee != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Empleado no existe");
                }
            }
            
        }
        public Employee GetActiveEmployee()
        {
            return this.CurrentEmployee;
        }
        private void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                PasswordTextBox.Focus();
            }
            if (Convert.ToChar(Keys.Back) == e.KeyChar)
            {
                e.Handled = false;
            }
            if (Convert.ToChar(Keys.Space) == e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Convert.ToChar(Keys.Back) == e.KeyChar)
            {
                e.Handled = false;
            }
            if (Convert.ToChar(Keys.Space) == e.KeyChar)
            {
                e.Handled = true;
            }

            if (Convert.ToChar(Keys.Enter) == e.KeyChar)
            {
                BtnPictureBoxInitSession.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult rs = RadMessageBox.Show("¿ Usted está seguro de cerrar el formulario ?","JOSIAS INDUSTRIAL SRL",MessageBoxButtons.OKCancel,RadMessageIcon.Question);
            if(rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void LoginRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CurrentEmployee != null)
            {
                Program.currentEmployee = CurrentEmployee;
                this.DialogResult = DialogResult.OK;
            }
            e.Cancel = false;
        }

        private void LoginRadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
