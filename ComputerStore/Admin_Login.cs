using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }



        private void Admin_Login_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }



        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AdminUserOptions adminuseroption = new AdminUserOptions();
            adminuseroption.Show();
        }

        private void ProductOptions_Click(object sender, EventArgs e)
        {
            ProductForm productform = new ProductForm();
            productform.Show();
        }

        private void CustomerOptionsbutton_Click(object sender, EventArgs e)
        {
            CustomerOptions customer = new CustomerOptions();
            customer.Show();
        }

        private void SQLbutton_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Show();
        }

        private void CustomerOptionsbutton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change Customer Options";
        }

        private void AddUserButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change User Options";
        }

        private void ProductOptions_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change Product Options";
        }

        private void SQLbutton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to look at SQL Form";
        }

        private void Admin_Login_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }



    }
}
