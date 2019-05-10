using System.Windows.Forms;

namespace Sablon.Hasta
{
    class Formlar
    {
        public void Hasta()
        {
            frmHasta frm = new frmHasta();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public void DoktorList(bool secim = false)
        {
            frmDoktorList frm = new frmDoktorList();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
        }

        public int HastaList(bool secim = false)
        {
            frmHastaList frm = new frmHastaList();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.Aktarma;
        }

        public void OperationList(bool secim = false)
        {
            FrmOperationList frm = new FrmOperationList();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
        }

        public void Ara(bool secim = false)
        {
            frmArama Ara = new frmArama();
            Ara.MdiParent = Form.ActiveForm;
            Ara.WindowState = FormWindowState.Maximized;
            Ara.Show();
        }
    }
}
