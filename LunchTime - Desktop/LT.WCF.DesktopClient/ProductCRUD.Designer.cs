namespace LT.WCF.DesktopClient
{
    partial class ProductCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCRUD));
            this.produkterGroupBox = new System.Windows.Forms.GroupBox();
            this.produktDataGridView = new System.Windows.Forms.DataGridView();
            this.opretKnap = new System.Windows.Forms.Button();
            this.opdaterKnap = new System.Windows.Forms.Button();
            this.rydKnap = new System.Windows.Forms.Button();
            this.produktNavnTextBox = new System.Windows.Forms.TextBox();
            this.produktBeskrivelseTextBox = new System.Windows.Forms.TextBox();
            this.produktPrisTextBox = new System.Windows.Forms.TextBox();
            this.produktLagerTextBox = new System.Windows.Forms.TextBox();
            this.produktGroupBox = new System.Windows.Forms.GroupBox();
            this.produktLagerLbl = new System.Windows.Forms.Label();
            this.produktPrisLbl = new System.Windows.Forms.Label();
            this.produktBeskrivelseLbl = new System.Windows.Forms.Label();
            this.produktNavnLbl = new System.Windows.Forms.Label();
            this.produktIdLbl = new System.Windows.Forms.Label();
            this.produktIdTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produkterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).BeginInit();
            this.produktGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produkterGroupBox
            // 
            this.produkterGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.produkterGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.produkterGroupBox.Controls.Add(this.produktDataGridView);
            this.produkterGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.produkterGroupBox.Location = new System.Drawing.Point(31, 21);
            this.produkterGroupBox.Name = "produkterGroupBox";
            this.produkterGroupBox.Size = new System.Drawing.Size(1175, 415);
            this.produkterGroupBox.TabIndex = 0;
            this.produkterGroupBox.TabStop = false;
            this.produkterGroupBox.Text = "Produkter (viser alle produkter)";
            // 
            // produktDataGridView
            // 
            this.produktDataGridView.AutoGenerateColumns = false;
            this.produktDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.produktDataGridView.DataSource = this.productBindingSource;
            this.produktDataGridView.Location = new System.Drawing.Point(6, 30);
            this.produktDataGridView.Name = "produktDataGridView";
            this.produktDataGridView.RowTemplate.Height = 33;
            this.produktDataGridView.Size = new System.Drawing.Size(1163, 378);
            this.produktDataGridView.TabIndex = 0;
            this.produktDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduktDataGridView_CellContentClick);
            // 
            // opretKnap
            // 
            this.opretKnap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opretKnap.Location = new System.Drawing.Point(940, 31);
            this.opretKnap.Name = "opretKnap";
            this.opretKnap.Size = new System.Drawing.Size(214, 67);
            this.opretKnap.TabIndex = 1;
            this.opretKnap.Text = "Opret";
            this.opretKnap.UseVisualStyleBackColor = true;
            this.opretKnap.Click += new System.EventHandler(this.OpretKnap_Click);
            // 
            // opdaterKnap
            // 
            this.opdaterKnap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opdaterKnap.Location = new System.Drawing.Point(940, 118);
            this.opdaterKnap.Name = "opdaterKnap";
            this.opdaterKnap.Size = new System.Drawing.Size(213, 68);
            this.opdaterKnap.TabIndex = 2;
            this.opdaterKnap.Text = "Opdatér";
            this.opdaterKnap.UseVisualStyleBackColor = true;
            this.opdaterKnap.Click += new System.EventHandler(this.OpdaterKnap_Click);
            // 
            // rydKnap
            // 
            this.rydKnap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rydKnap.Location = new System.Drawing.Point(940, 208);
            this.rydKnap.Name = "rydKnap";
            this.rydKnap.Size = new System.Drawing.Size(213, 63);
            this.rydKnap.TabIndex = 3;
            this.rydKnap.Text = "Ryd";
            this.rydKnap.UseVisualStyleBackColor = true;
            this.rydKnap.Click += new System.EventHandler(this.SletKnap_Click);
            // 
            // produktNavnTextBox
            // 
            this.produktNavnTextBox.Location = new System.Drawing.Point(254, 90);
            this.produktNavnTextBox.Name = "produktNavnTextBox";
            this.produktNavnTextBox.Size = new System.Drawing.Size(345, 31);
            this.produktNavnTextBox.TabIndex = 4;
            this.produktNavnTextBox.Text = "Indtast produktnavn";
            // 
            // produktBeskrivelseTextBox
            // 
            this.produktBeskrivelseTextBox.Location = new System.Drawing.Point(254, 128);
            this.produktBeskrivelseTextBox.Name = "produktBeskrivelseTextBox";
            this.produktBeskrivelseTextBox.Size = new System.Drawing.Size(345, 31);
            this.produktBeskrivelseTextBox.TabIndex = 5;
            this.produktBeskrivelseTextBox.Text = "Indtast produktbeskrivelse";
            // 
            // produktPrisTextBox
            // 
            this.produktPrisTextBox.Location = new System.Drawing.Point(254, 166);
            this.produktPrisTextBox.Name = "produktPrisTextBox";
            this.produktPrisTextBox.Size = new System.Drawing.Size(345, 31);
            this.produktPrisTextBox.TabIndex = 6;
            this.produktPrisTextBox.Text = "Indtast produktpris";
            // 
            // produktLagerTextBox
            // 
            this.produktLagerTextBox.Location = new System.Drawing.Point(254, 204);
            this.produktLagerTextBox.Name = "produktLagerTextBox";
            this.produktLagerTextBox.Size = new System.Drawing.Size(345, 31);
            this.produktLagerTextBox.TabIndex = 7;
            this.produktLagerTextBox.Text = "Indtast produktlager";
            // 
            // produktGroupBox
            // 
            this.produktGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.produktGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("produktGroupBox.BackgroundImage")));
            this.produktGroupBox.Controls.Add(this.produktLagerLbl);
            this.produktGroupBox.Controls.Add(this.produktPrisLbl);
            this.produktGroupBox.Controls.Add(this.produktBeskrivelseLbl);
            this.produktGroupBox.Controls.Add(this.produktNavnLbl);
            this.produktGroupBox.Controls.Add(this.produktIdLbl);
            this.produktGroupBox.Controls.Add(this.produktIdTextBox);
            this.produktGroupBox.Controls.Add(this.rydKnap);
            this.produktGroupBox.Controls.Add(this.opdaterKnap);
            this.produktGroupBox.Controls.Add(this.produktLagerTextBox);
            this.produktGroupBox.Controls.Add(this.opretKnap);
            this.produktGroupBox.Controls.Add(this.produktPrisTextBox);
            this.produktGroupBox.Controls.Add(this.produktNavnTextBox);
            this.produktGroupBox.Controls.Add(this.produktBeskrivelseTextBox);
            this.produktGroupBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.produktGroupBox.Location = new System.Drawing.Point(31, 456);
            this.produktGroupBox.Name = "produktGroupBox";
            this.produktGroupBox.Size = new System.Drawing.Size(1175, 305);
            this.produktGroupBox.TabIndex = 8;
            this.produktGroupBox.TabStop = false;
            this.produktGroupBox.Text = "Produkt Info (opret/opdatér/ryd produkt(er))";
            // 
            // produktLagerLbl
            // 
            this.produktLagerLbl.AutoSize = true;
            this.produktLagerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produktLagerLbl.Location = new System.Drawing.Point(7, 204);
            this.produktLagerLbl.Name = "produktLagerLbl";
            this.produktLagerLbl.Size = new System.Drawing.Size(73, 25);
            this.produktLagerLbl.TabIndex = 13;
            this.produktLagerLbl.Text = "Lager:";
            // 
            // produktPrisLbl
            // 
            this.produktPrisLbl.AutoSize = true;
            this.produktPrisLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produktPrisLbl.Location = new System.Drawing.Point(7, 166);
            this.produktPrisLbl.Name = "produktPrisLbl";
            this.produktPrisLbl.Size = new System.Drawing.Size(55, 25);
            this.produktPrisLbl.TabIndex = 12;
            this.produktPrisLbl.Text = "Pris:";
            // 
            // produktBeskrivelseLbl
            // 
            this.produktBeskrivelseLbl.AutoSize = true;
            this.produktBeskrivelseLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produktBeskrivelseLbl.Location = new System.Drawing.Point(7, 131);
            this.produktBeskrivelseLbl.Name = "produktBeskrivelseLbl";
            this.produktBeskrivelseLbl.Size = new System.Drawing.Size(129, 25);
            this.produktBeskrivelseLbl.TabIndex = 11;
            this.produktBeskrivelseLbl.Text = "Beskrivelse:";
            // 
            // produktNavnLbl
            // 
            this.produktNavnLbl.AutoSize = true;
            this.produktNavnLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produktNavnLbl.Location = new System.Drawing.Point(7, 93);
            this.produktNavnLbl.Name = "produktNavnLbl";
            this.produktNavnLbl.Size = new System.Drawing.Size(68, 25);
            this.produktNavnLbl.TabIndex = 10;
            this.produktNavnLbl.Text = "Navn:";
            // 
            // produktIdLbl
            // 
            this.produktIdLbl.AutoSize = true;
            this.produktIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produktIdLbl.Location = new System.Drawing.Point(7, 53);
            this.produktIdLbl.Name = "produktIdLbl";
            this.produktIdLbl.Size = new System.Drawing.Size(38, 25);
            this.produktIdLbl.TabIndex = 9;
            this.produktIdLbl.Text = "ID:";
            // 
            // produktIdTextBox
            // 
            this.produktIdTextBox.Enabled = false;
            this.produktIdTextBox.Location = new System.Drawing.Point(254, 53);
            this.produktIdTextBox.Name = "produktIdTextBox";
            this.produktIdTextBox.Size = new System.Drawing.Size(345, 31);
            this.produktIdTextBox.TabIndex = 8;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LT.WCF.DesktopClient.WcfServiceReference.Product);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Produkt Beskrivelse";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Produkt Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Produkt Navn";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Produkt Pris";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Produkt Lager";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // ProductCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 911);
            this.Controls.Add(this.produkterGroupBox);
            this.Controls.Add(this.produktGroupBox);
            this.Name = "ProductCRUD";
            this.Text = "LunchTime - Desktop: Ekspedient - Håndtér produkter";
            this.Load += new System.EventHandler(this.ProductCRUD_Load);
            this.produkterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).EndInit();
            this.produktGroupBox.ResumeLayout(false);
            this.produktGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox produkterGroupBox;
        private System.Windows.Forms.DataGridView produktDataGridView;
        private System.Windows.Forms.Button opretKnap;
        private System.Windows.Forms.Button opdaterKnap;
        private System.Windows.Forms.Button rydKnap;
        private System.Windows.Forms.TextBox produktNavnTextBox;
        private System.Windows.Forms.TextBox produktBeskrivelseTextBox;
        private System.Windows.Forms.TextBox produktPrisTextBox;
        private System.Windows.Forms.TextBox produktLagerTextBox;
        private System.Windows.Forms.GroupBox produktGroupBox;
        private System.Windows.Forms.TextBox produktIdTextBox;
        private System.Windows.Forms.Label produktLagerLbl;
        private System.Windows.Forms.Label produktPrisLbl;
        private System.Windows.Forms.Label produktBeskrivelseLbl;
        private System.Windows.Forms.Label produktNavnLbl;
        private System.Windows.Forms.Label produktIdLbl;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}