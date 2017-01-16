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
    public partial class main : Form
    {
        public string UserName { get; set; }
        public main()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void enrollesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Records rec = new Records();
            rec.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string con = string.Empty;
            con = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sql = @"SELECT *FROM[id]WHERE Username = @Username ";
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                sqlcon.Open();
                using (SqlCommand com = new SqlCommand(sql,sqlcon))
                {
                    com.Parameters.AddWithValue("Username",UserName);
                    using (SqlDataReader read = com.ExecuteReader())
                    {
                        if (read.HasRows)
                        {
                            read.Read();
                            tsUser.Text = read["Username"].ToString();
                        }
                    }
                }
            }
             sql = "UPDATE [id] set [Login]= GETDATE() WHERE [Username] = @Username";
            using (SqlConnection conx = new SqlConnection(con))
            {
                conx.Open();
                using (SqlCommand comx = new SqlCommand(sql,conx))
                {
                    comx.Parameters.AddWithValue("@Username",UserName);
                    comx.ExecuteNonQuery();
                }
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = string.Empty;
            string con = string.Empty;
            con = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sql = "UPDATE [id] set [logout]= GETDATE() WHERE [Username] = @Username";

            using (SqlConnection conx = new SqlConnection(con))
            {
                conx.Open();
                using (SqlCommand comx = new SqlCommand(sql, conx))
                {
                    comx.Parameters.AddWithValue("@Username", UserName);
                    comx.ExecuteNonQuery();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basic Enrollment System" + Environment.NewLine +
                "Computer Programming 3 Program Project" + Environment.NewLine +
                "Group Members: " + Environment.NewLine +
                "1. Danica Boque" + Environment.NewLine +
                "2. Alexandria Deocariza" + Environment.NewLine +
                "3. Emmanuel Domiquil" + Environment.NewLine +
                "4. Carlo John Estologa" + Environment.NewLine +
                "5. Richbong Lopez" + Environment.NewLine +
                "6. Jonas Mari Malabag" + Environment.NewLine +
                "7. Ruby Rae Olaya");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.ShowDialog();
        }

        private void btnEnrollees_Click(object sender, EventArgs e)
        {
            Records rec = new Records();
            rec.ShowDialog();
        }
    }
}
