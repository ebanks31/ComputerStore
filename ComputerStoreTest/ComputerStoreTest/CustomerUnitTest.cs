using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;
using System.Collections.Generic;
using System.Collections;
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
    public class CustomerUnitTest
    {
        [TestMethod]
        public void TestGetAllCustomer()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            List<Customer> customerlist =customer.getAllCustomerList(userlogin.DeserializeLogin());
            Assert.IsTrue(customerlist.Count > 0);
        }

        [TestMethod]
        public void TestGetAllCustomerUserlistIsNull()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            List<User> userlist = null;
            List<Customer> customerlist = customer.getAllCustomerList(userlist);
            Assert.IsTrue(customerlist.Count > 0);
        }


        [TestMethod]
        public void TestGetCurrentCustomersByCustomerID()
        {
            Customer customer = new Customer();
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            UserLogin userlogin = new UserLogin();
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            Customer currentcustomer = customer.getCurrentCustomerByCustomerID(list, customerlist);
            Assert.AreEqual(1, currentcustomer.Customerid);
        }
  
        [TestMethod]
        public void TestUpdateCustomerDatagridRows()
        {
            Customer customer = new Customer();
            DataGridView datagridview = new DataGridView();
            customer.UpdateDataGrid(datagridview);
            DataTable dt = (DataTable)datagridview.DataSource;
            int rowcount = dt.Rows.Count;
            Assert.IsTrue(rowcount > 0);
        }

        [TestMethod]
        public void TestUpdateCustomerDatagridColumns()
        {
            Customer customer = new Customer();
            DataGridView datagridview = new DataGridView();
            customer.UpdateDataGrid(datagridview);
            DataTable dt = (DataTable)datagridview.DataSource;
            int rowcount = dt.Columns.Count;
            Assert.IsTrue(rowcount > 0);
        }




        [TestMethod]
        public void TestUpdateCustomerEmailfound()
        {
        Customer customer = new Customer();
        UserLogin userlogin = new UserLogin();
        User user = new User("admin", "password");
        List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
        string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
        Customer currcustomer = Customer.currentcustomer;
        bool email = customer.CheckIfCustomerEmail(currcustomer, customerlist);
        Assert.IsTrue(email);
        }

        [TestMethod]
        public void TestUpdateCustomerEmailNotfound()
        {
        Customer customer = new Customer();
        UserLogin userlogin = new UserLogin();
        User user = new User("admin", "password");
        List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
        string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
        Customer currcustomer = Customer.currentcustomer;
        bool email = customer.CheckIfCustomerEmail(customer, customerlist);
        Assert.IsFalse(email);
        }

                        [TestMethod]
        public void TestUpdateCustomerIDIncrementMethod()
        {
        Customer customer = new Customer();
        UserLogin userlogin = new UserLogin();
                              
        List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
        int customerid = customer.incrementCustomerNumber(userlogin.DeserializeLogin());
        int customeridfromlist=    customerlist[customerlist.Count - 1].Customerid+1;
      //  bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
        Assert.AreEqual(customeridfromlist, customerid);
        }

        
        [TestMethod]
        public void TestIsUserinCustomerList()
        {
        Customer customer = new Customer();
        UserLogin userlogin = new UserLogin();
        User user = new User("test2", "test2");
        List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
        bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
        Assert.IsTrue(validcustomer);
        }

        [TestMethod]
        public void TestIsNotUserinCustomerList()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("", "");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Assert.IsFalse(validcustomer);
        }

        [TestMethod]
        public void TestCustomerChangePhonenumber()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("admin", "password");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Customer currcustomer = Customer.currentcustomer;
            customer.ChangePhoneNumber(currcustomer, "222389254");
            Assert.AreEqual("222389254", currcustomer.Phonenumber);
        }

        [TestMethod]
        public void TestCustomerChangeEmail()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("admin", "password");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Customer currcustomer = Customer.currentcustomer;
            customer.ChangeEmail(currcustomer, "test@gmail.com");
            Assert.AreEqual("test@gmail.com", currcustomer.Email);
        }

        [TestMethod]
        public void TestCustomerChangeAddress()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("admin", "password");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Customer currcustomer = Customer.currentcustomer;
            customer.ChangeAddress(currcustomer, "12121 rrere dr");
            Assert.AreEqual("12121 rrere dr", currcustomer.Address);
        }

        [TestMethod]
        public void TestCustomerChangePassword()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("admin", "password");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Customer currcustomer = Customer.currentcustomer;
            List<User> userlist = userlogin.DeserializeLogin();
            customer.Changepassword(user, userlist, "new");
            Assert.AreEqual("new",currcustomer.Password);
        }


        //Add Customer
        [TestMethod]
        public void TestCustomerChangePassword2()
        {
            Customer customer = new Customer();
            UserLogin userlogin = new UserLogin();
            User user = new User("admin", "password");
            List<Customer> customerlist = customer.getAllCustomerList(userlogin.DeserializeLogin());
            string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            bool validcustomer = customer.IsUserinCustomerList(user, customerlist);
            Customer currcustomer = Customer.currentcustomer;
            List<User> userlist = userlogin.DeserializeLogin();
            customer.Changepassword(user, userlist, "new");
            Assert.AreEqual("new", currcustomer.Password);
        }

    }
}
