namespace Sablon.Hasta
{
    partial class frmArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArama));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.HastaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boyut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kanama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patoloji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPatolojiArama = new System.Windows.Forms.ComboBox();
            this.cbPKSArama = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTumorBoyut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKanamaMik = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.txtKanamaMik);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTumorBoyut);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cbPatolojiArama);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.cbPKSArama);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Size = new System.Drawing.Size(860, 450);
            this.splitContainer1.SplitterDistance = 660;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaID,
            this.Adi,
            this.Soyadi,
            this.Boyut,
            this.Kanama,
            this.Patoloji,
            this.PKS});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(656, 446);
            this.Liste.TabIndex = 0;
            // 
            // HastaID
            // 
            this.HastaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HastaID.HeaderText = "HastaID";
            this.HastaID.Name = "HastaID";
            this.HastaID.Width = 71;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adi.HeaderText = "Adı";
            this.Adi.Name = "Adi";
            this.Adi.Width = 47;
            // 
            // Soyadi
            // 
            this.Soyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Soyadi.HeaderText = "Soyadı";
            this.Soyadi.Name = "Soyadi";
            this.Soyadi.Width = 64;
            // 
            // Boyut
            // 
            this.Boyut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Boyut.HeaderText = "Tümor Boyutu";
            this.Boyut.Name = "Boyut";
            this.Boyut.Width = 90;
            // 
            // Kanama
            // 
            this.Kanama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kanama.HeaderText = "Kanama Miktarı";
            this.Kanama.Name = "Kanama";
            this.Kanama.Width = 96;
            // 
            // Patoloji
            // 
            this.Patoloji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patoloji.HeaderText = "Patoloji";
            this.Patoloji.Name = "Patoloji";
            // 
            // PKS
            // 
            this.PKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PKS.HeaderText = "PKS Açılma";
            this.PKS.Name = "PKS";
            this.PKS.Width = 80;
            // 
            // cbPatolojiArama
            // 
            this.cbPatolojiArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPatolojiArama.FormattingEnabled = true;
            this.cbPatolojiArama.Location = new System.Drawing.Point(0, 135);
            this.cbPatolojiArama.Name = "cbPatolojiArama";
            this.cbPatolojiArama.Size = new System.Drawing.Size(192, 21);
            this.cbPatolojiArama.TabIndex = 4;
            this.cbPatolojiArama.SelectedIndexChanged += new System.EventHandler(this.cbPatolojiArama_SelectedIndexChanged);
            this.cbPatolojiArama.TextChanged += new System.EventHandler(this.cbPatolojiArama_TextChanged);
            // 
            // cbPKSArama
            // 
            this.cbPKSArama.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPKSArama.FormattingEnabled = true;
            this.cbPKSArama.Location = new System.Drawing.Point(0, 91);
            this.cbPKSArama.Name = "cbPKSArama";
            this.cbPKSArama.Size = new System.Drawing.Size(192, 21);
            this.cbPKSArama.TabIndex = 4;
            this.cbPKSArama.SelectedIndexChanged += new System.EventHandler(this.cbPKSArama_SelectedIndexChanged);
            this.cbPKSArama.TextChanged += new System.EventHandler(this.cbPKSArama_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "PKS Açılma Durum :";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patoloji :";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tümor Boyutu :";
            // 
            // txtTumorBoyut
            // 
            this.txtTumorBoyut.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTumorBoyut.Location = new System.Drawing.Point(0, 179);
            this.txtTumorBoyut.Name = "txtTumorBoyut";
            this.txtTumorBoyut.Size = new System.Drawing.Size(192, 20);
            this.txtTumorBoyut.TabIndex = 1;
            this.txtTumorBoyut.TextChanged += new System.EventHandler(this.txtTumorBoyut_TextChanged);
            this.txtTumorBoyut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTumorBoyut_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kanama Miktarı :";
            // 
            // txtKanamaMik
            // 
            this.txtKanamaMik.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKanamaMik.Location = new System.Drawing.Point(0, 222);
            this.txtKanamaMik.Name = "txtKanamaMik";
            this.txtKanamaMik.Size = new System.Drawing.Size(192, 20);
            this.txtKanamaMik.TabIndex = 1;
            this.txtKanamaMik.TextChanged += new System.EventHandler(this.txtKanamaMik_TextChanged);
            this.txtKanamaMik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKanamaMik_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 68);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmArama";
            this.Text = "frmArama";
            this.Load += new System.EventHandler(this.frmArama_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTumorBoyut;
        private System.Windows.Forms.TextBox txtKanamaMik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boyut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kanama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patoloji;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPKSArama;
        private System.Windows.Forms.ComboBox cbPatolojiArama;
    }
}