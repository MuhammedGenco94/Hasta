using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sablon.Hasta;

namespace Sablon
{
    public partial class frmAnaSayfa : Form
    {
        public static int Aktarma;
        public static string AnaString = "";
        Formlar _f = new Formlar();

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;
            grpLeft.Text = "Bölüm-1 Giriş İşlemleri";
            pnlLeft1.Visible = true;
        }

        private void btnBolum1_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = true;
            pnlLeft2.Visible = false;
            pnlLeft3.Visible = false;
            grpLeft.Text = "Bölüm-1 Giriş İşlemleri";
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnBolum2_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = true;
            pnlLeft3.Visible = false;
            grpLeft.Text = "Bölüm-2 Giriş İşlemleri";
            grpLeft.BackColor = Color.Olive;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnBolum3_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = false;
            pnlLeft3.Visible = true;
            grpLeft.Text = "Bölüm-3 Giriş İşlemleri";
            grpLeft.BackColor = Color.Maroon;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnHastaGir_Click(object sender, EventArgs e)
        {
            _f.Hasta();
            closeAllForms();
        }

        void closeAllForms()
        {
            for (int i = Application.OpenForms.Count - 2; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmAnaSayfa")
                    Application.OpenForms[i].Close();
            }
        }

        private void btnHastaList_Click(object sender, EventArgs e)
        {
            _f.HastaList();
        }
        
        private void btnAra_Click(object sender, EventArgs e)
        {
            _f.Ara();
            closeAllForms();
        }

    }
}
