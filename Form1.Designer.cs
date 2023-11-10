namespace kütüphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kıtap_kayıt_btn = new System.Windows.Forms.Button();
            this.ktp_list = new System.Windows.Forms.Button();
            this.odnç_ver_btn = new System.Windows.Forms.Button();
            this.odnç_al_btn = new System.Windows.Forms.Button();
            this.kyt_et = new System.Windows.Forms.Button();
            this.kullnıcı_lis_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kıtap_kayıt_btn
            // 
            this.kıtap_kayıt_btn.Location = new System.Drawing.Point(75, 63);
            this.kıtap_kayıt_btn.Name = "kıtap_kayıt_btn";
            this.kıtap_kayıt_btn.Size = new System.Drawing.Size(185, 145);
            this.kıtap_kayıt_btn.TabIndex = 0;
            this.kıtap_kayıt_btn.Text = "KİTAP KAYIT";
            this.kıtap_kayıt_btn.UseVisualStyleBackColor = true;
            this.kıtap_kayıt_btn.Click += new System.EventHandler(this.kıtap_kayıt_btn_Click);
            // 
            // ktp_list
            // 
            this.ktp_list.Location = new System.Drawing.Point(75, 325);
            this.ktp_list.Name = "ktp_list";
            this.ktp_list.Size = new System.Drawing.Size(185, 145);
            this.ktp_list.TabIndex = 1;
            this.ktp_list.Text = "KİTAPLARI LİSTELE";
            this.ktp_list.UseVisualStyleBackColor = true;
            // 
            // odnç_ver_btn
            // 
            this.odnç_ver_btn.Location = new System.Drawing.Point(315, 63);
            this.odnç_ver_btn.Name = "odnç_ver_btn";
            this.odnç_ver_btn.Size = new System.Drawing.Size(185, 145);
            this.odnç_ver_btn.TabIndex = 2;
            this.odnç_ver_btn.Text = "ÖDÜNÇ VER";
            this.odnç_ver_btn.UseVisualStyleBackColor = true;
            // 
            // odnç_al_btn
            // 
            this.odnç_al_btn.Location = new System.Drawing.Point(315, 325);
            this.odnç_al_btn.Name = "odnç_al_btn";
            this.odnç_al_btn.Size = new System.Drawing.Size(185, 145);
            this.odnç_al_btn.TabIndex = 3;
            this.odnç_al_btn.Text = "ÖDÜNÇ ALINAN";
            this.odnç_al_btn.UseVisualStyleBackColor = true;
            // 
            // kyt_et
            // 
            this.kyt_et.Location = new System.Drawing.Point(565, 63);
            this.kyt_et.Name = "kyt_et";
            this.kyt_et.Size = new System.Drawing.Size(185, 145);
            this.kyt_et.TabIndex = 4;
            this.kyt_et.Text = "KULLANICI İŞLEMLERİ";
            this.kyt_et.UseVisualStyleBackColor = true;
            this.kyt_et.Click += new System.EventHandler(this.kyt_et_Click);
            // 
            // kullnıcı_lis_btn
            // 
            this.kullnıcı_lis_btn.Location = new System.Drawing.Point(565, 325);
            this.kullnıcı_lis_btn.Name = "kullnıcı_lis_btn";
            this.kullnıcı_lis_btn.Size = new System.Drawing.Size(185, 145);
            this.kullnıcı_lis_btn.TabIndex = 5;
            this.kullnıcı_lis_btn.Text = "KULLANICILARI LİSTELE";
            this.kullnıcı_lis_btn.UseVisualStyleBackColor = true;
            this.kullnıcı_lis_btn.Click += new System.EventHandler(this.kyt_lis_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 531);
            this.Controls.Add(this.kullnıcı_lis_btn);
            this.Controls.Add(this.kyt_et);
            this.Controls.Add(this.odnç_al_btn);
            this.Controls.Add(this.odnç_ver_btn);
            this.Controls.Add(this.ktp_list);
            this.Controls.Add(this.kıtap_kayıt_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kıtap_kayıt_btn;
        private System.Windows.Forms.Button ktp_list;
        private System.Windows.Forms.Button odnç_ver_btn;
        private System.Windows.Forms.Button odnç_al_btn;
        private System.Windows.Forms.Button kyt_et;
        private System.Windows.Forms.Button kullnıcı_lis_btn;
    }
}

