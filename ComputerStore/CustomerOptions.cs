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
    public partial class CustomerOptions : Form
    {
        /// <summary>
        /// Default Constructor of CustomerOptions class
        /// </summary>
        public CustomerOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to get all customers from the database
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void GetAllCustomersbutton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            DataTable datatable = customer.GetSearchResults(Customer.customerqueryStr);
            customerdatagrid.DataSource = datatable;

        }

        /// <summary>
        /// Button that removes the customer
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin();
            Customer customer = new Customer();
            List<User> userlist = user.DeserializeLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);

            if (customerlist != null)
            {
                ArrayList list = customer.getSelectedCustomerID(this.customerdatagrid);
                Customer currentcustomer = customer.getCurrentCustomerByCustomerID(list, customerlist);
                currentcustomer.removeUser(currentcustomer, userlist);
                customer.RemoveCustomer(list, this.customerdatagrid, customerlist);

            }

        }

        private void removeCustomerButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Select a Customer from table above and click this button to remove a customer";
        }

        private void GetAllCustomersbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click this button to get all customers";
        }

        private void CustomerOptions_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void CustomerOptions_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }



    }
}
