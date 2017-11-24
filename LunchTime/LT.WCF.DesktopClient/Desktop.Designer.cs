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

            this.cprSøgKnap = new System.Windows.Forms.Button();
            this.cprNrBox = new System.Windows.Forms.TextBox();

            this.afslutOrdreKnap = new System.Windows.Forms.Button();

            this.lunchTimeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).BeginInit();

            this.SuspendLayout();
            // 
            // ordreDataGridView
            // 
            this.ordreDataGridView.AllowUserToAddRows = false;
            this.ordreDataGridView.AllowUserToDeleteRows = false;
            this.ordreDataGridView.AllowUserToResizeColumns = false;
            this.ordreDataGridView.AllowUserToResizeRows = false;
            this.ordreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordreDataGridView.Location = new System.Drawing.Point(36, 113);
            this.ordreDataGridView.MultiSelect = false;
            this.ordreDataGridView.Name = "ordreDataGridView";
            this.ordreDataGridView.ReadOnly = true;
            this.ordreDataGridView.RowTemplate.Height = 33;
            this.ordreDataGridView.Size = new System.Drawing.Size(1379, 596);
            this.ordreDataGridView.TabIndex = 0;
            this.ordreDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordreDataGridView;

        private System.Windows.Forms.Button cprSøgKnap;
        private System.Windows.Forms.TextBox cprNrBox;

        private System.Windows.Forms.Button afslutOrdreKnap;

        private System.Windows.Forms.Label lunchTimeLbl;
    }
}

