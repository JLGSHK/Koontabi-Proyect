namespace KoontabiTelerikWinFormsApp
{
    partial class ProductRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRadForm));
            this.OperationsRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.SeeMoreProductRadButton = new Telerik.WinControls.UI.RadButton();
            this.EditProductRadButton = new Telerik.WinControls.UI.RadButton();
            this.DeleteProductRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewProductRadButton = new Telerik.WinControls.UI.RadButton();
            this.ProductsRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).BeginInit();
            this.OperationsRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeeMoreProductRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProductRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewProductRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsRadGroupBox
            // 
            this.OperationsRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.OperationsRadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationsRadGroupBox.Controls.Add(this.SeeMoreProductRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.EditProductRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.DeleteProductRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.NewProductRadButton);
            this.OperationsRadGroupBox.HeaderText = "Operaciones";
            this.OperationsRadGroupBox.Location = new System.Drawing.Point(16, 347);
            this.OperationsRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationsRadGroupBox.Name = "OperationsRadGroupBox";
            this.OperationsRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.OperationsRadGroupBox.Size = new System.Drawing.Size(564, 123);
            this.OperationsRadGroupBox.TabIndex = 4;
            this.OperationsRadGroupBox.Text = "Operaciones";
            // 
            // SeeMoreProductRadButton
            // 
            this.SeeMoreProductRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SeeMoreProductRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.order_history;
            this.SeeMoreProductRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SeeMoreProductRadButton.Location = new System.Drawing.Point(415, 26);
            this.SeeMoreProductRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeeMoreProductRadButton.Name = "SeeMoreProductRadButton";
            this.SeeMoreProductRadButton.Size = new System.Drawing.Size(121, 84);
            this.SeeMoreProductRadButton.TabIndex = 4;
            this.SeeMoreProductRadButton.Text = "Detalles";
            this.SeeMoreProductRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SeeMoreProductRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SeeMoreProductRadButton.Click += new System.EventHandler(this.SeeMoreProductRadButton_Click);
            // 
            // EditProductRadButton
            // 
            this.EditProductRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditProductRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.edit;
            this.EditProductRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditProductRadButton.Location = new System.Drawing.Point(285, 26);
            this.EditProductRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditProductRadButton.Name = "EditProductRadButton";
            this.EditProductRadButton.Size = new System.Drawing.Size(121, 84);
            this.EditProductRadButton.TabIndex = 3;
            this.EditProductRadButton.Text = "Editar";
            this.EditProductRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditProductRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditProductRadButton.Click += new System.EventHandler(this.EditProductRadButton_Click);
            // 
            // DeleteProductRadButton
            // 
            this.DeleteProductRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteProductRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete;
            this.DeleteProductRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteProductRadButton.Location = new System.Drawing.Point(156, 26);
            this.DeleteProductRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteProductRadButton.Name = "DeleteProductRadButton";
            this.DeleteProductRadButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteProductRadButton.TabIndex = 2;
            this.DeleteProductRadButton.Text = "Eliminar";
            this.DeleteProductRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteProductRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteProductRadButton.Click += new System.EventHandler(this.DeleteProductRadButton_Click);
            // 
            // NewProductRadButton
            // 
            this.NewProductRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewProductRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.add1;
            this.NewProductRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewProductRadButton.Location = new System.Drawing.Point(27, 26);
            this.NewProductRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewProductRadButton.Name = "NewProductRadButton";
            this.NewProductRadButton.Size = new System.Drawing.Size(121, 84);
            this.NewProductRadButton.TabIndex = 1;
            this.NewProductRadButton.Text = "Nuevo";
            this.NewProductRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewProductRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewProductRadButton.Click += new System.EventHandler(this.NewProductRadButton_Click);
            // 
            // ProductsRadGridView
            // 
            this.ProductsRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsRadGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ProductsRadGridView.Location = new System.Drawing.Point(16, 15);
            this.ProductsRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // ProductsRadGridView
            // 
            this.ProductsRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowColumnResize = false;
            this.ProductsRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowDragToGroup = false;
            this.ProductsRadGridView.MasterTemplate.AllowEditRow = false;
            this.ProductsRadGridView.MasterTemplate.AllowRowResize = false;
            this.ProductsRadGridView.MasterTemplate.AllowSearchRow = true;
            this.ProductsRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.ProductsRadGridView.Name = "ProductsRadGridView";
            this.ProductsRadGridView.Size = new System.Drawing.Size(1083, 325);
            this.ProductsRadGridView.TabIndex = 5;
            this.ProductsRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ProductsRadGridView_CellClick);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // ProductRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 498);
            this.Controls.Add(this.ProductsRadGridView);
            this.Controls.Add(this.OperationsRadGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.ProductRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).EndInit();
            this.OperationsRadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeeMoreProductRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProductRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProductRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewProductRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox OperationsRadGroupBox;
        private Telerik.WinControls.UI.RadButton SeeMoreProductRadButton;
        private Telerik.WinControls.UI.RadButton EditProductRadButton;
        private Telerik.WinControls.UI.RadButton DeleteProductRadButton;
        private Telerik.WinControls.UI.RadButton NewProductRadButton;
        private Telerik.WinControls.UI.RadGridView ProductsRadGridView;
        private System.Windows.Forms.Timer MyTimer;
    }
}
