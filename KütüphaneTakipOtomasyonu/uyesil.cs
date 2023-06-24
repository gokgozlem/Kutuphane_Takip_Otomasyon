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
    public partial class uyesil : Form
    {
        public uyesil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");

        private void txtuyeno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from uyeekle where tc like'" + txtuyeno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();
                txteposta.Text = read["eposta"].ToString();
                txtadres.Text = read["adres"].ToString();
            }
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtuyeno.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        DataSet daset = new DataSet();
        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uyeekle"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from uyeekle where tc like'%" + txttcara.Text + "%'", baglanti);
            adtr.Fill(daset, "uyeekle");
            dataGridView1.DataSource = daset.Tables["uyeekle"];
            baglanti.Close();



        }

        private void btnuyeiptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnuyesil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz?","sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uyeekle where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme işlemi tamamlandı");
                daset.Tables["uyeekle"].Clear();
                uyelistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
           
        }
        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from uyeekle", baglanti);
            adtr.Fill(daset, "uyeekle");
            dataGridView1.DataSource = daset.Tables["uyeekle"];
            baglanti.Close();
        }

        private void uyesil_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnuyeguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uyeekle set ad=@ad,soyad=@soyad,telefon=@telefon,eposta=@eposta,adres=@adres where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc",txtuyeno.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            daset.Tables["uyeekle"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
