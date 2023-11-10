using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class kul_ekle : Form
    {
        kutuphaneotoEntities1 db=new kutuphaneotoEntities1();
        public kul_ekle()
        {
            InitializeComponent();
        }

        private void kul_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kullanıcılar kullaniciekle = new kullanıcılar();
                kullaniciekle.kullanıcı_ad = ad_tb.Text;
                kullaniciekle.kullanıcı_soyad = sad_tb.Text;
                kullaniciekle.kullanıcı_tc = tc_tb.Text;
                kullaniciekle.kullanıcı_mail = mail_tb.Text;
                kullaniciekle.kullanıcı_tel = tel_tb.Text;

                db.kullanıcılar.Add(kullaniciekle);
                db.SaveChanges();

                // Kullanıcı başarıyla eklenirse, başarı mesajı göster
                MessageBox.Show("Kullanıcı başarıyla eklenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verileri temizle
                ad_tb.Clear();
                sad_tb.Clear();
                tc_tb.Clear();
                mail_tb.Clear();
                tel_tb.Clear();
            }
            catch (Exception ex)
            {
                // Hata durumunda bir hata mesajı göster
                MessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form2'yi oluştur
            Form1 form1 = new Form1();

            // Form2'yi göster
            form1.Show();

            // Form1'i gizle
            this.Hide();
        }
    }
}
