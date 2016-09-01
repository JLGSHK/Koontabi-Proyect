namespace KoontabiTelerikWinFormsApp
{
    partial class CategoryRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryRadForm));
            this.OperationsRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.LookCategoryRadButton = new Telerik.WinControls.UI.RadButton();
            this.EditCategoryRadButton = new Telerik.WinControls.UI.RadButton();
            this.DeleteCategoryRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewCategoryRadButton = new Telerik.WinControls.UI.RadButton();
            this.CategoryRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).BeginInit();
            this.OperationsRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookCategoryRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCategoryRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCategoryRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCategoryRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsRadGroupBox
            // 
            this.OperationsRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.OperationsRadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationsRadGroupBox.Controls.Add(this.LookCategoryRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.EditCategoryRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.DeleteCategoryRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.NewCategoryRadButton);
            this.OperationsRadGroupBox.HeaderText = "Operaciones";
            this.OperationsRadGroupBox.Location = new System.Drawing.Point(16, 454);
            this.OperationsRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationsRadGroupBox.Name = "OperationsRadGroupBox";
            this.OperationsRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.OperationsRadGroupBox.Size = new System.Drawing.Size(564, 123);
            this.OperationsRadGroupBox.TabIndex = 4;
            this.OperationsRadGroupBox.Text = "Operaciones";
            // 
            // LookCategoryRadButton
            // 
            this.LookCategoryRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LookCategoryRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.order_history;
            this.LookCategoryRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.LookCategoryRadButton.Location = new System.Drawing.Point(415, 26);
            this.LookCategoryRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LookCategoryRadButton.Name = "LookCategoryRadButton";
            this.LookCategoryRadButton.Size = new System.Drawing.Size(121, 84);
            this.LookCategoryRadButton.TabIndex = 4;
            this.LookCategoryRadButton.Text = "Ver";
            this.LookCategoryRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.LookCategoryRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LookCategoryRadButton.Click += new System.EventHandler(this.LookCategoryRadButton_Click);
            // 
            // EditCategoryRadButton
            // 
            this.EditCategoryRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditCategoryRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.edit;
            this.EditCategoryRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCategoryRadButton.Location = new System.Drawing.Point(285, 26);
            this.EditCategoryRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCategoryRadButton.Name = "EditCategoryRadButton";
            this.EditCategoryRadButton.Size = new System.Drawing.Size(121, 84);
            this.EditCategoryRadButton.TabIndex = 3;
            this.EditCategoryRadButton.Text = "Editar";
            this.EditCategoryRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCategoryRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditCategoryRadButton.Click += new System.EventHandler(this.EditCategoryRadButton_Click);
            // 
            // DeleteCategoryRadButton
            // 
            this.DeleteCategoryRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteCategoryRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete;
            this.DeleteCategoryRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCategoryRadButton.Location = new System.Drawing.Point(156, 26);
            this.DeleteCategoryRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCategoryRadButton.Name = "DeleteCategoryRadButton";
            this.DeleteCategoryRadButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteCategoryRadButton.TabIndex = 2;
            this.DeleteCategoryRadButton.Text = "Eliminar";
            this.DeleteCategoryRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCategoryRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCategoryRadButton.Click += new System.EventHandler(this.DeleteCategoryRadButton_Click);
            // 
            // NewCategoryRadButton
            // 
            this.NewCategoryRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewCategoryRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.add1;
            this.NewCategoryRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCategoryRadButton.Location = new System.Drawing.Point(27, 26);
            this.NewCategoryRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewCategoryRadButton.Name = "NewCategoryRadButton";
            this.NewCategoryRadButton.Size = new System.Drawing.Size(121, 84);
            this.NewCategoryRadButton.TabIndex = 1;
            this.NewCategoryRadButton.Text = "Nuevo";
            this.NewCategoryRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCategoryRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewCategoryRadButton.Click += new System.EventHandler(this.NewCategoryRadButton_Click);
            // 
            // CategoryRadGridView
            // 
            this.CategoryRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryRadGridView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryRadGridView.Location = new System.Drawing.Point(16, 15);
            this.CategoryRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // CategoryRadGridView
            // 
            this.CategoryRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.CategoryRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.CategoryRadGridView.MasterTemplate.AllowEditRow = false;
            this.CategoryRadGridView.MasterTemplate.AllowRowResize = false;
            this.CategoryRadGridView.MasterTemplate.AllowSearchRow = true;
            this.CategoryRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.CategoryRadGridView.Name = "CategoryRadGridView";
            this.CategoryRadGridView.Size = new System.Drawing.Size(1049, 432);
            this.CategoryRadGridView.TabIndex = 5;
            this.CategoryRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CategoryRadGridView_CellClick);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // CategoryRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 605);
            this.Controls.Add(this.CategoryRadGridView);
            this.Controls.Add(this.OperationsRadGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoryRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.CategoryRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).EndInit();
            this.OperationsRadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LookCategoryRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCategoryRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCategoryRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCategoryRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox OperationsRadGroupBox;
        private Telerik.WinControls.UI.RadButton LookCategoryRadButton;
        private Telerik.WinControls.UI.RadButton EditCategoryRadButton;
        private Telerik.WinControls.UI.RadButton DeleteCategoryRadButton;
        private Telerik.WinControls.UI.RadButton NewCategoryRadButton;
        private Telerik.WinControls.UI.RadGridView CategoryRadGridView;
        private System.Windows.Forms.Timer MyTimer;
    }
}
