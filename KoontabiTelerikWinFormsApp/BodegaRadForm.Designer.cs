namespace KoontabiTelerikWinFormsApp
{
    partial class BodegaRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodegaRadForm));
            this.OperationsRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.SearchCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.EditCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.DeleteCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.BodegaRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).BeginInit();
            this.OperationsRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsRadGroupBox
            // 
            this.OperationsRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.OperationsRadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationsRadGroupBox.Controls.Add(this.SearchCustomerRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.EditCustomerRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.DeleteCustomerRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.NewCustomerRadButton);
            this.OperationsRadGroupBox.HeaderText = "Operaciones";
            this.OperationsRadGroupBox.Location = new System.Drawing.Point(16, 454);
            this.OperationsRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationsRadGroupBox.Name = "OperationsRadGroupBox";
            this.OperationsRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.OperationsRadGroupBox.Size = new System.Drawing.Size(564, 123);
            this.OperationsRadGroupBox.TabIndex = 3;
            this.OperationsRadGroupBox.Text = "Operaciones";
            // 
            // SearchCustomerRadButton
            // 
            this.SearchCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchCustomerRadButton.Enabled = false;
            this.SearchCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.order_history;
            this.SearchCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchCustomerRadButton.Location = new System.Drawing.Point(415, 26);
            this.SearchCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchCustomerRadButton.Name = "SearchCustomerRadButton";
            this.SearchCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.SearchCustomerRadButton.TabIndex = 4;
            this.SearchCustomerRadButton.Text = "Ver";
            this.SearchCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditCustomerRadButton
            // 
            this.EditCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditCustomerRadButton.Enabled = false;
            this.EditCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.edit;
            this.EditCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCustomerRadButton.Location = new System.Drawing.Point(285, 26);
            this.EditCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCustomerRadButton.Name = "EditCustomerRadButton";
            this.EditCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.EditCustomerRadButton.TabIndex = 3;
            this.EditCustomerRadButton.Text = "Editar";
            this.EditCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DeleteCustomerRadButton
            // 
            this.DeleteCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteCustomerRadButton.Enabled = false;
            this.DeleteCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete;
            this.DeleteCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCustomerRadButton.Location = new System.Drawing.Point(156, 26);
            this.DeleteCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCustomerRadButton.Name = "DeleteCustomerRadButton";
            this.DeleteCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteCustomerRadButton.TabIndex = 2;
            this.DeleteCustomerRadButton.Text = "Eliminar";
            this.DeleteCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // NewCustomerRadButton
            // 
            this.NewCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewCustomerRadButton.Enabled = false;
            this.NewCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.add1;
            this.NewCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCustomerRadButton.Location = new System.Drawing.Point(27, 26);
            this.NewCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewCustomerRadButton.Name = "NewCustomerRadButton";
            this.NewCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.NewCustomerRadButton.TabIndex = 1;
            this.NewCustomerRadButton.Text = "Nuevo";
            this.NewCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BodegaRadGridView
            // 
            this.BodegaRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodegaRadGridView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodegaRadGridView.Location = new System.Drawing.Point(16, 15);
            this.BodegaRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // BodegaRadGridView
            // 
            this.BodegaRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.BodegaRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.BodegaRadGridView.MasterTemplate.AllowEditRow = false;
            this.BodegaRadGridView.MasterTemplate.AllowRowResize = false;
            this.BodegaRadGridView.MasterTemplate.AllowSearchRow = true;
            this.BodegaRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.BodegaRadGridView.Name = "BodegaRadGridView";
            this.BodegaRadGridView.Size = new System.Drawing.Size(1049, 432);
            this.BodegaRadGridView.TabIndex = 4;
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // BodegaRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 605);
            this.Controls.Add(this.BodegaRadGridView);
            this.Controls.Add(this.OperationsRadGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BodegaRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.BodegaRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).EndInit();
            this.OperationsRadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGroupBox OperationsRadGroupBox;
        private Telerik.WinControls.UI.RadButton SearchCustomerRadButton;
        private Telerik.WinControls.UI.RadButton EditCustomerRadButton;
        private Telerik.WinControls.UI.RadButton DeleteCustomerRadButton;
        private Telerik.WinControls.UI.RadButton NewCustomerRadButton;
        private Telerik.WinControls.UI.RadGridView BodegaRadGridView;
        private System.Windows.Forms.Timer MyTimer;
    }
}
