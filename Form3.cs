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
    public partial class Form3 : Form
    {
        kutuphaneotoEntities1 db = new kutuphaneotoEntities1();
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenAd=kul_ad.Text;
            string gelenpsv=kul_psv.Text;

            var personel =db.personel.Where(x=>x.personal_kulad.Equals(gelenAd)&& x.personel_psv.Equals(gelenpsv)).FirstOrDefault();

            if (personel == null ) 
            {
                MessageBox.Show("giriş yapılamadı");
            }
            else
            {
                Form1 form1 = new Form1(); // Form 1'in nesnesini oluşturun
                form1.Show(); // Form 1'i göster
                this.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
