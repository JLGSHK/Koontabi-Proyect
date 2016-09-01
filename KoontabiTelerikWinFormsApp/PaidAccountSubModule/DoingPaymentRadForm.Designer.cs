namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    partial class DoingPaymentRadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoingPaymentRadForm));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.DocumentIDRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.CustomerNameRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ConceptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ReceiptRefMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PrintReciptRadCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.PayMethodRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.TotalPayRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.PaymentRadRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.CancelPayRadButton = new Telerik.WinControls.UI.RadButton();
            this.PayProcessRadButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.DatePayRadDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.AmountPayRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIDRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintReciptRadCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayMethodRadGroupBox)).BeginInit();
            this.PayMethodRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPayRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentRadRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPayRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayProcessRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePayRadDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPayRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.radPanel1.Controls.Add(this.DocumentIDRadLabel);
            this.radPanel1.Controls.Add(this.CustomerNameRadLabel);
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(520, 365);
            this.radPanel1.TabIndex = 0;
            // 
            // DocumentIDRadLabel
            // 
            this.DocumentIDRadLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentIDRadLabel.Location = new System.Drawing.Point(12, 36);
            this.DocumentIDRadLabel.Name = "DocumentIDRadLabel";
            this.DocumentIDRadLabel.Size = new System.Drawing.Size(48, 21);
            this.DocumentIDRadLabel.TabIndex = 1;
            this.DocumentIDRadLabel.Text = "Cedula";
            // 
            // CustomerNameRadLabel
            // 
            this.CustomerNameRadLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameRadLabel.Location = new System.Drawing.Point(12, 12);
            this.CustomerNameRadLabel.Name = "CustomerNameRadLabel";
            this.CustomerNameRadLabel.Size = new System.Drawing.Size(51, 21);
            this.CustomerNameRadLabel.TabIndex = 0;
            this.CustomerNameRadLabel.Text = "Cliente";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ConceptRichTextBox);
            this.radGroupBox1.Controls.Add(this.ReceiptRefMaskedTextBox);
            this.radGroupBox1.Controls.Add(this.PrintReciptRadCheckBox);
            this.radGroupBox1.Controls.Add(this.PayMethodRadGroupBox);
            this.radGroupBox1.Controls.Add(this.CancelPayRadButton);
            this.radGroupBox1.Controls.Add(this.PayProcessRadButton);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.DatePayRadDateTimePicker);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.AmountPayRadMaskedEditBox);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.HeaderText = "Detalles del pago";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 60);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(496, 293);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Detalles del pago";
            // 
            // ConceptRichTextBox
            // 
            this.ConceptRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConceptRichTextBox.Location = new System.Drawing.Point(5, 95);
            this.ConceptRichTextBox.Name = "ConceptRichTextBox";
            this.ConceptRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ConceptRichTextBox.Size = new System.Drawing.Size(322, 66);
            this.ConceptRichTextBox.TabIndex = 5;
            this.ConceptRichTextBox.Text = "";
            // 
            // ReceiptRefMaskedTextBox
            // 
            this.ReceiptRefMaskedTextBox.Location = new System.Drawing.Point(391, 39);
            this.ReceiptRefMaskedTextBox.Mask = "99999";
            this.ReceiptRefMaskedTextBox.Name = "ReceiptRefMaskedTextBox";
            this.ReceiptRefMaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.ReceiptRefMaskedTextBox.TabIndex = 3;
            this.ReceiptRefMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReceiptRefMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ReceiptRefMaskedTextBox.TextChanged += new System.EventHandler(this.ReceiptRefMaskedTextBox_TextChanged);
            // 
            // PrintReciptRadCheckBox
            // 
            this.PrintReciptRadCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReciptRadCheckBox.Location = new System.Drawing.Point(14, 265);
            this.PrintReciptRadCheckBox.Name = "PrintReciptRadCheckBox";
            this.PrintReciptRadCheckBox.Size = new System.Drawing.Size(241, 21);
            this.PrintReciptRadCheckBox.TabIndex = 9;
            this.PrintReciptRadCheckBox.Text = "Imprimir comprobante para el cliente";
            // 
            // PayMethodRadGroupBox
            // 
            this.PayMethodRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.PayMethodRadGroupBox.Controls.Add(this.TotalPayRadRadioButton);
            this.PayMethodRadGroupBox.Controls.Add(this.PaymentRadRadioButton);
            this.PayMethodRadGroupBox.Enabled = false;
            this.PayMethodRadGroupBox.HeaderText = "Metodo de pago";
            this.PayMethodRadGroupBox.Location = new System.Drawing.Point(5, 175);
            this.PayMethodRadGroupBox.Name = "PayMethodRadGroupBox";
            this.PayMethodRadGroupBox.Size = new System.Drawing.Size(212, 76);
            this.PayMethodRadGroupBox.TabIndex = 8;
            this.PayMethodRadGroupBox.Text = "Metodo de pago";
            // 
            // TotalPayRadRadioButton
            // 
            this.TotalPayRadRadioButton.Location = new System.Drawing.Point(23, 47);
            this.TotalPayRadRadioButton.Name = "TotalPayRadRadioButton";
            this.TotalPayRadRadioButton.Size = new System.Drawing.Size(127, 18);
            this.TotalPayRadRadioButton.TabIndex = 1;
            this.TotalPayRadRadioButton.TabStop = false;
            this.TotalPayRadRadioButton.Text = "Pago Total / Cancelar";
            // 
            // PaymentRadRadioButton
            // 
            this.PaymentRadRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PaymentRadRadioButton.Location = new System.Drawing.Point(23, 22);
            this.PaymentRadRadioButton.Name = "PaymentRadRadioButton";
            this.PaymentRadRadioButton.Size = new System.Drawing.Size(106, 18);
            this.PaymentRadRadioButton.TabIndex = 0;
            this.PaymentRadRadioButton.Text = "Abono en cuenta";
            this.PaymentRadRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // CancelPayRadButton
            // 
            this.CancelPayRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelPayRadButton.Location = new System.Drawing.Point(375, 222);
            this.CancelPayRadButton.Name = "CancelPayRadButton";
            this.CancelPayRadButton.Size = new System.Drawing.Size(110, 61);
            this.CancelPayRadButton.TabIndex = 11;
            this.CancelPayRadButton.Text = "Cancelar";
            // 
            // PayProcessRadButton
            // 
            this.PayProcessRadButton.Location = new System.Drawing.Point(259, 222);
            this.PayProcessRadButton.Name = "PayProcessRadButton";
            this.PayProcessRadButton.Size = new System.Drawing.Size(110, 61);
            this.PayProcessRadButton.TabIndex = 10;
            this.PayProcessRadButton.Text = "Procesar";
            this.PayProcessRadButton.Click += new System.EventHandler(this.PayProcessRadButton_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(377, 103);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(47, 21);
            this.radLabel6.TabIndex = 6;
            this.radLabel6.Text = "Fecha:";
            // 
            // DatePayRadDateTimePicker
            // 
            this.DatePayRadDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePayRadDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayRadDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePayRadDateTimePicker.Location = new System.Drawing.Point(361, 130);
            this.DatePayRadDateTimePicker.Name = "DatePayRadDateTimePicker";
            this.DatePayRadDateTimePicker.Size = new System.Drawing.Size(105, 23);
            this.DatePayRadDateTimePicker.TabIndex = 7;
            this.DatePayRadDateTimePicker.TabStop = false;
            this.DatePayRadDateTimePicker.Text = "27/11/2015";
            this.DatePayRadDateTimePicker.Value = new System.DateTime(2015, 11, 27, 20, 32, 37, 256);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(5, 72);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(91, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Concepto :";
            // 
            // AmountPayRadMaskedEditBox
            // 
            this.AmountPayRadMaskedEditBox.Location = new System.Drawing.Point(75, 36);
            this.AmountPayRadMaskedEditBox.Mask = "C2";
            this.AmountPayRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.AmountPayRadMaskedEditBox.Name = "AmountPayRadMaskedEditBox";
            this.AmountPayRadMaskedEditBox.Size = new System.Drawing.Size(102, 20);
            this.AmountPayRadMaskedEditBox.TabIndex = 1;
            this.AmountPayRadMaskedEditBox.TabStop = false;
            this.AmountPayRadMaskedEditBox.Text = "RD$0.00";
            this.AmountPayRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountPayRadMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.AmountPayRadMaskedEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPayRadMaskedEditBox_KeyPress);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.ForeColor = System.Drawing.Color.Red;
            this.radLabel5.Location = new System.Drawing.Point(198, 34);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(186, 25);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Numero de Referencia:";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.Red;
            this.radLabel4.Location = new System.Drawing.Point(5, 34);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(64, 25);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Monto:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DoingPaymentRadForm
            // 
            this.AcceptButton = this.PayProcessRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelPayRadButton;
            this.ClientSize = new System.Drawing.Size(520, 365);
            this.Controls.Add(this.radPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoingPaymentRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar pago";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoingPaymentRadForm_FormClosing);
            this.Load += new System.EventHandler(this.DoingPaymentRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIDRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintReciptRadCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayMethodRadGroupBox)).EndInit();
            this.PayMethodRadGroupBox.ResumeLayout(false);
            this.PayMethodRadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPayRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentRadRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPayRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayProcessRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePayRadDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountPayRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel DocumentIDRadLabel;
        private Telerik.WinControls.UI.RadLabel CustomerNameRadLabel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadMaskedEditBox AmountPayRadMaskedEditBox;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDateTimePicker DatePayRadDateTimePicker;
        private Telerik.WinControls.UI.RadButton CancelPayRadButton;
        private Telerik.WinControls.UI.RadButton PayProcessRadButton;
        private Telerik.WinControls.UI.RadCheckBox PrintReciptRadCheckBox;
        private Telerik.WinControls.UI.RadGroupBox PayMethodRadGroupBox;
        private Telerik.WinControls.UI.RadRadioButton TotalPayRadRadioButton;
        private Telerik.WinControls.UI.RadRadioButton PaymentRadRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox ReceiptRefMaskedTextBox;
        private System.Windows.Forms.RichTextBox ConceptRichTextBox;
    }
}
