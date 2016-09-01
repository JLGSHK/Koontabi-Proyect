namespace KoontabiTelerikWinFormsApp
{
    partial class InventoryReportRadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReportRadForm));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.ProductsInventoryRadButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsInventoryRadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton3);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.ProductsInventoryRadButton);
            this.radGroupBox1.HeaderText = "Inventario";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(719, 183);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Inventario";
            // 
            // radButton3
            // 
            this.radButton3.Enabled = false;
            this.radButton3.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.kardexReport;
            this.radButton3.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton3.Location = new System.Drawing.Point(279, 21);
            this.radButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(125, 84);
            this.radButton3.TabIndex = 0;
            this.radButton3.Text = "Kardex";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radButton2
            // 
            this.radButton2.Enabled = false;
            this.radButton2.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.ListOfProductOfficial;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton2.Location = new System.Drawing.Point(142, 21);
            this.radButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(125, 84);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "Listado de Producto";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ProductsInventoryRadButton
            // 
            this.ProductsInventoryRadButton.Image = global::KoontabiTelerikWinFormsApp.Properties.Resources.InventoryValue;
            this.ProductsInventoryRadButton.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.ProductsInventoryRadButton.Location = new System.Drawing.Point(5, 21);
            this.ProductsInventoryRadButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsInventoryRadButton.Name = "ProductsInventoryRadButton";
            this.ProductsInventoryRadButton.Size = new System.Drawing.Size(125, 84);
            this.ProductsInventoryRadButton.TabIndex = 0;
            this.ProductsInventoryRadButton.Text = "Valor del Inventario";
            this.ProductsInventoryRadButton.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsInventoryRadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductsInventoryRadButton.Click += new System.EventHandler(this.ProductsInventoryRadButton_Click);
            // 
            // InventoryReportRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 400);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "InventoryReportRadForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsInventoryRadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton ProductsInventoryRadButton;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
    }
}
