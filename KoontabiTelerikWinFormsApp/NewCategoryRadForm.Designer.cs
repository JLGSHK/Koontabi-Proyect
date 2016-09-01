namespace KoontabiTelerikWinFormsApp
{
    partial class NewCategoryRadForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.CodeCategoryRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.CategoryRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.RegisterRadButton = new Telerik.WinControls.UI.RadButton();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.MsgErrorLabel = new System.Windows.Forms.Label();
            this.DescriptionRadRichTextEditor = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeCategoryRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionRadRichTextEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(33, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Código";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(22, 44);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(54, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Categoría";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 68);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(64, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Descripción";
            // 
            // CodeCategoryRadTextBox
            // 
            this.CodeCategoryRadTextBox.Location = new System.Drawing.Point(82, 17);
            this.CodeCategoryRadTextBox.Name = "CodeCategoryRadTextBox";
            this.CodeCategoryRadTextBox.Size = new System.Drawing.Size(206, 20);
            this.CodeCategoryRadTextBox.TabIndex = 1;
            this.CodeCategoryRadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeCategoryRadTextBox_KeyPress);
            // 
            // CategoryRadTextBox
            // 
            this.CategoryRadTextBox.Location = new System.Drawing.Point(82, 43);
            this.CategoryRadTextBox.Name = "CategoryRadTextBox";
            this.CategoryRadTextBox.Size = new System.Drawing.Size(206, 20);
            this.CategoryRadTextBox.TabIndex = 3;
            this.CategoryRadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryRadTextBox_KeyPress);
            // 
            // RegisterRadButton
            // 
            this.RegisterRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Save;
            this.RegisterRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterRadButton.Location = new System.Drawing.Point(134, 224);
            this.RegisterRadButton.Name = "RegisterRadButton";
            this.RegisterRadButton.Size = new System.Drawing.Size(74, 58);
            this.RegisterRadButton.TabIndex = 7;
            this.RegisterRadButton.Text = "Registrar";
            this.RegisterRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete1;
            this.CancelRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelRadButton.Location = new System.Drawing.Point(214, 224);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(74, 58);
            this.CancelRadButton.TabIndex = 8;
            this.CancelRadButton.Text = "Cancelar";
            this.CancelRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MsgErrorLabel
            // 
            this.MsgErrorLabel.AutoSize = true;
            this.MsgErrorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.MsgErrorLabel.Location = new System.Drawing.Point(12, 175);
            this.MsgErrorLabel.Name = "MsgErrorLabel";
            this.MsgErrorLabel.Size = new System.Drawing.Size(41, 17);
            this.MsgErrorLabel.TabIndex = 6;
            this.MsgErrorLabel.Text = "label1";
            // 
            // DescriptionRadRichTextEditor
            // 
            this.DescriptionRadRichTextEditor.AutoSize = false;
            this.DescriptionRadRichTextEditor.Location = new System.Drawing.Point(82, 69);
            this.DescriptionRadRichTextEditor.Multiline = true;
            this.DescriptionRadRichTextEditor.Name = "DescriptionRadRichTextEditor";
            this.DescriptionRadRichTextEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionRadRichTextEditor.Size = new System.Drawing.Size(206, 103);
            this.DescriptionRadRichTextEditor.TabIndex = 5;
            this.DescriptionRadRichTextEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionRadRichTextEditor_KeyPress);
            // 
            // NewCategoryRadForm
            // 
            this.AcceptButton = this.RegisterRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(292, 294);
            this.Controls.Add(this.DescriptionRadRichTextEditor);
            this.Controls.Add(this.MsgErrorLabel);
            this.Controls.Add(this.RegisterRadButton);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.CategoryRadTextBox);
            this.Controls.Add(this.CodeCategoryRadTextBox);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCategoryRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCategoryRadForm_FormClosing);
            this.Load += new System.EventHandler(this.NewCategoryRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeCategoryRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionRadRichTextEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox CodeCategoryRadTextBox;
        private Telerik.WinControls.UI.RadTextBox CategoryRadTextBox;
        private Telerik.WinControls.UI.RadButton RegisterRadButton;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private System.Windows.Forms.Label MsgErrorLabel;
        private Telerik.WinControls.UI.RadTextBox DescriptionRadRichTextEditor;
    }
}
