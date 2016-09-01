namespace KoontabiTelerikWinFormsApp
{
    partial class UnitRadForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitRadForm));
            this.OperationsRadGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.LookUnitRadButton = new Telerik.WinControls.UI.RadButton();
            this.EditUnitRadButton = new Telerik.WinControls.UI.RadButton();
            this.DeleteUnitRadButton = new Telerik.WinControls.UI.RadButton();
            this.NewUnitRadButton = new Telerik.WinControls.UI.RadButton();
            this.UnitsRadGridView = new Telerik.WinControls.UI.RadGridView();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).BeginInit();
            this.OperationsRadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUnitRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUnitRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteUnitRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewUnitRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsRadGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsRadGroupBox
            // 
            this.OperationsRadGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.OperationsRadGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationsRadGroupBox.Controls.Add(this.LookUnitRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.EditUnitRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.DeleteUnitRadButton);
            this.OperationsRadGroupBox.Controls.Add(this.NewUnitRadButton);
            this.OperationsRadGroupBox.HeaderText = "Operaciones";
            this.OperationsRadGroupBox.Location = new System.Drawing.Point(16, 326);
            this.OperationsRadGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OperationsRadGroupBox.Name = "OperationsRadGroupBox";
            this.OperationsRadGroupBox.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.OperationsRadGroupBox.Size = new System.Drawing.Size(569, 123);
            this.OperationsRadGroupBox.TabIndex = 5;
            this.OperationsRadGroupBox.Text = "Operaciones";
            // 
            // LookUnitRadButton
            // 
            this.LookUnitRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LookUnitRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.order_history;
            this.LookUnitRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.LookUnitRadButton.Location = new System.Drawing.Point(419, 26);
            this.LookUnitRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LookUnitRadButton.Name = "LookUnitRadButton";
            this.LookUnitRadButton.Size = new System.Drawing.Size(121, 84);
            this.LookUnitRadButton.TabIndex = 4;
            this.LookUnitRadButton.Text = "Ver";
            this.LookUnitRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.LookUnitRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LookUnitRadButton.Click += new System.EventHandler(this.LookUnitRadButton_Click);
            // 
            // EditUnitRadButton
            // 
            this.EditUnitRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditUnitRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.edit;
            this.EditUnitRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditUnitRadButton.Location = new System.Drawing.Point(289, 26);
            this.EditUnitRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditUnitRadButton.Name = "EditUnitRadButton";
            this.EditUnitRadButton.Size = new System.Drawing.Size(121, 84);
            this.EditUnitRadButton.TabIndex = 3;
            this.EditUnitRadButton.Text = "Editar";
            this.EditUnitRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.EditUnitRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditUnitRadButton.Click += new System.EventHandler(this.EditUnitRadButton_Click);
            // 
            // DeleteUnitRadButton
            // 
            this.DeleteUnitRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteUnitRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.delete;
            this.DeleteUnitRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteUnitRadButton.Location = new System.Drawing.Point(160, 26);
            this.DeleteUnitRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteUnitRadButton.Name = "DeleteUnitRadButton";
            this.DeleteUnitRadButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteUnitRadButton.TabIndex = 2;
            this.DeleteUnitRadButton.Text = "Eliminar";
            this.DeleteUnitRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteUnitRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteUnitRadButton.Click += new System.EventHandler(this.DeleteUnitRadButton_Click);
            // 
            // NewUnitRadButton
            // 
            this.NewUnitRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewUnitRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.add1;
            this.NewUnitRadButton.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewUnitRadButton.Location = new System.Drawing.Point(31, 26);
            this.NewUnitRadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewUnitRadButton.Name = "NewUnitRadButton";
            this.NewUnitRadButton.Size = new System.Drawing.Size(121, 84);
            this.NewUnitRadButton.TabIndex = 1;
            this.NewUnitRadButton.Text = "Nuevo";
            this.NewUnitRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.NewUnitRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewUnitRadButton.Click += new System.EventHandler(this.NewUnitRadButton_Click);
            // 
            // UnitsRadGridView
            // 
            this.UnitsRadGridView.AutoSizeRows = true;
            this.UnitsRadGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.UnitsRadGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnitsRadGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UnitsRadGridView.ForeColor = System.Drawing.Color.Black;
            this.UnitsRadGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UnitsRadGridView.Location = new System.Drawing.Point(16, 15);
            this.UnitsRadGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // UnitsRadGridView
            // 
            this.UnitsRadGridView.MasterTemplate.AllowAddNewRow = false;
            this.UnitsRadGridView.MasterTemplate.AllowDeleteRow = false;
            this.UnitsRadGridView.MasterTemplate.AllowDragToGroup = false;
            this.UnitsRadGridView.MasterTemplate.AllowEditRow = false;
            this.UnitsRadGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "UnitID";
            gridViewTextBoxColumn1.HeaderText = "UnitID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "UnitID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "UnitDescription";
            gridViewTextBoxColumn2.HeaderText = "Unidad de Medida";
            gridViewTextBoxColumn2.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "UnitDescription";
            gridViewTextBoxColumn2.Width = 275;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Abbreviation";
            gridViewTextBoxColumn3.HeaderText = "Abreviatura";
            gridViewTextBoxColumn3.Name = "Abbreviation";
            gridViewTextBoxColumn3.Width = 275;
            this.UnitsRadGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.UnitsRadGridView.MasterTemplate.EnableGrouping = false;
            this.UnitsRadGridView.Name = "UnitsRadGridView";
            this.UnitsRadGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnitsRadGridView.ShowGroupPanel = false;
            this.UnitsRadGridView.Size = new System.Drawing.Size(569, 304);
            this.UnitsRadGridView.TabIndex = 6;
            this.UnitsRadGridView.Text = "radGridView1";
            this.UnitsRadGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.UnitsRadGridView_CellClick);
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // UnitRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 477);
            this.Controls.Add(this.UnitsRadGridView);
            this.Controls.Add(this.OperationsRadGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad de medida";
            this.Load += new System.EventHandler(this.UnitRadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRadGroupBox)).EndInit();
            this.OperationsRadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LookUnitRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditUnitRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteUnitRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewUnitRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsRadGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox OperationsRadGroupBox;
        private Telerik.WinControls.UI.RadButton LookUnitRadButton;
        private Telerik.WinControls.UI.RadButton EditUnitRadButton;
        private Telerik.WinControls.UI.RadButton DeleteUnitRadButton;
        private Telerik.WinControls.UI.RadButton NewUnitRadButton;
        private Telerik.WinControls.UI.RadGridView UnitsRadGridView;
        private System.Windows.Forms.Timer MyTimer;
    }
}
