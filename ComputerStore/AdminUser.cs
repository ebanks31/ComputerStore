using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerStore
{
    public class AdminUser : User
    {
        /// <summary>
        /// Default Constructor of Admin User class
        /// </summary>
        public AdminUser()
        {

        }



        /// <summary>
        /// Password for admin user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool isAdminUser(string username, string password)
        {
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Add valid Admin User to userlist
        /// </summary>
        /// <param name="user">User to be added.</param>
        public void AddAdminUser(User user)
        {

            List<User> usernamelist = new List<User>();


            usernamelist.Add(user);

            UserLogin login = new UserLogin();

            login.SerializeLogin(user);

        }


        /// <summary>
        /// 
        /// 
        /// 
        /// </summary>
        public void GetAllUsers(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            DataGridViewTextBoxColumn usernamecolumn = new DataGridViewTextBoxColumn(); // add a column to the grid
            usernamecolumn.HeaderText = "Username";
            usernamecolumn.Name = "Username";
            usernamecolumn.Visible = true;
            usernamecolumn.Width = 100;
            dataGridView1.Columns.Add(usernamecolumn);

            DataGridViewTextBoxColumn firstnamecolumn = new DataGridViewTextBoxColumn(); // add a column to the grid
            firstnamecolumn.HeaderText = "First Name";
            firstnamecolumn.Name = "First Name";
            firstnamecolumn.Visible = true;
            firstnamecolumn.Width = 100;
            dataGridView1.Columns.Add(firstnamecolumn);

            DataGridViewTextBoxColumn lastnamecolumn = new DataGridViewTextBoxColumn(); // add a column to the grid
            lastnamecolumn.HeaderText = "Last Name";
            lastnamecolumn.Name = "Last Name";
            lastnamecolumn.Visible = true;
            lastnamecolumn.Width = 100;
            dataGridView1.Columns.Add(lastnamecolumn);

            UserLogin userlogin = new UserLogin();
            List<User> userlist = userlogin.DeserializeLogin();

            Customer customer = new Customer();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);

            int i = 0;
            foreach (Customer currentcustomer in customerlist)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = currentcustomer.Users.Username;
                row.Cells[1].Value = currentcustomer.Firstname;
                row.Cells[2].Value = currentcustomer.Lastname;
                dataGridView1.Rows.Add(row);

            }

        }


    }
}
