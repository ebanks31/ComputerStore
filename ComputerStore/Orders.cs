using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;

namespace ComputerStore
{
    /// <summary>
    /// This contains methods and properties related to the orders of a customer
    /// </summary>
    public class Orders
    {
        private User user;
        private List<Product> productlist;
        private int quantity;
        private DateTime lastpurchasedate;
        public static List<Orders> finalorderlist = new List<Orders>();
        private int orderNumber;
        public static int incrementorderNumber = 0;
        public const string orderqueryStr = "SELECT * from Orders";
        /// <summary>
        /// Property of the Order Number
        /// </summary>
        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        /// <summary>
        /// Property of a User Object
        /// </summary>
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// Property for List of Products
        /// </summary>
        public List<Product> Productlist
        {
            get { return productlist; }
            set { productlist = value; }
        }

        /// <summary>
        /// Property of the Quantity
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Property for the last date purchased
        /// </summary>
        public DateTime Lastpurchasedate
        {
            get { return lastpurchasedate; }
            set { lastpurchasedate = value; }
        }

        /// <summary>
        /// Default Constructor of Orders class
        /// </summary>
        public Orders()
        {

        }

        /// <summary>
        /// Overloaded constructor of the Orders class.  Properties are set by the parameter
        /// </summary>
        /// <param name="orderNumber">Customer's order number</param>
        /// <param name="user">Customer's user object</param>
        /// <param name="productlist">List of products</param>
        /// <param name="quantity">Quantity that the customer ordered</param>
        /// <param name="lastpurchaseddate">Last purchase date</param>
        public Orders(int orderNumber, User user, List<Product> productlist, int quantity, DateTime lastpurchaseddate)
        {
            incrementorderNumber++;
            OrderNumber = incrementorderNumber;
            User = user;
            Productlist = productlist;
            Quantity = quantity;
            Lastpurchasedate = lastpurchasedate;
            //   orderlist = new List<Orders>();
        }

        /// <summary>
        /// Adds Order to orderlist
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Orders order)
        {

            finalorderlist.Add(order);
        }

        /// <summary>
        /// Gets current order given a current user
        /// </summary>
        /// <param name="user">Current user</param>
        /// <param name="orderlist">List of orders </param>
        /// <returns>List of orders from a current user</returns>
        public static List<Orders> getCurrentOrder(User user, List<Orders> orderlist)
        {
            List<Orders> finalorderlist = new List<Orders>();
            for (int i = 0; i < orderlist.Count; i++)
            {
                if (user == orderlist[i].User)
                {
                    finalorderlist.Add(orderlist[i]);
                }
            }

            return finalorderlist;

        }

        /// <summary>
        ///  Update orders datagrid given a list of orderlist
        /// </summary>
        /// <param name="datagrid">datagird of orders</param>
        /// <param name="orderslist">List of all orders</param>
        /// <returns>Datatable for all orders</returns>
        public DataTable GetAllOrders(DataGridView datagrid, List<Orders> orderslist)
        {
            datagrid.DataSource = this.GetOrdersTable(orderslist);

            return this.GetOrdersTable(orderslist);
        }


