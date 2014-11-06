using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
namespace ComputerStore
{
    /// <summary>
    /// This class has methods and properties for a Product 
    /// </summary>
    public class Product
    {

        private double weight;
        private double height;
        private double width;
        private int productid;
        private string productname;
        private double cost;
        private double length;
        private string brand;
        private string category;
        private List<Product> productlist;

        public static List<Product> finalproductlist;

        public const string queryStr = "SELECT * from Product";

        /// <summary>
        /// Proerty for Query String
        /// </summary>
        public string QueryStr
        {
            get { return queryStr; }
        }

        /// <summary>
        /// Property for Product's Weight
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /// <summary>
        /// Property for List of Products
        /// </summary>
        public List<Product> ProductList
        {
            get { return productlist; }
            set { productlist = value; }
        }

        /// <summary>
        /// Property for Product's Height
        /// </summary>
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Property for Product's Width
        /// </summary>
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Property for Product's Name
        /// </summary>
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

        /// <summary>
        /// Property for Product's Cost
        /// </summary>
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        /// <summary>
        /// Property for Product's Length
        /// </summary>
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// Property for Product's Brand
        /// </summary>
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        /// <summary>
        /// Property for Product's ID
        /// </summary>
        public int ProductID
        {
            get { return productid; }
            set { productid = value; }
        }

