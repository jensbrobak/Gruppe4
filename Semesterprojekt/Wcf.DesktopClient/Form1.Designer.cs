namespace Wcf.DesktopClient
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.itemsTotalDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1379, 433);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderItemsBindingSource1
            // 
            this.orderItemsBindingSource1.DataMember = "OrderItems";
            this.orderItemsBindingSource1.DataSource = this.orderBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 498);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 31);
            this.textBox1.TabIndex = 3;
            // 
            // orderItemsBindingSource2
            // 
            this.orderItemsBindingSource2.DataMember = "OrderItems";
            this.orderItemsBindingSource2.DataSource = this.orderBindingSource;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(977, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Order);
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
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(Wcf.DesktopClient.WcfServiceReference.Order);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // itemsTotalDataGridViewTextBoxColumn
            // 
            this.itemsTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.HeaderText = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.Name = "itemsTotalDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderStatusIdDataGridViewTextBoxColumn
            // 
            this.orderStatusIdDataGridViewTextBoxColumn.DataPropertyName = "OrderStatusId";
            this.orderStatusIdDataGridViewTextBoxColumn.HeaderText = "OrderStatusId";
            this.orderStatusIdDataGridViewTextBoxColumn.Name = "orderStatusIdDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 879);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource orderItemBindingSource1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource2;
    }
}

