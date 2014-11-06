using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;

namespace ComputerStore
{
    public partial class AdminUserOptions : Form
    {

        /// <summary>
        /// Constructor for AdminUserOptions Form
        /// </summary>
        public AdminUserOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add User Button Click Event
        /// </summary>
        /// <param name="sender">Sender of Event</param>
        /// <param name="e">Event Arguments</param>
        private void AddUserButton_Click(object sender, EventArgs e)
        {
           
            string username = this.usernametextbox.Text;
            string password = this.passwordtextbox.Text;

           
             User user = new User(username,password);


            user.AddUser(user);
        }

        /// <summary>
        /// Remove User Button Click Event
        /// </summary>
        /// <param name="sender">Sender of Event</param>
        /// <param name="e">Event Arguments</param>
        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
        
            UserLogin userlogin = new UserLogin();
            string user = Userlistbox.SelectedItem.ToString();
       
            User users = new User(user);
            Userlistbox.Items.Clear();
            List<User> userlist = userlogin.DeserializeLogin();

            List<User> finaluserlist = users.removeUser(users, userlist);

            int i = 0;
            foreach (User userf in finaluserlist)
            {

                Userlistbox.Items.Add(userf.Username);

            }

            userlogin.SerializeLogin(finaluserlist);


        }


        /// <summary>
        /// Get User Button Click Event
        /// </summary>
        /// <param name="sender">Sender of Event</param>
        /// <param name="e">Event Arguments</param>
        private void GetUserButton_Click(object sender, EventArgs e)
        {
            Userlistbox.Items.Clear();
            DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn(); // add a column to the grid
            newCol.HeaderText = "Username";
            newCol.Name = "Username";
            newCol.Visible = true;
            newCol.Width = 40;
            this.dataGridView1.Columns.Add(newCol);

            DataGridViewTextBoxColumn newCol1 = new DataGridViewTextBoxColumn(); // add a column to the grid
            newCol1.HeaderText = "Password";
            newCol1.Name = "Password";
            newCol1.Visible = true;
            newCol1.Width = 40;
            this.dataGridView1.Columns.Add(newCol1);

            UserLogin userlogin = new UserLogin();
            List<User> userlist = userlogin.DeserializeLogin();

            int i = 0 ;
            foreach(User user in userlist)
            {
                DataGridViewRow row = (DataGridViewRow)this.dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = user.Username;
                row.Cells[1].Value = user.Password;
                this.dataGridView1.Rows.Add(row);
                //Userlistbox.Items.Add(user.Username + " " + user.Password);
                
            }
        }

        private void AdminUserOptions_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void AddUserButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to Add a User";
        }

        private void RemoveUserButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Select a User from above and click this button to remove User";
        }

        private void GetUserButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Button to get all users";
        }

        private void usernametextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid username";
        }

        private void passwordtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid password";
        }

        private void AdminUserOptions_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }


    }
}
