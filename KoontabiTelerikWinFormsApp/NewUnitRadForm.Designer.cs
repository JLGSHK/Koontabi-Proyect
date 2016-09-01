namespace KoontabiTelerikWinFormsApp
{
    partial class NewUnitRadForm
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
            this.MsgErrorLabel = new System.Windows.Forms.Label();
            this.RegisterRadButton = new Telerik.WinControls.UI.RadButton();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.AbbreviationRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.UnitDescriptionRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbreviationRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitDescriptionRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgErrorLabel
            // 
            this.MsgErrorLabel.AutoSize = true;
            this.MsgErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MsgErrorLabel.Location = new System.Drawing.Point(26, 62);
            this.MsgErrorLabel.Name = "MsgErrorLabel";
            this.MsgErrorLabel.Size = new System.Drawing.Size(43, 17);
            this.MsgErrorLabel.TabIndex = 15;
            this.MsgErrorLabel.Text = "label1";
            // 
            // RegisterRadButton
            // 
            this.RegisterRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Save;
            this.RegisterRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterRadButton.Location = new System.Drawing.Point(128, 103);
            this.RegisterRadButton.Name = "RegisterRadButton";
            this.RegisterRadButton.Size = new System.Drawing.Size(74, 58);
            this.RegisterRadButton.TabIndex = 16;
            this.RegisterRadButton.Text = "Registrar";
            this.RegisterRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete1;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(208, 103);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(74, 58);
            this.CancelRadButton.TabIndex = 17;
            this.CancelRadButton.Text = "Cancelar";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AbbreviationRadTextBox
            // 
            this.AbbreviationRadTextBox.Location = new System.Drawing.Point(78, 29);
            this.AbbreviationRadTextBox.Name = "AbbreviationRadTextBox";
            this.AbbreviationRadTextBox.Size = new System.Drawing.Size(206, 20);
            this.AbbreviationRadTextBox.TabIndex = 12;
            this.AbbreviationRadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AbbreviationRadTextBox_KeyPress);
            // 
            // UnitDescriptionRadTextBox
            // 
            this.UnitDescriptionRadTextBox.Location = new System.Drawing.Point(78, 3);
            this.UnitDescriptionRadTextBox.Name = "UnitDescriptionRadTextBox";
            this.UnitDescriptionRadTextBox.Size = new System.Drawing.Size(206, 20);
            this.UnitDescriptionRadTextBox.TabIndex = 10;
            this.UnitDescriptionRadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitDescriptionRadTextBox_KeyPress);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 31);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Abreviatura";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(34, 6);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(42, 18);
            this.radLabel1.TabIndex = 9;
            this.radLabel1.Text = "Unidad";
            // 
            // NewUnitRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 172);
            this.Controls.Add(this.MsgErrorLabel);
            this.Controls.Add(this.RegisterRadButton);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.AbbreviationRadTextBox);
            this.Controls.Add(this.UnitDescriptionRadTextBox);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUnitRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.NewUnitRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbbreviationRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitDescriptionRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MsgErrorLabel;
        private Telerik.WinControls.UI.RadButton RegisterRadButton;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private Telerik.WinControls.UI.RadTextBox AbbreviationRadTextBox;
        private Telerik.WinControls.UI.RadTextBox UnitDescriptionRadTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
