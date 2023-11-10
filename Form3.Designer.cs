namespace kütüphane
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.kul_ad = new System.Windows.Forms.TextBox();
            this.kul_psv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(272, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 118);
            this.button1.TabIndex = 1;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kul_ad
            // 
            this.kul_ad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_ad.Location = new System.Drawing.Point(360, 91);
            this.kul_ad.Name = "kul_ad";
            this.kul_ad.Size = new System.Drawing.Size(277, 42);
            this.kul_ad.TabIndex = 2;
            this.kul_ad.Text = "1";
            this.kul_ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kul_psv
            // 
            this.kul_psv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_psv.Location = new System.Drawing.Point(360, 237);
            this.kul_psv.Name = "kul_psv";
            this.kul_psv.Size = new System.Drawing.Size(277, 42);
            this.kul_psv.TabIndex = 3;
            this.kul_psv.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "kullanıcı şifresi";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kul_psv);
            this.Controls.Add(this.kul_ad);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giriş";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kul_ad;
        private System.Windows.Forms.TextBox kul_psv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}