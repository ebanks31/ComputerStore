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

namespace ComputerStore
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }


        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            SQLConnect sql = new SQLConnect();
            string query = querybox.Text;
            System.Data.SqlClient.SqlConnection sqlconn = sql.SQLconnect();
            string queryresult = sql.QueryDatabase(sqlconn,query);

            resultbox.Text=queryresult;


        }

        private void SQL_Load(object sender, EventArgs e)
        {

        }
    }
}
