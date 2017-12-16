using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LT.WCF.DesktopClient.WcfServiceReference;

namespace LT.WCF.DesktopClient
{
    public partial class ProductCRUD : Form
    {
        // WCF Service klienten bliver initialiseret således at vi kan kommunikere med hosten
        private readonly WcfServiceReference.WcfServiceClient _client = new WcfServiceReference.WcfServiceClient();
        public ProductCRUD()
        {
            InitializeComponent();
        }

        private void ProductCRUD_Load(object sender, EventArgs e)
        {
           produktDataGridView.DataSource = _client.GetProducts();
        }

        private void OpretKnap_Click(object sender, EventArgs e)
        {
            _client.CreateProduct(produktNavnTextBox.Text, produktBeskrivelseTextBox.Text, double.Parse(produktPrisTextBox.Text), int.Parse(produktLagerTextBox.Text));

            produktIdTextBox.Text = "";
            produktNavnTextBox.Text = @"Indtast produktnavn";
            produktBeskrivelseTextBox.Text = @"Indtast produktbeskrivelse";
            produktPrisTextBox.Text = @"Indtast produktpris";
            produktLagerTextBox.Text = @"Indtast produktlager";

            produktDataGridView.DataSource = _client.GetProducts();
        }

        private void OpdaterKnap_Click(object sender, EventArgs e)
        {

            _client.UpdateProduct(int.Parse(produktIdTextBox.Text), produktNavnTextBox.Text, produktBeskrivelseTextBox.Text, double.Parse(produktPrisTextBox.Text), int.Parse(produktLagerTextBox.Text));

            produktIdTextBox.Text = "";
            produktNavnTextBox.Text = @"Indtast produktnavn";
            produktBeskrivelseTextBox.Text = @"Indtast produktbeskrivelse";
            produktPrisTextBox.Text = @"Indtast produktpris";
            produktLagerTextBox.Text = @"Indtast produktlager";

            produktDataGridView.DataSource = _client.GetProducts();
        }

        private void SletKnap_Click(object sender, EventArgs e)
        {

            produktIdTextBox.Text = "";
            produktNavnTextBox.Text = @"Indtast produktnavn";
            produktBeskrivelseTextBox.Text = @"Indtast produktbeskrivelse";
            produktPrisTextBox.Text = @"Indtast produktpris";
            produktLagerTextBox.Text = @"Indtast produktlager";

            produktDataGridView.DataSource = _client.GetProducts();
        }

        private void ProduktDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = produktDataGridView.CurrentCell.RowIndex;

            var id = produktDataGridView.Rows[rowindex].Cells[1].Value.ToString();

            produktDataGridView.DataSource = _client.GetProductById(int.Parse(id));

            Product p = _client.GetProductById(int.Parse(id));

            produktIdTextBox.Text = p.Id.ToString();
            produktNavnTextBox.Text = p.Name;
            produktBeskrivelseTextBox.Text = p.Description;
            produktPrisTextBox.Text = p.Price.ToString();
            produktLagerTextBox.Text = p.Stock.ToString();

            produktDataGridView.DataSource = _client.GetProducts();
        }
    }
}
