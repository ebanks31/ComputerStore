using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class ClientOrders : Form
    {
        public DataTable Table { get; set; }

        public ClientOrders()
        {
            InitializeComponent();
        }

        public ClientOrders(List<Orders> dataGridView)
        {
            this.orderdataGridView1.DataSource = dataGridView;
            InitializeComponent();
        }

        private void ClientRental_Click(object sender, EventArgs e)
        {
            ClientStore clientrental = new ClientStore();
            clientrental.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void orderdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientOrders_Load(object sender, EventArgs e)
        {
            this.orderdataGridView1.DataSource = Table;
        }
    }
}
