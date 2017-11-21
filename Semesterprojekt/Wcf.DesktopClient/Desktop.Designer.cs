namespace Wcf.DesktopClient
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
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cprSøgKnap = new System.Windows.Forms.Button();
            this.cprNrBox = new System.Windows.Forms.TextBox();
            this.orderItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.afslutOrdreKnap = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lunchTimeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).BeginInit();
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
            this.customerIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.itemsTotalDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusIdDataGridViewTextBoxColumn});
            this.ordreDataGridView.DataSource = this.orderBindingSource2;
            this.ordreDataGridView.Location = new System.Drawing.Point(36, 113);
            this.ordreDataGridView.MultiSelect = false;
            this.ordreDataGridView.Name = "ordreDataGridView";
            this.ordreDataGridView.ReadOnly = true;
            this.ordreDataGridView.RowTemplate.Height = 33;
            this.ordreDataGridView.Size = new System.Drawing.Size(1379, 596);
            this.ordreDataGridView.TabIndex = 0;
            this.ordreDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsTotalDataGridViewTextBoxColumn
            // 
            this.itemsTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.HeaderText = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.Name = "itemsTotalDataGridViewTextBoxColumn";
            this.itemsTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusIdDataGridViewTextBoxColumn
            // 
            this.orderStatusIdDataGridViewTextBoxColumn.DataPropertyName = "OrderStatusId";
            this.orderStatusIdDataGridViewTextBoxColumn.HeaderText = "OrderStatusId";
            this.orderStatusIdDataGridViewTextBoxColumn.Name = "orderStatusIdDataGridViewTextBoxColumn";
            this.orderStatusIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Order);
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Order);
            // 
            // orderItemsBindingSource1
            // 
            this.orderItemsBindingSource1.DataMember = "OrderItems";
            this.orderItemsBindingSource1.DataSource = this.orderBindingSource;
            // 
            // cprSøgKnap
            // 
            this.cprSøgKnap.Location = new System.Drawing.Point(409, 35);
            this.cprSøgKnap.Name = "cprSøgKnap";
            this.cprSøgKnap.Size = new System.Drawing.Size(147, 45);
            this.cprSøgKnap.TabIndex = 1;
            this.cprSøgKnap.Text = "Scan";
            this.cprSøgKnap.UseVisualStyleBackColor = true;
            this.cprSøgKnap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cprNrBox
            // 
            this.cprNrBox.Location = new System.Drawing.Point(36, 39);
            this.cprNrBox.Name = "cprNrBox";
            this.cprNrBox.Size = new System.Drawing.Size(348, 31);
            this.cprNrBox.TabIndex = 3;
            this.cprNrBox.Text = "Indtast CPR-nr";
            this.cprNrBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // orderItemsBindingSource2
            // 
            this.orderItemsBindingSource2.DataMember = "OrderItems";
            this.orderItemsBindingSource2.DataSource = this.orderBindingSource;
            // 
            // afslutOrdreKnap
            // 
            this.afslutOrdreKnap.Location = new System.Drawing.Point(1159, 748);
            this.afslutOrdreKnap.Name = "afslutOrdreKnap";
            this.afslutOrdreKnap.Size = new System.Drawing.Size(256, 68);
            this.afslutOrdreKnap.TabIndex = 4;
            this.afslutOrdreKnap.Text = "Afslut ordre";
            this.afslutOrdreKnap.UseVisualStyleBackColor = true;
            this.afslutOrdreKnap.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Customer);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Order);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Customer);
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.OrderItem);
            // 
            // orderItemBindingSource1
            // 
            this.orderItemBindingSource1.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.OrderItem);
            // 
            // lunchTimeLbl
            // 
            this.lunchTimeLbl.AutoSize = true;
            this.lunchTimeLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lunchTimeLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchTimeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.lunchTimeLbl.Location = new System.Drawing.Point(1179, 34);
            this.lunchTimeLbl.Name = "lunchTimeLbl";
            this.lunchTimeLbl.Size = new System.Drawing.Size(236, 59);
            this.lunchTimeLbl.TabIndex = 5;
            this.lunchTimeLbl.Text = "LunchTime";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 890);
            this.Controls.Add(this.lunchTimeLbl);
            this.Controls.Add(this.afslutOrdreKnap);
            this.Controls.Add(this.cprNrBox);
            this.Controls.Add(this.cprSøgKnap);
            this.Controls.Add(this.ordreDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Desktop";
            this.Text = "LunchTime - Ekspedient";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordreDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource1;
        private System.Windows.Forms.Button cprSøgKnap;
        private System.Windows.Forms.TextBox cprNrBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource orderItemBindingSource1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource2;
        private System.Windows.Forms.Button afslutOrdreKnap;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.Label lunchTimeLbl;
    }
}

