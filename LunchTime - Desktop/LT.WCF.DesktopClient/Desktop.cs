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
                ordreDataGridView.DataSource = "";

                _idNr = idNrBox.Text;
                // ordren bliver hentet ud fra id nr og vist i ordreDataGridView
                ordreDataGridView.DataSource = _client.GetOrders(_idNr);

                // vi tjekker størrelserne på vores elementer for at undgå eventuelle null pointer fejl
                if (_client.GetOrders(_idNr).Length == 0 && ordreDataGridView.Rows.Count == 0)
                    {
                    MessageBox.Show(@"ID NR IKKE FUNDET ELLER INGEN AKTIVE ORDRE PÅ DETTE ID");
                    }

            }
            catch (Exception)
            {
                MessageBox.Show(@"DER GIK ET ELLER ANDET GALT");
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

                // her "tømmer" vi vores ordredatagridview efter afsluttet ordre
                ordreDataGridView.DataSource = "";

                idNrBox.Text = @"Scan ID-nr";
            }
            catch (Exception)
            {
                MessageBox.Show(@"DER ER IKKE MARKERET NOGEN ORDRE - PRØV AT SØG ET ID NR OP!");
            }

        }
    }
}
