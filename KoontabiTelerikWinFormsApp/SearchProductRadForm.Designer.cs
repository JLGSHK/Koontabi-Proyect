namespace KoontabiTelerikWinFormsApp
{
    partial class SearchProductRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProductRadForm));
            this.AceptRadButton = new Telerik.WinControls.UI.RadButton();
            this.ProductsRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AceptRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptRadButton
            // 
            this.AceptRadButton.Location = new System.Drawing.Point(304, 231);
            this.AceptRadButton.Name = "AceptRadButton";
            this.AceptRadButton.Size = new System.Drawing.Size(89, 61);
            this.AceptRadButton.TabIndex = 0;
            this.AceptRadButton.Text = "&Aceptar";
            this.AceptRadButton.Click += new System.EventHandler(this.AceptRadButton_Click);
            // 
            // ProductsRadGridView
            // 
            this.ProductsRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsRadGridView.Location = new System.Drawing.Point(12, 12);
            // 
            // ProductsRadGridView
            // 
            this.ProductsRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowDragToGroup = false;
            this.ProductsRadGridView.MasterTemplate.AllowEditRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowSearchRow = true;
            this.ProductsRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.ProductsRadGridView.Name = "ProductsRadGridView";
            this.ProductsRadGridView.Size = new System.Drawing.Size(476, 213);
            this.ProductsRadGridView.TabIndex = 1;
            this.ProductsRadGridView.Text = "radGridView1";
            this.ProductsRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ProductsRadGridView_CellClick);
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Location = new System.Drawing.Point(399, 231);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(89, 61);
            this.CancelRadButton.TabIndex = 0;
            this.CancelRadButton.Text = "&Cancelar";
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // SearchProductRadForm
            // 
            this.AcceptButton = this.AceptRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.ProductsRadGridView);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.AceptRadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchProductRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchProductRadForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchProductRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AceptRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton AceptRadButton;
        private Telerik.WinControls.UI.RadGridView ProductsRadGridView;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private System.Windows.Forms.Timer MyTimer;
    }
}
