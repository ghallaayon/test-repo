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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {

            this.Hide();
            Enrollment en = new Enrollment();
            en.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void Records_Load(object sender, EventArgs e)
        {
            string sql = string.Empty;
            string con = string.Empty;
            ListViewItem lv;
            try
            {
                sql = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con = @"SELECT [id], [FirstName] +' '+[MiddleInitial]+'. '+[LastName] as FullName
                          ,[Course]
                          ,[Section]
                          ,[Address]
                          ,[Gender]
                          ,[contact]
                      FROM [Enrolles]";
                using (SqlConnection sqlcon = new SqlConnection(sql))
                {
                    sqlcon.Open();
                    string[] sub_Item = new string[6];
                    using (SqlCommand com = new SqlCommand(con,sqlcon))
                    {
                        using (SqlDataReader read = com.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            if (read.HasRows)
                            {
                                while (read.Read())
                                {
                                    sub_Item[0] = read["FullName"].ToString();
                                    sub_Item[1] = read["Course"].ToString();
                                    sub_Item[2] = read["Section"].ToString();
                                    sub_Item[3] = read["Address"].ToString();
                                    sub_Item[4] = read["Gender"].ToString();
                                    sub_Item[5] = read["Contact"].ToString();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
