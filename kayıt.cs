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
    public partial class kullanıcı_islem : Form
    {
        public kullanıcı_islem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kul_ekle kul_Ekle = new kul_ekle();
          kul_Ekle.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1(); // Form 1'in nesnesini oluşturun
            form1.Show(); // Form 1'i göster
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kul_lis_form kul_Lis = new kul_lis_form();
            kul_Lis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kul_sil kul_Sil = new kul_sil();
            kul_Sil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kul_güncelle kul_Güncelle=new kul_güncelle();
            kul_Güncelle.Show();
            this.Hide();    

        }
    }
}
