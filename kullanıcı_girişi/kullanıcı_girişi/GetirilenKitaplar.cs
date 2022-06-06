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
    public partial class GetirilenKitaplar : Form
    {
        public GetirilenKitaplar()
        {
            InitializeComponent();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-TG2J65J, database = library, integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //cmd.CommandText = "select * from IRBook where  "


        }
    }
}
