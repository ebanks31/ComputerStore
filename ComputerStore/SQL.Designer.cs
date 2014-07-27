namespace ComputerStore
{
    partial class SQL
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
            this.querybutton = new System.Windows.Forms.Button();
            this.querybox = new System.Windows.Forms.RichTextBox();
            this.resultbox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // querybutton
            // 
            this.querybutton.Location = new System.Drawing.Point(117, 350);
            this.querybutton.Name = "querybutton";
            this.querybutton.Size = new System.Drawing.Size(75, 23);
            this.querybutton.TabIndex = 0;
            this.querybutton.Text = "Query";
            this.querybutton.UseVisualStyleBackColor = true;
            this.querybutton.Click += new System.EventHandler(this.querybutton_Click);
            // 
            // querybox
            // 
            this.querybox.Location = new System.Drawing.Point(39, 12);
            this.querybox.Name = "querybox";
            this.querybox.Size = new System.Drawing.Size(239, 312);
            this.querybox.TabIndex = 1;
            this.querybox.Text = "";
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(301, 13);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(270, 319);
            this.resultbox.TabIndex = 2;
            this.resultbox.Text = "";
            this.resultbox.TextChanged += new System.EventHandler(this.resultbox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Translate to HTML";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.querybox);
            this.Controls.Add(this.querybutton);
            this.Name = "SQL";
            this.Text = "SQL";
            this.Load += new System.EventHandler(this.SQL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button querybutton;
        private System.Windows.Forms.RichTextBox querybox;
        private System.Windows.Forms.RichTextBox resultbox;
        private System.Windows.Forms.Button button2;
    }
}