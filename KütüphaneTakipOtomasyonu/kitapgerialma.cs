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
    public partial class kitapgerialma : Form
    {
        public kitapgerialma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=KütüphaneTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanetkitaplar", baglanti);
            adtr.Fill(daset, "emanetkitaplar");
            dataGridView1.DataSource = daset.Tables["emanetkitaplar"];
            baglanti.Close();
        }
        private void kitapgerialma_Load(object sender, EventArgs e)
        {
            emanetlistele();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnteslimal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
