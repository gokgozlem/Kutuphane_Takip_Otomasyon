using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipOtomasyonu
{
    public partial class kutuphanegiris : Form
    {
        public kutuphanegiris()
        {
            InitializeComponent();
        }

        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            string sifre;
            sifre = textBox1.Text;
            if (sifre == "123")
            {
                yoneticigiris yoneticigiris = new yoneticigiris();
                yoneticigiris.Show();
                this.Hide();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Parola Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            // datagridview ile kitap rezerve edicek,kitap süresi uzatıcak
        }
    }
}
