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
    public partial class Account : Form
    {
        /// <summary>
        /// Default Constructor of Account Class
        /// </summary>
        public Account()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Button to change the password of current user
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            
            UserLogin userlogin = new UserLogin();
            Customer customer = new Customer();
            List<User> userlist = userlogin.DeserializeLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);
            string password = passwordtextBox1.Text;

            customer.Changepassword(User.currentuser, userlist, password);

        }


        /// <summary>
        /// Button to Change Email of current User
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
           
            Customer customer = new Customer();
            List<User> userlist = userlogin.DeserializeLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);
            string email = emailpasswordtextBox2.Text;


            customer.ChangeEmail(Customer.currentcustomer, email);

        }

        /// <summary>
        /// Button to Change Address of current user
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void changeaddressbutton4_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
            Customer customer = new Customer();
            List<User> userlist = userlogin.DeserializeLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);
            string address = addresstextBox3.Text;


            customer.ChangeAddress(Customer.currentcustomer, address);
        }


        /// <summary>
        /// Button to Change Phone number of Current User
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e"></param>
        private void PhoneNumberbutton_Click(object sender, EventArgs e)
        {
            UserLogin userlogin = new UserLogin();
            Customer customer = new Customer();
            List<User> userlist = userlogin.DeserializeLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);
            string phonenumber = phonenumbertextBox4.Text;

            

            customer.ChangePhoneNumber(Customer.currentcustomer, phonenumber);

        }

        private void Account_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ChangePasswordButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change password";
        }

        private void ChangeEmailButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change email";
        }

        private void changeaddressbutton4_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change address";
        }

        private void PhoneNumberbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to change phone number";
        }
    }
}
