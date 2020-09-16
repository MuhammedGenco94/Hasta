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
    public partial class frmDoktorList : Form
    {
        HastaDBDataContext _db = new HastaDBDataContext();
        MyMessages _m = new MyMessages();

        public bool Secim = false;
        public string DoktorString = "";
        
        public frmDoktorList()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoktorList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var LST = (from dr in _db.tblDoktors
                       where dr.DrAdi.Contains(txtDoktorBul.Text)
                       select dr).OrderBy(x => x.ID).ToList();

            foreach (var item in LST)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.ID;
                Liste.Rows[i].Cells[1].Value = item.DrAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void butAktar_Click(object sender, EventArgs e)
        {
            if (Secim)
            {
                DoktorString += txtDR1.Text + "+" + txtDR2.Text + "+" + txtDR3.Text + "+"
                                + txtDR4.Text + "+" + txtDR5.Text + "+" + txtDR6.Text;
                int DrLength = DoktorString.Length;
                for (int i = 0; i < DrLength; i++)
                {
                    if (DoktorString[DoktorString.Length - 1] == '+')
                    {
                        DoktorString = DoktorString.Remove(DoktorString.Length - 1);
                    }
                }
                frmMainPage.AnaString = DoktorString;
                if (DoktorString != "")
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
                if (txtDR1.Text == "")
                {
                    txtDR1.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDR2.Text == "")
                {
                    txtDR2.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDR3.Text == "")
                {
                    txtDR3.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDR4.Text == "")
                {
                    txtDR4.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDR5.Text == "")
                {
                    txtDR5.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDR6.Text == "")
                {
                    txtDR6.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception k)
            {
                _m.Hata(k);
            }
        }

        private void btnYeniDoktor_Click(object sender, EventArgs e)
        {
            if (txtYeniDoktor.Text != "")
            {
                YeniKayit();
            }

            Listele();
        }

        void YeniKayit()
        {
            tblDoktor yeniDoktor = new tblDoktor();

            var dokName = txtYeniDoktor.Text.Split(' ');
            yeniDoktor.DrAdi = dokName[0].Substring(0, 1) + dokName[1].Substring(0, 1);

            _db.tblDoktors.InsertOnSubmit(yeniDoktor);
            _db.SubmitChanges();
            _m.YeniKayit("Yeni Doktor başarıyla eklendi.");
        }

        private void txtDoktorBul_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
