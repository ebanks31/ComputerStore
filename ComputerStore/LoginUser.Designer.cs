namespace ComputerStore
{
    partial class LoginUser
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.admincheckbox = new System.Windows.Forms.CheckBox();
            this.passwordtextbox = new System.Windows.Forms.MaskedTextBox();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(111, 50);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 9;
            this.usernamelabel.Text = "Username";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(113, 96);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 8;
            this.passwordlabel.Text = "Password";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(200, 50);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(142, 20);
            this.usernametextbox.TabIndex = 1;
            this.usernametextbox.MouseHover += new System.EventHandler(this.usernametextbox_MouseHover);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(142, 165);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 25);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            this.loginbutton.MouseHover += new System.EventHandler(this.loginbutton_MouseHover);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(101, 234);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.ErrorLabel.TabIndex = 8;
            this.ErrorLabel.Text = "label";
            this.ErrorLabel.Visible = false;
            // 
            // admincheckbox
            // 
            this.admincheckbox.AutoSize = true;
            this.admincheckbox.Location = new System.Drawing.Point(116, 133);
            this.admincheckbox.Name = "admincheckbox";
            this.admincheckbox.Size = new System.Drawing.Size(171, 17);
            this.admincheckbox.TabIndex = 3;
            this.admincheckbox.Text = "Check to login as Administrator";
            this.admincheckbox.UseVisualStyleBackColor = true;
            this.admincheckbox.MouseHover += new System.EventHandler(this.admincheckbox_MouseHover);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(200, 96);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(142, 20);
            this.passwordtextbox.TabIndex = 2;
            this.passwordtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtextbox_KeyDown);
            this.passwordtextbox.MouseHover += new System.EventHandler(this.passwordtextbox_MouseHover);
            // 
            // Registerbutton
            // 
            this.Registerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Registerbutton.Location = new System.Drawing.Point(290, 166);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 5;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            this.Registerbutton.MouseHover += new System.EventHandler(this.Registerbutton_MouseHover);
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 300);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.admincheckbox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginUser";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            this.MouseHover += new System.EventHandler(this.LoginUser_MouseHover);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.CheckBox admincheckbox;
        private System.Windows.Forms.MaskedTextBox passwordtextbox;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}