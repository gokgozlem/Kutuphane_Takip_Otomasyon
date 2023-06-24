using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipOtomasyonu
{
    public partial class kitapekle : Form
    {
        public kitapekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");

        private void kitapekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkodno,kitapadi,yazar,yayinevi,sayfasayisi,turu,stoksayisi,rafno,aciklama) values(@barkodno,@kitapadi,@yazar,@yayinevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtkitapadı.Text);
            komut.Parameters.AddWithValue("@yazar", txtyazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboBox1.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtstok.Text);
            komut.Parameters.AddWithValue("@rafno", txtrafno.Text);
            komut.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT İŞLEMİ TAMAMLANDI..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
