using System;
using System.Linq;
using System.Windows.Forms;

namespace LT.WCF.DesktopClient
{
    public partial class Desktop : Form
    {
        // WCF Service klienten bliver initialiseret således at vi kan kommunikere med hosten
        private readonly WcfServiceReference.WcfServiceClient _client = new WcfServiceReference.WcfServiceClient();
        private string _idNr;
        public Desktop()
        {
            InitializeComponent();
        }

        private void ScanId_Click(object sender, EventArgs e)
        {
            try
            {    
                _idNr = idNrBox.Text;
                // ordren bliver hentet ud fra id nr og vist i ordreDataGridView
                ordreDataGridView.DataSource = _client.GetOrders(_idNr);
                // ordrelinjen bliver således hentet udfra ordre nr ved hjælp af ovenstående metode og vist i ordreItemsDataGridView
                ordreItemsDataGridView.DataSource = _client.GetOrderItems(_client.GetOrders(_idNr).First().Id);
            }
            catch (Exception)

            {
                MessageBox.Show(@"ID NR IKKE FUNDET - PRØV IGEN!");
            }

        }

        private void AfslutOrdre_Click(object sender, EventArgs e)
        {
            try
            {
                var rowindex = ordreDataGridView.CurrentCell.RowIndex;
                // ordre id'et bliver fundet via. nuværende række samt celle på plads 1
                var id = ordreDataGridView.Rows[rowindex].Cells[1].Value.ToString();
                // ordren bliver således afsluttet ud fra ordre id'et
                _client.CloseOrder(int.Parse(id));

                MessageBox.Show($@"Ordre #{id} er blevet afsluttet", $@"ID NR: {_idNr} - Ordre afsluttet");

                ordreDataGridView.DataSource = "";
                ordreItemsDataGridView.DataSource = "";
                produktDataGridView.DataSource = "";

                idNrBox.Text = @"Scan ID-nr";
            }
            catch (Exception)
            {
                MessageBox.Show(@"DER ER IKKE MARKERET NOGEN ORDRE - PRØV AT SØG ET ID NR OP!");
            }

        }

        private void OrdreItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rowindex = ordreItemsDataGridView.CurrentCell.RowIndex;

                var id = ordreItemsDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                // produkt id'et bliver fundet via. nuværende række samt celle på plads 0 og vist i produktDataGridView
                produktDataGridView.DataSource = _client.GetProducts(int.Parse(id));
            }
            catch (Exception)
            {
                MessageBox.Show(@"DER GIK ET ELLER ANDET GALT");
            }
        }
    }
}
