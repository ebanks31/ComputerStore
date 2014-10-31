namespace ComputerStore
{
    partial class ClientStore
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewOrderButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetAllProducts = new System.Windows.Forms.Button();
            this.categorySortcombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Removeorderbutton = new System.Windows.Forms.Button();
            this.AccountInfoButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
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
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(379, 407);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(131, 23);
            this.PlaceOrderButton.TabIndex = 3;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            this.PlaceOrderButton.MouseEnter += new System.EventHandler(this.PlaceOrderButton_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Products";
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.Location = new System.Drawing.Point(742, 406);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(130, 23);
            this.ViewOrderButton.TabIndex = 8;
            this.ViewOrderButton.Text = "View Current Orders";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            this.ViewOrderButton.MouseHover += new System.EventHandler(this.ViewOrderButton_MouseHover);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 251);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // GetAllProducts
            // 
            this.GetAllProducts.Location = new System.Drawing.Point(79, 407);
            this.GetAllProducts.Name = "GetAllProducts";
            this.GetAllProducts.Size = new System.Drawing.Size(99, 23);
            this.GetAllProducts.TabIndex = 11;
            this.GetAllProducts.Text = "Get All Products";
            this.GetAllProducts.UseVisualStyleBackColor = true;
            this.GetAllProducts.Click += new System.EventHandler(this.GetAllProducts_Click);
            this.GetAllProducts.MouseHover += new System.EventHandler(this.GetAllProducts_MouseHover);
            // 
            // categorySortcombobox
            // 
            this.categorySortcombobox.FormattingEnabled = true;
            this.categorySortcombobox.Location = new System.Drawing.Point(132, 452);
            this.categorySortcombobox.Name = "categorySortcombobox";
            this.categorySortcombobox.Size = new System.Drawing.Size(121, 21);
            this.categorySortcombobox.TabIndex = 12;
            this.categorySortcombobox.SelectedIndexChanged += new System.EventHandler(this.categorySortcombobox_SelectedIndexChanged);
            this.categorySortcombobox.MouseHover += new System.EventHandler(this.categorySortcombobox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sort";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 330);
            this.dataGridView1.TabIndex = 14;
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.Location = new System.Drawing.Point(410, 456);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(100, 20);
            this.quantitytextbox.TabIndex = 15;
            this.quantitytextbox.MouseHover += new System.EventHandler(this.quantitytextbox_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantity";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(574, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(446, 330);
            this.dataGridView2.TabIndex = 17;
            // 
            // Removeorderbutton
            // 
            this.Removeorderbutton.Location = new System.Drawing.Point(607, 406);
            this.Removeorderbutton.Name = "Removeorderbutton";
            this.Removeorderbutton.Size = new System.Drawing.Size(106, 23);
            this.Removeorderbutton.TabIndex = 18;
            this.Removeorderbutton.Text = "Remove Order";
            this.Removeorderbutton.UseVisualStyleBackColor = true;
            this.Removeorderbutton.Click += new System.EventHandler(this.Removeorderbutton_Click);
            this.Removeorderbutton.MouseHover += new System.EventHandler(this.Removeorderbutton_MouseHover);
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.Location = new System.Drawing.Point(607, 452);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Size = new System.Drawing.Size(160, 23);
            this.AccountInfoButton.TabIndex = 19;
            this.AccountInfoButton.Text = "View Account Information";
            this.AccountInfoButton.UseVisualStyleBackColor = true;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            this.AccountInfoButton.MouseHover += new System.EventHandler(this.AccountInfoButton_MouseHover);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(767, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Orders";
            // 
            // ClientStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AccountInfoButton);
            this.Controls.Add(this.Removeorderbutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorySortcombobox);
            this.Controls.Add(this.GetAllProducts);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ViewOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientStore";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.ClientStore_Load);
            this.MouseHover += new System.EventHandler(this.ClientStore_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewOrderButton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetAllProducts;
        private System.Windows.Forms.ComboBox categorySortcombobox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Removeorderbutton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button AccountInfoButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
    }
}