        /// <summary>
        /// Property for Product's Category
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }

        }


        /// <summary>
        /// Overloaded constructor of product class. This construct initializes the property values from the parameter taken in.
        /// </summary>
        /// <param name="productid">Product's product id</param>
        /// <param name="length">Product's length</param>
        /// <param name="width">Product's width</param>
        /// <param name="height">Product's height</param>
        /// <param name="weight">Product's weight</param>
        /// <param name="cost">Product's cost</param>
        /// <param name="productname">Product's name</param>
        /// <param name="brand">Product's brand</param>
        /// <param name="category">Product's category</param>
        public Product(int productid, double length, double width, double height, double weight, double cost, string productname, string brand,string category)
        {
            Weight = weight;
            Height = height;
            Width = width;
            ProductName = productname;
            Cost = cost;
            Length = length;
            Brand = brand;
            ProductID = productid;
            Category = category;
        }

        /// <summary>
        /// Default constructor of Product class
        /// </summary>
        public Product()
        {


        }


        /// <summary>
        /// This method insert into data based on Product object fields
        /// </summary>
        /// <param name="myConnection">Connection to database</param>
        /// <param name="productfieldlist">Product id fields</param>
        public void InsertDatabase(ArrayList productfieldlist)
        {
            string insertquery = "INSERT INTO PRODUCT VALUES (@productname,@width,@height,@brand,@productid,@cost,@weight,@category,@length)";
       

                            using (SqlConnection myConnection = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                try
                {
                SqlCommand myCommand = new SqlCommand(insertquery, myConnection);
                myCommand.CommandText = insertquery;
                myCommand.Parameters.AddWithValue("@productname", productfieldlist[0].ToString());
                myCommand.Parameters.AddWithValue("@width", productfieldlist[1].ToString());
                myCommand.Parameters.AddWithValue("@height", productfieldlist[2].ToString());
                myCommand.Parameters.AddWithValue("@brand", productfieldlist[3].ToString());
                myCommand.Parameters.AddWithValue("@productid", productfieldlist[4].ToString());
                myCommand.Parameters.AddWithValue("@cost", productfieldlist[5].ToString());
                myCommand.Parameters.AddWithValue("@weight", productfieldlist[6].ToString());
                myCommand.Parameters.AddWithValue("@category", productfieldlist[7].ToString());
                myCommand.Parameters.AddWithValue("@length", productfieldlist[8].ToString());
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
        /// Get all products from database
        /// </summary>
        /// <returns>ArrayList of all products from database</returns>
        public ArrayList GetAllProducts()
        {
            string query = "SELECT * FROM PRODUCT";
            SQLConnect sql = new SQLConnect();
            System.Data.SqlClient.SqlConnection sqlconn = sql.SQLconnect();
            ArrayList queryresult = this.ProductQueryDatabase(sqlconn, query);

            return queryresult;
        }

        /// <summary>
        /// This method gets the product from database
        /// </summary>
        /// <param name="myConnection">Connection to database</param>
        /// <param name="productquery">Query to select all products from database</param>
        /// <returns>ArrayList of products from database</returns>
        public ArrayList ProductQueryDatabase(SqlConnection myConnection, string productquery)
        {
            string result = "";
            ArrayList list = new ArrayList();
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(productquery, myConnection);
                myCommand.CommandText = productquery;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    string firstcolumn = myReader["ProductID"].ToString();
                    string secondcolumn = myReader["ProductName"].ToString();

                    result = firstcolumn + " " + secondcolumn;
                    list.Add(result);
                    result = "";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {

                myConnection.Close();
            }
            return list;
        }


        /// <summary>
        /// This method updates the product list from the product datagrid
        /// </summary>
        /// <param name="queryStr">Product query string for getting all products from database</param>
        /// <param name="productdataGridView1">Product datagrid for display</param>
        /// <returnsLiist of products</returns>
        public List<Product> UpdateProductList(string queryStr, DataGridView productdataGridView1)
        {
            productdataGridView1.DataSource = GetSearchResults(queryStr);

            List<Product> productlist = new List<Product>();

            for (int j = 0; j < productdataGridView1.Rows.Count - 1; j++)
            {
                Product product = new Product();
                string category = "";
                int productid;
                productid = Convert.ToInt32(productdataGridView1[0, j].Value);
                double length;
                length = Convert.ToDouble(productdataGridView1[1, j].Value);
                double width;
                width = Convert.ToDouble(productdataGridView1[2, j].Value);
                double height;
                height = Convert.ToDouble(productdataGridView1[3, j].Value);
                double weight;
                weight = Convert.ToDouble(productdataGridView1[4, j].Value);
                double cost;
                cost = Convert.ToDouble(productdataGridView1[5, j].Value);

                string productname = productdataGridView1[6, j].Value.ToString();
                string brand = productdataGridView1[7, j].Value.ToString();
                category = productdataGridView1[8, j].Value.ToString();


                product = new Product(productid, length, width, height, weight, cost, productname, brand, category);
                productlist.Add(product);
                ProductList = productlist;


            }
            finalproductlist = productlist;
            return productlist;
        }

        /// <summary>
        /// Gets all information from product table from database and stores in datatable
        /// </summary>
        /// <param name="queryStr">Query to get all products from database</param>
        /// <returns>Datatable with all products from database</returns>
        public DataTable GetSearchResults(string queryStr)
        {
            DataTable datatable = null;
            try
            {
                using (SqlConnection sqlconnection = new SqlConnection(
                Properties.Settings.Default.DataConnectionString))
                {
                    sqlconnection.Open();

                    using (SqlDataAdapter a = new SqlDataAdapter(
                        queryStr, sqlconnection))
                    {

                        datatable = new DataTable();
                        a.Fill(datatable);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return datatable;
        }

        /// <summary>
        /// Remove a product from product datagrid. Product is selected by user
        /// </summary>
        /// <param name="productidsList">ArrayList of all productids</param>
        /// <param name="productdatagridview">datagrid for product display</param>
        /// <returns>datagrid for product display after the product has been removed</returns>
		public DataGridView RemoveProduct(ArrayList productidsList, DataGridView productdatagridview)
		{
		string deletequery="";
		
		for(int i=0;i<productidsList.Count;i++)
		{
		 int productid = Convert.ToInt32(productidsList[i].ToString());
		 
		 if(i==0)
		 {
		 deletequery="DELETE FROM PRODUCT WHERE ProductID IN (@productid"+i.ToString();
		 
		 }
		 else
		 {
		 deletequery+=",@"+productid+i.ToString();
		 }
		 deletequery+=")";
		}
		
		DeleteSelectedProductFromDatabase(deletequery,productidsList);
        UpdateProductList(queryStr, productdatagridview);
        return productdatagridview;
		
		}
		


        /// <summary>
        /// Filter products by a certain category
        /// </summary>
        /// <param name="selecteditem">selected category item</param>
        /// <param name="productdataGridView1">Product datagrid that is displayed</param>
        public void FilterByCategorySearchResults(string selecteditem, DataGridView productdataGridView1)
        {

            string insertquery = "SELECT * FROM PRODUCT WHERE category=@selectedItem";
            DataTable datatable = null;
            using (SqlConnection myconn = new SqlConnection(
            Properties.Settings.Default.DataConnectionString))
            {
                myconn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(
                    insertquery, myconn))
                {

                    adapter.SelectCommand.Parameters.AddWithValue("@selectedItem", selecteditem);

                    datatable = new DataTable();
                    adapter.Fill(datatable);
                }
            }
            productdataGridView1.DataSource = datatable;

        }


        /// <summary>
        /// Create an arraylist for the product ids from the selected row and selected cells of a datagrid
        /// </summary>
        /// <param name="productdataGridView1">product datagrid for display</param>
        /// <returns>Arraylist of product ids</returns>
        public ArrayList getCurrentProductID(DataGridView productdataGridView1)
        {

            ArrayList productidlist = new ArrayList();
                        for (int i = 0; i < productdataGridView1.SelectedRows.Count; i++)
            {
                        for (int j = 0; j < productdataGridView1.SelectedRows[i].Cells.Count-1; j++)
                    {
                        if (productdataGridView1.SelectedRows[i].Cells[j].ColumnIndex==0)//Name.Equals("ProductID"))
                        {
                            productidlist.Add(productdataGridView1.SelectedRows[i].Cells[j].Value);
                        }
                
 
                        }


                        }

                       ArrayList finallist = this.getCurrentProductIDSelectedCells(productidlist, productdataGridView1);
                       return finallist;

        }

        /// <summary>
        /// This method gets a arraylist of productid from the selected cells of a datagrid
        /// </summary>
        /// <param name="productidarraylist">List of products id from selected rows</param>
        /// <param name="productdatagridview1">Datagrid for the product display</param>
        /// <returns>ArrayList of productids</returns>
		public ArrayList getCurrentProductIDSelectedCells(ArrayList productidarraylist, DataGridView productdatagridview1)
		{

        for (int i = 0; i < productdatagridview1.SelectedCells.Count; i++)
            {
                if (!productidarraylist.Contains(productdatagridview1.SelectedCells[0].Value) || productidarraylist == null)
						{
                            productidarraylist.Add(productdatagridview1.SelectedCells[0].Value);
							}
                        }
                return productidarraylist;    
		}

        /// <summary>
        /// Get Current list of products given an array list of current user product ids
        /// </summary>
        /// <param name="productlist">List of all products</param>
        /// <param name="currentproductid">List of current user product id</param>
        /// <returns>Current list of product from product ids arraylist</returns>
        public List<Product> GetCurrentUserProductList(List<Product> productlist, ArrayList currentproductid)
        {
            List<Product> finalproductlist = new List<Product>();

            for(int i =0;i<productlist.Count;i++)
            {
                for(int j=0;j<currentproductid.Count;j++)
                {
                    int productid = Convert.ToInt32(currentproductid[j]);
                    if (productlist[i].ProductID == productid)
                    {
                        finalproductlist.Add(productlist[i]);
                    }

                }
            }

            return finalproductlist;
            
        }


        /// <summary>
        /// Delect a selected product from database
        /// </summary>
        /// <param name="queryresult">delete query string for Product table</param>
        /// <param name="productidlist">List of all products</param>
        public void DeleteSelectedProductFromDatabase(string queryresult,ArrayList productidlist)
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
							for(int i=0;i<productidlist.Count;i++)
							{
							string parameter="@productid"+i.ToString();
							int value=Convert.ToInt32(productidlist[i]);
							
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
        /// This methods adds product fields to an arraylist
        /// </summary>
        /// <param name="productname">Product's product name</param>
        /// <param name="width">Product's width</param>
        /// <param name="height">Product's height</param>
        /// <param name="brand">Product's brand</param>
        /// <param name="productid">Product's product id</param>
        /// <param name="cost">Product's cost</param>
        /// <param name="weight">Product's weight</param>
        /// <param name="category">Product's category</param>
        /// <param name="length">Product's length</param>
        /// <returns>Arraylist of product fields</returns>
        public ArrayList AddProductToArraylist(string productname, string width, string height, string brand, string productid, string cost, string weight, string category, string length)
		{
		    ArrayList list = new ArrayList();
            list.Add(productid);
            list.Add(length);
            list.Add(width);
            list.Add(height);
            list.Add(weight);
            list.Add(cost);
            list.Add(productname);
            list.Add(brand);
            list.Add(category);
			return list;
		}

		}
    }



