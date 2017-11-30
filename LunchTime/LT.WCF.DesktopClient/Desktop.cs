using System;
using System.Linq;
using System.Windows.Forms;

namespace LT.WCF.DesktopClient
{
    public partial class Desktop : Form
    {
        WcfServiceReference.WcfServiceClient client = new WcfServiceReference.WcfServiceClient();
        private Guid Guid;
        private string cpr;
        private int OrderId;

        public Desktop()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                cpr = cprNrBox.Text;
                //Guid = new Guid(input);

                ordreDataGridView.DataSource = client.GetOrders(cpr);
               // dataGridView1.DataSource = client.GetOrderItems(client.GetOrders(cpr).First().Id);
                //dataGridView2.DataSource = client.GetProducts(client.GetOrderItems(client.GetOrders(cpr).First().Id).First().ProductId);
            }
            catch (Exception)

            {
                MessageBox.Show("CPR NR IKKE FUNDET - PRØV IGEN!");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = ordreDataGridView.CurrentCell.RowIndex;

                OrderId = Int32.Parse(ordreDataGridView.Rows[rowindex].Cells[1].Value.ToString());

                //dataGridView1.DataSource = client.GetOrderItems(OrderId);

                client.CloseOrder(OrderId);

                MessageBox.Show($"Ordre #{OrderId} er blevet afsluttet", $"CPR NR:{cpr} - Ordre afsluttet");

                ordreDataGridView.DataSource = "";

                cprNrBox.Text = "Indtast CPR-nr";
            }
            catch (Exception)
            {
                MessageBox.Show("DER ER IKKE MARKERET NOGEN ORDRE - PRØV AT SØG ET CPR NR OP!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.SelectAll();
        }
    }
}
