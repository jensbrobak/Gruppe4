﻿namespace LT.WCF.DesktopClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
            this.ordreDataGridView = new System.Windows.Forms.DataGridView();
            this.idScanKnap = new System.Windows.Forms.Button();
            this.idNrBox = new System.Windows.Forms.TextBox();
            this.afslutOrdreKnap = new System.Windows.Forms.Button();
            this.lunchTimeLbl = new System.Windows.Forms.Label();
            this.lunchTimelbld = new System.Windows.Forms.Label();
            this.ordreGroupBox = new System.Windows.Forms.GroupBox();
            this.ScanGroupBox = new System.Windows.Forms.GroupBox();
            this.AfslutGroupBox = new System.Windows.Forms.GroupBox();
            this.VisAlleOrdreGroupBox = new System.Windows.Forms.GroupBox();
            this.visAlleOrdreKnap = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.håndterProdukterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).BeginInit();
            this.ordreGroupBox.SuspendLayout();
            this.ScanGroupBox.SuspendLayout();
            this.AfslutGroupBox.SuspendLayout();
            this.VisAlleOrdreGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordreDataGridView
            // 
            this.ordreDataGridView.AllowUserToAddRows = false;
            this.ordreDataGridView.AllowUserToDeleteRows = false;
            this.ordreDataGridView.AllowUserToResizeColumns = false;
            this.ordreDataGridView.AllowUserToResizeRows = false;
            this.ordreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordreDataGridView.Location = new System.Drawing.Point(6, 30);
            this.ordreDataGridView.MultiSelect = false;
            this.ordreDataGridView.Name = "ordreDataGridView";
            this.ordreDataGridView.ReadOnly = true;
            this.ordreDataGridView.RowTemplate.Height = 33;
            this.ordreDataGridView.Size = new System.Drawing.Size(1367, 649);
            this.ordreDataGridView.TabIndex = 0;
            // 
            // idScanKnap
            // 
            this.idScanKnap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idScanKnap.Location = new System.Drawing.Point(573, 46);
            this.idScanKnap.Name = "idScanKnap";
            this.idScanKnap.Size = new System.Drawing.Size(147, 45);
            this.idScanKnap.TabIndex = 1;
            this.idScanKnap.Text = "Scan";
            this.idScanKnap.UseVisualStyleBackColor = true;
            this.idScanKnap.Click += new System.EventHandler(this.ScanId_Click);
            // 
            // idNrBox
            // 
            this.idNrBox.Location = new System.Drawing.Point(47, 118);
            this.idNrBox.Name = "idNrBox";
            this.idNrBox.Size = new System.Drawing.Size(537, 31);
            this.idNrBox.TabIndex = 3;
            this.idNrBox.Text = "Scan ID-nr";
            // 
            // afslutOrdreKnap
            // 
            this.afslutOrdreKnap.ForeColor = System.Drawing.Color.DarkRed;
            this.afslutOrdreKnap.Location = new System.Drawing.Point(18, 40);
            this.afslutOrdreKnap.Name = "afslutOrdreKnap";
            this.afslutOrdreKnap.Size = new System.Drawing.Size(379, 68);
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
            this.lunchTimeLbl.Location = new System.Drawing.Point(1171, 33);
            this.lunchTimeLbl.Name = "lunchTimeLbl";
            this.lunchTimeLbl.Size = new System.Drawing.Size(236, 59);
            this.lunchTimeLbl.TabIndex = 5;
            this.lunchTimeLbl.Text = "LunchTime";
            // 
            // lunchTimelbld
            // 
            this.lunchTimelbld.AutoSize = true;
            this.lunchTimelbld.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lunchTimelbld.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchTimelbld.ForeColor = System.Drawing.SystemColors.Window;
            this.lunchTimelbld.Location = new System.Drawing.Point(1302, 15);
            this.lunchTimelbld.Name = "lunchTimelbld";
            this.lunchTimelbld.Size = new System.Drawing.Size(105, 33);
            this.lunchTimelbld.TabIndex = 7;
            this.lunchTimelbld.Text = "Desktop";
            // 
            // ordreGroupBox
            // 
            this.ordreGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ordreGroupBox.Controls.Add(this.ordreDataGridView);
            this.ordreGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordreGroupBox.Location = new System.Drawing.Point(27, 209);
            this.ordreGroupBox.Name = "ordreGroupBox";
            this.ordreGroupBox.Size = new System.Drawing.Size(1379, 685);
            this.ordreGroupBox.TabIndex = 9;
            this.ordreGroupBox.TabStop = false;
            this.ordreGroupBox.Text = "Vælg Ordre (som skal afsluttes)";
            // 
            // ScanGroupBox
            // 
            this.ScanGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ScanGroupBox.Controls.Add(this.idScanKnap);
            this.ScanGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScanGroupBox.Location = new System.Drawing.Point(28, 69);
            this.ScanGroupBox.Name = "ScanGroupBox";
            this.ScanGroupBox.Size = new System.Drawing.Size(737, 119);
            this.ScanGroupBox.TabIndex = 10;
            this.ScanGroupBox.TabStop = false;
            this.ScanGroupBox.Text = "Scan ID-nr (søg aktive ordre(r) op på id-nr)";
            // 
            // AfslutGroupBox
            // 
            this.AfslutGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AfslutGroupBox.Controls.Add(this.afslutOrdreKnap);
            this.AfslutGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AfslutGroupBox.Location = new System.Drawing.Point(991, 917);
            this.AfslutGroupBox.Name = "AfslutGroupBox";
            this.AfslutGroupBox.Size = new System.Drawing.Size(415, 133);
            this.AfslutGroupBox.TabIndex = 11;
            this.AfslutGroupBox.TabStop = false;
            this.AfslutGroupBox.Text = "Afslut Ordre (for at afslutte ordre)";
            // 
            // VisAlleOrdreGroupBox
            // 
            this.VisAlleOrdreGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VisAlleOrdreGroupBox.Controls.Add(this.visAlleOrdreKnap);
            this.VisAlleOrdreGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VisAlleOrdreGroupBox.Location = new System.Drawing.Point(782, 69);
            this.VisAlleOrdreGroupBox.Name = "VisAlleOrdreGroupBox";
            this.VisAlleOrdreGroupBox.Size = new System.Drawing.Size(323, 119);
            this.VisAlleOrdreGroupBox.TabIndex = 12;
            this.VisAlleOrdreGroupBox.TabStop = false;
            this.VisAlleOrdreGroupBox.Text = "Hent Ordrer (viser alle aktive ordre(r))";
            // 
            // visAlleOrdreKnap
            // 
            this.visAlleOrdreKnap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visAlleOrdreKnap.Location = new System.Drawing.Point(37, 46);
            this.visAlleOrdreKnap.Name = "visAlleOrdreKnap";
            this.visAlleOrdreKnap.Size = new System.Drawing.Size(250, 45);
            this.visAlleOrdreKnap.TabIndex = 0;
            this.visAlleOrdreKnap.Text = "Hent ordre(r)";
            this.visAlleOrdreKnap.UseVisualStyleBackColor = true;
            this.visAlleOrdreKnap.Click += new System.EventHandler(this.HentAlleAktiveOrdreKnap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1456, 40);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.håndterProdukterToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 36);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // håndterProdukterToolStripMenuItem
            // 
            this.håndterProdukterToolStripMenuItem.Name = "håndterProdukterToolStripMenuItem";
            this.håndterProdukterToolStripMenuItem.Size = new System.Drawing.Size(311, 38);
            this.håndterProdukterToolStripMenuItem.Text = "Håndtér Produkter";
            this.håndterProdukterToolStripMenuItem.Click += new System.EventHandler(this.HåndterProdukterToolStripMenuItem_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 1110);
            this.Controls.Add(this.VisAlleOrdreGroupBox);
            this.Controls.Add(this.lunchTimelbld);
            this.Controls.Add(this.lunchTimeLbl);
            this.Controls.Add(this.idNrBox);
            this.Controls.Add(this.ordreGroupBox);
            this.Controls.Add(this.AfslutGroupBox);
            this.Controls.Add(this.ScanGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Desktop";
            this.Text = "LunchTime - Desktop: Ekspedient";
            ((System.ComponentModel.ISupportInitialize)(this.ordreDataGridView)).EndInit();
            this.ordreGroupBox.ResumeLayout(false);
            this.ScanGroupBox.ResumeLayout(false);
            this.AfslutGroupBox.ResumeLayout(false);
            this.VisAlleOrdreGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox ordreGroupBox;
        private System.Windows.Forms.GroupBox ScanGroupBox;
        private System.Windows.Forms.GroupBox AfslutGroupBox;
        private System.Windows.Forms.GroupBox VisAlleOrdreGroupBox;
        private System.Windows.Forms.Button visAlleOrdreKnap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem håndterProdukterToolStripMenuItem;
    }
}

