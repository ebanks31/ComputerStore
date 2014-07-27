using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace ComputerStore
{
    public class Customer : User
    {
        private int customerid;
        private string firstname;
        private string lastname;
        private string address;
        private string email;
        private string phonenumber;
        private User user;
        private DateTime lastLoginDate;
        private DateTime lastPurchaseDate;
        public static List<Customer> Customerlist = new List<Customer>();
        public const string customerqueryStr = "SELECT * from Customer";
        public static Customer currentcustomer;

        /// <summary>
        /// Property of a User
        /// </summary>
        public User Users
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// Property for a Customer's ID
        /// </summary>
        public int Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

        /// <summary>
        /// Property of a Customer's First name
        /// </summary>
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        /// <summary>
        /// Property of a Customer's Last name
        /// </summary>
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        /// <summary>
        /// Property of a Customer's Email
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Property of a Customer's Phone number
        /// </summary>
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        /// <summary>
        /// Property of a Customer's address or PO Box
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Property of a Customer's Last Purchase date
        /// </summary>
        public DateTime LastPurchaseDate
        {
            get { return lastPurchaseDate; }
            set { lastPurchaseDate = value; }
        }


        /// <summary>
        /// Property of a Customer's Last Login date
        /// </summary>
        public DateTime LastLoginDate
        {
            get { return lastLoginDate; }
            set { lastLoginDate = value; }
        }

        /// <summary>
        /// Overloaded Constructor of Customer class. Initial Property values are set based on parameters.
        /// </summary>
        /// <param name="customerid">Customer's customer id</param>
        /// <param name="user">User from current customer</param>
        /// <param name="firstname">Customer's first name</param>
        /// <param name="lastname">Customer's last name</param>
        /// <param name="address">Customer's address</param>
        /// <param name="email">Customer's email</param>
        /// <param name="phonenumber">Customer's phone number</param>
        /// <param name="lastLoginDate">Customer's last login date</param>
        public Customer(int customerid, User user, string firstname, string lastname, string address, string email, string phonenumber, DateTime lastLoginDate)
        {

            Customerid = customerid;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Email = email;
            Phonenumber = phonenumber;
            LastLoginDate = lastLoginDate;
            Users = user;

        }

        /// <summary>
        /// Default Constructor of Customer class
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Add a customer to current customer list.
        /// </summary>
        /// <param name="customer">current customer</param>
        /// <returns>datatable of customer list with added customer</returns>
        public DataTable AddCustomer(Customer customer)
        {
            //Get CurrentCustomerList from table
            //see if customer is in customer list
            DataTable datatable = GetSearchResults(customerqueryStr);
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                for (int j = 0; j < datatable.Columns.Count; j++)
                {
                    string email = datatable.Rows[i][4].ToString();

                    if (customer.Email != email && !this.CheckIfCustomerEmail(customer, Customerlist))
                    {
                        Customerlist.Add(customer);
                    }
                }
            }
            return datatable;
        }
        
        /// <summary>
        /// Checks if a Customer Email is in the list of customer list
        /// </summary>
        /// <param name="customer">current customer</param>
        /// <param name="customerlist">list of all customers</param>
        /// <returns>Bool expression displaying whether an email address is found in customer list</returns>
        public bool CheckIfCustomerEmail(Customer customer, List<Customer> customerlist)
        {
            for (int i = 0; i < customerlist.Count; i++)
            {
                if (customerlist[i].Email.Equals(customer.Email))
                {
                    return true;

                }
            }
            return false;
        }


        /// <summary>
        /// Gets all the customer from database
        /// </summary>
        /// <param name="userlist">List of all users</param>
        /// <returns>List of all customers in database</returns>
        public List<Customer> getAllCustomerList(List<User> userlist)
        {
            DataTable datatable = this.GetSearchResults(customerqueryStr);

            for (int i = 0; i < datatable.Rows.Count; i++)
            {

                int customerid = (int)datatable.Rows[i][0];
                string username = (string)datatable.Rows[i][1];
                string firstname = (string)datatable.Rows[i][2];
                string lastname = (string)datatable.Rows[i][3];
                string customeraddress = (string)datatable.Rows[i][4];
                string email = (string)datatable.Rows[i][5];
                string phonenumber = (string)datatable.Rows[i][6];
                DateTime lastlogindate = (DateTime)datatable.Rows[i][7];
                DateTime lastPurchaseDate = (DateTime)datatable.Rows[i][8];
                User currentuser = this.GetCurrentUser(username, userlist);
                if (currentuser != null)
                {
                    Customer customer = new Customer(customerid, currentuser, firstname, lastname, address, email, phonenumber, lastlogindate);
                    Customer.Customerlist.Add(customer);
                }


            }

            return Customer.Customerlist;
        }

        /// <summary>
        /// Determine if current user is in the customer list.
        /// </summary>
        /// <param name="user">Current user</param>
        /// <param name="customerlist">List of Customers</param>
        /// <returns>True if user is in customer list, otherwise false</returns>
        public bool IsUserinCustomerList(User user, List<Customer> customerlist)
        {
            for (int i = 0; i < customerlist.Count; i++)
            {
                if (user.Username == customerlist[i].user.Username && user.Password == customerlist[i].user.Password)
                {
                    Customer.currentcustomer = customerlist[i];
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Adds Customer fields to ArrayList
        /// </summary>
        /// <param name="customerid">Customer's Customer id</param>
        /// <param name="username">Customer's username</param>
        /// <param name="firstname">Customer's firstname</param>
        /// <param name="lastname">Customer's lastname</param>
        /// <param name="email">Customer's email</param>
        /// <param name="phonenumber">Customer's phone number</param>
        /// <param name="address">Customer's address</param>
        /// <param name="lastlogin">Customer's last login date</param>
        /// <param name="lastpurchasedate">Customer's last purchase date</param>
        /// <returns></returns>
        public ArrayList AddCustomerToArraylist(string customerid, string username, string firstname, string lastname, string email, string phonenumber, string address, string lastlogin, string lastpurchasedate)
        {
            ArrayList list = new ArrayList();
            list.Add(customerid);
            list.Add(username);
            list.Add(firstname);
            list.Add(lastname);
            list.Add(email);
            list.Add(phonenumber);
            list.Add(address);
            list.Add(lastlogin);
            list.Add(lastpurchasedate);
            return list;
        }


        /// <summary>
        /// Insert a Customer in Database
        /// </summary>
        /// <param name="list">Arraylist of customer fields</param>
        public void InsertDatabase(ArrayList list)
        {
            string insertquery = "INSERT INTO CUSTOMER VALUES (@customerid,@username,@firstname,@lastname,@address,@email,@phonenumber,@lastLoginDate,@lastPurchaseDate)";

            using (SqlConnection myConnection = new SqlConnection(
Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand(insertquery, myConnection);
                    myCommand.CommandText = insertquery;
                    myCommand.Parameters.AddWithValue("@customerid", list[0].ToString());
                    myCommand.Parameters.AddWithValue("@username", list[1].ToString());
                    myCommand.Parameters.AddWithValue("@firstname", list[2].ToString());
                    myCommand.Parameters.AddWithValue("@lastname", list[3].ToString());
                    myCommand.Parameters.AddWithValue("@address", list[4].ToString());
                    myCommand.Parameters.AddWithValue("@email", list[5].ToString());
                    myCommand.Parameters.AddWithValue("@phonenumber", list[6].ToString());
                    myCommand.Parameters.AddWithValue("@lastLoginDate", list[7].ToString());
                    myCommand.Parameters.AddWithValue("@lastPurchaseDate", list[8].ToString());
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {

                    myConnection.Close();
                }


            }
        }

        /// <summary>
        /// Increment CustomerID number in order to obtain unique customer ids
        /// </summary>
        /// <param name="userlist">Current List of All Users</param>
        /// <returns>integer displaying a unique customerid. Customer Id is incremented by 1</returns>
        public int incrementCustomerNumber(List<User> userlist)
        {
            Customer customer = new Customer();
            List<Customer> customerlist = customer.getAllCustomerList(userlist);

            int lastcustomerid = customerlist[customerlist.Count - 1].customerid;
            int final = lastcustomerid + 1;
            return final;

        }

        /// <summary>
        /// Gets current datatable based on query string
        /// </summary>
        /// <param name="queryStr">Query string</param>
        /// <returns>datatable based on query string</returns>
        public DataTable GetSearchResults(string queryStr)
        {
            DataTable datatable = null;

            using (SqlConnection conn = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                conn.Open();
                // 2
                // Create new DataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    queryStr, conn))
                {
                    datatable = new DataTable();
                    adapter.Fill(datatable);

                }
            }

            return datatable;
        }


        /// <summary>
        /// Get Current Customer base off of username
        /// </summary>
        /// <param name="user">Current User</param>
        /// <param name="customerlist">list of customer</param>
        /// <returns>Current customer if customer is found in customer list</returns>
        public Customer getCurrentCustomer(User user, List<Customer> customerlist)
        {

            for (int i = 0; i < customerlist.Count; i++)
            {
                if (user.Username == customerlist[i].Username)
                {
                    return customerlist[i];
                }
            }
            return null;

        }

        /// <summary>
        /// Get current customer by customer id 
        /// </summary>
        /// <param name="customeridlist">List of customer ids</param>
        /// <param name="customerlist">List of customer</param>
        /// <returns>current customer if customer if found</returns>
        public Customer getCurrentCustomerByCustomerID(ArrayList customeridlist, List<Customer> customerlist)
        {

            for (int i = 0; i < customerlist.Count; i++)
            {
                if ((int)customeridlist[i] == customerlist[i].Customerid)
                {
                    return customerlist[i];
                }
            }
            return null;

        }

        /// <summary>
        /// Remove customer from Customer List. 
        /// </summary>
        /// <param name="list">ArrayList of customerfields</param>
        /// <param name="datagridview">datagrid view for customer display</param>
        /// <param name="customerlist">List of customers</param>
        /// <returns>datagrid for current customer list after customer removal</returns>
        public DataGridView RemoveCustomer(ArrayList list, DataGridView datagridview,List<Customer> customerlist)
        {
            string deletequery = "";

            for (int i = 0; i < list.Count; i++)
            {
                int productid = Convert.ToInt32(list[i].ToString());

                if (i == 0)
                {
                    deletequery = "DELETE FROM Customer WHERE customerid IN (@customerid" + i.ToString();

                }
                else
                {
                    deletequery += ",@" + productid + i.ToString();
                }
                deletequery += ")";
            }

            DeleteSelectedCustomerFromDatabase(deletequery, list);
            UpdateDataGrid(datagridview);
            return datagridview;

        }

        /// <summary>
        /// Delete selected customer from database.
        /// </summary>
        /// <param name="queryresult">Delete query that used to delete customer from database</param>
        /// <param name="list">Arraykust if customer fields</param>
        public void DeleteSelectedCustomerFromDatabase(string queryresult, ArrayList list)
        {
            SqlConnection myconnection = null;

            try
            {
                using (myconnection = new SqlConnection(
Properties.Settings.Default.DataConnectionString))
                {
                    myconnection.Open();
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(queryresult, myconnection);
                    myCommand.CommandText = queryresult;
                    for (int i = 0; i < list.Count; i++)
                    {
                        string parameter = "@customerid" + i.ToString();
                        int value =Convert.ToInt32(list[i].ToString());

                        myCommand.Parameters.AddWithValue(parameter, value);
                    }
                    myCommand.BeginExecuteNonQuery();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myconnection.Close();
            }

        }

        /// <summary>
        /// Gets ArrayList of Customer ids from selected rows and selected cells
        /// </summary>
        /// <param name="dataGridView1">Datagrid for customer display</param>
        /// <returns>ArrayList of Customer ids that are selected from datagrid</returns>
        public ArrayList getSelectedCustomerID(DataGridView dataGridView1)
        {
            //Create list of customerids from selected rows.
            ArrayList list = new ArrayList();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.SelectedRows[i].Cells.Count - 1; j++)
                {
                    if (dataGridView1.SelectedRows[i].Cells[j].ColumnIndex == 0)
                    {
                        list.Add(dataGridView1.SelectedRows[i].Cells[j].Value);
                    }

                }


            }

            //Create list of customerids from selected cells.
            ArrayList finallist = this.getCurrentCustomerIDSelectedCells(list, dataGridView1);


            return finallist;
        }

        /// <summary>
        /// Gets ArrayList of Customer ids selected cells
        /// </summary>
        /// <param name="arraylist">ArrayList of Customer ids that are selected from datagrid</param>
        /// <param name="datagridview1">Datagrid for customer display</param>
        /// <returns>ArrayList of Customer ids that are selected cells from datagrid</returns>
        public ArrayList getCurrentCustomerIDSelectedCells(ArrayList arraylist, DataGridView datagridview1)
        {

            for (int i = 0; i < datagridview1.SelectedCells.Count; i++)
            {
                if (!arraylist.Contains(datagridview1.SelectedCells[0].Value) || arraylist == null)
                {
                    arraylist.Add(datagridview1.SelectedCells[0].Value);
                }
            }

            return arraylist;
        }

        /// <summary>
        /// Update current data grid datasource
        /// </summary>
        /// <param name="datagrid">datagrid of customer display</param>
        public void UpdateDataGrid(DataGridView datagrid)
        {
            datagrid.DataSource = this.GetCustomerTable();

        }
        
        /// <summary>
        /// Gets current datatable based off customer query string.
        /// </summary>
        public DataTable GetCustomerTable()
        {
            DataTable datatable = null;
            using (SqlConnection myconn = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                myconn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    customerqueryStr, myconn))
                {

                    datatable = new DataTable();
                    adapter.Fill(datatable);


                }
            }

            return datatable;
        }


        /// <summary>
        /// Change the phone nunber of a customer
        /// </summary>
        /// <param name="customer">Current customer</param>
        /// <param name="phonenumber">phone number that the customer will change to</param>
        public void ChangePhoneNumber(Customer customer,string phonenumber)
        {
            string changephonenumberquery = "UPDATE CUSTOMER SET phonenumber = " + phonenumber + " WHERE customerid =" + customer.Customerid;

            using (SqlConnection myConnection = new SqlConnection(
Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand(changephonenumberquery, myConnection);
                    myCommand.CommandText = changephonenumberquery;
                    myCommand.ExecuteNonQuery();
                    Customer.currentcustomer.Phonenumber = phonenumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                
                    myConnection.Close();
                }


            }

        }

        /// <summary>
        /// Change the address of a customer
        /// </summary>
        /// <param name="customer">Current customer</param>
        /// <param name="newaddress">address that the customer will change to</param>
        public void ChangeAddress(Customer customer, string newaddress)
        {
            string changeaddressquery = "UPDATE CUSTOMER SET customeraddress =\'" + newaddress + "\' WHERE customerid =" + customer.Customerid;

            using (SqlConnection myConnection = new SqlConnection(
Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand(changeaddressquery, myConnection);
                    myCommand.CommandText = changeaddressquery;

                    myCommand.ExecuteNonQuery();
                    Customer.currentcustomer.Address = newaddress;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    myConnection.Close();
                }


            }

        }

        /// <summary>
        /// Change the email of a customer
        /// </summary>
        /// <param name="customer">Current customer</param>
        /// <param name="newemail">email that the customer will change to</param>
        public void ChangeEmail(Customer customer,string newemail)
        {
            string changeemailquery = "UPDATE CUSTOMER SET email = \'" + newemail + "\' WHERE customerid =" + customer.Customerid;

            using (SqlConnection myConnection = new SqlConnection(
Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand(changeemailquery, myConnection);
                    myCommand.CommandText = changeemailquery;
                    myCommand.ExecuteNonQuery();

                    Customer.currentcustomer.Email = newemail;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {

                    myConnection.Close();
                }


            }
        }


                    /// <summary>
                    /// Change the password of a customer
                    /// </summary>
                    /// <param name="currentuser">Current user</param>
                    /// <param name="userlist">List of all users</param>
                    /// <param name="newpassword">new password that the customer wishes to change top[-</param>
                    public void Changepassword(User currentuser,List<User> userlist,string newpassword)
        {
                        UserLogin loginuser = new UserLogin();
                        currentuser.removeUser(currentuser,userlist);
                        User user = new User(currentuser.Username,newpassword);
                        user.AddUser(user);
                        loginuser.SerializeLogin(user);
                        Customer.currentcustomer.Password = newpassword;

            }

        }


    }

