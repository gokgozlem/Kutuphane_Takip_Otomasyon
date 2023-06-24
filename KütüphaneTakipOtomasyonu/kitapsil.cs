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
    public partial class kitapsil : Form
    {
        public kitapsil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        private void kitapsil_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnkitapsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz?", "sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme işlemi tamamlandı");
                daset.Tables["kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set barkodno=@barkodno,kitapadi=@kitapadi,yazar=@yazar,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno", baglanti);
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
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            daset.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtbarkodara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from kitap where barkodno like'%" + txtbarkodara.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from kitap where barkodno like'" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtbarkodno.Text = read["barkodno"].ToString();
                txtkitapadı.Text = read["kitapadi"].ToString();
                txtyazar.Text = read["yazar"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();
                comboBox1.Text = read["turu"].ToString();
                txtstok.Text = read["stoksayisi"].ToString();
                txtrafno.Text = read["rafno"].ToString();
                txtaciklama.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }
    }
}
