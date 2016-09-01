namespace KoontabiTelerikWinFormsApp
{
    partial class SearchRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchRadForm));
            this.ItemsRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.AceptRadButton = new Telerik.WinControls.UI.RadButton();
            this.CancelRadButton = new Telerik.WinControls.UI.RadButton();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceptRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsRadGridView
            // 
            this.ItemsRadGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsRadGridView.Location = new System.Drawing.Point(12, 12);
            // 
            // ItemsRadGridView
            // 
            this.ItemsRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.ItemsRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.ItemsRadGridView.MasterTemplate.AllowEditRow = false;
            this.ItemsRadGridView.MasterTemplate.AllowSearchRow = true;
            this.ItemsRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.ItemsRadGridView.Name = "ItemsRadGridView";
            this.ItemsRadGridView.Size = new System.Drawing.Size(473, 266);
            this.ItemsRadGridView.TabIndex = 0;
            this.ItemsRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.ItemsRadGridView_CellClick);
            // 
            // AceptRadButton
            // 
            this.AceptRadButton.Location = new System.Drawing.Point(289, 295);
            this.AceptRadButton.Name = "AceptRadButton";
            this.AceptRadButton.Size = new System.Drawing.Size(95, 80);
            this.AceptRadButton.TabIndex = 2;
            this.AceptRadButton.Text = "&Aceptar";
            this.AceptRadButton.Click += new System.EventHandler(this.AceptRadButton_Click);
            // 
            // CancelRadButton
            // 
            this.CancelRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelRadButton.Location = new System.Drawing.Point(390, 295);
            this.CancelRadButton.Name = "CancelRadButton";
            this.CancelRadButton.Size = new System.Drawing.Size(95, 80);
            this.CancelRadButton.TabIndex = 3;
            this.CancelRadButton.Text = "&Cancelar";
            this.CancelRadButton.Click += new System.EventHandler(this.CancelRadButton_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 1000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // SearchRadForm
            // 
            this.AcceptButton = this.AceptRadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRadButton;
            this.ClientSize = new System.Drawing.Size(497, 378);
            this.Controls.Add(this.CancelRadButton);
            this.Controls.Add(this.AceptRadButton);
            this.Controls.Add(this.ItemsRadGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchRadForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AceptRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView ItemsRadGridView;
        private Telerik.WinControls.UI.RadButton AceptRadButton;
        private Telerik.WinControls.UI.RadButton CancelRadButton;
        private System.Windows.Forms.Timer MyTimer;
    }
}
