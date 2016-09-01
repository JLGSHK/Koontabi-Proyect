using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KoontabiTelerikWinFormsApp
{
    public partial class OldMainRadForm : Telerik.WinControls.UI.RadForm
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
        public OldMainRadForm()
        {
            InitializeComponent();
        }

       
        private void MainRadForm_Load(object sender, EventArgs e)
        {
            SetSizeScreen();
            CustomerRadMenuItem.Click += CustomerRadMenuItem_Click;
            BodegaRadMenuItem.Click += BodegaRadMenuItem_Click;
            CategoriesRadMenuItem.Click += CategoriesRadMenuItem_Click;

            GetDateTime();
            timer1.Start();

        }

        private void CategoriesRadMenuItem_Click(object sender, EventArgs e)
        {
            CategoryRadForm _categoryRadForm = new CategoryRadForm();
            if (!isOpenForm(_categoryRadForm))
            {
                _categoryRadForm.MdiParent = this;
                _categoryRadForm.Show();
            }
        }

        private void BodegaRadMenuItem_Click(object sender, EventArgs e)
        {
            BodegaRadForm _bodegaRadForm = new BodegaRadForm();
            if (!isOpenForm(_bodegaRadForm))
            {
                _bodegaRadForm.MdiParent = this;
                _bodegaRadForm.Show();
            }
        }

        private void GetDateTime()
        {
            HourRadLabelElement.Text = String.Format("{0:F}", DateTime.Now);
        }

        private void CustomerRadMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRadForm _customerRadForm = new CustomerRadForm();
            if (!isOpenForm(_customerRadForm))
            {
                _customerRadForm.MdiParent = this;
                _customerRadForm.Show();
            }
           

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDateTime();
        }
    }
}
