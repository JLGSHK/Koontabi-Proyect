using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace KoontabiTelerikWinFormsApp.Splash
{
    public partial class KoontabiSplashRadForm : Telerik.WinControls.UI.RadForm
    {
        public KoontabiSplashRadForm()
        {

            InitializeComponent();
            
           
            MyTimer.Start();
            
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // LoadingFormRadProgressBar.Value1 += 1;
            //518, 22
            if(radPanel2.Width < 513)
            {
                Random r = new Random();
                var valor = r.Next(2, 4);
                //DisplayRadLabel.Text = valor.ToString();
                radPanel2.Width += valor;
               
            }
            else
            {
                MyTimer.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }



        }

        private void KoontabiSplashRadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            

            
           
        }
    }
}
