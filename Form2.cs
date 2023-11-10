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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
