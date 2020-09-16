using System;
using System.Linq;
using System.Windows.Forms;
using Sablon.Modal;


namespace Sablon.Hasta
{
    public partial class frmHastaList : Form
    {
        HastaDBDataContext _db = new HastaDBDataContext();
        public bool Secim = false;
        int _secimId = -1;

        public frmHastaList()
        {
            InitializeComponent();
        }

        private void frmHastaList_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var LST = (from s in _db.tblHastaBilgileris
                       where s.Ad.Contains(txtHastaBul.Text)
                       select s).OrderBy(x => x.ID).ToList();

            foreach (var Hasta in LST)
            {
                Liste.Rows.Add();   //Boş satır ekliyor
                Liste.Rows[i].Cells[0].Value = Hasta.ID;
                Liste.Rows[i].Cells[1].Value = Hasta.Ad;
                Liste.Rows[i].Cells[2].Value = Hasta.Soyad;
                Liste.Rows[i].Cells[3].Value = Hasta.Protokol;
                Liste.Rows[i].Cells[4].Value = Hasta.OPTarihi;
                Liste.Rows[i].Cells[5].Value = Hasta.OPTuru;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                frmMainPage.Aktarma = _secimId;
                Close();
            }
        }

        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtHastaBul_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
