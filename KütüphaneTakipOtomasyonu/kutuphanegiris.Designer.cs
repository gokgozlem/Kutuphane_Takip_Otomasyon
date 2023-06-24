namespace KütüphaneTakipOtomasyonu
{
    partial class kutuphanegiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kutuphanegiris));
            this.btnyoneticigiris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.btnyonetici = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyoneticigiris
            // 
            this.btnyoneticigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyoneticigiris.Location = new System.Drawing.Point(195, 380);
            this.btnyoneticigiris.Name = "btnyoneticigiris";
            this.btnyoneticigiris.Size = new System.Drawing.Size(87, 27);
            this.btnyoneticigiris.TabIndex = 12;
            this.btnyoneticigiris.Text = "Giriş Yap";
            this.btnyoneticigiris.UseVisualStyleBackColor = true;
            this.btnyoneticigiris.Click += new System.EventHandler(this.btnyoneticigiris_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(395, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "KULLANICI GİRİŞİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "YÖNETİCİ GİRİŞİ";
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkullanici.BackgroundImage")));
            this.btnkullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkullanici.Location = new System.Drawing.Point(334, 94);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(247, 248);
            this.btnkullanici.TabIndex = 8;
            this.btnkullanici.UseVisualStyleBackColor = true;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnyonetici.BackgroundImage")));
            this.btnyonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyonetici.Location = new System.Drawing.Point(49, 94);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(247, 248);
            this.btnyonetici.TabIndex = 7;
            this.btnyonetici.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre :";
            // 
            // kutuphanegiris
            // 
            this.AcceptButton = this.btnyoneticigiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnyoneticigiris);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkullanici);
            this.Controls.Add(this.btnyonetici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kutuphanegiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KÜTÜPHANE GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyoneticigiris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Label label3;
    }
}

