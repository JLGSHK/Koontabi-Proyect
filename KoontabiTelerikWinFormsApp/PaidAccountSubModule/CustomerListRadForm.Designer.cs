namespace KoontabiTelerikWinFormsApp.PaidAccountSubModule
{
    partial class CustomerListRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListRadForm));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SearchingRadTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.SelectingRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewCustomerRadButton = new Telerik.WinControls.UI.RadButton();
            this.CloseRadButton = new Telerik.WinControls.UI.RadButton();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomersRadGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingRadTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectingRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SearchingRadTextBox);
            this.radGroupBox1.HeaderText = "Buscar cliente";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(407, 67);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Buscar cliente";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // SearchingRadTextBox
            // 
            this.SearchingRadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.SearchingRadTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchingRadTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchingRadTextBox.Location = new System.Drawing.Point(35, 32);
            this.SearchingRadTextBox.Name = "SearchingRadTextBox";
            this.SearchingRadTextBox.NullText = "Introduzca nombre";
            this.SearchingRadTextBox.Size = new System.Drawing.Size(339, 27);
            this.SearchingRadTextBox.TabIndex = 0;
            this.SearchingRadTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchingRadTextBox_MouseClick);
            // 
            // SelectingRadButton
            // 
            this.SelectingRadButton.Location = new System.Drawing.Point(12, 403);
            this.SelectingRadButton.Name = "SelectingRadButton";
            this.SelectingRadButton.Size = new System.Drawing.Size(127, 41);
            this.SelectingRadButton.TabIndex = 2;
            this.SelectingRadButton.Text = "Seleccionar";
            this.SelectingRadButton.Click += new System.EventHandler(this.SelectingRadButton_Click);
            // 
            // NewCustomerRadButton
            // 
            this.NewCustomerRadButton.Enabled = false;
            this.NewCustomerRadButton.Location = new System.Drawing.Point(152, 403);
            this.NewCustomerRadButton.Name = "NewCustomerRadButton";
            this.NewCustomerRadButton.Size = new System.Drawing.Size(127, 41);
            this.NewCustomerRadButton.TabIndex = 3;
            this.NewCustomerRadButton.Text = "Crear cliente";
            // 
            // CloseRadButton
            // 
            this.CloseRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseRadButton.Location = new System.Drawing.Point(292, 403);
            this.CloseRadButton.Name = "CloseRadButton";
            this.CloseRadButton.Size = new System.Drawing.Size(127, 41);
            this.CloseRadButton.TabIndex = 4;
            this.CloseRadButton.Text = "Cerrar";
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // CustomersRadGridView
            // 
            this.CustomersRadGridView.AllowDrop = true;
            this.CustomersRadGridView.Location = new System.Drawing.Point(12, 85);
            // 
            // CustomersRadGridView
            // 
            this.CustomersRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.CustomersRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.CustomersRadGridView.MasterTemplate.AllowDragToGroup = false;
            this.CustomersRadGridView.MasterTemplate.AllowEditRow = false;
            this.CustomersRadGridView.MasterTemplate.EnableFiltering = true;
            this.CustomersRadGridView.MasterTemplate.ShowFilteringRow = false;
            this.CustomersRadGridView.Name = "CustomersRadGridView";
            this.CustomersRadGridView.Size = new System.Drawing.Size(407, 312);
            this.CustomersRadGridView.TabIndex = 1;
            this.CustomersRadGridView.Text = "radGridView1";
            this.CustomersRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.CustomersRadGridView_CellClick);
            // 
            // CustomerListRadForm
            // 
            this.AcceptButton = this.SelectingRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseRadButton;
            this.ClientSize = new System.Drawing.Size(431, 456);
            this.Controls.Add(this.CustomersRadGridView);
            this.Controls.Add(this.SelectingRadButton);
            this.Controls.Add(this.NewCustomerRadButton);
            this.Controls.Add(this.CloseRadButton);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerListRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerListRadForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerListRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchingRadTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectingRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewCustomerRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox SearchingRadTextBox;
        private Telerik.WinControls.UI.RadButton SelectingRadButton;
        private Telerik.WinControls.UI.RadButton NewCustomerRadButton;
        private Telerik.WinControls.UI.RadButton CloseRadButton;
        private System.Windows.Forms.Timer MyTimer;
        private Telerik.WinControls.UI.RadGridView CustomersRadGridView;
    }
}
