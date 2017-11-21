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
    public partial class Desktop : Form
    {
        WcfServiceReference.WcfServiceClient client = new WcfServiceReference.WcfServiceClient();
        private Guid Guid;
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
                var input = cprNrBox.Text;

                Guid = new Guid(input);

                ordreDataGridView.DataSource = client.GetOrders(Guid);
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

                var Id = ordreDataGridView.Rows[rowindex].Cells[1].Value.ToString();

                client.CloseOrder(Int32.Parse(Id));

                MessageBox.Show($"Ordre #{Id} er blevet afsluttet", $"CPR NR:{Guid} - Ordre afsluttet");

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
