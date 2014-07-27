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
    public partial class ProductForm : Form
    {
        /// <summary>
        /// Default Constructor of the Product Form
        /// </summary>
        public ProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to get all products from database and set products to datagrid
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Evemt Arguments</param>
        private void getallproducts_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //ArrayList result = product.GetAllProducts();

           // product.InsertDatabase(result);
            product.UpdateProductList(product.QueryStr, this.dataGridView1);

        }

        /// <summary>
        /// Button to remove product from database
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void removeproductbutton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            string category = categorySortCombobox.SelectedItem.ToString();
            ArrayList productlist=product.getCurrentProductID(this.dataGridView1);

            if (productlist != null)
            {
                product.RemoveProduct(productlist, this.dataGridView1);
            }

        }

        /// <summary>
        /// Button that adds a product to the database
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void addproductbutton_Click(object sender, EventArgs e)
        {
            string productname = productNametextbox.Text;
            string width = widthtextbox.Text;
            string height = heighttextbox.Text;
            string brand = brandtextbox.Text;
            string productid = productIDtextbox.Text;
            string cost = costtextbox.Text;
            string weight = weighttextbox.Text;
            string category = categoryproductcombobox.SelectedItem.ToString();
            string length = lengthtextbox.Text;


            Product product = new Product();
            ArrayList listofproductvalues = product.AddProductToArraylist(productname, width, height, brand, productid, cost, weight, category, length);

            product.InsertDatabase(listofproductvalues);
            product.UpdateProductList(product.QueryStr, this.dataGridView1);
        }

        /// <summary>
        /// Sort the database by specified category
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void categorySortCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            string selecteditem = categorySortCombobox.SelectedItem.ToString();
            if (selecteditem.Equals("All"))
            {
                getallproducts_Click(sender, e);
            }
            else
            {
               product.FilterByCategorySearchResults(selecteditem,this.dataGridView1);
            }
        }


        /// <summary>
        /// Initializes component when the form loads
        /// </summary>
        /// <param name="sender">sender of event</param>
        /// <param name="e">Event Arguments</param>
        private void ProductForm_Load(object sender, EventArgs e)
        {
            categorySortCombobox.Items.Add("All");
            categorySortCombobox.Items.Add("Desktop");
            categorySortCombobox.Items.Add("Laptop");
            categorySortCombobox.Items.Add("Accessories");
            categorySortCombobox.Items.Add("Software");
            categorySortCombobox.Items.Add("Hardware");
            categorySortCombobox.Items.Add("Other");
            categorySortCombobox.SelectedItem = "All";

            categoryproductcombobox.Items.Add("Desktop");
            categoryproductcombobox.Items.Add("Laptop");
            categoryproductcombobox.Items.Add("Accessories");
            categoryproductcombobox.Items.Add("Software");
            categoryproductcombobox.Items.Add("Hardware");
            categoryproductcombobox.Items.Add("Other");
            categoryproductcombobox.SelectedItem = "Desktop";

            
            Product product = new Product();
            product.UpdateProductList(product.QueryStr, this.dataGridView1);
            toolStripStatusLabel1.Text = "";
        }

        private void removeproductbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Remove Product(s)";
        }

        private void getallproducts_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Get All Products";
        }

        private void addproductbutton_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Add a Product";
        }

        private void ProductForm_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void productNametextbox_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid Product Name";
        }

        private void weighttextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid weight";
        }


        private void heighttextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid height";
        }

        private void widthtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid width";
        }

        private void brandtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid brand";
        }

        private void productIDtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter a valid product id";
        }

        private void categoryproductcombobox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose a valid category";
        }

        private void costtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose a valid cost";
        }

        private void lengthtextbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose a valid length";
        }

        private void categorySortCombobox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Sort the Product by category";
        }

    }
}
