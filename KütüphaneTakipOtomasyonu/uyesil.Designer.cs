namespace KütüphaneTakipOtomasyonu
{
    partial class uyesil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.btnuyesil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lbluyeno = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtuyeno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnuyeiptal = new System.Windows.Forms.Button();
            this.btnuyeguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 313);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(413, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tc Kimlik Ara";
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(522, 101);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(231, 22);
            this.txttcara.TabIndex = 32;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // btnuyesil
            // 
            this.btnuyesil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyesil.Location = new System.Drawing.Point(546, 193);
            this.btnuyesil.Name = "btnuyesil";
            this.btnuyesil.Size = new System.Drawing.Size(118, 37);
            this.btnuyesil.TabIndex = 31;
            this.btnuyesil.Text = "S İ L";
            this.btnuyesil.UseVisualStyleBackColor = true;
            this.btnuyesil.Click += new System.EventHandler(this.btnuyesil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.lbluyeno);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.txteposta);
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtuyeno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 220);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(94, 64);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(231, 22);
            this.txtad.TabIndex = 24;
            // 
            // lbluyeno
            // 
            this.lbluyeno.AutoSize = true;
            this.lbluyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluyeno.Location = new System.Drawing.Point(19, 35);
            this.lbluyeno.Name = "lbluyeno";
            this.lbluyeno.Size = new System.Drawing.Size(73, 17);
            this.lbluyeno.TabIndex = 23;
            this.lbluyeno.Text = "Tc Kimlik";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(94, 178);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(231, 22);
            this.txtadres.TabIndex = 19;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(94, 150);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(231, 22);
            this.txteposta.TabIndex = 18;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(94, 121);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(231, 22);
            this.txttelefon.TabIndex = 17;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(94, 92);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(231, 22);
            this.txtsoyad.TabIndex = 16;
            // 
            // txtuyeno
            // 
            this.txtuyeno.Location = new System.Drawing.Point(94, 36);
            this.txtuyeno.Name = "txtuyeno";
            this.txtuyeno.Size = new System.Drawing.Size(231, 22);
            this.txtuyeno.TabIndex = 15;
            this.txtuyeno.TextChanged += new System.EventHandler(this.txtuyeno_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-Posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ad :";
            // 
            // btnuyeiptal
            // 
            this.btnuyeiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyeiptal.Location = new System.Drawing.Point(683, 193);
            this.btnuyeiptal.Name = "btnuyeiptal";
            this.btnuyeiptal.Size = new System.Drawing.Size(117, 37);
            this.btnuyeiptal.TabIndex = 30;
            this.btnuyeiptal.Text = "İ P T A L";
            this.btnuyeiptal.UseVisualStyleBackColor = true;
            this.btnuyeiptal.Click += new System.EventHandler(this.btnuyeiptal_Click);
            // 
            // btnuyeguncelle
            // 
            this.btnuyeguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyeguncelle.Location = new System.Drawing.Point(365, 193);
            this.btnuyeguncelle.Name = "btnuyeguncelle";
            this.btnuyeguncelle.Size = new System.Drawing.Size(155, 37);
            this.btnuyeguncelle.TabIndex = 29;
            this.btnuyeguncelle.Text = "G Ü N C E L L E";
            this.btnuyeguncelle.UseVisualStyleBackColor = true;
            this.btnuyeguncelle.Click += new System.EventHandler(this.btnuyeguncelle_Click);
            // 
            // uyesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.btnuyesil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnuyeiptal);
            this.Controls.Add(this.btnuyeguncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "uyesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uyesil";
            this.Load += new System.EventHandler(this.uyesil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Button btnuyesil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lbluyeno;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtuyeno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnuyeiptal;
        private System.Windows.Forms.Button btnuyeguncelle;
    }
}