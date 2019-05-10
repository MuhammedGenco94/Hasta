using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sablon.Hasta
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir. \nGüncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrardan yapmak istediğinizden emin misiniz?", "Kayıt Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Kayıt kalıcı olarak silinecektir.\nSilme işlemimi onaylıyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Kayit(bool kayit)
        {
            MessageBox.Show("Aynı kayıt tekrardan kaydedilmiştir", "Kayıt Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydı yazdırmak istiyor musunuz?", "Yazdırma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
