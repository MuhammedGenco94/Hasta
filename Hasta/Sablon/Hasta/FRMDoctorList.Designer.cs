namespace Sablon.Hasta
{
    partial class FRMDoctorList
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.DrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtYeniDoktor = new System.Windows.Forms.TextBox();
            this.btnYeniDoktor = new System.Windows.Forms.Button();
            this.butAktar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDR6 = new System.Windows.Forms.TextBox();
            this.txtDR5 = new System.Windows.Forms.TextBox();
            this.txtDR4 = new System.Windows.Forms.TextBox();
            this.txtDR3 = new System.Windows.Forms.TextBox();
            this.txtDR2 = new System.Windows.Forms.TextBox();
            this.txtDR1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoktorBul = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrID,
            this.DrAdi});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Liste.Size = new System.Drawing.Size(617, 446);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // DrID
            // 
            this.DrID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DrID.HeaderText = "Doktor ID";
            this.DrID.Name = "DrID";
            this.DrID.ReadOnly = true;
            this.DrID.Width = 78;
            // 
            // DrAdi
            // 
            this.DrAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DrAdi.HeaderText = "Doktor Adı";
            this.DrAdi.Name = "DrAdi";
            this.DrAdi.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.txtYeniDoktor);
            this.splitContainer1.Panel2.Controls.Add(this.btnYeniDoktor);
            this.splitContainer1.Panel2.Controls.Add(this.butAktar);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR6);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR5);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR4);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR3);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDR1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtDoktorBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(861, 450);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtYeniDoktor
            // 
            this.txtYeniDoktor.Location = new System.Drawing.Point(0, 280);
            this.txtYeniDoktor.Name = "txtYeniDoktor";
            this.txtYeniDoktor.Size = new System.Drawing.Size(232, 20);
            this.txtYeniDoktor.TabIndex = 8;
            // 
            // btnYeniDoktor
            // 
            this.btnYeniDoktor.BackColor = System.Drawing.Color.Chocolate;
            this.btnYeniDoktor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnYeniDoktor.Location = new System.Drawing.Point(-2, 302);
            this.btnYeniDoktor.Name = "btnYeniDoktor";
            this.btnYeniDoktor.Size = new System.Drawing.Size(234, 57);
            this.btnYeniDoktor.TabIndex = 5;
            this.btnYeniDoktor.Text = "Yeni Doktor Ekle";
            this.btnYeniDoktor.UseVisualStyleBackColor = false;
            this.btnYeniDoktor.Click += new System.EventHandler(this.btnYeniDoktor_Click);
            // 
            // butAktar
            // 
            this.butAktar.BackColor = System.Drawing.Color.ForestGreen;
            this.butAktar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.butAktar.Location = new System.Drawing.Point(-1, 176);
            this.butAktar.Name = "butAktar";
            this.butAktar.Size = new System.Drawing.Size(234, 57);
            this.butAktar.TabIndex = 5;
            this.butAktar.Text = "Aktar";
            this.butAktar.UseVisualStyleBackColor = false;
            this.butAktar.Click += new System.EventHandler(this.butAktar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "6.Dr";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "5.Dr";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "4.Dr";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "3.Dr";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "2.Dr";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "1.Dr";
            // 
            // txtDR6
            // 
            this.txtDR6.Location = new System.Drawing.Point(38, 155);
            this.txtDR6.Name = "txtDR6";
            this.txtDR6.Size = new System.Drawing.Size(194, 20);
            this.txtDR6.TabIndex = 6;
            // 
            // txtDR5
            // 
            this.txtDR5.Location = new System.Drawing.Point(38, 135);
            this.txtDR5.Name = "txtDR5";
            this.txtDR5.Size = new System.Drawing.Size(194, 20);
            this.txtDR5.TabIndex = 6;
            // 
            // txtDR4
            // 
            this.txtDR4.Location = new System.Drawing.Point(38, 115);
            this.txtDR4.Name = "txtDR4";
            this.txtDR4.Size = new System.Drawing.Size(194, 20);
            this.txtDR4.TabIndex = 6;
            // 
            // txtDR3
            // 
            this.txtDR3.Location = new System.Drawing.Point(38, 95);
            this.txtDR3.Name = "txtDR3";
            this.txtDR3.Size = new System.Drawing.Size(194, 20);
            this.txtDR3.TabIndex = 6;
            // 
            // txtDR2
            // 
            this.txtDR2.Location = new System.Drawing.Point(38, 75);
            this.txtDR2.Name = "txtDR2";
            this.txtDR2.Size = new System.Drawing.Size(194, 20);
            this.txtDR2.TabIndex = 6;
            // 
            // txtDR1
            // 
            this.txtDR1.Location = new System.Drawing.Point(38, 55);
            this.txtDR1.Name = "txtDR1";
            this.txtDR1.Size = new System.Drawing.Size(194, 20);
            this.txtDR1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Adını Bul :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoktorBul
            // 
            this.txtDoktorBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDoktorBul.Location = new System.Drawing.Point(0, 426);
            this.txtDoktorBul.Name = "txtDoktorBul";
            this.txtDoktorBul.Size = new System.Drawing.Size(232, 20);
            this.txtDoktorBul.TabIndex = 3;
            this.txtDoktorBul.TextChanged += new System.EventHandler(this.txtDoktorBul_TextChanged);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(232, 55);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmDoktorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDoktorList";
            this.Text = "Doktor Listesi";
            this.Load += new System.EventHandler(this.frmDoktorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoktorBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrAdi;
        private System.Windows.Forms.Button butAktar;
        private System.Windows.Forms.TextBox txtDR6;
        private System.Windows.Forms.TextBox txtDR5;
        private System.Windows.Forms.TextBox txtDR4;
        private System.Windows.Forms.TextBox txtDR3;
        private System.Windows.Forms.TextBox txtDR2;
        private System.Windows.Forms.TextBox txtDR1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYeniDoktor;
        private System.Windows.Forms.TextBox txtYeniDoktor;
    }
}