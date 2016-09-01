namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    partial class InvoiceNumberRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceNumberRadForm));
            this.DisplayMsgRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.DocumentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.SearchingRadButton = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayMsgRadLabel
            // 
            this.DisplayMsgRadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMsgRadLabel.ForeColor = System.Drawing.Color.Red;
            this.DisplayMsgRadLabel.Location = new System.Drawing.Point(18, 68);
            this.DisplayMsgRadLabel.Name = "DisplayMsgRadLabel";
            this.DisplayMsgRadLabel.Size = new System.Drawing.Size(60, 25);
            this.DisplayMsgRadLabel.TabIndex = 4;
            this.DisplayMsgRadLabel.Text = "Default";
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.CloseForm1;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(288, 31);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(61, 62);
            this.CancelRadButton.TabIndex = 3;
            this.CancelRadButton.Text = "Salir";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DocumentIDMaskedTextBox
            // 
            this.DocumentIDMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.DocumentIDMaskedTextBox.Location = new System.Drawing.Point(18, 31);
            this.DocumentIDMaskedTextBox.Mask = "9999";
            this.DocumentIDMaskedTextBox.Name = "DocumentIDMaskedTextBox";
            this.DocumentIDMaskedTextBox.Size = new System.Drawing.Size(197, 20);
            this.DocumentIDMaskedTextBox.TabIndex = 1;
            this.DocumentIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DocumentIDMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(18, 7);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(171, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Introduzca un número de factura";
            // 
            // SearchingRadButton
            // 
            this.SearchingRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.SearchDatabase;
            this.SearchingRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchingRadButton.Location = new System.Drawing.Point(221, 31);
            this.SearchingRadButton.Name = "SearchingRadButton";
            this.SearchingRadButton.Size = new System.Drawing.Size(61, 62);
            this.SearchingRadButton.TabIndex = 2;
            this.SearchingRadButton.Text = "Buscar";
            this.SearchingRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchingRadButton.Click += new System.EventHandler(this.SearchingRadButton_Click);
            // 
            // InvoiceNumberRadForm
            // 
            this.AcceptButton = this.SearchingRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(356, 96);
            this.Controls.Add(this.SearchingRadButton);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DocumentIDMaskedTextBox);
            this.Controls.Add(this.DisplayMsgRadLabel);
            this.Controls.Add(this.CancelRadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceNumberRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOSIAS INDUSTRIAL SRL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceNumberRadForm_FormClosing);
            this.Load += new System.EventHandler(this.InvoiceNumberRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayMsgRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel DisplayMsgRadLabel;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private System.Windows.Forms.MaskedTextBox DocumentIDMaskedTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton SearchingRadButton;
        private System.Windows.Forms.Timer timer1;
    }
}
