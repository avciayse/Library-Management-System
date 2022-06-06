using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_girişi
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void btn_onceki_islem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void kİtaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void yeniKitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle abs = new KitapEkle();
            abs.Show();
        }

        private void kitabıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitaplarıGörüntüle vb = new KitaplarıGörüntüle();
            vb.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void öğrencileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÖğrencileriGörüntüle vsi = new ÖğrencileriGörüntüle();
            vsi.Show();
        }

        private void alınanKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlınanKitaplar ib = new AlınanKitaplar();
            ib.Show();
        }

        private void getirilenKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetirilenKitaplar rb = new GetirilenKitaplar();
            rb.Show();

        }
    }
}
