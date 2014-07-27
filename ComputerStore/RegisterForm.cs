using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ComputerStore
{
    public partial class RegisterForm : Form
    {

        /// <summary>
        /// Default Constructor of Register Form Class
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button that cancel a customer's registration.
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginUser login = new LoginUser();
            login.Show();
            login.Focus();
        }

        /// <summary>
        /// Button that registers a customer 
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void Registerbutton1_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
            LoginUser login = new LoginUser();
            //TO DO NEXT
            Register registerclass = new Register();
            
            string username = UsernametextBox1.Text;
            string password = PasswordtextBox2.Text;
            string address = AddresstextBox5.Text;
            string firstname = FirstNametextBox3.Text;
            string lastname = LastNametextBox4.Text;
            string phonenumber = PhonenumbertextBox6.Text;
            string email = EmailtextBox.Text;

            userlogin.UsernamePasswordValidation(username, password);
            registerclass.ValidateRegisterFields(firstname, lastname, address, phonenumber, email);
            DisplayLabel.Text = registerclass.ValidAllRegisterFields(DisplayLabel.Text,userlogin);

            if (registerclass.ValidCustomer == true)
            {
                DateTime lastlogindate = DateTime.Now;
                DateTime lastpurchasedate = lastlogindate;
                User user = new User(username, password);
                Customer customer1 = new Customer();

                int customerid = customer1.incrementCustomerNumber(userlogin.DeserializeLogin());
                Customer customer = new Customer(customerid, user, firstname, lastname, address, email, phonenumber, lastlogindate);
                ArrayList list = customer.AddCustomerToArraylist(customerid.ToString(), user.Username, firstname, lastname, email, phonenumber, address, lastlogindate.ToString(), lastpurchasedate.ToString());
                customer.AddUser(user);
                customer.AddCustomer(customer);
                customer.InsertDatabase(list);
                Customer.currentcustomer = customer;

                MessageBox.Show("You have successfully registered. Please login");

                login.Show();
                login.Focus();
            }
            else
            {
                UsernametextBox1.Clear();
                PasswordtextBox2.Clear();
                AddresstextBox5.Clear();
                FirstNametextBox3.Clear();
                LastNametextBox4.Clear();
                PhonenumbertextBox6.Clear();
                EmailtextBox.Clear();
            }
        }

        /// <summary>
        /// Key Event for Register Form Class
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && !Cancelbutton1.Focused)
            {
                Registerbutton1_Click(sender, e);
            }
            else
            {
                Cancelbutton1_Click(sender, e);
            }
        }

        private void Registerbutton1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to Register";
        }

        private void RegisterForm_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void UsernametextBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Username";
        }

        private void PasswordtextBox2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Password";
        }

        private void FirstNametextBox3_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter First name";
        }

        private void LastNametextBox4_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Last Name";
        }

        private void AddresstextBox5_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid address";
        }

        private void Cancelbutton1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Cancel and go back to Client Store Form";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void PhonenumbertextBox6_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid phone number";
        }

        private void EmailtextBox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid email";
        }

    }
}
