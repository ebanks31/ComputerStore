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
    public partial class ClientStore : Form
    {
        private Thread demoThread = null;

        /// <summary>
        /// Default constructor of ClientStore Form
        /// </summary>
        public ClientStore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button that gets all the products from the database
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void GetAllProducts_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            SQLConnect sql = new SQLConnect();

            ArrayList result = product.GetAllProducts();
           
            product.InsertDatabase(result);
            product.UpdateProductList(product.QueryStr, this.dataGridView1);
        }

        /// <summary>
        /// Allows the sorting of the product by category. Uses combobox for selection
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void categorySortcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            string selecteditem = categorySortcombobox.SelectedItem.ToString();
            if (selecteditem.Equals("All"))
            {
                GetAllProducts_Click(sender, e);
            }
            else
            {
                product.FilterByCategorySearchResults(selecteditem, this.dataGridView1);

            }
        }

        // This method is executed on the worker thread and makes
        // an unsafe call on the TextBox control.
        private void ThreadProcSafe()
        {
           toolStripStatusLabel1.Text = "This text was set unsafely.";
        }

        /// <summary>
        /// Button that allow the customer to place an order
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            /*
            this.demoThread =
    new Thread(new ThreadStart(this.ThreadProcSafe));

            this.demoThread.Start();

            this.backgroundWorker1.RunWorkerAsync();
            */
            Product product = new Product();
            User user =User.currentuser;
            string quantitytext = quantitytextbox.Text;

            int quantity = 0;
            if (quantitytext == "" || quantitytext=="0")
            {
 
                MessageBox.Show("Enter a valid Quantity");
            }
            else
            {
                quantity = Convert.ToInt32(quantitytext);


                DateTime purchasedate = DateTime.Now;
                ArrayList list = product.getCurrentProductID(this.dataGridView1);
                //Good current product instead of id or get product name
                List<Product> productlist = product.UpdateProductList(product.QueryStr, this.dataGridView1);
                List<Product> finalproductlist = product.GetCurrentUserProductList(productlist, list);
                int ordernumber = 0;

                if (finalproductlist != null)
                {
                    Customer currcustomer = Customer.currentcustomer;
                    Orders order = new Orders(ordernumber, user, finalproductlist, quantity, purchasedate);
                    order.AddOrder(order);
                    string date = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    string lastpurchasedate = DateTime.Now.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    ArrayList orderlistfields = order.AddOrderToArraylist(currcustomer.Customerid.ToString(), currcustomer.Users.Username, currcustomer.Firstname, currcustomer.Lastname, currcustomer.Email, order.OrderNumber.ToString(),"Product","0","0", "0", order.Quantity.ToString(), date, date,date);
                    order.InsertDatabase(orderlistfields);
                }
                ViewOrderButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Button that allows customer to view all orders.
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void ViewOrderButton_Click(object sender, EventArgs e)
        {

            Orders order = new Orders();
            DataTable finaldatatable = order.GetAllOrders(dataGridView2, Orders.finalorderlist);
            order.GetCurrentOrder(this.dataGridView2,Customer.currentcustomer.Customerid);
            ClientOrders clientorders = new ClientOrders();
            clientorders.Table = finaldatatable;
            clientorders.Show();

        }

        /// <summary>
        /// Button that allos the removal an order or multiple of orders
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void Removeorderbutton_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            List<Orders> orderslist;
            orderslist=order.CancelOrder(Orders.finalorderlist, Product.finalproductlist, dataGridView2);
            order.GetAllOrders(this.dataGridView2, orderslist);
        }


        /// <summary>
        /// Initializes any components when the form loads
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void ClientStore_Load(object sender, EventArgs e)
        {
            categorySortcombobox.Items.Add("All");
            categorySortcombobox.Items.Add("Desktop");
            categorySortcombobox.Items.Add("Laptop");
            categorySortcombobox.Items.Add("Accessories");
            categorySortcombobox.Items.Add("Software");
            categorySortcombobox.Items.Add("Hardware");
            categorySortcombobox.Items.Add("Other");
            categorySortcombobox.SelectedItem = "All";
            GetAllProducts_Click(sender, e);
            toolStripStatusLabel1.Text = "";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AccountInfoButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
        }

        private void PlaceOrderButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to place an order";
        }

        private void GetAllProducts_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to get all products";
        }

        private void Removeorderbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Select an order from table and cick yhis button yo remove products";
        }

        private void ViewOrderButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to View All of your Order";
        }

        private void ClientStore_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void quantitytextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter quantity";
        }

        private void categorySortcombobox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Sort Products by category";
        }

        private void AccountInfoButton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to view your account information and change if you like";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }



    }
}
