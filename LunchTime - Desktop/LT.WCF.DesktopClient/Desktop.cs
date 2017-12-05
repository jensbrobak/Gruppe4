using System;
using System.Linq;
using System.Windows.Forms;

namespace LT.WCF.DesktopClient
{
    public partial class Desktop : Form
    {
        WcfServiceReference.WcfServiceClient client = new WcfServiceReference.WcfServiceClient();
        private string idNr;
        public Desktop()
        {
            InitializeComponent();
        }

        private void scanId_Click(object sender, EventArgs e)
        {
            try
            {
                idNr = idNrBox.Text;

                ordreDataGridView.DataSource = client.GetOrders(idNr);
                ordreItemsDataGridView.DataSource = client.GetOrderItems(client.GetOrders(idNr).First().Id);
            }
            catch (Exception)

            {
                MessageBox.Show("ID NR IKKE FUNDET - PRØV IGEN!");
            }

        }

        private void afslutOrdre_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = ordreDataGridView.CurrentCell.RowIndex;

                var id = ordreDataGridView.Rows[rowindex].Cells[1].Value.ToString();

                client.CloseOrder(Int32.Parse(id));

                MessageBox.Show($"Ordre #{id} er blevet afsluttet", $"ID NR: {idNr} - Ordre afsluttet");

                ordreDataGridView.DataSource = "";
                ordreItemsDataGridView.DataSource = "";
                produktDataGridView.DataSource = "";

                idNrBox.Text = "Indtast ID-nr";
            }
            catch (Exception)
            {
                MessageBox.Show("DER ER IKKE MARKERET NOGEN ORDRE - PRØV AT SØG ET ID NR OP!");
            }

        }

        private void ordreItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = ordreItemsDataGridView.CurrentCell.RowIndex;

                var id = ordreItemsDataGridView.Rows[rowindex].Cells[1].Value.ToString();

                produktDataGridView.DataSource = client.GetProducts(Int32.Parse(id));
            }
            catch (Exception)
            {
                MessageBox.Show("DER GIK ET ELLER ANDET GALT");
            }
        }
    }
}
