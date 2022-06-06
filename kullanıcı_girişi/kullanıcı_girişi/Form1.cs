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

namespace kullanıcı_girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

       

        private void btn_giris_yap_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TG2J65J; database = library ;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where username = '" + txt_username.Text + "' and pass = '"+txt_password.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

           if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı ya da Şifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txt_password_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_username.Text == "Kullanıcı Adı")
            {
                txt_username.Clear();
            }
        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_password.Text == "Şifre")
            {
                txt_password.Clear();
                txt_password.PasswordChar ='*';
            }
        }

        private void pictureBoxYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
