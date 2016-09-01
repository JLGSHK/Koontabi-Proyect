namespace KoontabiTelerikWinFormsApp.Login
{
    partial class LoginRadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.BtnPictureBoxInitSession = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPictureBoxInitSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTextBox
            // 
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(240, 116);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(295, 32);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTextBox_KeyPress);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.PasswordTextBox.Location = new System.Drawing.Point(240, 170);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(295, 32);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // BtnPictureBoxInitSession
            // 
            this.BtnPictureBoxInitSession.BackColor = System.Drawing.Color.Transparent;
            this.BtnPictureBoxInitSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPictureBoxInitSession.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.button;
            this.BtnPictureBoxInitSession.Location = new System.Drawing.Point(392, 266);
            this.BtnPictureBoxInitSession.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPictureBoxInitSession.Name = "BtnPictureBoxInitSession";
            this.BtnPictureBoxInitSession.Size = new System.Drawing.Size(173, 49);
            this.BtnPictureBoxInitSession.TabIndex = 3;
            this.BtnPictureBoxInitSession.TabStop = false;
            this.BtnPictureBoxInitSession.Click += new System.EventHandler(this.BtnPictureBoxInitSession_Click);
            this.BtnPictureBoxInitSession.MouseLeave += new System.EventHandler(this.BtnPictureBoxInitSession_MouseLeave);
            this.BtnPictureBoxInitSession.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KoontabiTelerikWinFormsApp.Properties.Resources.loginOficial1;
            this.ClientSize = new System.Drawing.Size(600, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPictureBoxInitSession);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginRadForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginRadForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPictureBoxInitSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox BtnPictureBoxInitSession;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
