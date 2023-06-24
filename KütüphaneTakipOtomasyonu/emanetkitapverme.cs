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
    public partial class emanetkitapverme : Form
    {
        public emanetkitapverme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazar,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazar,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtbarkodno.Text);
            komut.Parameters.AddWithValue("@kitapadi",txtkitapadi.Text);
            komut.Parameters.AddWithValue("@yazar",txtyazar.Text);
            komut.Parameters.AddWithValue("@yayinevi",txtyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("@kitapsayisi",int.Parse(txtkitapsayisi.Text));
            komut.Parameters.AddWithValue("@teslimtarihi",dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi",dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitap(lar) sepete eklendi","ekleme işlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            //*foreach(Control item in groupBox2.Controls)
           // {
               // if(item is TextBox)
              //  {
                  //  if (item != txtkitapsayisi) 
                   // {
                      //  item.Text = "";
                    //}
                //}
            //}

        }

        private void emanetkitapverme_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uyeekle where tc like'"+txttc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
            if(txttc.Text=="")
            {
                foreach(Control item in groupBox1.Controls)
                {
                    item.Text = "";
                }
            }
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like'"+txtbarkodno.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtyazar.Text = read["yazar"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();


            }
            baglanti.Close();
            foreach(Control item in groupBox2.Controls)
            {
                if(item is TextBox)
                {
                    if(item!=txtkitapsayisi)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno'"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi tamamlandı","silme işlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
        }

        private void txttc_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uyeekle where tc like'"+txttc.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtad.Text = read["ad"].ToString();
                txtsoyad.Text = read["soyad"].ToString();
                txttelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
            if(txttc.Text=="")
            {
                foreach(Control item in groupBox1.Controls)
                {
                    item.Text = "";
                }
            }
        }

        private void txtbarkodno_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like'" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtkitapadi.Text = read["kitapadi"].ToString();
                txtyazar.Text = read["yazar"].ToString();
                txtyayinevi.Text = read["yayinevi"].ToString();
                txtsayfasayisi.Text = read["sayfasayisi"].ToString();


            }
            baglanti.Close();
            
        }
    }
}
