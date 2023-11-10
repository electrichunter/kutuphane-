using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class kul_güncelle : Form
    {
        kutuphaneotoEntities1 db = new kutuphaneotoEntities1();
        public void kul_liste()
        {
           
            var kullanicilar = db.kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            // Kullanıcı ID sütununu kaldırın
            //dataGridView1.Columns.Remove("kullanıcı_id");
            //dataGridView1.Columns.Remove("kullanıcı_ceza");
        }
        public kul_güncelle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { 
     
{
                ad_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                sad_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                tc_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                mail_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                tel_tb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }

}

private void kul_güncelle_Load(object sender, EventArgs e)
        {
            kul_liste();
        }

        private void ad_tb_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int secilenID =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanicilar=db.kullanıcılar.Where(x=>x.kullanıcı_id==secilenID).FirstOrDefault();
            kullanicilar.kullanıcı_ad = ad_tb.Text;
            kullanicilar.kullanıcı_soyad = sad_tb.Text;
            kullanicilar.kullanıcı_tc = tc_tb.Text;
            kullanicilar.kullanıcı_mail = mail_tb.Text;
            kullanicilar.kullanıcı_tel = tel_tb.Text;
            db.SaveChanges();
            kul_liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kul_ekle kul_Ekle_FRM = new kul_ekle();
            kul_Ekle_FRM.Show();
            this.Hide();
        }
    }
}
