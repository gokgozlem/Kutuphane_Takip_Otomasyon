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
    public partial class emanetkitaplistele : Form
    {
        public emanetkitaplistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void emanetkitaplistele_Load(object sender, EventArgs e)
        {
            emanetlistele();
            comboBox1.SelectedIndex = 0;
        }
        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetkitaplar"].Clear();
            if(comboBox1.SelectedIndex==0)
            {
                emanetlistele();
            }
            else if(comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar where '"+DateTime.Now.ToShortDateString()+"'>iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar where '" + DateTime.Now.ToShortDateString() + "'<= iadetarihi", baglanti);
                adtr.Fill(daset, "emanetkitaplar");
                dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
                baglanti.Close();
            }
        }
    }
}
