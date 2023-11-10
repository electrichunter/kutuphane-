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
    public partial class kul_lis_form : Form
    {
         public void kul_liste()
        {
            kutuphaneotoEntities1 db = new kutuphaneotoEntities1();
            var kullanicilar = db.kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            // Kullanıcı ID sütununu kaldırın
            dataGridView1.Columns.Remove("kullanıcı_id");
            dataGridView1.Columns.Remove("kullanıcı_ceza");
        }
        public kul_lis_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
       
        private void kul_lis_form_Load(object sender, EventArgs e)
        {
            kul_liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Form 1'in nesnesini oluşturun
            form1.Show(); // Form 1'i göster
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kul_ekle kul_Ekle_FRM = new kul_ekle();
            kul_Ekle_FRM.Show();
            this.Hide();
        }
    }
}
