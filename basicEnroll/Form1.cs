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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string con = string.Empty;
            con = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sql = @"SELECT *FROM [id] WHERE Username = @Username and Password = @Password";
            using (SqlConnection sqlcon = new SqlConnection( con))
            {
                sqlcon.Open();
                using (SqlCommand com = new SqlCommand(sql,sqlcon))
                {
                    com.Parameters.AddWithValue("@Username",txtuser.Text);
                    com.Parameters.AddWithValue("Password", txtpass.Text);
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        if (read.HasRows)
                        {
                            read.Read();
                            this.Hide();
                            main main = new main();
                            main.UserName = read["Username"].ToString();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
