using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerStore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace ComputerStoreTest
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestGetSearchResultsMethod()
        {
            Product product = new Product();
            DataTable datatable = product.GetSearchResults(Product.queryStr);
            int rowcount = datatable.Rows.Count;
            Assert.IsTrue(rowcount > 0, "The actualCount was not greater than zero");
        }

        [TestMethod]
        public void TestGetSearchResultsWithEmptyString() 
        {
            Product product = new Product();
            DataTable datatable = product.GetSearchResults("");
            int rowcount = datatable.Rows.Count;
            Assert.AreEqual(rowcount, 0);

        }

        [TestMethod]
        public void TestUpdateProductListMethod()
        {
            Product product = new Product();
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();

            product.UpdateProductList(product.QueryStr, dataGridView1);

            DataTable dt = (DataTable)dataGridView1.DataSource;
            int rowcount = dt.Columns.Count;
            Assert.AreEqual(rowcount, 9);

        }

        
        /*
        [TestMethod]
        public void TestgetCurrentProductIDMethod()
        {
            Product product = new Product();
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView1.DataSource = product.GetSearchResults(Product.queryStr);
            ProductForm productform = new ProductForm();
            productform.Show();


            ArrayList productlist = product.getCurrentProductID(dataGridView1);

            int rowcount = productlist.Count;
            Assert.AreEqual(rowcount, 9);

        }*/

        [TestMethod]
        public void TestGetCurrentUserProductListMethod()
        {
            Product product = new Product();
            ArrayList currentproductidlist = new ArrayList();
            currentproductidlist.Add(1);
            currentproductidlist.Add(2);
            currentproductidlist.Add(3);
            Product product1 = new Product(1, 23, 34, 56, 78, 88, "shoes", "brand", "clothes");
            Product product2 = new Product(2, 233, 34, 56, 78, 88, "shirt", "brand", "clothes");
            Product product3 = new Product(3, 234, 34, 56, 78, 88, "hat", "brand", "clothes");
            List<Product> productlist = new List<Product>();
            productlist.Add(product1);
            productlist.Add(product2);
            productlist.Add(product3);

            List<Product> currentproductlist =product.GetCurrentUserProductList(productlist, currentproductidlist);

            Assert.AreEqual(currentproductlist.Count, 3);

        }

        [TestMethod]
        public void TestGetCurrentUserProductListMethodEmptyProductList()
        {
            Product product = new Product();
            ArrayList currentproductidlist = new ArrayList();
            currentproductidlist.Add(1);
            currentproductidlist.Add(2);
            currentproductidlist.Add(3);
            Product product1 = new Product(1, 23, 34, 56, 78, 88, "shoes", "brand", "clothes");
            Product product2 = new Product(2, 233, 34, 56, 78, 88, "shirt", "brand", "clothes");
            Product product3 = new Product(3, 234, 34, 56, 78, 88, "hat", "brand", "clothes");
            List<Product> productlist = new List<Product>();

            List<Product> currentproductlist = product.GetCurrentUserProductList(productlist, currentproductidlist);

            Assert.AreEqual(currentproductlist.Count, 0);

        }

        [TestMethod]
        public void TestFilterByCategorySearchResultsMethod()
        {
            Product product = new Product();
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();
            product.FilterByCategorySearchResults("Desktop", dataGridView1);
            DataTable dt = (DataTable)dataGridView1.DataSource;
            int rowcount = dt.Rows.Count;

            Assert.AreEqual(4, rowcount);

        }

    }

}
