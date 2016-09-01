namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    partial class DisplayAllSalesRadForm
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
            Telerik.Reporting.InstanceReportSource instanceReportSource2 = new Telerik.Reporting.InstanceReportSource();
            this.displayAllSalesReport = new Koontabi.Reporting.DisplayAllSalesReport();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseRadButton = new Telerik.WinControls.UI.RadButton();
            this.reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllSalesReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // displayAllSalesReport
            // 
            this.displayAllSalesReport.Name = "DisplayAllSalesReport";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseRadButton);
            this.panel1.Controls.Add(this.reportViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 728);
            this.panel1.TabIndex = 0;
            // 
            // CloseRadButton
            // 
            this.CloseRadButton.Location = new System.Drawing.Point(516, 0);
            this.CloseRadButton.Name = "CloseRadButton";
            this.CloseRadButton.Size = new System.Drawing.Size(51, 24);
            this.CloseRadButton.TabIndex = 1;
            this.CloseRadButton.Text = "Cerrar";
            this.CloseRadButton.Click += new System.EventHandler(this.CloseRadButton_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            instanceReportSource2.ReportDocument = this.displayAllSalesReport;
            this.reportViewer.ReportSource = instanceReportSource2;
            this.reportViewer.Size = new System.Drawing.Size(885, 728);
            this.reportViewer.TabIndex = 0;
            // 
            // DisplayAllSalesRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 728);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayAllSalesRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.displayAllSalesReport)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton CloseRadButton;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer;
        private Koontabi.Reporting.DisplayAllSalesReport displayAllSalesReport;
    }
}
