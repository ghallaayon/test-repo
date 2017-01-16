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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Userentry user = new Userentry();
            user.ShowDialog();
        }

        private void Users_Load(object sender, EventArgs e)
        {
           
            string sql = string.Empty;
            string con = string.Empty;
            ListViewItem lv;
            try
            {
                sql = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con = @"SELECT [id], [Username],[Login],[logout]FROM [id]";
                using (SqlConnection sqlcon = new SqlConnection(sql))
                {
                    sqlcon.Open();
                    string[] sub_Item = new string[3];
                    using (SqlCommand com = new SqlCommand(con, sqlcon))
                    {
                        using (SqlDataReader read = com.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            if (read.HasRows)
                            {
                                while (read.Read())
                                {
                                    sub_Item[0] = read["Username"].ToString();
                                    sub_Item[1] = read["Login"].ToString();
                                    sub_Item[2] = read["logout"].ToString();
                                    lv = listView1.Items.Add(new ListViewItem(sub_Item));
                                    lv.Tag = read["id"].ToString();
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
