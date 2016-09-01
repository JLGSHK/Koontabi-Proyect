namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    partial class ProductsInventoryRadFormReportView
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
            Telerik.Reporting.InstanceReportSource instanceReportSource1 = new Telerik.Reporting.InstanceReportSource();
            this.inventoryValueReport1 = new Koontabi.Reporting.InventoryValueReport();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.CloseRadButton = new Telerik.WinControls.UI.RadButton();
            this.ProductsInventoryReportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryValueReport1
            // 
            this.inventoryValueReport1.Name = "InventoryValueReport";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.CloseRadButton);
            this.radPanel1.Controls.Add(this.ProductsInventoryReportViewer);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(856, 698);
            this.radPanel1.TabIndex = 0;
            // 
            // CloseRadButton
            // 
            this.CloseRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseRadButton.Location = new System.Drawing.Point(515, 0);
            this.CloseRadButton.Name = "CloseRadButton";
            this.CloseRadButton.Size = new System.Drawing.Size(57, 24);
            this.CloseRadButton.TabIndex = 1;
            this.CloseRadButton.Text = "Cerrar";
            // 
            // ProductsInventoryReportViewer
            // 
            this.ProductsInventoryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsInventoryReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductsInventoryReportViewer.Name = "ProductsInventoryReportViewer";
            instanceReportSource1.ReportDocument = this.inventoryValueReport1;
            this.ProductsInventoryReportViewer.ReportSource = instanceReportSource1;
            this.ProductsInventoryReportViewer.Size = new System.Drawing.Size(856, 698);
            this.ProductsInventoryReportViewer.TabIndex = 0;
            // 
            // ProductsInventoryRadFormReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseRadButton;
            this.ClientSize = new System.Drawing.Size(856, 698);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsInventoryRadFormReportView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsInventoryRadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryValueReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton CloseRadButton;
        private Telerik.ReportViewer.WinForms.ReportViewer ProductsInventoryReportViewer;
        private Koontabi.Reporting.InventoryValueReport inventoryValueReport1;
    }
}
