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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kıtap_kayıt_btn_Click(object sender, EventArgs e)
        {
            // Form2'yi oluştur
            Form2 form2 = new Form2();

            // Form2'yi göster
            form2.Show();

            // Form1'i gizle
            this.Hide();
        }

        private void kyt_et_Click(object sender, EventArgs e)
        {
            kullanıcı_islem kyt = new kullanıcı_islem();
            kyt.Show();
            this.Hide();
        }

        private void kyt_lis_btn_Click(object sender, EventArgs e)
        {
        kul_lis_form kul_Lis = new kul_lis_form();
            kul_Lis.Show();
            this.Hide();

        }
    }
}
