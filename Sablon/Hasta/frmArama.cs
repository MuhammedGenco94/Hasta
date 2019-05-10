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
    public partial class frmArama : Form
    {
        public int textBoyut = -1;
        public int textKanama = -1;
        HastaDBDataContext _db = new HastaDBDataContext();

        public frmArama()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmArama_Load(object sender, EventArgs e)
        {
            Listele();
            Combox();
        }

        void Listele()
        {
            if (txtTumorBoyut.Text != "")
            {
                textBoyut = int.Parse(txtTumorBoyut.Text);
            }
            else if (txtTumorBoyut.Text == "")
            {
                textBoyut = -1;
            }

            if (txtKanamaMik.Text != "")
            {
                textKanama = int.Parse(txtKanamaMik.Text);
            }
            else if (txtKanamaMik.Text == "")
            {
                textKanama = -1;
            }

            Liste.Rows.Clear();
            int pp = 0;

            var LST = (from k in _db.tblHastaBilgileris
                       where k.tblDemografik_Ozellikleris.First().Boyut >= textBoyut
                       && k.tblOperatif_Ozelliklers.First().KANAMA >= textKanama
                       && k.dbo_tblPatolojikVerilers.First().PATOLOJI.Contains(cbPatolojiArama.Text)
                       && k.tblOperatif_Ozelliklers.First().PKS_Aciklama.Contains(cbPKSArama.Text)
                       select k).OrderBy(y=>y.ID).ToList();

            foreach (var hast in LST)
            {
                Liste.Rows.Add();
                Liste.Rows[pp].Cells[0].Value = hast.ID;
                Liste.Rows[pp].Cells[1].Value = hast.Ad;
                Liste.Rows[pp].Cells[2].Value = hast.Soyad;
                Liste.Rows[pp].Cells[3].Value = hast.tblDemografik_Ozellikleris.First(x => x.HastaID == hast.ID).Boyut;
                Liste.Rows[pp].Cells[4].Value = hast.tblOperatif_Ozelliklers.First(x => x.HastaID == hast.ID).KANAMA;
                Liste.Rows[pp].Cells[5].Value = hast.dbo_tblPatolojikVerilers.First(x => x.HastaID == hast.ID).PATOLOJI;
                Liste.Rows[pp].Cells[6].Value = hast.tblOperatif_Ozelliklers.First(x => x.HastaID == hast.ID).PKS_Aciklama;
                pp++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void Combox()
        {
            var lst1 = _db.tblOperatif_Ozelliklers.Select(s => s.PKS_Aciklama).Distinct();
            foreach (string PKS in lst1)
            {
                if (PKS != null && PKS != "")
                {
                    cbPKSArama.Items.Add(PKS);
                }
            }

            var lst2 = _db.dbo_tblPatolojikVerilers.Select(s => s.PATOLOJI).Distinct();
            foreach (string PAT in lst2)
            {
                if (PAT != null && PAT != "")
                {
                    cbPatolojiArama.Items.Add(PAT);
                }
            }
        }

        #region TextChanged
        private void cbPKSArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
        private void cbPKSArama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        private void cbPatolojiArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
        private void cbPatolojiArama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        private void txtTumorBoyut_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
        private void txtKanamaMik_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        #endregion

        #region KeyPress
        private void txtTumorBoyut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtKanamaMik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion
    }
}
