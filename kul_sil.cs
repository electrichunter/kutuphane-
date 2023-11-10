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
    
 
    public partial class kul_sil : Form
    {
        kutuphaneotoEntities1 db = new kutuphaneotoEntities1();
        public void kul_liste()
        {
           
            var kullanicilar = db.kullanıcılar.ToList();

            dataGridView1.DataSource = kullanicilar.ToList();
            // Kullanıcı ID sütununu kaldırın
            // dataGridView1.Columns.Remove("kullanıcı_id");

        }
        public kul_sil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void kul_sil_Load(object sender, EventArgs e)
        {
            kul_liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value);
            var kullanicilar = db.kullanıcılar.Where(x=> x.kullanıcı_id == secilenID).FirstOrDefault();
            db.kullanıcılar.Remove(kullanicilar);
            
            db.SaveChanges();
            kul_liste();
        }
    }
}
