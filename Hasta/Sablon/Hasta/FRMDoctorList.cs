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
    public partial class FRMDoctorList : Form
    {
        HastaDBDataContext _db = new HastaDBDataContext();
        MyMessages myMessages = new MyMessages();

        public bool Secim = false;
        public string DoktorString = "";

        public FRMDoctorList()
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
            try
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
                    frmMainPage.myMainString = DoktorString;
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
            catch (Exception ee)
            {
                myMessages.Hata(ee);
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Liste.CurrentCell.Value != null)
                {
                    Sec();
                }
            }
            catch (Exception k)
            {
                myMessages.Hata(k);
            }
        }

        void Sec()
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

        private void btnYeniDoktor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYeniDoktor.Text != "")
                {
                    YeniKayit();
                }

                Listele();
            }
            catch (Exception k)
            {
                myMessages.Hata(k);
            }
        }

        void YeniKayit()
        {
            tblDoktor yeniDoktor = new tblDoktor();

            var dokName = txtYeniDoktor.Text.Split(' ');
            yeniDoktor.DrAdi = dokName[0].Substring(0, 1) + dokName[1].Substring(0, 1);

            _db.tblDoktors.InsertOnSubmit(yeniDoktor);
            _db.SubmitChanges();
            myMessages.YeniKayit("Yeni Doktor başarıyla eklendi.");
        }

        private void txtDoktorBul_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
