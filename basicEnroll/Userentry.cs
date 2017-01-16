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

namespace basicEnroll
{
    public partial class Userentry : Form
    {
        public Userentry()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string con = string.Empty;
            con = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sql = @"INSERT INTO [id]([id],[Username],[Password])VALUES(@id,@Username,@Password)";

            using (SqlConnection sqlcon = new SqlConnection (con))
            {
                sqlcon.Open();
                using (SqlCommand com = new SqlCommand(sql,sqlcon))
                {
                    com.Parameters.AddWithValue("@Username",txtuser.Text);
                    com.Parameters.AddWithValue("@Password", txtpass.Text);
                    com.Parameters.AddWithValue("@id", txtid.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Process Complete");
                    txtuser.Text = "";
                    txtpass.Text = "";
                }
            }
        }

        private void Userentry_Load(object sender, EventArgs e)
        {

        }
    }
}
