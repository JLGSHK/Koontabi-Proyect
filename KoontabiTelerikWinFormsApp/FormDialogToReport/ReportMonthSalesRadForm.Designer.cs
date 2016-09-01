namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
    partial class ReportMonthSalesRadForm
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
            this.OthersRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.MonthlyRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.EndMonthRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.InitMonthRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.DisplayMsgRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.GetReportRadButton = new Telerik.WinControls.UI.RadButton();
            this.InitMonthComboBox = new System.Windows.Forms.ComboBox();
            this.EndMonthComboBox = new System.Windows.Forms.ComboBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OthersRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonthRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitMonthRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.OthersRadRadioButton);
            this.radGroupBox1.Controls.Add(this.MonthlyRadRadioButton);
            this.radGroupBox1.HeaderText = "Seleccione";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(309, 86);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Seleccione";
            // 
            // OthersRadRadioButton
            // 
            this.OthersRadRadioButton.Location = new System.Drawing.Point(96, 28);
            this.OthersRadRadioButton.Name = "OthersRadRadioButton";
            this.OthersRadRadioButton.Size = new System.Drawing.Size(48, 18);
            this.OthersRadRadioButton.TabIndex = 0;
            this.OthersRadRadioButton.TabStop = false;
            this.OthersRadRadioButton.Text = "Otros";
            // 
            // MonthlyRadRadioButton
            // 
            this.MonthlyRadRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MonthlyRadRadioButton.Location = new System.Drawing.Point(23, 28);
            this.MonthlyRadRadioButton.Name = "MonthlyRadRadioButton";
            this.MonthlyRadRadioButton.Size = new System.Drawing.Size(56, 18);
            this.MonthlyRadRadioButton.TabIndex = 0;
            this.MonthlyRadRadioButton.Text = "Mesual";
            this.MonthlyRadRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // EndMonthRadLabel
            // 
            this.EndMonthRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndMonthRadLabel.Location = new System.Drawing.Point(171, 21);
            this.EndMonthRadLabel.Name = "EndMonthRadLabel";
            this.EndMonthRadLabel.Size = new System.Drawing.Size(31, 25);
            this.EndMonthRadLabel.TabIndex = 5;
            this.EndMonthRadLabel.Text = "&Fin";
            // 
            // InitMonthRadLabel
            // 
            this.InitMonthRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitMonthRadLabel.Location = new System.Drawing.Point(23, 21);
            this.InitMonthRadLabel.Name = "InitMonthRadLabel";
            this.InitMonthRadLabel.Size = new System.Drawing.Size(50, 25);
            this.InitMonthRadLabel.TabIndex = 4;
            this.InitMonthRadLabel.Text = "&Inicio";
            // 
            // DisplayMsgRadLabel
            // 
            this.DisplayMsgRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgRadLabel.ForeColor = System.Drawing.Color.Red;
            this.DisplayMsgRadLabel.Location = new System.Drawing.Point(12, 376);
            this.DisplayMsgRadLabel.Name = "DisplayMsgRadLabel";
            this.DisplayMsgRadLabel.Size = new System.Drawing.Size(60, 25);
            this.DisplayMsgRadLabel.TabIndex = 10;
            this.DisplayMsgRadLabel.Text = "Default";
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm3;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(196, 269);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(125, 84);
            this.CancelRadButton.TabIndex = 9;
            this.CancelRadButton.Text = "Salir";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GetReportRadButton
            // 
            this.GetReportRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.UpdateReport;
            this.GetReportRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.GetReportRadButton.Location = new System.Drawing.Point(12, 269);
            this.GetReportRadButton.Name = "GetReportRadButton";
            this.GetReportRadButton.Size = new System.Drawing.Size(125, 84);
            this.GetReportRadButton.TabIndex = 8;
            this.GetReportRadButton.Text = "Generar";
            this.GetReportRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.GetReportRadButton.Click += new System.EventHandler(this.GetReportRadButton_Click);
            // 
            // InitMonthComboBox
            // 
            this.InitMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitMonthComboBox.FormattingEnabled = true;
            this.InitMonthComboBox.Location = new System.Drawing.Point(23, 52);
            this.InitMonthComboBox.Name = "InitMonthComboBox";
            this.InitMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.InitMonthComboBox.TabIndex = 11;
            // 
            // EndMonthComboBox
            // 
            this.EndMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndMonthComboBox.FormattingEnabled = true;
            this.EndMonthComboBox.Location = new System.Drawing.Point(171, 52);
            this.EndMonthComboBox.Name = "EndMonthComboBox";
            this.EndMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.EndMonthComboBox.TabIndex = 11;
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(23, 34);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(99, 21);
            this.YearComboBox.TabIndex = 13;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.InitMonthRadLabel);
            this.radGroupBox2.Controls.Add(this.EndMonthRadLabel);
            this.radGroupBox2.Controls.Add(this.InitMonthComboBox);
            this.radGroupBox2.Controls.Add(this.EndMonthComboBox);
            this.radGroupBox2.HeaderText = "Periodo";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 83);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(309, 100);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.Text = "Periodo";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.YearComboBox);
            this.radGroupBox3.HeaderText = "Año";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 189);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(309, 74);
            this.radGroupBox3.TabIndex = 15;
            this.radGroupBox3.Text = "Año";
            // 
            // ReportMonthSalesRadForm
            // 
            this.AcceptButton = this.GetReportRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(338, 408);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.DisplayMsgRadLabel);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.GetReportRadButton);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportMonthSalesRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Reporte Por Mes";
            this.Load += new System.EventHandler(this.ReportMonthSalesRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OthersRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMonthRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitMonthRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton OthersRadRadioButton;
        private Telerik.WinControls.UI.RadRadioButton MonthlyRadRadioButton;
        private Telerik.WinControls.UI.RadLabel EndMonthRadLabel;
        private Telerik.WinControls.UI.RadLabel InitMonthRadLabel;
        private Telerik.WinControls.UI.RadLabel DisplayMsgRadLabel;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private Telerik.WinControls.UI.RadButton GetReportRadButton;
        private System.Windows.Forms.ComboBox InitMonthComboBox;
        private System.Windows.Forms.ComboBox EndMonthComboBox;
        private System.Windows.Forms.ComboBox YearComboBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
    }
}
