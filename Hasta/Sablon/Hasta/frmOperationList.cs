using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sablon.Modal;

namespace Sablon.Hasta
{
    public partial class FrmOperationList : Form
    {
        HastaDBDataContext _db = new HastaDBDataContext();
        MyMessages _m = new MyMessages();

        public bool Secim = false;
        public string OperationString = "";
        
        public FrmOperationList()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOperationList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var LST = (from OpTu in _db.tblOpTurus
                where OpTu.OpTuru.Contains(txtOperationBul.Text)
                select OpTu).OrderBy(x => x.ID).ToList();

            foreach (var item in LST)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.ID;
                Liste.Rows[i].Cells[1].Value = item.OpTuru;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void txtOperationBul_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        
        private void butAktar_Click(object sender, EventArgs e)
        {
            if (Secim)
            {
                OperationString += txtOP1.Text + "+" + txtOP2.Text + "+" + txtOP3.Text + "+"
                                + txtOP4.Text + "+" + txtOP5.Text + "+" + txtOP6.Text;
                int OpLength = OperationString.Length;
                for (int i = 0; i < OpLength; i++)
                {
                    if (OperationString[OperationString.Length - 1] == '+')
                    {
                        OperationString = OperationString.Remove(OperationString.Length - 1);
                    }
                }
                frmMainPage.AnaString = OperationString;
                if (OperationString != "")
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("En az bir Doktor seçmen gerekiyor!!", "Boş Alan !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentCell.Value != null)
            {
                Sec();
            }
        }

        void Sec()
        {
            try
            {
                if (txtOP1.Text == "")
                {
                    txtOP1.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtOP2.Text == "")
                {
                    txtOP2.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtOP3.Text == "")
                {
                    txtOP3.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtOP4.Text == "")
                {
                    txtOP4.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtOP5.Text == "")
                {
                    txtOP5.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtOP6.Text == "")
                {
                    txtOP6.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception k)
            {
                _m.Hata(k);
            }
        }

        private void btnYeniOperation_Click(object sender, EventArgs e)
        {
            if (txtYeniOperation.Text != "")
            {
                YeniKayit();
            }

            Listele();
        }

        void YeniKayit()
        {
            tblOpTuru yeniOperation = new tblOpTuru();
            yeniOperation.OpTuru = txtYeniOperation.Text;

            _db.tblOpTurus.InsertOnSubmit(yeniOperation);
            _db.SubmitChanges();
            _m.YeniKayit("Yeni Operasyon başarıyla eklendi.");
        }
    }
}
