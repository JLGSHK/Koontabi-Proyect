namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
    partial class GetInvoiceByZoneRadForm
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ZoneComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayMsgRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.GetReportRadButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ZoneComboBox);
            this.radGroupBox1.HeaderText = "Seleccione Zona";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(265, 68);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Seleccione Zona";
            // 
            // ZoneComboBox
            // 
            this.ZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZoneComboBox.FormattingEnabled = true;
            this.ZoneComboBox.Location = new System.Drawing.Point(18, 30);
            this.ZoneComboBox.Name = "ZoneComboBox";
            this.ZoneComboBox.Size = new System.Drawing.Size(225, 21);
            this.ZoneComboBox.TabIndex = 0;
            // 
            // DisplayMsgRadLabel
            // 
            this.DisplayMsgRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgRadLabel.ForeColor = System.Drawing.Color.Red;
            this.DisplayMsgRadLabel.Location = new System.Drawing.Point(12, 211);
            this.DisplayMsgRadLabel.Name = "DisplayMsgRadLabel";
            this.DisplayMsgRadLabel.Size = new System.Drawing.Size(60, 25);
            this.DisplayMsgRadLabel.TabIndex = 13;
            this.DisplayMsgRadLabel.Text = "Default";
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm3;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(152, 108);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(125, 84);
            this.CancelRadButton.TabIndex = 12;
            this.CancelRadButton.Text = "Salir";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GetReportRadButton
            // 
            this.GetReportRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.UpdateReport;
            this.GetReportRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.GetReportRadButton.Location = new System.Drawing.Point(12, 108);
            this.GetReportRadButton.Name = "GetReportRadButton";
            this.GetReportRadButton.Size = new System.Drawing.Size(125, 84);
            this.GetReportRadButton.TabIndex = 11;
            this.GetReportRadButton.Text = "Generar";
            this.GetReportRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.GetReportRadButton.Click += new System.EventHandler(this.GetReportRadButton_Click);
            // 
            // GetInvoiceByZoneRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 245);
            this.Controls.Add(this.DisplayMsgRadLabel);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.GetReportRadButton);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetInvoiceByZoneRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de reporte por zona";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.GetInvoiceByZoneRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox ZoneComboBox;
        private Telerik.WinControls.UI.RadLabel DisplayMsgRadLabel;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private Telerik.WinControls.UI.RadButton GetReportRadButton;
    }
}
