namespace LT.WCF.DesktopClient
{
    partial class Desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.ordreDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idScanKnap = new System.Windows.Forms.Button();
            this.idNrBox = new System.Windows.Forms.TextBox();
            this.afslutOrdreKnap = new System.Windows.Forms.Button();
            this.lunchTimeLbl = new System.Windows.Forms.Label();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lunchTimelbld = new System.Windows.Forms.Label();
            this.produktDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordreItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordreGroupBox = new System.Windows.Forms.GroupBox();
            this.ordreItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.produktGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreItemsDataGridView)).BeginInit();
            this.ordreGroupBox.SuspendLayout();
            this.ordreItemsGroupBox.SuspendLayout();
            this.produktGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordreDataGridView
            // 
            this.ordreDataGridView.AllowUserToAddRows = false;
            this.ordreDataGridView.AllowUserToDeleteRows = false;
            this.ordreDataGridView.AllowUserToResizeColumns = false;
            this.ordreDataGridView.AllowUserToResizeRows = false;
            this.ordreDataGridView.AutoGenerateColumns = false;
            this.ordreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.Id,
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.ordreDataGridView.DataSource = this.orderBindingSource;
            this.ordreDataGridView.Location = new System.Drawing.Point(9, 30);
            this.ordreDataGridView.MultiSelect = false;
            this.ordreDataGridView.Name = "ordreDataGridView";
            this.ordreDataGridView.ReadOnly = true;
            this.ordreDataGridView.RowTemplate.Height = 33;
            this.ordreDataGridView.Size = new System.Drawing.Size(1361, 250);
            this.ordreDataGridView.TabIndex = 0;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(LT.WCF.DesktopClient.WcfServiceReference.Order);
            // 
            // idScanKnap
            // 
            this.idScanKnap.Location = new System.Drawing.Point(409, 35);
            this.idScanKnap.Name = "idScanKnap";
            this.idScanKnap.Size = new System.Drawing.Size(147, 45);
            this.idScanKnap.TabIndex = 1;
            this.idScanKnap.Text = "Scan";
            this.idScanKnap.UseVisualStyleBackColor = true;
            this.idScanKnap.Click += new System.EventHandler(this.ScanId_Click);
            // 
            // idNrBox
            // 
            this.idNrBox.Location = new System.Drawing.Point(36, 39);
            this.idNrBox.Name = "idNrBox";
            this.idNrBox.Size = new System.Drawing.Size(348, 31);
            this.idNrBox.TabIndex = 3;
            this.idNrBox.Text = "Scan ID-nr";
            // 
            // afslutOrdreKnap
            // 
            this.afslutOrdreKnap.Location = new System.Drawing.Point(1150, 1018);
            this.afslutOrdreKnap.Name = "afslutOrdreKnap";
            this.afslutOrdreKnap.Size = new System.Drawing.Size(256, 68);
            this.afslutOrdreKnap.TabIndex = 4;
            this.afslutOrdreKnap.Text = "Afslut ordre";
            this.afslutOrdreKnap.UseVisualStyleBackColor = true;
            this.afslutOrdreKnap.Click += new System.EventHandler(this.AfslutOrdre_Click);
            // 
            // lunchTimeLbl
            // 
            this.lunchTimeLbl.AutoSize = true;
            this.lunchTimeLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lunchTimeLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchTimeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.lunchTimeLbl.Location = new System.Drawing.Point(1179, 27);
            this.lunchTimeLbl.Name = "lunchTimeLbl";
            this.lunchTimeLbl.Size = new System.Drawing.Size(236, 59);
            this.lunchTimeLbl.TabIndex = 5;
            this.lunchTimeLbl.Text = "LunchTime";
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(LT.WCF.DesktopClient.WcfServiceReference.OrderItem);
            // 
            // lunchTimelbld
            // 
            this.lunchTimelbld.AutoSize = true;
            this.lunchTimelbld.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lunchTimelbld.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchTimelbld.ForeColor = System.Drawing.SystemColors.Window;
            this.lunchTimelbld.Location = new System.Drawing.Point(1310, 9);
            this.lunchTimelbld.Name = "lunchTimelbld";
            this.lunchTimelbld.Size = new System.Drawing.Size(105, 33);
            this.lunchTimelbld.TabIndex = 7;
            this.lunchTimelbld.Text = "Desktop";
            // 
            // produktDataGridView
            // 
            this.produktDataGridView.AllowUserToAddRows = false;
            this.produktDataGridView.AllowUserToDeleteRows = false;
            this.produktDataGridView.AutoGenerateColumns = false;
            this.produktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produktDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Stock});
            this.produktDataGridView.DataSource = this.productBindingSource;
            this.produktDataGridView.Location = new System.Drawing.Point(6, 30);
            this.produktDataGridView.Name = "produktDataGridView";
            this.produktDataGridView.ReadOnly = true;
            this.produktDataGridView.RowTemplate.Height = 33;
            this.produktDataGridView.Size = new System.Drawing.Size(1364, 214);
            this.produktDataGridView.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LT.WCF.DesktopClient.WcfServiceReference.Product);
            // 
            // ordreItemsDataGridView
            // 
            this.ordreItemsDataGridView.AllowUserToAddRows = false;
            this.ordreItemsDataGridView.AllowUserToDeleteRows = false;
            this.ordreItemsDataGridView.AutoGenerateColumns = false;
            this.ordreItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordreItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.ordreItemsDataGridView.DataSource = this.orderItemBindingSource;
            this.ordreItemsDataGridView.Location = new System.Drawing.Point(6, 30);
            this.ordreItemsDataGridView.Name = "ordreItemsDataGridView";
            this.ordreItemsDataGridView.ReadOnly = true;
            this.ordreItemsDataGridView.RowTemplate.Height = 33;
            this.ordreItemsDataGridView.Size = new System.Drawing.Size(1364, 226);
            this.ordreItemsDataGridView.TabIndex = 6;
            this.ordreItemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdreItemsDataGridView_CellClick);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordreGroupBox
            // 
            this.ordreGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ordreGroupBox.Controls.Add(this.ordreDataGridView);
            this.ordreGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordreGroupBox.Location = new System.Drawing.Point(36, 117);
            this.ordreGroupBox.Name = "ordreGroupBox";
            this.ordreGroupBox.Size = new System.Drawing.Size(1379, 287);
            this.ordreGroupBox.TabIndex = 9;
            this.ordreGroupBox.TabStop = false;
            this.ordreGroupBox.Text = "Vælg ordre";
            // 
            // ordreItemsGroupBox
            // 
            this.ordreItemsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ordreItemsGroupBox.Controls.Add(this.ordreItemsDataGridView);
            this.ordreItemsGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordreItemsGroupBox.Location = new System.Drawing.Point(36, 435);
            this.ordreItemsGroupBox.Name = "ordreItemsGroupBox";
            this.ordreItemsGroupBox.Size = new System.Drawing.Size(1379, 262);
            this.ordreItemsGroupBox.TabIndex = 10;
            this.ordreItemsGroupBox.TabStop = false;
            this.ordreItemsGroupBox.Text = "Vælg produkt";
            // 
            // produktGroupBox
            // 
            this.produktGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.produktGroupBox.Controls.Add(this.produktDataGridView);
            this.produktGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.produktGroupBox.Location = new System.Drawing.Point(36, 729);
            this.produktGroupBox.Name = "produktGroupBox";
            this.produktGroupBox.Size = new System.Drawing.Size(1379, 250);
            this.produktGroupBox.TabIndex = 11;
            this.produktGroupBox.TabStop = false;
            this.produktGroupBox.Text = "Vis produkt";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 1198);
            this.Controls.Add(this.produktGroupBox);
            this.Controls.Add(this.ordreItemsGroupBox);
            this.Controls.Add(this.lunchTimelbld);
            this.Controls.Add(this.lunchTimeLbl);
            this.Controls.Add(this.afslutOrdreKnap);
            this.Controls.Add(this.idNrBox);
            this.Controls.Add(this.idScanKnap);
            this.Controls.Add(this.ordreGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Desktop";
            this.Text = "LunchTime - Desktop: Ekspedient";
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreItemsDataGridView)).EndInit();
            this.ordreGroupBox.ResumeLayout(false);
            this.ordreItemsGroupBox.ResumeLayout(false);
            this.produktGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordreDataGridView;
        private System.Windows.Forms.Button idScanKnap;
        private System.Windows.Forms.TextBox idNrBox;
        private System.Windows.Forms.Button afslutOrdreKnap;
        private System.Windows.Forms.Label lunchTimeLbl;
        private System.Windows.Forms.Label lunchTimelbld;
        private System.Windows.Forms.DataGridView produktDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ordreItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox ordreGroupBox;
        private System.Windows.Forms.GroupBox ordreItemsGroupBox;
        private System.Windows.Forms.GroupBox produktGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}

