using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
namespace ComputerStoreTest
{
    [TestClass]
    public class OrderUnitTest
    {
        [TestMethod]
        public void TestUpdateOrderDataGrid()
        {
            Orders order = new Orders();
            DataGridView dataGridView1 = new DataGridView();
            order.UpdateDataGrid(dataGridView1);

            DataTable dt = (DataTable)dataGridView1.DataSource;
            int rowcount = dt.Rows.Count;
            Assert.IsTrue(rowcount > 0, "The actualCount was not greater than zero");
        }

       [TestMethod]
        public void TestGetCurrentOrder()
        {
            Orders order = new Orders();
            DataGridView dataGridView1 = new DataGridView();
            DataGridView dataGridView2 =order.GetCurrentOrder(dataGridView1,2);

            DataTable dt = (DataTable)dataGridView2.DataSource;
            int rowcount = dt.Rows.Count;
            Assert.IsTrue(rowcount > 0, "The actualCount was not greater than zero");
        }


       [TestMethod]
       public void TestGetCurrentOrderRowCountIsAccurate()
       {
           Orders order = new Orders();
           DataGridView dataGridView1 = new DataGridView();
           DataGridView dataGridView2 = order.GetCurrentOrder(dataGridView1, 9999999);

           DataTable dt = (DataTable)dataGridView2.DataSource;
           int rowcount = dt.Rows.Count;
           Assert.AreEqual(0, rowcount);
       }

       [TestMethod]
       public void TestGetCurrentOrderColumnCountIsAccurate()
       {
           Orders order = new Orders();
           DataGridView dataGridView1 = new DataGridView();
           DataGridView dataGridView2 = order.GetCurrentOrder(dataGridView1, 1);

           DataTable dt = (DataTable)dataGridView2.DataSource;
           int rowcount = dt.Columns.Count;
           Assert.AreEqual(14, rowcount);
       }

       [TestMethod]
       public void TestAddCurrentCustomertoOrdersArrayList()
       {
           Orders order = new Orders();

           Customer customer = new Customer();
           UserLogin userlogin = new UserLogin();
           User user = new User("admin", "password");
           List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
           string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

           bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
           Customer currcustomer = Customer.currentcustomer;
           ArrayList orderlistfields = order.AddOrderToArraylist(currcustomer.Customerid.ToString(), currcustomer.Users.Username, currcustomer.Firstname, currcustomer.Lastname, currcustomer.Email, order.OrderNumber.ToString(), "Product", "0", "0", "0", order.Quantity.ToString(), date, date, date);

           Assert.AreEqual(14, orderlistfields.Count);
       }

       [TestMethod]
       public void TestCurrentCustomerEmailisFound()
       {
           Orders order = new Orders();

           Customer customer = new Customer();
           UserLogin userlogin = new UserLogin();
           User user = new User("admin", "password");
           List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
           string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

           bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
           Customer currcustomer = Customer.currentcustomer;

           bool emailfound = customer.CheckIfCustomerEmail(currcustomer, customerlist);
           Assert.IsTrue(emailfound, "Current Customer's email address is found");

       }
	   
	    [TestMethod]
       public void TestCurrentCustomerEmailisNotFound()
       {
           Orders order = new Orders();

           Customer customer = new Customer();
           UserLogin userlogin = new UserLogin();
           User user = new User("admin", "password");
           List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
           string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

           bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
           Customer currcustomer = Customer.currentcustomer;

           bool emailfound = customer.CheckIfCustomerEmail(customer, customerlist);
           Assert.IsFalse(emailfound, "Current Customer's email address is found");

       }


  
    }
}
