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
    public partial class FRMPatient : Form
    {
        HastaDBDataContext _db = new HastaDBDataContext();
        MyForms myForms = new MyForms();
        MyMessages myMessages = new MyMessages();
        MyNumbers myNumbers = new MyNumbers();

        bool edit = false;
        int _HastaID = -1;

        public FRMPatient()
        {
            InitializeComponent();
        }

        private void frmHasta_Load(object sender, EventArgs e)
        {
            Temizle();
            Combox();
        }

        void Temizle()
        {
            for (int ix = 0; ix < tabControl1.TabCount; ix++)
            {
                foreach (Control _control in tabControl1.TabPages[ix].Controls)
                {
                    if (_control is TextBox)
                    {
                        _control.Text = "";
                    }
                    if (_control is ComboBox)
                    {
                        ((ComboBox)_control).SelectedIndex = -1;
                        ((ComboBox)_control).Text = "";
                    }
                }
            }

            #region HastaID
            string newPatientId = myNumbers.GetNewPatientID();
            txtHastaID.Text = newPatientId;
            txtHastaIdDemo.Text = newPatientId;
            txtHastaIdOper.Text = newPatientId;
            txtHastaIdPatol.Text = newPatientId;
            txtHastaIdPosOP.Text = newPatientId;
            txtHastaIdTakipVer.Text = newPatientId;
            #endregion

            dtpOPTarihi.Text = DateTime.Now.ToShortDateString();
            edit = false;
        }

        void Combox()
        {
            try
            {
                var lst2_1 = _db.tblDemografik_Ozellikleris.Select(k => k.ASA).Distinct();
                foreach (var ASA in lst2_1)
                {
                    if (ASA != null)
                    {
                        cbASA.Items.Add(ASA);
                    }
                }
                var lst2_2 = _db.tblDemografik_Ozellikleris.Select(k => k.Cins).Distinct();
                foreach (string ASA in lst2_2)
                {
                    if (ASA != null)
                    {
                        cbCins.Items.Add(ASA);
                    }
                }

                var lst2_3 = _db.tblDemografik_Ozellikleris.Select(k => k.Taraf).Distinct();
                foreach (string ASA in lst2_3)
                {
                    if (ASA != null)
                    {
                        cbTaraf.Items.Add(ASA);
                    }
                }

                var lst3_1 = _db.tblOperatif_Ozelliklers.Select(k => k.PKS_Aciklama).Distinct();
                foreach (string ASA in lst3_1)
                {
                    if (ASA != null)
                    {
                        cbPKS.Items.Add(ASA);
                    }
                }

                var lst3_2 = _db.tblOperatif_Ozelliklers.Select(k => k.SIK).Distinct();
                foreach (string SIK in lst3_2)
                {
                    if (SIK != null)
                    {
                        cbSIK.Items.Add(SIK);
                    }
                }

                var lst4_1 = _db.tblPosOperatif_Ozelliklers.Select(k => k.PEROP_VE_ERKEN_KOMP).Distinct();
                foreach (string perop in lst4_1)
                {
                    if (perop != null)
                    {
                        cbPeropVeErk.Items.Add(perop);
                    }
                }

                var lst4_2 = _db.tblPosOperatif_Ozelliklers.Select(k => k.SONDA).Distinct();
                foreach (string sonda in lst4_2)
                {
                    if (sonda != null)
                    {
                        cbSonda.Items.Add(sonda);
                    }
                }

                var lst4_3 = _db.tblPosOperatif_Ozelliklers.Select(k => k.HOSP_SURESI).Distinct();
                foreach (var HOSP in lst4_3)
                {
                    if (HOSP != null)
                    {
                        cbHOSP.Items.Add(HOSP);
                    }
                }

                var lst5_1 = _db.tblPatolojikVerilers.Select(k => k.PATOLOJI).Distinct();
                foreach (string Patol in lst5_1)
                {
                    if (Patol != null)
                    {
                        cbPatoloji.Items.Add(Patol);
                    }
                }

                var lst5_2 = _db.tblPatolojikVerilers.Select(k => k.ALT_GRUP).Distinct();
                foreach (string Alt in lst5_2)
                {
                    if (Alt != null)
                    {
                        cbAltGrup.Items.Add(Alt);
                    }
                }

                var lst5_3 = _db.tblPatolojikVerilers.Select(k => k.FURHMAN_GRADE).Distinct();
                foreach (var Furh in lst5_3)
                {
                    if (Furh != null)
                    {
                        cbFurhGrade.Items.Add(Furh);
                    }
                }

                var lst5_4 = _db.tblPatolojikVerilers.Select(k => k.PATOLOJIK_EVRE).Distinct();
                foreach (string PatEv in lst5_4)
                {
                    if (PatEv != null)
                    {
                        cbPatolojiEvre.Items.Add(PatEv);
                    }
                }

                //Burada Properitisinden tanımlamıştım .........................................
                //var lst5_5 = _db.tblPatolojikVerilers.Select(k => k.CERRAHI_SINIR).Distinct();
                //foreach (string cerrah in lst5_5)
                //{
                //    if (cerrah != null)
                //    {
                //        cbCerrahSinir.Items.Add(cerrah);
                //    }
                //}
            }
            catch (Exception eexx)
            {
                myMessages.Hata(eexx);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GÖSTER";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && _HastaID > 0 && myMessages.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (!edit)
            {
                YeniKaydet();
            }
        }

        void YeniKaydet()
        {
            try
            {
                //1
                #region HastaBilgileri
                tblHastaBilgileri hasBilgi = new tblHastaBilgileri();
                hasBilgi.Ad = txtAd.Text;
                hasBilgi.Soyad = txtSoyad.Text;
                hasBilgi.Protokol = txtProtokol.Text;
                hasBilgi.OPTarihi = DateTime.Parse(dtpOPTarihi.Text);
                hasBilgi.OPTuru = txtOPTuru.Text;
                hasBilgi.Takip = txtTakip.Text != "" ? int.Parse(txtTakip.Text) : (-1);
                hasBilgi.ANAH = txtANAH.Text != "" ? int.Parse(txtANAH.Text) : (-1);
                _db.tblHastaBilgileris.InsertOnSubmit(hasBilgi);
                #endregion

                //2
                #region Demografik_Ozellikleri
                tblDemografik_Ozellikleri Demog = new tblDemografik_Ozellikleri();
                Demog.HastaID = int.Parse(txtHastaIdDemo.Text);
                Demog.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : (-1);
                Demog.Boy = txtBoy.Text != "" ? int.Parse(txtBoy.Text) : (-1);
                Demog.Kilo = txtKilo.Text != "" ? int.Parse(txtKilo.Text) : (-1);
                Demog.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : (-1);
                Demog.ASA = cbASA.Text != "" ? int.Parse(cbASA.Text) : (-1);
                Demog.Dr = txtDR.Text;
                Demog.Cins = cbCins.Text;
                Demog.Taraf = cbTaraf.Text;
                Demog.Lokalizasyon = txtLokalizasyon.Text;
                Demog.Boyut = txtBoyut.Text != "" ? int.Parse(txtBoyut.Text) : (-1);
                Demog.KO_Morbidite = txtKoMorbidite.Text;
                _db.tblDemografik_Ozellikleris.InsertOnSubmit(Demog);
                #endregion

                //3
                #region Operatif_Ozellikler
                tblOperatif_Ozellikler OpOz = new tblOperatif_Ozellikler();
                OpOz.HastaID = int.Parse(txtHastaIdOper.Text);
                OpOz.PKS_Aciklama = cbPKS.Text;
                OpOz.SIK = cbSIK.Text;
                OpOz.CO_Operasyon = txtCOOP.Text;
                OpOz.iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : (-1);
                OpOz.Port_Sayisi = txtPortSay.Text != "" ? int.Parse(txtPortSay.Text) : (-1);
                OpOz.Yardim_YNT = txtYardim.Text;
                OpOz.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : (-1);
                OpOz.DREN = txtDREN.Text;
                OpOz.KANAMA = txtKANAMA.Text != "" ? int.Parse(txtKANAMA.Text) : (-1);
                OpOz.PIYES = txtPIYES.Text != "" ? int.Parse(txtPIYES.Text) : (-1);
                _db.tblOperatif_Ozelliklers.InsertOnSubmit(OpOz);
                #endregion

                //4
                #region PosOperatif_Ozellikler
                tblPosOperatif_Ozellikler PosOP = new tblPosOperatif_Ozellikler();
                PosOP.HastaID = int.Parse(txtHastaIdPosOP.Text);
                PosOP.PEROP_VE_ERKEN_KOMP = cbPeropVeErk.Text;
                PosOP.POSTOP_ANALIZ = txtPostANA.Text != "" ? decimal.Parse(txtPostANA.Text) : (-1);
                PosOP.SONDA = cbSonda.Text;
                PosOP.HOSP_SURESI = cbHOSP.Text != "" ? int.Parse(cbHOSP.Text) : (-1);
                PosOP.PREOP_KREATIN = txtPreoKreat.Text != "" ? decimal.Parse(txtPreoKreat.Text) : (-1);
                PosOP.POSTOP_KREATIN = txtPosKreat.Text != "" ? decimal.Parse(txtPosKreat.Text) : (-1);
                PosOP.PREOP_HCT = txtPreoHCT.Text != "" ? decimal.Parse(txtPreoHCT.Text) : (-1);
                PosOP.POSTOP_HCT = txtPostHCT.Text != "" ? decimal.Parse(txtPostHCT.Text) : (-1);
                PosOP.PREOP_HB = txtPreoHB.Text != "" ? decimal.Parse(txtPreoHB.Text) : (-1);
                PosOP.POSTOP_HB = txtPostHB.Text != "" ? decimal.Parse(txtPostHB.Text) : (-1);
                PosOP.TAKIP = txtTakipPOS.Text;
                PosOP.TEL = txtTEL.Text;
                _db.tblPosOperatif_Ozelliklers.InsertOnSubmit(PosOP);
                #endregion

                //5
                #region PatolojikVeriler
                tblPatolojikVeriler Patol = new tblPatolojikVeriler();
                Patol.HastaID = int.Parse(txtHastaIdPatol.Text);
                Patol.PATOLOJI = cbPatoloji.Text;
                Patol.ALT_GRUP = cbAltGrup.Text;
                Patol.FURHMAN_GRADE = cbFurhGrade.Text != "" ? int.Parse(cbFurhGrade.Text) : (-1);
                Patol.PATOLOJIK_EVRE = cbPatolojiEvre.Text;
                Patol.CERRAHI_SINIR = cbCerrahSinir.Text;
                _db.tblPatolojikVerilers.InsertOnSubmit(Patol);
                #endregion

                //6
                #region TakipVerileri
                tblTakipVerileri takip = new tblTakipVerileri();
                takip.HastaID = int.Parse(txtHastaIdTakipVer.Text);
                takip.POSTOP_3_AY_LOKAL_NUKS = txtPost3Lok.Text;
                takip.POSTOP_3_AY_KREATIN = txtPost3Krea.Text != "" ? decimal.Parse(txtPost3Krea.Text) : (-1);
                takip.POSTOP_6_AY_LOKAL_NUKS = txtPost6Lok.Text;
                takip.POSTOP_6_AY_KREATIN = txtPost6Krea.Text != "" ? decimal.Parse(txtPost6Krea.Text) : (-1);
                takip.POSTOP_12_AY_LOKAL_NUKS = txtPost12Lok.Text;
                takip.POSTOP_12_AY_KREATIN = txtPost12Krea.Text != "" ? decimal.Parse(txtPost12Krea.Text) : (-1);
                _db.tblTakipVerileris.InsertOnSubmit(takip);
                #endregion

                _db.SubmitChanges();
                myMessages.YeniKayit("Kayıt başarıyla gerçekleşti.");
                Temizle();
            }
            catch (Exception e)
            {
                myMessages.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                //1
                #region tblHastaBilgileri
                tblHastaBilgileri hasBilgi = _db.tblHastaBilgileris.First(o => o.ID == _HastaID);
                hasBilgi.Ad = txtAd.Text;
                hasBilgi.Soyad = txtSoyad.Text;
                hasBilgi.Protokol = txtProtokol.Text;
                hasBilgi.OPTarihi = DateTime.Parse(dtpOPTarihi.Text);
                hasBilgi.OPTuru = txtOPTuru.Text;
                hasBilgi.Takip = txtTakip.Text != "" ? int.Parse(txtTakip.Text) : (-1);
                hasBilgi.ANAH = txtANAH.Text != "" ? int.Parse(txtANAH.Text) : (-1);
                #endregion

                //2
                #region tblDemografik_Ozellikleri
                tblDemografik_Ozellikleri Demog = _db.tblDemografik_Ozellikleris.First(o => o.HastaID == _HastaID);
                Demog.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : (-1);
                Demog.Boy = txtBoy.Text != "" ? int.Parse(txtBoy.Text) : (-1);
                Demog.Kilo = txtKilo.Text != "" ? int.Parse(txtKilo.Text) : (-1);
                Demog.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : (-1);
                Demog.ASA = cbASA.Text != "" ? int.Parse(cbASA.Text) : (-1);
                Demog.Dr = txtDR.Text;
                Demog.Cins = cbCins.Text;
                Demog.Taraf = cbTaraf.Text;
                Demog.Lokalizasyon = txtLokalizasyon.Text;
                Demog.Boyut = int.Parse(txtBoyut.Text);
                Demog.KO_Morbidite = txtKoMorbidite.Text;
                #endregion

                //3
                #region tblOperatif_Ozellikler
                tblOperatif_Ozellikler OpOz = _db.tblOperatif_Ozelliklers.First(o => o.HastaID == _HastaID);
                OpOz.PKS_Aciklama = cbPKS.Text;
                OpOz.SIK = cbSIK.Text;
                OpOz.CO_Operasyon = txtCOOP.Text;
                OpOz.iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : (-1);
                OpOz.Port_Sayisi = txtPortSay.Text != "" ? int.Parse(txtPortSay.Text) : (-1);
                OpOz.Yardim_YNT = txtYardim.Text;
                OpOz.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : (-1);
                OpOz.DREN = txtDREN.Text;
                OpOz.KANAMA = txtKANAMA.Text != "" ? int.Parse(txtKANAMA.Text) : (-1);
                OpOz.PIYES = txtPIYES.Text != "" ? int.Parse(txtPIYES.Text) : (-1);
                #endregion

                //4
                #region tblPosOperatif_Ozellikler
                tblPosOperatif_Ozellikler PosOP = _db.tblPosOperatif_Ozelliklers.First(o => o.HastaID == _HastaID);
                PosOP.PEROP_VE_ERKEN_KOMP = cbPeropVeErk.Text;
                PosOP.POSTOP_ANALIZ = txtPostANA.Text != "" ? decimal.Parse(txtPostANA.Text) : (-1);
                PosOP.SONDA = cbSonda.Text;
                PosOP.HOSP_SURESI = cbHOSP.Text != "" ? int.Parse(cbHOSP.Text) : (-1);
                PosOP.PREOP_KREATIN = txtPreoKreat.Text != "" ? decimal.Parse(txtPreoKreat.Text) : (-1);
                PosOP.POSTOP_KREATIN = txtPosKreat.Text != "" ? decimal.Parse(txtPosKreat.Text) : (-1);
                PosOP.PREOP_HCT = txtPreoHCT.Text != "" ? decimal.Parse(txtPreoHCT.Text) : (-1);
                PosOP.POSTOP_HCT = txtPostHCT.Text != "" ? decimal.Parse(txtPostHCT.Text) : (-1);
                PosOP.PREOP_HB = txtPreoHB.Text != "" ? decimal.Parse(txtPreoHB.Text) : (-1);
                PosOP.POSTOP_HB = txtPostHB.Text != "" ? decimal.Parse(txtPostHB.Text) : (-1);
                PosOP.TAKIP = txtTakipPOS.Text;
                PosOP.TEL = txtTEL.Text;
                #endregion

                //5
                #region tblPatolojikVeriler
                tblPatolojikVeriler Patol = _db.tblPatolojikVerilers.First(o => o.HastaID == _HastaID);
                Patol.PATOLOJI = cbPatoloji.Text;
                Patol.ALT_GRUP = cbAltGrup.Text;
                Patol.FURHMAN_GRADE = cbFurhGrade.Text != "" ? int.Parse(cbFurhGrade.Text) : (-1);
                Patol.PATOLOJIK_EVRE = cbPatolojiEvre.Text;
                Patol.CERRAHI_SINIR = cbCerrahSinir.Text;
                #endregion

                //6
                #region tblTakipVerileri
                tblTakipVerileri takip = _db.tblTakipVerileris.First(o => o.HastaID == _HastaID);
                takip.POSTOP_3_AY_LOKAL_NUKS = txtPost3Lok.Text;
                takip.POSTOP_3_AY_KREATIN = txtPost3Krea.Text != "" ? decimal.Parse(txtPost3Krea.Text) : (-1);
                takip.POSTOP_6_AY_LOKAL_NUKS = txtPost6Lok.Text;
                takip.POSTOP_6_AY_KREATIN = txtPost6Krea.Text != "" ? decimal.Parse(txtPost6Krea.Text) : (-1);
                takip.POSTOP_12_AY_LOKAL_NUKS = txtPost12Lok.Text;
                takip.POSTOP_12_AY_KREATIN = txtPost12Krea.Text != "" ? decimal.Parse(txtPost12Krea.Text) : (-1);
                #endregion

                _db.SubmitChanges();
                myMessages.Guncelle(true);
                Temizle();
            }
            catch (Exception gg)
            {
                myMessages.Hata(gg);
            }
        }

        #region SanalButonlar
        protected override void OnLoad(EventArgs e)
        {
            #region DoktorSanalBtn
            var btnDr = new Button();
            btnDr.Size = new Size(25, txtDR.ClientSize.Height + 2);
            btnDr.Location = new Point(txtDR.ClientSize.Width - btnDr.Width, -1);
            btnDr.Cursor = Cursors.Default;
            btnDr.Image = Properties.Resources.arrow1;
            txtDR.Controls.Add(btnDr);
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtDR.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnDr.Width << 16));
            btnDr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            #endregion

            #region HastaSanalBtn
            var btnHast = new Button();
            btnHast.Size = new Size(25, txtHastaID.ClientSize.Height + 2);
            btnHast.Location = new Point(txtHastaID.ClientSize.Width - btnHast.Width, -1);
            btnHast.Cursor = Cursors.Default;
            btnHast.Image = Properties.Resources.arrow1;
            txtHastaID.Controls.Add(btnHast);
            SendMessage(txtHastaID.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnHast.Width << 16));
            btnHast.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            #endregion

            #region OperationSanalBtn
            var btnOp = new Button();
            btnOp.Size = new Size(25, txtOPTuru.ClientSize.Height + 2);
            btnOp.Location = new Point(txtOPTuru.ClientSize.Width - btnOp.Width, -1);
            btnOp.Cursor = Cursors.Default;
            btnOp.Image = Properties.Resources.arrow1;
            txtOPTuru.Controls.Add(btnOp);
            SendMessage(txtOPTuru.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnOp.Width << 16));
            btnOp.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            #endregion

            base.OnLoad(e);
            btnDr.Click += btnDr_Click;
            btnHast.Click += btnHast_Click;
            btnOp.Click += btnOp_Click;

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnDr_Click(object sender, EventArgs e)
        {
            myForms.DoktorList(true);
            DoktorAktar();
            frmMainPage.myMainString = "";
        }
        void DoktorAktar()
        {
            try
            {
                //edit = true;
                txtDR.Text = frmMainPage.myMainString;
            }
            catch (Exception e)
            {
                myMessages.Hata(e);
            }
        }

        private void btnHast_Click(object sender, EventArgs e)
        {
            int Hasid = myForms.HastaList(true);
            if (Hasid > 0)
            {
                HastaAktar(Hasid);
            }
            frmMainPage.transferID = -1;
        }
        void HastaAktar(int id)
        {
            try
            {
                edit = true;
                _HastaID = id;

                #region tblHastaBilgileri
                tblHastaBilgileri Has = _db.tblHastaBilgileris.First(s => s.ID == _HastaID);
                txtHastaID.Text = Has.ID.ToString().PadLeft(9, '0');
                txtAd.Text = Has.Ad;
                txtSoyad.Text = Has.Soyad;
                txtProtokol.Text = Has.Protokol;
                dtpOPTarihi.Text = DateTime.Now.ToShortDateString();
                txtOPTuru.Text = Has.OPTuru;
                txtTakip.Text = Has.Takip.ToString();
                txtANAH.Text = Has.ANAH.ToString();
                #endregion

                #region tblDemografik_Ozellikleri
                tblDemografik_Ozellikleri Demo = _db.tblDemografik_Ozellikleris.First(s => s.HastaID == _HastaID);
                txtHastaIdDemo.Text = Demo.HastaID.ToString().PadLeft(5, '0');
                txtYas.Text = Demo.Yas.ToString();
                txtBoy.Text = Demo.Boy.ToString();
                txtKilo.Text = Demo.Kilo.ToString();
                txtBMI.Text = Demo.BMI.ToString();
                cbASA.Text = Demo.ASA.ToString();
                txtDR.Text = Demo.Dr;
                cbCins.Text = Demo.Cins;
                cbTaraf.Text = Demo.Taraf;
                txtLokalizasyon.Text = Demo.Lokalizasyon;
                txtBoyut.Text = Demo.Boyut.ToString();
                txtKoMorbidite.Text = Demo.KO_Morbidite;
                #endregion

                #region tblOperatif_Ozellikler
                tblOperatif_Ozellikler Opera = _db.tblOperatif_Ozelliklers.First(s => s.HastaID == _HastaID);
                txtHastaIdOper.Text = Opera.HastaID.ToString().PadLeft(5, '0');
                cbPKS.Text = Opera.PKS_Aciklama;
                cbSIK.Text = Opera.SIK;
                txtCOOP.Text = Opera.CO_Operasyon;
                txtIskemi.Text = Opera.iskemi.ToString();
                txtPortSay.Text = Opera.Port_Sayisi.ToString();
                txtYardim.Text = Opera.Yardim_YNT;
                txtSure.Text = Opera.Sure.ToString();
                txtDREN.Text = Opera.DREN;
                txtKANAMA.Text = Opera.KANAMA.ToString();
                txtPIYES.Text = Opera.PIYES.ToString();
                #endregion

                #region tblPosOperatif_Ozellikler
                tblPosOperatif_Ozellikler POSOp = _db.tblPosOperatif_Ozelliklers.First(s => s.HastaID == _HastaID);
                txtHastaIdPosOP.Text = POSOp.HastaID.ToString().PadLeft(5, '0');
                cbPeropVeErk.Text = POSOp.PEROP_VE_ERKEN_KOMP;
                txtPostANA.Text = POSOp.POSTOP_ANALIZ.ToString();
                cbSonda.Text = POSOp.SONDA;
                cbHOSP.Text = POSOp.HOSP_SURESI.ToString();
                txtPreoKreat.Text = POSOp.PREOP_KREATIN.ToString();
                txtPosKreat.Text = POSOp.POSTOP_KREATIN.ToString();
                txtPreoHCT.Text = POSOp.PREOP_HCT.ToString();
                txtPostHCT.Text = POSOp.POSTOP_HCT.ToString();
                txtPreoHB.Text = POSOp.PREOP_HB.ToString();
                txtPostHB.Text = POSOp.POSTOP_HB.ToString();
                txtTakipPOS.Text = POSOp.TAKIP;
                txtTEL.Text = POSOp.TEL;
                #endregion

                #region tblPatolojikVeriler
                tblPatolojikVeriler Pat = _db.tblPatolojikVerilers.First(s => s.HastaID == _HastaID);
                txtHastaIdPatol.Text = Pat.HastaID.ToString().PadLeft(5, '0');
                cbPatoloji.Text = Pat.PATOLOJI;
                cbAltGrup.Text = Pat.ALT_GRUP;
                cbFurhGrade.Text = Pat.FURHMAN_GRADE.ToString();
                cbPatolojiEvre.Text = Pat.PATOLOJIK_EVRE;
                cbCerrahSinir.Text = Pat.CERRAHI_SINIR;
                #endregion

                #region tblTakipVerileri
                tblTakipVerileri Tak = _db.tblTakipVerileris.First(s => s.HastaID == _HastaID);
                txtHastaIdTakipVer.Text = Tak.HastaID.ToString().PadLeft(5, '0');
                txtPost3Lok.Text = Tak.POSTOP_3_AY_LOKAL_NUKS;
                txtPost3Krea.Text = Tak.POSTOP_3_AY_KREATIN.ToString();
                txtPost6Lok.Text = Tak.POSTOP_6_AY_LOKAL_NUKS;
                txtPost6Krea.Text = Tak.POSTOP_6_AY_KREATIN.ToString();
                txtPost12Lok.Text = Tak.POSTOP_12_AY_LOKAL_NUKS;
                txtPost12Krea.Text = Tak.POSTOP_12_AY_KREATIN.ToString();
                #endregion
            }
            catch (Exception jj)
            {
                myMessages.Hata(jj);
            }
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            myForms.OperationList(true);
            OperationAktar();
            frmMainPage.myMainString = "";
        }
        void OperationAktar()
        {
            try
            {
                //edit = true;
                txtOPTuru.Text = frmMainPage.myMainString;
            }
            catch (Exception e)
            {
                myMessages.Hata(e);
            }
        }
        #endregion

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void txtBMI_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKilo.Text != "" && txtBoy.Text != "")
                {
                    double BMI = (double.Parse(txtKilo.Text) / Math.Pow((double.Parse(txtBoy.Text) / 100), 2));
                    txtBMI.Text = Math.Round(BMI).ToString();
                }
                else
                {
                    txtBMI.Text = "";
                }
            }
            catch (Exception ff)
            {
                myMessages.Hata(ff);
            }
        }

        #region KeyPress
        //1
        private void txtTakip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtANAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //2
        private void txtYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //3
        private void txtIskemi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPortSay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtDREN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtKANAMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPIYES_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //4
        private void txtPostANA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPreoKreat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPosKreat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPreoHCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPostHCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPreoHB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPostHB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //6
        private void txtPost3Krea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPost6Krea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtPost12Krea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

    }
}
