namespace Tutorial
{
    partial class mainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainContainer));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBySearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.addNewProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 48);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNewProductToolStripMenuItem.Text = "Add new product";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductsToolStripMenuItem,
            this.deletToolStripMenuItem,
            this.updateProductsToolStripMenuItem,
            this.displayAllToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productsToolStripMenuItem.Text = "Production";
            // 
            // addNewProductsToolStripMenuItem
            // 
            this.addNewProductsToolStripMenuItem.Name = "addNewProductsToolStripMenuItem";
            this.addNewProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewProductsToolStripMenuItem.Text = "Add new Product";
            this.addNewProductsToolStripMenuItem.Click += new System.EventHandler(this.addNewProductsToolStripMenuItem_Click);
            // 
            // updateProductsToolStripMenuItem
            // 
            this.updateProductsToolStripMenuItem.Name = "updateProductsToolStripMenuItem";
            this.updateProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateProductsToolStripMenuItem.Text = "Update Product";
            // 
            // displayAllToolStripMenuItem
            // 
            this.displayAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllToolStripMenuItem1,
            this.displayBySearchToolStripMenuItem});
            this.displayAllToolStripMenuItem.Name = "displayAllToolStripMenuItem";
            this.displayAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayAllToolStripMenuItem.Text = "Display";
            // 
            // displayAllToolStripMenuItem1
            // 
            this.displayAllToolStripMenuItem1.Name = "displayAllToolStripMenuItem1";
            this.displayAllToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.displayAllToolStripMenuItem1.Text = "Display all";
            this.displayAllToolStripMenuItem1.Click += new System.EventHandler(this.displayAllToolStripMenuItem1_Click);
            // 
            // displayBySearchToolStripMenuItem
            // 
            this.displayBySearchToolStripMenuItem.Name = "displayBySearchToolStripMenuItem";
            this.displayBySearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayBySearchToolStripMenuItem.Text = "Display by Search";
            this.displayBySearchToolStripMenuItem.Click += new System.EventHandler(this.displayBySearchToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // deletToolStripMenuItem
            // 
            this.deletToolStripMenuItem.Name = "deletToolStripMenuItem";
            this.deletToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletToolStripMenuItem.Text = "Delete Product";
            this.deletToolStripMenuItem.Click += new System.EventHandler(this.deletToolStripMenuItem_Click);
            // 
            // mainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 494);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainContainer";
            this.Text = "KN Manufacturing Company";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayBySearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletToolStripMenuItem;
    }
}