        /// <summary>
        ///  Creates a datatable for a list of orders.
        /// </summary>
        /// <param name="orderslist">List of all orders</param>
        /// <returns>datatable created that to captures a list of orders</returns>
        public DataTable GetOrdersTable(List<Orders> orderslist)
        {
            DataTable table = new DataTable();
            try
            {
                //
                // Create a DataTable with five columns.
                //
                
                table.Columns.Add("Username", typeof(string));
                table.Columns.Add("ProductName", typeof(string));
                table.Columns.Add("Quantity", typeof(string));
                table.Columns.Add("PurchaseDate", typeof(string));
                table.Columns.Add("OrderNumber", typeof(string));

                for (int i = 0; i < orderslist.Count; i++)
                {

                    for (int j = 0; j < orderslist[i].Productlist.Count; j++)
                        table.Rows.Add(orderslist[i].User.Username, orderslist[i].Productlist[j].ProductName, orderslist[i].Quantity, orderslist[i].Lastpurchasedate.Date.ToString(), orderslist[i].OrderNumber);
                }

             
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }


        /// <summary>
        /// Cancel a Orders. Orders is selected from datagrid. Order is removed from database and from List of all orders
        /// </summary>
        /// <param name="orderslist">List of all orders</param>
        /// <param name="productlist">List of all products</param>
        /// <param name="orderdataGridView1">datagrid for the display of the orders</param>
        /// <returns>List of orders with selected order removed</returns>
        public List<Orders> CancelOrder(List<Orders> orderslist, List<Product> productlist, DataGridView orderdataGridView1)
        {
            List<Orders> neworderlist = new List<Orders>();
            List<int> ordernumberlist = new List<int>();

            for (int i = 0; i < orderdataGridView1.SelectedRows.Count; i++)
            {

                int ordernumberparse = Convert.ToInt32(orderdataGridView1.SelectedRows[i].Cells[4].Value);
                ordernumberlist.Add(ordernumberparse);
            }

            for (int i = 0; i < orderdataGridView1.SelectedCells.Count; i++)
            {

                int ordernumberparse = Convert.ToInt32(orderdataGridView1.SelectedCells[i].OwningRow.Cells[4].Value);
                if (!ordernumberlist.Contains(ordernumberparse))
                {
                    ordernumberlist.Add(ordernumberparse);
                }
            }

            for (int i = 0; i < orderslist.Count; i++)
            {
                for (int j = 0; j < ordernumberlist.Count; j++)
                {
                    if (orderslist[i].orderNumber != ordernumberlist[j])
                    {
                        int ordernumberparse = Convert.ToInt32(ordernumberlist[j]);
                        neworderlist.Add(orderslist[i]);
                    }

                }

            }
            Orders.finalorderlist = neworderlist;
            return neworderlist;


        }


        /// <summary>
        /// This method adds order fields to an arraylist
        /// </summary>
        /// <param name="customerid">Customer's customer id</param>
        /// <param name="username">Customer's username</param>
        /// <param name="firstname">Customer's first name</param>
        /// <param name="lastname">Customer's last name</param>
        /// <param name="email">Customer's email</param>
        /// <param name="ordernumber">Customer's order number</param>
        /// <param name="numberoforders">Number of orders from the customers</param>
        /// <param name="numberofproductorders">Number of products ordered by the customers</param>
        /// <param name="quantity">Quantity ordered by the customer</param>
        /// <param name="dateorder">Date the order was made</param>
        /// <param name="lastpurchasedate">Last purchase date</param>
        /// <returns></returns>
        public ArrayList AddOrderToArraylist(string customerid, string username, string firstname, string lastname, string email, string ordernumber, string productname, string productid, string numberoforders, string numberofproductorders, string quantity,string dateorder, string lastpurchasedate,string lastlogindate)
        {
            ArrayList list = new ArrayList();
            list.Add(customerid);
            list.Add(username);
            list.Add(firstname);
            list.Add(lastname);
            list.Add(email);
            list.Add(ordernumber);
            list.Add(productname);
            list.Add(productid);
            list.Add(numberoforders);
            list.Add(numberofproductorders);
            list.Add(quantity);
            list.Add(dateorder);
            list.Add(lastpurchasedate);
            list.Add(lastlogindate);

            return list;
        }


        /// <summary>
        ///  Insert orders into  the orders database
        /// </summary>
        /// <param name="list">list of customer fields</param>
        public void InsertDatabase(ArrayList list)
        {
            string insertquery = "INSERT INTO Orders VALUES (@customerid,@username,@firstname,@lastname,@email,@ordernumber,@productname,@productid,@numberoforders,@numberofproductorders,@quantity,@dateorder,@lastpurchasedate,@lastlogindate)";

            using (SqlConnection myConnection = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand(insertquery, myConnection);
                    myCommand.CommandText = insertquery;
                    int customerid = Convert.ToInt32(list[0]);
                    myCommand.Parameters.AddWithValue("@customerid", customerid);
                    myCommand.Parameters.AddWithValue("@username", list[1].ToString());
                    myCommand.Parameters.AddWithValue("@firstname", list[2].ToString());
                    myCommand.Parameters.AddWithValue("@lastname", list[3].ToString());
                    myCommand.Parameters.AddWithValue("@email", list[4].ToString());
                    int ordernumber = Convert.ToInt32(list[5]);
                    myCommand.Parameters.AddWithValue("@ordernumber", ordernumber);
                    myCommand.Parameters.AddWithValue("@productname", list[6].ToString());
                    int productid = Convert.ToInt32(list[7]);
                    myCommand.Parameters.AddWithValue("@productid", productid);
                    int numberoforders = Convert.ToInt32(list[8]);
                    myCommand.Parameters.AddWithValue("@numberoforders", numberoforders);
                    int numberofproductorders = Convert.ToInt32(list[9]);
                    myCommand.Parameters.AddWithValue("@numberofproductorders", numberofproductorders);
                    int quantity = Convert.ToInt32(list[10]);
                    myCommand.Parameters.AddWithValue("@quantity", quantity);
                    DateTime dateorder = DateTime.ParseExact(list[11].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    myCommand.Parameters.AddWithValue("@dateorder", dateorder);
                    DateTime lastpurchasedate = DateTime.ParseExact(list[12].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    myCommand.Parameters.AddWithValue("@lastpurchasedate", lastpurchasedate);
                    DateTime lastlogindate = DateTime.ParseExact(list[13].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    myCommand.Parameters.AddWithValue("@lastlogindate", lastlogindate);
                    myCommand.ExecuteNonQuery();
                }

                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    myConnection.Close();
                }

            }
        }




        /// <summary>
        /// Remove customer from Customer List. 
        /// </summary>
        /// <param name="list">ArrayList of customerfields</param>
        /// <param name="datagridview">datagrid view for customer display</param>
        /// <param name="customerlist">List of customers</param>
        /// <returns>datagrid for current customer list after customer removal</returns>
        public DataGridView GetCurrentOrder(DataGridView datagridview, int customerid)
        {

            string selectquery = "SELECT * FROM ORDERS WHERE customerid = @customerid";

            //DeleteSelectedCustomerFromDatabase(deletequery, list);
            DataTable datatable = null;
            using (SqlConnection myconn = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                myconn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    selectquery, myconn))
                {

                    adapter.SelectCommand.Parameters.AddWithValue("@customerid", customerid);

                    datatable = new DataTable();
                    adapter.Fill(datatable);
                }
            }
            datagridview.DataSource = datatable;
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
                    SqlCommand myCommand = new SqlCommand(queryresult, myconnection);
                    myCommand.CommandText = queryresult;
                    for (int i = 0; i < list.Count; i++)
                    {
                        string parameter = "@customerid" + i.ToString();
                        int value = Convert.ToInt32(list[i].ToString());

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
                    orderqueryStr, myconn))
                {

                    datatable = new DataTable();
                    adapter.Fill(datatable);


                }
            }

            return datatable;
        }
    }
}
