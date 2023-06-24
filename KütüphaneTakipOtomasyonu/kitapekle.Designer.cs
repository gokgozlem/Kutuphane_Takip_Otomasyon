namespace KütüphaneTakipOtomasyonu
{
    partial class kitapekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btniptal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txtkitapadı = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtrafno = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.txtrafno);
            this.groupBox1.Controls.Add(this.txtstok);
            this.groupBox1.Controls.Add(this.txtsayfasayisi);
            this.groupBox1.Controls.Add(this.txtyayinevi);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.txtkitapadı);
            this.groupBox1.Controls.Add(this.txtbarkodno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btniptal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yayınevi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniptal.Location = new System.Drawing.Point(229, 419);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(97, 38);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İ P T A L";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(54, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Türü :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stok Sayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Raf No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Açıklama :";
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(117, 52);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(209, 22);
            this.txtbarkodno.TabIndex = 11;
            // 
            // txtkitapadı
            // 
            this.txtkitapadı.Location = new System.Drawing.Point(117, 90);
            this.txtkitapadı.Name = "txtkitapadı";
            this.txtkitapadı.Size = new System.Drawing.Size(209, 22);
            this.txtkitapadı.TabIndex = 12;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(117, 128);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(209, 22);
            this.txtyazar.TabIndex = 13;
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(117, 166);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(209, 22);
            this.txtyayinevi.TabIndex = 14;
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Location = new System.Drawing.Point(117, 204);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(209, 22);
            this.txtsayfasayisi.TabIndex = 15;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(117, 282);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(209, 22);
            this.txtstok.TabIndex = 16;
            // 
            // txtrafno
            // 
            this.txtrafno.Location = new System.Drawing.Point(117, 320);
            this.txtrafno.Name = "txtrafno";
            this.txtrafno.Size = new System.Drawing.Size(209, 22);
            this.txtrafno.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Psikoloji",
            "Tarih",
            "Din",
            "Siyaset-Politika",
            "Dünya Klasikleri",
            "Aşk",
            "Kişisel Gelişim",
            "Çocuk",
            "Macera-Aksiyon",
            "Felsefe-Düşünce",
            "Şiir",
            "Korku-Gerilim",
            "Polisiye",
            "Fantastik",
            "Edebiyat",
            "Bilim Kurgu",
            "Sosyoloji",
            "Biyografi",
            "Araştırma-İnceleme",
            "Deneme-İnceleme",
            "Parapsikoloji-Spiritualizm",
            "Ekonomi-Emek-İş Dünyası",
            "Eğlence-Mizah",
            "Masal",
            "Anı-Mektup-Günlük",
            "Sağlık-Tıp",
            "İnsan ve Toplum",
            "Eğitim",
            "Bilim-Teknoloji-Mühendislik",
            "Tiyatro",
            "Çizgi-Roman",
            "Türk Klasikleri",
            "Antropoloji-Etnoloji",
            "Bilgisayar-İnternet",
            "Yeraltı Edebiyatı",
            "Hukuk",
            "Mitolojiler",
            "Spor",
            "Sanat",
            "Gezi",
            "Anlatı",
            "Kadın-Erkek",
            "Efsaneler-Destanlar",
            "Dergi",
            "Eleştiri-Kuram",
            "Aile",
            "Hobi",
            "Söyleşi-Röportaj",
            "İletişim-Medya",
            "Halk Edebiyatı",
            "Senaryo-Oyun",
            "Ekoloji",
            "Sözlük-Kılavuz Kİtap-Ansiklopedi",
            "Moda",
            "Kültür"});
            this.comboBox1.Location = new System.Drawing.Point(117, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(117, 419);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 38);
            this.btnekle.TabIndex = 20;
            this.btnekle.Text = "E K L E";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(117, 358);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(209, 45);
            this.txtaciklama.TabIndex = 18;
            // 
            // kitapekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 506);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kitapekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme ";
            this.Load += new System.EventHandler(this.kitapekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtrafno;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtkitapadı;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtaciklama;
    }
}