namespace KoontabiTelerikWinFormsApp
{
    partial class KardexRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KardexRadForm));
            this.KardexRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.OutputRadLabel = new Telerik.WinControls.UI.RadLabel();
            this.SearchRadButton = new Telerik.WinControls.UI.RadButton();
            this.CodeProductRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.UpdateProductStockRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.UpdateStockToDBRadButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.NewStockRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ProductSearchedTextBox = new System.Windows.Forms.TextBox();
            this.ActualStockRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.SearchToProductUpdateStockRadButton = new Telerik.WinControls.UI.RadButton();
            this.UpdateProductStockRadMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.KardexRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KardexRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputRadLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeProductRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductStockRadGroupBox)).BeginInit();
            this.UpdateProductStockRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStockToDBRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewStockRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualStockRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchToProductUpdateStockRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductStockRadMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // KardexRadGridView
            // 
            this.KardexRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KardexRadGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.KardexRadGridView.Location = new System.Drawing.Point(16, 203);
            this.KardexRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // KardexRadGridView
            // 
            this.KardexRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.KardexRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.KardexRadGridView.MasterTemplate.AllowDragToGroup = false;
            this.KardexRadGridView.MasterTemplate.AllowEditRow = false;
            this.KardexRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.KardexRadGridView.Name = "KardexRadGridView";
            this.KardexRadGridView.Size = new System.Drawing.Size(1093, 257);
            this.KardexRadGridView.TabIndex = 0;
            this.KardexRadGridView.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.KardexRadGridView_RowFormatting);
            this.KardexRadGridView.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.KardexRadGridView_CellFormatting);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.OutputRadLabel);
            this.radGroupBox1.Controls.Add(this.SearchRadButton);
            this.radGroupBox1.Controls.Add(this.CodeProductRadMaskedEditBox);
            this.radGroupBox1.HeaderText = "Consultar Kardex";
            this.radGroupBox1.Location = new System.Drawing.Point(16, 15);
            this.radGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(484, 181);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Consultar Kardex";
            // 
            // OutputRadLabel
            // 
            this.OutputRadLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputRadLabel.ForeColor = System.Drawing.Color.Red;
            this.OutputRadLabel.Location = new System.Drawing.Point(208, 38);
            this.OutputRadLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputRadLabel.Name = "OutputRadLabel";
            this.OutputRadLabel.Size = new System.Drawing.Size(2, 2);
            this.OutputRadLabel.TabIndex = 2;
            // 
            // SearchRadButton
            // 
            this.SearchRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.search1;
            this.SearchRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchRadButton.Location = new System.Drawing.Point(95, 74);
            this.SearchRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchRadButton.Name = "SearchRadButton";
            this.SearchRadButton.Size = new System.Drawing.Size(105, 47);
            this.SearchRadButton.TabIndex = 1;
            this.SearchRadButton.Tag = "";
            this.SearchRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchRadButton.Click += new System.EventHandler(this.SearchRadButton_Click);
            // 
            // CodeProductRadMaskedEditBox
            // 
            this.CodeProductRadMaskedEditBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeProductRadMaskedEditBox.Location = new System.Drawing.Point(7, 33);
            this.CodeProductRadMaskedEditBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CodeProductRadMaskedEditBox.Name = "CodeProductRadMaskedEditBox";
            this.CodeProductRadMaskedEditBox.Size = new System.Drawing.Size(193, 32);
            this.CodeProductRadMaskedEditBox.TabIndex = 0;
            this.CodeProductRadMaskedEditBox.TabStop = false;
            this.CodeProductRadMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.CodeProductRadMaskedEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeProductRadMaskedEditBox_KeyPress);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.UpdateProductStockRadGroupBox);
            this.radGroupBox2.Controls.Add(this.SearchToProductUpdateStockRadButton);
            this.radGroupBox2.Controls.Add(this.UpdateProductStockRadMaskedEditBox);
            this.radGroupBox2.HeaderText = "Actualizar Existencia de Producto";
            this.radGroupBox2.Location = new System.Drawing.Point(508, 15);
            this.radGroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(601, 181);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "Actualizar Existencia de Producto";
            // 
            // UpdateProductStockRadGroupBox
            // 
            this.UpdateProductStockRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.UpdateProductStockRadGroupBox.Controls.Add(this.UpdateStockToDBRadButton);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.radLabel1);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.radLabel3);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.NewStockRadMaskedEditBox);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.radLabel2);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.ProductSearchedTextBox);
            this.UpdateProductStockRadGroupBox.Controls.Add(this.ActualStockRadMaskedEditBox);
            this.UpdateProductStockRadGroupBox.HeaderText = "";
            this.UpdateProductStockRadGroupBox.Location = new System.Drawing.Point(208, 26);
            this.UpdateProductStockRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateProductStockRadGroupBox.Name = "UpdateProductStockRadGroupBox";
            this.UpdateProductStockRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.UpdateProductStockRadGroupBox.Size = new System.Drawing.Size(376, 135);
            this.UpdateProductStockRadGroupBox.TabIndex = 5;
            this.UpdateProductStockRadGroupBox.Click += new System.EventHandler(this.UpdateProductStockRadGroupBox_Click);
            // 
            // UpdateStockToDBRadButton
            // 
            this.UpdateStockToDBRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Update;
            this.UpdateStockToDBRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateStockToDBRadButton.Location = new System.Drawing.Point(251, 82);
            this.UpdateStockToDBRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateStockToDBRadButton.Name = "UpdateStockToDBRadButton";
            this.UpdateStockToDBRadButton.Size = new System.Drawing.Size(105, 47);
            this.UpdateStockToDBRadButton.TabIndex = 8;
            this.UpdateStockToDBRadButton.Tag = "";
            this.UpdateStockToDBRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateStockToDBRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpdateStockToDBRadButton.Click += new System.EventHandler(this.UpdateStockToDBRadButton_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(19, 12);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(60, 22);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Product";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(19, 107);
            this.radLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(62, 22);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Ingresar";
            // 
            // NewStockRadMaskedEditBox
            // 
            this.NewStockRadMaskedEditBox.Location = new System.Drawing.Point(91, 106);
            this.NewStockRadMaskedEditBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewStockRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.NewStockRadMaskedEditBox.Name = "NewStockRadMaskedEditBox";
            this.NewStockRadMaskedEditBox.Size = new System.Drawing.Size(131, 24);
            this.NewStockRadMaskedEditBox.TabIndex = 7;
            this.NewStockRadMaskedEditBox.TabStop = false;
            this.NewStockRadMaskedEditBox.Text = "0";
            this.NewStockRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NewStockRadMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Red;
            this.radLabel2.Location = new System.Drawing.Point(19, 78);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(67, 22);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Exitencia";
            // 
            // ProductSearchedTextBox
            // 
            this.ProductSearchedTextBox.Enabled = false;
            this.ProductSearchedTextBox.Location = new System.Drawing.Point(19, 41);
            this.ProductSearchedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductSearchedTextBox.Name = "ProductSearchedTextBox";
            this.ProductSearchedTextBox.Size = new System.Drawing.Size(336, 22);
            this.ProductSearchedTextBox.TabIndex = 6;
            // 
            // ActualStockRadMaskedEditBox
            // 
            this.ActualStockRadMaskedEditBox.Enabled = false;
            this.ActualStockRadMaskedEditBox.Location = new System.Drawing.Point(93, 74);
            this.ActualStockRadMaskedEditBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActualStockRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.ActualStockRadMaskedEditBox.Name = "ActualStockRadMaskedEditBox";
            this.ActualStockRadMaskedEditBox.Size = new System.Drawing.Size(128, 24);
            this.ActualStockRadMaskedEditBox.TabIndex = 7;
            this.ActualStockRadMaskedEditBox.TabStop = false;
            this.ActualStockRadMaskedEditBox.Text = "0";
            this.ActualStockRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ActualStockRadMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // SearchToProductUpdateStockRadButton
            // 
            this.SearchToProductUpdateStockRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.search1;
            this.SearchToProductUpdateStockRadButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchToProductUpdateStockRadButton.Location = new System.Drawing.Point(125, 74);
            this.SearchToProductUpdateStockRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchToProductUpdateStockRadButton.Name = "SearchToProductUpdateStockRadButton";
            this.SearchToProductUpdateStockRadButton.Size = new System.Drawing.Size(75, 47);
            this.SearchToProductUpdateStockRadButton.TabIndex = 4;
            this.SearchToProductUpdateStockRadButton.Tag = "";
            this.SearchToProductUpdateStockRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchToProductUpdateStockRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchToProductUpdateStockRadButton.Click += new System.EventHandler(this.SearchToProductUpdateStockRadButton_Click);
            // 
            // UpdateProductStockRadMaskedEditBox
            // 
            this.UpdateProductStockRadMaskedEditBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductStockRadMaskedEditBox.Location = new System.Drawing.Point(7, 33);
            this.UpdateProductStockRadMaskedEditBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateProductStockRadMaskedEditBox.Name = "UpdateProductStockRadMaskedEditBox";
            this.UpdateProductStockRadMaskedEditBox.Size = new System.Drawing.Size(193, 32);
            this.UpdateProductStockRadMaskedEditBox.TabIndex = 3;
            this.UpdateProductStockRadMaskedEditBox.TabStop = false;
            this.UpdateProductStockRadMaskedEditBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.UpdateProductStockRadMaskedEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateProductStockRadMaskedEditBox_KeyPress);
            // 
            // KardexRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 488);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.KardexRadGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KardexRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.StoreRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KardexRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KardexRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputRadLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeProductRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductStockRadGroupBox)).EndInit();
            this.UpdateProductStockRadGroupBox.ResumeLayout(false);
            this.UpdateProductStockRadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStockToDBRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewStockRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualStockRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchToProductUpdateStockRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateProductStockRadMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView KardexRadGridView;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMaskedEditBox CodeProductRadMaskedEditBox;
        private Telerik.WinControls.UI.RadButton SearchRadButton;
        private Telerik.WinControls.UI.RadLabel OutputRadLabel;
        private System.Windows.Forms.Timer MyTimer;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton SearchToProductUpdateStockRadButton;
        private Telerik.WinControls.UI.RadMaskedEditBox UpdateProductStockRadMaskedEditBox;
        private Telerik.WinControls.UI.RadMaskedEditBox ActualStockRadMaskedEditBox;
        private System.Windows.Forms.TextBox ProductSearchedTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox UpdateProductStockRadGroupBox;
        private Telerik.WinControls.UI.RadButton UpdateStockToDBRadButton;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadMaskedEditBox NewStockRadMaskedEditBox;
    }
}
