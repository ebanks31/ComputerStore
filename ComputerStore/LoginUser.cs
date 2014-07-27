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
    public partial class LoginUser : Form
    {
        /// <summary>
        /// Constructor of LoginUser Form. 
        /// </summary>
        public LoginUser()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Login Button Click Event. Login a user given a valid username and password
        /// </summary>
        /// <param name="sender">Sender of Event</param>
        /// <param name="e">Event Arguments</param>
        private void loginbutton_Click(object sender, EventArgs e)
        {

            string username = usernametextbox.Text;
            string password = passwordtextbox.Text;

            UserLogin userlogin =  new UserLogin();
            bool usernamepasswordinvalid = userlogin.UsernamePasswordValidation(username, password);

            //checks if Username or Password is valid.
            if (userlogin.UsernameValid == false || userlogin.PasswordValid == false)
            {

                userlogin.DisplayInvalidUsernamePasswordMessage(ErrorLabel);

            }
            else if(admincheckbox.Checked==true)
                {
                //Check if Admin User box is checked
                    AdminUser adminuser = new AdminUser();
                    ErrorLabel.Text = "";

                    if(adminuser.isAdminUser(username,password))
                    {
                        Admin_Login adminlogin = new Admin_Login();
                        adminlogin.Show();
                    }
                    else
                    {
                        userlogin.DisplayInvalidUsernamePasswordMessage(ErrorLabel);
                    }

 
                }
                else //Show Regular User Form
                {
        
                    User user = new User(username, password);

                    List<User> userlist = userlogin.DeserializeLogin();
                
                    bool validuser = userlogin.CheckValidUser(user, userlist);

                    Customer customer = new Customer();

                    List<Customer> customerlist = customer.getAllCustomerList(userlist);

                    bool validcustomer = customer.IsUserinCustomerList(user, customerlist);

                    //Checks if user is a valid user and a valid customer
                    if(validuser==true && validcustomer==true)
                    {
                        User.currentuser = user;
                        ClientStore clientform = new ClientStore();
                        clientform.Show();
                    }
                    else
                    {
                        userlogin.DisplayInvalidUsernamePasswordMessage(ErrorLabel);
                    }

                }

            admincheckbox.Checked = false;
            usernametextbox.Text="";
            passwordtextbox.Text="";

            }

        /// <summary>
        /// Enter Key Event for Login Form
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void passwordtextbox_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter && !Registerbutton.Focused)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
                this.loginbutton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Registerbutton_Click(sender, e);
            }
        }

        /// <summary>
        /// Loads the Register Form
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();

        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void loginbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to login";
        }

        private void Registerbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to Register";
        }

        private void LoginUser_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void admincheckbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Check this box if you are an admin";
        }

        private void passwordtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a password";
        }

        private void usernametextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a username";
        }

        }
    }

