namespace ComputerStore
{
    partial class ProductForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.productNametextbox = new System.Windows.Forms.TextBox();
            this.weighttextbox = new System.Windows.Forms.TextBox();
            this.heighttextbox = new System.Windows.Forms.TextBox();
            this.brandtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productlistbox = new System.Windows.Forms.ListBox();
            this.getallproducts = new System.Windows.Forms.Button();
            this.addproductbutton = new System.Windows.Forms.Button();
            this.categorySortCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productIDtextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.removeproductbutton = new System.Windows.Forms.Button();
            this.widthtextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.costtextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lengthtextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.categoryproductcombobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.opitonToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // opitonToolStripMenuItem
            // 
            this.opitonToolStripMenuItem.Name = "opitonToolStripMenuItem";
            this.opitonToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.opitonToolStripMenuItem.Text = "Opiton";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // productNametextbox
            // 
            this.productNametextbox.Location = new System.Drawing.Point(180, 62);
            this.productNametextbox.Name = "productNametextbox";
            this.productNametextbox.Size = new System.Drawing.Size(100, 20);
            this.productNametextbox.TabIndex = 2;
            this.productNametextbox.MouseEnter += new System.EventHandler(this.productNametextbox_MouseEnter);
            // 
            // weighttextbox
            // 
            this.weighttextbox.Location = new System.Drawing.Point(180, 113);
            this.weighttextbox.Name = "weighttextbox";
            this.weighttextbox.Size = new System.Drawing.Size(100, 20);
            this.weighttextbox.TabIndex = 3;
            this.weighttextbox.MouseHover += new System.EventHandler(this.weighttextbox_MouseHover);
            // 
            // heighttextbox
            // 
            this.heighttextbox.Location = new System.Drawing.Point(180, 166);
            this.heighttextbox.Name = "heighttextbox";
            this.heighttextbox.Size = new System.Drawing.Size(100, 20);
            this.heighttextbox.TabIndex = 4;
            this.heighttextbox.MouseHover += new System.EventHandler(this.heighttextbox_MouseHover);
            // 
            // brandtextbox
            // 
            this.brandtextbox.Location = new System.Drawing.Point(180, 232);
            this.brandtextbox.Name = "brandtextbox";
            this.brandtextbox.Size = new System.Drawing.Size(100, 20);
            this.brandtextbox.TabIndex = 5;
            this.brandtextbox.MouseHover += new System.EventHandler(this.brandtextbox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Brand";
            // 
            // productlistbox
            // 
            this.productlistbox.FormattingEnabled = true;
            this.productlistbox.Location = new System.Drawing.Point(423, 68);
            this.productlistbox.Name = "productlistbox";
            this.productlistbox.Size = new System.Drawing.Size(332, 329);
            this.productlistbox.TabIndex = 10;
            this.productlistbox.Visible = false;
            // 
            // getallproducts
            // 
            this.getallproducts.Location = new System.Drawing.Point(644, 432);
            this.getallproducts.Name = "getallproducts";
            this.getallproducts.Size = new System.Drawing.Size(111, 23);
            this.getallproducts.TabIndex = 11;
            this.getallproducts.Text = "Get All Products";
            this.getallproducts.UseVisualStyleBackColor = true;
            this.getallproducts.Click += new System.EventHandler(this.getallproducts_Click);
            this.getallproducts.MouseHover += new System.EventHandler(this.getallproducts_MouseHover);
            // 
            // addproductbutton
            // 
            this.addproductbutton.Location = new System.Drawing.Point(122, 432);
            this.addproductbutton.Name = "addproductbutton";
            this.addproductbutton.Size = new System.Drawing.Size(91, 23);
            this.addproductbutton.TabIndex = 12;
            this.addproductbutton.Text = "Add Product";
            this.addproductbutton.UseVisualStyleBackColor = true;
            this.addproductbutton.Click += new System.EventHandler(this.addproductbutton_Click);
            this.addproductbutton.MouseHover += new System.EventHandler(this.addproductbutton_MouseHover);
            // 
            // categorySortCombobox
            // 
            this.categorySortCombobox.FormattingEnabled = true;
            this.categorySortCombobox.Location = new System.Drawing.Point(554, 32);
            this.categorySortCombobox.Name = "categorySortCombobox";
            this.categorySortCombobox.Size = new System.Drawing.Size(121, 21);
            this.categorySortCombobox.TabIndex = 26;
            this.categorySortCombobox.SelectedIndexChanged += new System.EventHandler(this.categorySortCombobox_SelectedIndexChanged);
            this.categorySortCombobox.MouseHover += new System.EventHandler(this.categorySortCombobox_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ProductID";
            // 
            // productIDtextbox
            // 
            this.productIDtextbox.Location = new System.Drawing.Point(180, 267);
            this.productIDtextbox.Name = "productIDtextbox";
            this.productIDtextbox.Size = new System.Drawing.Size(100, 20);
            this.productIDtextbox.TabIndex = 16;
            this.productIDtextbox.MouseHover += new System.EventHandler(this.productIDtextbox_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category";
            // 
            // removeproductbutton
            // 
            this.removeproductbutton.Location = new System.Drawing.Point(423, 432);
            this.removeproductbutton.Name = "removeproductbutton";
            this.removeproductbutton.Size = new System.Drawing.Size(109, 23);
            this.removeproductbutton.TabIndex = 19;
            this.removeproductbutton.Text = "Remove Product";
            this.removeproductbutton.UseVisualStyleBackColor = true;
            this.removeproductbutton.Click += new System.EventHandler(this.removeproductbutton_Click);
            this.removeproductbutton.MouseHover += new System.EventHandler(this.removeproductbutton_MouseHover);
            // 
            // widthtextbox
            // 
            this.widthtextbox.Location = new System.Drawing.Point(180, 206);
            this.widthtextbox.Name = "widthtextbox";
            this.widthtextbox.Size = new System.Drawing.Size(100, 20);
            this.widthtextbox.TabIndex = 20;
            this.widthtextbox.MouseHover += new System.EventHandler(this.widthtextbox_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Width";
            // 
            // costtextbox
            // 
            this.costtextbox.Location = new System.Drawing.Point(180, 353);
            this.costtextbox.Name = "costtextbox";
            this.costtextbox.Size = new System.Drawing.Size(100, 20);
            this.costtextbox.TabIndex = 22;
            this.costtextbox.MouseHover += new System.EventHandler(this.costtextbox_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Cost";
            // 
            // lengthtextbox
            // 
            this.lengthtextbox.Location = new System.Drawing.Point(180, 388);
            this.lengthtextbox.Name = "lengthtextbox";
            this.lengthtextbox.Size = new System.Drawing.Size(100, 20);
            this.lengthtextbox.TabIndex = 24;
            this.lengthtextbox.MouseHover += new System.EventHandler(this.lengthtextbox_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Length";
            // 
            // categoryproductcombobox
            // 
            this.categoryproductcombobox.FormattingEnabled = true;
            this.categoryproductcombobox.Location = new System.Drawing.Point(180, 306);
            this.categoryproductcombobox.Name = "categoryproductcombobox";
            this.categoryproductcombobox.Size = new System.Drawing.Size(100, 21);
            this.categoryproductcombobox.TabIndex = 27;
            this.categoryproductcombobox.MouseHover += new System.EventHandler(this.categoryproductcombobox_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 328);
            this.dataGridView1.TabIndex = 28;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categoryproductcombobox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lengthtextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.costtextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.widthtextbox);
            this.Controls.Add(this.removeproductbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productIDtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categorySortCombobox);
            this.Controls.Add(this.addproductbutton);
            this.Controls.Add(this.getallproducts);
            this.Controls.Add(this.productlistbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandtextbox);
            this.Controls.Add(this.heighttextbox);
            this.Controls.Add(this.weighttextbox);
            this.Controls.Add(this.productNametextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.MouseHover += new System.EventHandler(this.ProductForm_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opitonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox productNametextbox;
        private System.Windows.Forms.TextBox weighttextbox;
        private System.Windows.Forms.TextBox heighttextbox;
        private System.Windows.Forms.TextBox brandtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox productlistbox;
        private System.Windows.Forms.Button getallproducts;
        private System.Windows.Forms.Button addproductbutton;
        private System.Windows.Forms.ComboBox categorySortCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productIDtextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button removeproductbutton;
        private System.Windows.Forms.TextBox widthtextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox costtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lengthtextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox categoryproductcombobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}