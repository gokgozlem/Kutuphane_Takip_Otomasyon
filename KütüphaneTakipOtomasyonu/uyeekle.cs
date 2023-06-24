using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneTakipOtomasyonu
{
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");

        private void uyeekle_Load(object sender, EventArgs e)
        {

        }

        private void btnuyeiptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnuyekaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uyeekle(tc,ad,soyad,telefon,eposta,adres) values(@tc,@ad,@soyad,@telefon,@eposta,@adres)", baglanti);
            komut.Parameters.AddWithValue("@tc",txtuyeno.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT İŞLEMİ TAMAMLANDI..","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
