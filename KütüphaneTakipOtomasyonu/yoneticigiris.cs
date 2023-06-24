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
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {
            InitializeComponent();
        }

        private void kİTAPKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void üYEEKLEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uyeekle uyeekle = new uyeekle();
            uyeekle.Show();

        }

        private void üYESİLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uyesil uyesil = new uyesil();
            uyesil.Show();

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapekle kitapekle = new kitapekle();
            kitapekle.Show();
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapsil kitapsil = new kitapsil();
            kitapsil.Show();
        }

        private void kitapVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emanetkitapverme emanetkitapverme = new emanetkitapverme();
            emanetkitapverme.Show();
        }

        private void yoneticigiris_Load(object sender, EventArgs e)
        {

        }

        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emanetkitaplistele emanetkitaplistele = new emanetkitaplistele();
            emanetkitaplistele.Show();
        }

        private void kitapGeriAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapgerialma kitapgerialma = new kitapgerialma();
            kitapgerialma.Show();
        }
    }
}
