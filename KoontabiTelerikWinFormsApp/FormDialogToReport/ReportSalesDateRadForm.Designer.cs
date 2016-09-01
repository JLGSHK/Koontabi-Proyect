namespace KoontabiTelerikWinFormsApp
{
    partial class ReportSalesDateRadForm
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
            this.InitRadDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.EndRadDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.DisplayMsgRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.GetReportRadButton = new Telerik.WinControls.UI.RadButton();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.InitRadDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndRadDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // InitRadDateTimePicker
            // 
            this.InitRadDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.InitRadDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitRadDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InitRadDateTimePicker.Location = new System.Drawing.Point(12, 51);
            this.InitRadDateTimePicker.Name = "InitRadDateTimePicker";
            this.InitRadDateTimePicker.Size = new System.Drawing.Size(120, 27);
            this.InitRadDateTimePicker.TabIndex = 0;
            this.InitRadDateTimePicker.TabStop = false;
            this.InitRadDateTimePicker.Text = "19/11/2015";
            this.InitRadDateTimePicker.Value = new System.DateTime(2015, 11, 19, 11, 43, 47, 228);
            // 
            // EndRadDateTimePicker
            // 
            this.EndRadDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.EndRadDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndRadDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndRadDateTimePicker.Location = new System.Drawing.Point(183, 51);
            this.EndRadDateTimePicker.Name = "EndRadDateTimePicker";
            this.EndRadDateTimePicker.Size = new System.Drawing.Size(120, 27);
            this.EndRadDateTimePicker.TabIndex = 1;
            this.EndRadDateTimePicker.TabStop = false;
            this.EndRadDateTimePicker.Text = "19/11/2015";
            this.EndRadDateTimePicker.Value = new System.DateTime(2015, 11, 19, 11, 43, 54, 773);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(99, 25);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Fecha Inicio";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(183, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 25);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Fecha Fin";
            // 
            // DisplayMsgRadLabel
            // 
            this.DisplayMsgRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgRadLabel.Location = new System.Drawing.Point(12, 219);
            this.DisplayMsgRadLabel.Name = "DisplayMsgRadLabel";
            this.DisplayMsgRadLabel.Size = new System.Drawing.Size(60, 25);
            this.DisplayMsgRadLabel.TabIndex = 6;
            this.DisplayMsgRadLabel.Text = "Default";
            // 
            // GetReportRadButton
            // 
            this.GetReportRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.UpdateReport;
            this.GetReportRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.GetReportRadButton.Location = new System.Drawing.Point(12, 117);
            this.GetReportRadButton.Name = "GetReportRadButton";
            this.GetReportRadButton.Size = new System.Drawing.Size(125, 84);
            this.GetReportRadButton.TabIndex = 4;
            this.GetReportRadButton.Text = "Generar";
            this.GetReportRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.GetReportRadButton.Click += new System.EventHandler(this.GetReportRadButton_Click);
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm3;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(183, 117);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(125, 84);
            this.CancelRadButton.TabIndex = 5;
            this.CancelRadButton.Text = "Salir";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ReportSalesDateRadForm
            // 
            this.AcceptButton = this.GetReportRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(333, 246);
            this.Controls.Add(this.DisplayMsgRadLabel);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.GetReportRadButton);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.EndRadDateTimePicker);
            this.Controls.Add(this.InitRadDateTimePicker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportSalesDateRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Reporte Por Fecha";
            ((System.ComponentModel.ISupportInitialize)(this.InitRadDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndRadDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker InitRadDateTimePicker;
        private Telerik.WinControls.UI.RadDateTimePicker EndRadDateTimePicker;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton GetReportRadButton;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private Telerik.WinControls.UI.RadLabel DisplayMsgRadLabel;
    }
}
