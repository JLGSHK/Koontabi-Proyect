namespace KoontabiTelerikWinFormsApp
{
    public partial class CustomerRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRadForm));
            this.CustomersRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.OperationsRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.SearchCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.EditCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.DeleteCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.object_0006f39c_3577_43ec_9586_6b6c8866c715 = new Telerik.WinControls.RootRadElement();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).BeginInit();
            this.OperationsRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersRadGridView
            // 
            this.CustomersRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersRadGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomersRadGridView.Location = new System.Drawing.Point(16, 15);
            this.CustomersRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // CustomersRadGridView
            // 
            this.CustomersRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.CustomersRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.CustomersRadGridView.MasterTemplate.AllowEditRow = false;
            this.CustomersRadGridView.MasterTemplate.AllowRowResize = false;
            this.CustomersRadGridView.MasterTemplate.AllowSearchRow = true;
            this.CustomersRadGridView.Name = "CustomersRadGridView";
            this.CustomersRadGridView.ReadOnly = true;
            // 
            // 
            // 
            this.CustomersRadGridView.RootElement.AutoSize = true;
            this.CustomersRadGridView.Size = new System.Drawing.Size(1291, 357);
            this.CustomersRadGridView.TabIndex = 0;
            this.CustomersRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CustomersRadGridView_CellClick);
            this.CustomersRadGridView.Click += new System.EventHandler(this.CustomersRadGridView_Click);
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
            this.OperationsRadGroupBox.Location = new System.Drawing.Point(4, 379);
            this.OperationsRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationsRadGroupBox.Name = "OperationsRadGroupBox";
            this.OperationsRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.OperationsRadGroupBox.Size = new System.Drawing.Size(564, 123);
            this.OperationsRadGroupBox.TabIndex = 2;
            this.OperationsRadGroupBox.Text = "Operaciones";
            // 
            // SearchCustomerRadButton
            // 
            this.SearchCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Search_Male_User;
            this.SearchCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchCustomerRadButton.Location = new System.Drawing.Point(415, 26);
            this.SearchCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchCustomerRadButton.Name = "SearchCustomerRadButton";
            this.SearchCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.SearchCustomerRadButton.TabIndex = 4;
            this.SearchCustomerRadButton.Text = "Buscar";
            this.SearchCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditCustomerRadButton
            // 
            this.EditCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Edit_Male_User;
            this.EditCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCustomerRadButton.Location = new System.Drawing.Point(285, 26);
            this.EditCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCustomerRadButton.Name = "EditCustomerRadButton";
            this.EditCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.EditCustomerRadButton.TabIndex = 3;
            this.EditCustomerRadButton.Text = "Editar";
            this.EditCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditCustomerRadButton.Click += new System.EventHandler(this.EditCustomerRadButton_Click);
            // 
            // DeleteCustomerRadButton
            // 
            this.DeleteCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Remove_Male_User;
            this.DeleteCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCustomerRadButton.Location = new System.Drawing.Point(156, 26);
            this.DeleteCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCustomerRadButton.Name = "DeleteCustomerRadButton";
            this.DeleteCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteCustomerRadButton.TabIndex = 2;
            this.DeleteCustomerRadButton.Text = "Eliminar";
            this.DeleteCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCustomerRadButton.Click += new System.EventHandler(this.DeleteCustomerRadButton_Click);
            // 
            // NewCustomerRadButton
            // 
            this.NewCustomerRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewCustomerRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.Add_Male_User;
            this.NewCustomerRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCustomerRadButton.Location = new System.Drawing.Point(27, 26);
            this.NewCustomerRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewCustomerRadButton.Name = "NewCustomerRadButton";
            this.NewCustomerRadButton.Size = new System.Drawing.Size(121, 84);
            this.NewCustomerRadButton.TabIndex = 1;
            this.NewCustomerRadButton.Text = "Nuevo";
            this.NewCustomerRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCustomerRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewCustomerRadButton.Click += new System.EventHandler(this.NewCustomerRadButton_Click);
            // 
            // object_0006f39c_3577_43ec_9586_6b6c8866c715
            // 
            this.object_0006f39c_3577_43ec_9586_6b6c8866c715.AutoSize = true;
            this.object_0006f39c_3577_43ec_9586_6b6c8866c715.Name = "object_0006f39c_3577_43ec_9586_6b6c8866c715";
            this.object_0006f39c_3577_43ec_9586_6b6c8866c715.StretchHorizontally = true;
            this.object_0006f39c_3577_43ec_9586_6b6c8866c715.StretchVertically = true;
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // CustomerRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 530);
            this.Controls.Add(this.OperationsRadGroupBox);
            this.Controls.Add(this.CustomersRadGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1339, 560);
            this.Name = "CustomerRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.CustomerRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).EndInit();
            this.OperationsRadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView CustomersRadGridView;
        private Telerik.WinControls.UI.RadButton NewCustomerRadButton;
        private Telerik.WinControls.UI.RadGroupBox OperationsRadGroupBox;
        private Telerik.WinControls.UI.RadButton DeleteCustomerRadButton;
        private Telerik.WinControls.UI.RadButton EditCustomerRadButton;
        private Telerik.WinControls.UI.RadButton SearchCustomerRadButton;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.RootRadElement object_0006f39c_3577_43ec_9586_6b6c8866c715;
        private System.Windows.Forms.Timer MyTimer;
    }
}
