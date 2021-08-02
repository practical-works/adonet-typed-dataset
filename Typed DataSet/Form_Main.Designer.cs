namespace GroceryManager
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_products = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStripPanel_top = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel_bottom = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel_left = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel_right = new System.Windows.Forms.ToolStripPanel();
            this.toolStrip_main.SuspendLayout();
            this.toolStripPanel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_products
            // 
            this.button_products.Image = global::GroceryManager.Properties.Resources.box;
            this.button_products.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(74, 22);
            this.button_products.Text = "Products";
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_products});
            this.toolStrip_main.Location = new System.Drawing.Point(3, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(86, 25);
            this.toolStrip_main.TabIndex = 1;
            // 
            // toolStripPanel_top
            // 
            this.toolStripPanel_top.Controls.Add(this.toolStrip_main);
            this.toolStripPanel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanel_top.Location = new System.Drawing.Point(0, 0);
            this.toolStripPanel_top.Name = "toolStripPanel_top";
            this.toolStripPanel_top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel_top.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel_top.Size = new System.Drawing.Size(1061, 25);
            // 
            // toolStripPanel_bottom
            // 
            this.toolStripPanel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripPanel_bottom.Location = new System.Drawing.Point(0, 506);
            this.toolStripPanel_bottom.Name = "toolStripPanel_bottom";
            this.toolStripPanel_bottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel_bottom.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel_bottom.Size = new System.Drawing.Size(1061, 0);
            // 
            // toolStripPanel_left
            // 
            this.toolStripPanel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripPanel_left.Location = new System.Drawing.Point(0, 25);
            this.toolStripPanel_left.Name = "toolStripPanel_left";
            this.toolStripPanel_left.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel_left.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanel_left.Size = new System.Drawing.Size(0, 481);
            // 
            // toolStripPanel_right
            // 
            this.toolStripPanel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripPanel_right.Location = new System.Drawing.Point(1061, 25);
            this.toolStripPanel_right.Name = "toolStripPanel_right";
            this.toolStripPanel_right.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel_right.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanel_right.Size = new System.Drawing.Size(0, 481);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 506);
            this.Controls.Add(this.toolStripPanel_right);
            this.Controls.Add(this.toolStripPanel_left);
            this.Controls.Add(this.toolStripPanel_bottom);
            this.Controls.Add(this.toolStripPanel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Manager (Example)";
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.toolStripPanel_top.ResumeLayout(false);
            this.toolStripPanel_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton button_products;
        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_top;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_bottom;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_left;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_right;

    }
}

