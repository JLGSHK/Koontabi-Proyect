namespace KoontabiTelerikWinFormsApp.FormDialogToReport
{
    partial class DisplayAllSalesByCustomerRadForm
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
            this.FirstRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.AllCustomersRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.IndividualCustomerRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.SecondRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.AllSalesRdCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.YearSalesCmboBox = new System.Windows.Forms.ComboBox();
            this.ThridRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.DisplayMsgRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.GetReportRadButton = new Telerik.WinControls.UI.RadButton();
            this.DocumentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FirstRadGroupBox)).BeginInit();
            this.FirstRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomersRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualCustomerRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondRadGroupBox)).BeginInit();
            this.SecondRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSalesRdCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThridRadGroupBox)).BeginInit();
            this.ThridRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstRadGroupBox
            // 
            this.FirstRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.FirstRadGroupBox.Controls.Add(this.AllCustomersRadRadioButton);
            this.FirstRadGroupBox.Controls.Add(this.IndividualCustomerRadRadioButton);
            this.FirstRadGroupBox.HeaderText = "Seleccione criterio de búsqueda";
            this.FirstRadGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FirstRadGroupBox.Name = "FirstRadGroupBox";
            this.FirstRadGroupBox.Size = new System.Drawing.Size(294, 68);
            this.FirstRadGroupBox.TabIndex = 0;
            this.FirstRadGroupBox.Text = "Seleccione criterio de búsqueda";
            // 
            // AllCustomersRadRadioButton
            // 
            this.AllCustomersRadRadioButton.Location = new System.Drawing.Point(185, 33);
            this.AllCustomersRadRadioButton.Name = "AllCustomersRadRadioButton";
            this.AllCustomersRadRadioButton.Size = new System.Drawing.Size(51, 18);
            this.AllCustomersRadRadioButton.TabIndex = 0;
            this.AllCustomersRadRadioButton.TabStop = false;
            this.AllCustomersRadRadioButton.Text = "Todos";
            // 
            // IndividualCustomerRadRadioButton
            // 
            this.IndividualCustomerRadRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IndividualCustomerRadRadioButton.Location = new System.Drawing.Point(20, 33);
            this.IndividualCustomerRadRadioButton.Name = "IndividualCustomerRadRadioButton";
            this.IndividualCustomerRadRadioButton.Size = new System.Drawing.Size(69, 18);
            this.IndividualCustomerRadRadioButton.TabIndex = 0;
            this.IndividualCustomerRadRadioButton.Text = "Individual";
            this.IndividualCustomerRadRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // SecondRadGroupBox
            // 
            this.SecondRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.SecondRadGroupBox.Controls.Add(this.AllSalesRdCheckBox);
            this.SecondRadGroupBox.Controls.Add(this.YearSalesCmboBox);
            this.SecondRadGroupBox.HeaderText = "Seleccione año";
            this.SecondRadGroupBox.Location = new System.Drawing.Point(12, 86);
            this.SecondRadGroupBox.Name = "SecondRadGroupBox";
            this.SecondRadGroupBox.Size = new System.Drawing.Size(294, 76);
            this.SecondRadGroupBox.TabIndex = 1;
            this.SecondRadGroupBox.Text = "Seleccione año";
            // 
            // AllSalesRdCheckBox
            // 
            this.AllSalesRdCheckBox.Location = new System.Drawing.Point(185, 38);
            this.AllSalesRdCheckBox.Name = "AllSalesRdCheckBox";
            this.AllSalesRdCheckBox.Size = new System.Drawing.Size(59, 18);
            this.AllSalesRdCheckBox.TabIndex = 1;
            this.AllSalesRdCheckBox.Text = "General";
            // 
            // YearSalesCmboBox
            // 
            this.YearSalesCmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearSalesCmboBox.FormattingEnabled = true;
            this.YearSalesCmboBox.Location = new System.Drawing.Point(20, 35);
            this.YearSalesCmboBox.Name = "YearSalesCmboBox";
            this.YearSalesCmboBox.Size = new System.Drawing.Size(121, 21);
            this.YearSalesCmboBox.TabIndex = 0;
            // 
            // ThridRadGroupBox
            // 
            this.ThridRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ThridRadGroupBox.Controls.Add(this.DocumentIDMaskedTextBox);
            this.ThridRadGroupBox.HeaderText = "Introduzca cedula";
            this.ThridRadGroupBox.Location = new System.Drawing.Point(12, 168);
            this.ThridRadGroupBox.Name = "ThridRadGroupBox";
            this.ThridRadGroupBox.Size = new System.Drawing.Size(294, 78);
            this.ThridRadGroupBox.TabIndex = 2;
            this.ThridRadGroupBox.Text = "Introduzca cedula";
            // 
            // DisplayMsgRadLabel
            // 
            this.DisplayMsgRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgRadLabel.ForeColor = System.Drawing.Color.Red;
            this.DisplayMsgRadLabel.Location = new System.Drawing.Point(12, 351);
            this.DisplayMsgRadLabel.Name = "DisplayMsgRadLabel";
            this.DisplayMsgRadLabel.Size = new System.Drawing.Size(60, 25);
            this.DisplayMsgRadLabel.TabIndex = 16;
            this.DisplayMsgRadLabel.Text = "Default";
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm3;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(181, 252);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(125, 84);
            this.CancelRadButton.TabIndex = 15;
            this.CancelRadButton.Text = "Salir";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GetReportRadButton
            // 
            this.GetReportRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.UpdateReport;
            this.GetReportRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.GetReportRadButton.Location = new System.Drawing.Point(12, 252);
            this.GetReportRadButton.Name = "GetReportRadButton";
            this.GetReportRadButton.Size = new System.Drawing.Size(125, 84);
            this.GetReportRadButton.TabIndex = 14;
            this.GetReportRadButton.Text = "Generar";
            this.GetReportRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.GetReportRadButton.Click += new System.EventHandler(this.GetReportRadButton_Click);
            // 
            // DocumentIDMaskedTextBox
            // 
            this.DocumentIDMaskedTextBox.Location = new System.Drawing.Point(20, 40);
            this.DocumentIDMaskedTextBox.Mask = "000-0000000-0";
            this.DocumentIDMaskedTextBox.Name = "DocumentIDMaskedTextBox";
            this.DocumentIDMaskedTextBox.Size = new System.Drawing.Size(224, 20);
            this.DocumentIDMaskedTextBox.TabIndex = 0;
            this.DocumentIDMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // DisplayAllSalesByCustomerRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 388);
            this.Controls.Add(this.DisplayMsgRadLabel);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.GetReportRadButton);
            this.Controls.Add(this.ThridRadGroupBox);
            this.Controls.Add(this.SecondRadGroupBox);
            this.Controls.Add(this.FirstRadGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayAllSalesByCustomerRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de reporte de ventas por cliente(s)";
            this.Load += new System.EventHandler(this.DisplayAllSalesByCustomerRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstRadGroupBox)).EndInit();
            this.FirstRadGroupBox.ResumeLayout(false);
            this.FirstRadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCustomersRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndividualCustomerRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondRadGroupBox)).EndInit();
            this.SecondRadGroupBox.ResumeLayout(false);
            this.SecondRadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllSalesRdCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThridRadGroupBox)).EndInit();
            this.ThridRadGroupBox.ResumeLayout(false);
            this.ThridRadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetReportRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox FirstRadGroupBox;
        private Telerik.WinControls.UI.RadRadioButton AllCustomersRadRadioButton;
        private Telerik.WinControls.UI.RadRadioButton IndividualCustomerRadRadioButton;
        private Telerik.WinControls.UI.RadGroupBox SecondRadGroupBox;
        private Telerik.WinControls.UI.RadCheckBox AllSalesRdCheckBox;
        private System.Windows.Forms.ComboBox YearSalesCmboBox;
        private Telerik.WinControls.UI.RadGroupBox ThridRadGroupBox;
        private Telerik.WinControls.UI.RadLabel DisplayMsgRadLabel;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private Telerik.WinControls.UI.RadButton GetReportRadButton;
        private System.Windows.Forms.MaskedTextBox DocumentIDMaskedTextBox;
    }
}
