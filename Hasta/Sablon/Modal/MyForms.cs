using Sablon.Hasta;
using System.Windows.Forms;

namespace Sablon.Modal
{
    class MyForms
    {
        public void Patient()
        {
            FRMPatient frm = new FRMPatient();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public void DoktorList(bool selection = false)
        {
            FRMDoctorList frmDoctorL = new FRMDoctorList();
            if (selection)
            {
                frmDoctorL.Secim = true;
                frmDoctorL.ShowDialog();
            }
            else
            {
                frmDoctorL.ShowDialog();
            }
        }

        public int HastaList(bool secim = false)
        {
            FRMPatientList frmPatientL = new FRMPatientList();
            if (secim)
            {
                frmPatientL.mainSelection = true;
                frmPatientL.ShowDialog();
            }
            else
            {
                frmPatientL.MdiParent = Form.ActiveForm;
                frmPatientL.WindowState = FormWindowState.Maximized;
                frmPatientL.Show();
            }
            return frmMainPage.transferID;
        }

        public void OperationList(bool secim = false)
        {
            FRMOperationList frmOperationL = new FRMOperationList();
            if (secim)
            {
                frmOperationL.mainSelection = true;
                frmOperationL.ShowDialog();
            }
            else
            {
                frmOperationL.ShowDialog();
            }
        }

        public void Ara(bool secim = false)
        {
            FRMSearch frmSearch = new FRMSearch();
            frmSearch.MdiParent = Form.ActiveForm;
            frmSearch.WindowState = FormWindowState.Maximized;
            frmSearch.Show();
        }
    }
}
