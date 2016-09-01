namespace KoontabiTelerikWinFormsApp.ReportViewForm
{
    partial class DisplayAllSalesByCustomerRadFormReportView
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
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.CloseRadButton = new Telerik.WinControls.UI.RadButton();
            this.displayAllSalesByCustomerReport = new Koontabi.Reporting.DisplayAllSalesByCustomerReport();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllSalesByCustomerReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.CloseRadButton);
            this.radPanel1.Controls.Add(this.reportViewer1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(869, 668);
            this.radPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            instanceReportSource1.ReportDocument = this.displayAllSalesByCustomerReport;
            this.reportViewer1.ReportSource = instanceReportSource1;
            this.reportViewer1.Size = new System.Drawing.Size(869, 668);
            this.reportViewer1.TabIndex = 0;
            // 
            // CloseRadButton
            // 
            this.CloseRadButton.Location = new System.Drawing.Point(516, 0);
            this.CloseRadButton.Name = "CloseRadButton";
            this.CloseRadButton.Size = new System.Drawing.Size(51, 24);
            this.CloseRadButton.TabIndex = 1;
            this.CloseRadButton.Text = "Cerrar";
            // 
            // displayAllSalesByCustomerReport
            // 
            this.displayAllSalesByCustomerReport.Name = "DisplayAllSalesByCustomerReport";
            // 
            // DisplayAllSalesByCustomerRadFormReportView_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 668);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayAllSalesByCustomerRadFormReportView_cs";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayAllSalesByCustomerRadFormReportView_cs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayAllSalesByCustomerRadFormReportView_cs_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayAllSalesByCustomerReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton CloseRadButton;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private Koontabi.Reporting.DisplayAllSalesByCustomerReport displayAllSalesByCustomerReport;
    }
}
