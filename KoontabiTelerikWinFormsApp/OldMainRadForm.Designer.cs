namespace KoontabiTelerikWinFormsApp
{
    partial class OldMainRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldMainRadForm));
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.MyBarRadStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.UserOnlineRadLabelElement = new Telerik.WinControls.UI.RadLabelElement();
            this.HourRadLabelElement = new Telerik.WinControls.UI.RadLabelElement();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.MaintenanceRadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.CustomerRadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.BodegaRadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.InventoryradMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.ProductRadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.ProductsradMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.CategoriesRadMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBarRadStatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MaintenanceRadMenuItem,
            this.InventoryradMenuItem});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(992, 36);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // MyBarRadStatusStrip
            // 
            this.MyBarRadStatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.UserOnlineRadLabelElement,
            this.HourRadLabelElement});
            this.MyBarRadStatusStrip.Location = new System.Drawing.Point(0, 546);
            this.MyBarRadStatusStrip.Name = "MyBarRadStatusStrip";
            this.MyBarRadStatusStrip.Size = new System.Drawing.Size(992, 24);
            this.MyBarRadStatusStrip.TabIndex = 3;
            this.MyBarRadStatusStrip.Text = "radStatusStrip1";
            // 
            // UserOnlineRadLabelElement
            // 
            this.UserOnlineRadLabelElement.AccessibleDescription = "Usuario Online: JLGSHK";
            this.UserOnlineRadLabelElement.AccessibleName = "Usuario Online: JLGSHK";
            this.UserOnlineRadLabelElement.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserOnlineRadLabelElement.Image = null;
            this.UserOnlineRadLabelElement.ImageAlignment = System.Drawing.ContentAlignment.TopRight;
            this.UserOnlineRadLabelElement.Name = "UserOnlineRadLabelElement";
            this.MyBarRadStatusStrip.SetSpring(this.UserOnlineRadLabelElement, false);
            this.UserOnlineRadLabelElement.Text = "Usuario Online: JLGSHK";
            this.UserOnlineRadLabelElement.TextWrap = true;
            // 
            // HourRadLabelElement
            // 
            this.HourRadLabelElement.AutoSize = false;
            this.HourRadLabelElement.Bounds = new System.Drawing.Rectangle(0, 0, 795, 18);
            this.HourRadLabelElement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourRadLabelElement.Name = "HourRadLabelElement";
            this.HourRadLabelElement.RightToLeft = true;
            this.MyBarRadStatusStrip.SetSpring(this.HourRadLabelElement, false);
            this.HourRadLabelElement.Text = "";
            this.HourRadLabelElement.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.HourRadLabelElement.TextWrap = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radLabelElement1.AutoSize = true;
            this.radLabelElement1.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.status;
            this.radLabelElement1.Name = "radLabelElement1";
            this.MyBarRadStatusStrip.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "";
            this.radLabelElement1.TextWrap = true;
            // 
            // MaintenanceRadMenuItem
            // 
            this.MaintenanceRadMenuItem.AccessibleDescription = "Mantenimientos";
            this.MaintenanceRadMenuItem.AccessibleName = "Mantenimientos";
            this.MaintenanceRadMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.wheel;
            this.MaintenanceRadMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.CustomerRadMenuItem,
            this.BodegaRadMenuItem});
            this.MaintenanceRadMenuItem.Name = "MaintenanceRadMenuItem";
            this.MaintenanceRadMenuItem.Text = "Mantenimientos";
            // 
            // CustomerRadMenuItem
            // 
            this.CustomerRadMenuItem.AccessibleDescription = "Clientes";
            this.CustomerRadMenuItem.AccessibleName = "Clientes";
            this.CustomerRadMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.man;
            this.CustomerRadMenuItem.Name = "CustomerRadMenuItem";
            this.CustomerRadMenuItem.Text = "Clientes";
            // 
            // BodegaRadMenuItem
            // 
            this.BodegaRadMenuItem.AccessibleDescription = "Bodegas";
            this.BodegaRadMenuItem.AccessibleName = "Bodegas";
            this.BodegaRadMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.utilities_folder_32;
            this.BodegaRadMenuItem.Name = "BodegaRadMenuItem";
            this.BodegaRadMenuItem.Text = "Empresa";
            // 
            // InventoryradMenuItem
            // 
            this.InventoryradMenuItem.AccessibleDescription = "Inventario";
            this.InventoryradMenuItem.AccessibleName = "Inventario";
            this.InventoryradMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.inventory_maintenance;
            this.InventoryradMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ProductRadMenuItem});
            this.InventoryradMenuItem.Name = "InventoryradMenuItem";
            this.InventoryradMenuItem.Text = "Inventario";
            // 
            // ProductRadMenuItem
            // 
            this.ProductRadMenuItem.AccessibleDescription = "Producto";
            this.ProductRadMenuItem.AccessibleName = "Producto";
            this.ProductRadMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.packing1;
            this.ProductRadMenuItem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ProductsradMenuItem,
            this.CategoriesRadMenuItem});
            this.ProductRadMenuItem.Name = "ProductRadMenuItem";
            this.ProductRadMenuItem.Text = "Producto";
            // 
            // ProductsradMenuItem
            // 
            this.ProductsradMenuItem.AccessibleDescription = "Productos";
            this.ProductsradMenuItem.AccessibleName = "Productos";
            this.ProductsradMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.packing;
            this.ProductsradMenuItem.Name = "ProductsradMenuItem";
            this.ProductsradMenuItem.Text = "Productos";
            // 
            // CategoriesRadMenuItem
            // 
            this.CategoriesRadMenuItem.AccessibleDescription = "Categorias";
            this.CategoriesRadMenuItem.AccessibleName = "Categorias";
            this.CategoriesRadMenuItem.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.gealogy_view;
            this.CategoriesRadMenuItem.Name = "CategoriesRadMenuItem";
            this.CategoriesRadMenuItem.Text = "Categorias";
            // 
            // MainRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 570);
            this.Controls.Add(this.MyBarRadStatusStrip);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "KOONTABI - V. 1.00";
            this.Load += new System.EventHandler(this.MainRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyBarRadStatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem MaintenanceRadMenuItem;
        private Telerik.WinControls.UI.RadMenuItem CustomerRadMenuItem;
        private Telerik.WinControls.UI.RadStatusStrip MyBarRadStatusStrip;
        private Telerik.WinControls.UI.RadLabelElement UserOnlineRadLabelElement;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement HourRadLabelElement;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadMenuItem BodegaRadMenuItem;
        private Telerik.WinControls.UI.RadMenuItem InventoryradMenuItem;
        private Telerik.WinControls.UI.RadMenuItem ProductRadMenuItem;
        private Telerik.WinControls.UI.RadMenuItem ProductsradMenuItem;
        private Telerik.WinControls.UI.RadMenuItem CategoriesRadMenuItem;
    }
}