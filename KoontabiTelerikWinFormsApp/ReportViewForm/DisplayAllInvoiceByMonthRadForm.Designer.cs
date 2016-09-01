namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    partial class DisplayAllInvoiceByMonthRadForm
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.reportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.CloseRadButton = new Telerik.WinControls.UI.RadButton();
            this.displayAllInvoicesByMonthsReport = new Koontabi.Reporting.DisplayAllInvoicesByMonthsReport();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllInvoicesByMonthsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.CloseRadButton);
            this.radPanel1.Controls.Add(this.reportViewer);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(877, 698);
            this.radPanel1.TabIndex = 0;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            instanceReportSource1.ReportDocument = this.displayAllInvoicesByMonthsReport;
            this.reportViewer.ReportSource = instanceReportSource1;
            this.reportViewer.Size = new System.Drawing.Size(877, 698);
            this.reportViewer.TabIndex = 0;
            // 
            // CloseRadButton
            // 
            this.CloseRadButton.Location = new System.Drawing.Point(516, 0);
            this.CloseRadButton.Name = "CloseRadButton";
            this.CloseRadButton.Size = new System.Drawing.Size(51, 24);
            this.CloseRadButton.TabIndex = 1;
            this.CloseRadButton.Text = "Cerrar";
            // 
            // displayAllInvoicesByMonthsReport
            // 
            this.displayAllInvoicesByMonthsReport.Name = "DisplayAllInvoicesByMonthsReport";
            // 
            // DisplayAllInvoiceByMonthRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 698);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayAllInvoiceByMonthRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayAllInvoiceByMonthRadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayAllInvoiceByMonthRadForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllInvoicesByMonthsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton CloseRadButton;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer;
        private Koontabi.Reporting.DisplayAllInvoicesByMonthsReport displayAllInvoicesByMonthsReport;
    }
}
