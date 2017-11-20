using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wcf.DesktopClient
{
    public partial class Form1 : Form
    {
        WcfServiceReference.WcfServiceClient client = new WcfServiceReference.WcfServiceClient();
        private Guid Guid;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

           // dataGridView1.DataSource = client.GetOrders();

           // client.GetCustomers();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;

            Guid = new Guid(input);

            dataGridView1.DataSource = client.GetOrders(Guid);

          //label1.Text = client.GetCustomer(Guid).FirstName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = 0;

            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                Id = Convert.ToInt32(dgvr.Cells[1].Value);
            }
           // int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            client.CloseOrder(Id); 
        }
    }
}
