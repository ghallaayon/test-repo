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
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void lblfirst_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void cbxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conditon for  SECTIONS
            if (cbxCourse.Text =="BSCS")
            {
                cbxSection.Items.Clear();
                cbxSection.Items.Add("CS101A");
                cbxSection.Items.Add("CS102A");
                cbxSection.Items.Add("CS103A");

            }
         
           if(cbxCourse.Text=="BSIT")
            {
                cbxSection.Items.Clear();
                cbxSection.Items.Add("IT101A");
                cbxSection.Items.Add("IT102A");
                cbxSection.Items.Add("IT103A");
            }
        }

        private void cbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kung tutuusin pede sa database ung SOURCE Nateng Ng subject and prof kasu basic lang namn tau eto lang
            //basic lang to ahh to 
            //CS101A------------------------------------------------------------------
            if (cbxSection.Text == "CS101A")
            {

                txtsub1.Text = "";
                txtsub2.Text = "";
                txtsub3.Text = "";
                txtsub4.Text = "";
                txtsub5.Text = "";
                txtdes1.Text = " ";
                txtdes2.Text = " ";
                txtdes3.Text = " ";
                txtdes4.Text = "";
                txtdes5.Text = "";
                //change niu nlang ung proff name ibang section kac to
                txtprof1.Text = "";
                txtprof2.Text = "";
                txtprof3.Text = "";
                txtprof4.Text = "";
                txtprof5.Text = "";

                txtsub1.Text = "MATHPLUS";
                txtsub2.Text = "COMPRO";
                txtsub3.Text = "COMART";
                txtsub4.Text = "ALGEB";
                txtsub5.Text = "PE";
                txtdes1.Text = "MATHEMATICAL PLUS";
                txtdes2.Text = "COMPUTER PROGRAMMING";
                txtdes3.Text = "COMMUNICATION ART";
                txtdes4.Text = "ALGEBRA";
                txtdes5.Text = "PHYSICAL EDUCATION";
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";
                //CS102A------------------------------------------------------------------
            }
            if (cbxSection.Text == "CS102A")
            {

                txtsub1.Text = "";
                txtsub2.Text = "";
                txtsub3.Text = "";
                txtsub4.Text = "";
                txtsub5.Text = "";
                txtdes1.Text = " ";
                txtdes2.Text = " ";
                txtdes3.Text = " ";
                txtdes4.Text = "";
                txtdes5.Text = "";
                //change niu nlang ung proff name ibang section kac to
                txtprof1.Text = "";
                txtprof2.Text = "";
                txtprof3.Text = "";
                txtprof4.Text = "";
                txtprof5.Text = "";

                txtsub1.Text = "MATHPLUS";
                txtsub2.Text = "COMPRO";
                txtsub3.Text = "COMART";
                txtsub4.Text = "ALGEB";
                txtsub5.Text = "PE";
                txtdes1.Text = "MATHEMATICAL PLUS";
                txtdes2.Text = "COMPUTER PROGRAMMING";
                txtdes3.Text = "COMMUNICATION ART";
                txtdes4.Text = "ALGEBRA";
                txtdes5.Text = "PHYSICAL EDUCATION";
                //change niu nlang ung proff name ibang section kac to
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";
                //CS103A--------------------------------------------------------------
            }
            if (cbxSection.Text =="CS103A")
            {
                txtsub1.Text = "";
                txtsub2.Text = "";
                txtsub3.Text = "";
                txtsub4.Text = "";
                txtsub5.Text = "";
                txtdes1.Text = " ";
                txtdes2.Text = " ";
                txtdes3.Text = " ";
                txtdes4.Text = "";
                txtdes5.Text = "";
                //change niu nlang ung proff name ibang section kac to
                txtprof1.Text = "";
                txtprof2.Text = "";
                txtprof3.Text = "";
                txtprof4.Text = "";
                txtprof5.Text = "";

                txtsub1.Text = "MATHPLUS";
                txtsub2.Text = "COMPRO";
                txtsub3.Text = "COMART";
                txtsub4.Text = "ALGEB";
                txtsub5.Text = "PE";
                txtdes1.Text = "MATHEMATICAL PLUS";
                txtdes2.Text = "COMPUTER PROGRAMMING";
                txtdes3.Text = "COMMUNICATION ART";
                txtdes4.Text = "ALGEBRA";
                txtdes5.Text = "PHYSICAL EDUCATION";
                //change niu nlang ung proff name ibang section kac to
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";

            }
            if (cbxSection.Text=="IT101A")
            {
 //-------------------//IT101A--------------------------------------------------------------
                txtsub1.Text = "MATHPLUS";
                txtsub2.Text = "COMPRO1";
                txtsub3.Text = "COMART1";
                txtsub4.Text = "ALGEBRA";
                txtsub5.Text = "PE1";
                txtdes1.Text = "MATHEMATICAL PLUS";
                txtdes2.Text = "COMPUTER PROGRAMMING 1";
                txtdes3.Text = "COMMUNICATION ART 1";
                txtdes4.Text = "ALGEBRA";
                txtdes5.Text = "PHYSICAL EDUCATION 1";
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";
            }
            if (cbxSection.Text == "IT201A")
            {
                txtsub1.Text = "COMART2";
                txtsub2.Text = "COMPRO2";
                txtsub3.Text = "DATSTRUC";
                txtsub4.Text = "DISTRUC";
                txtsub5.Text = "PE2";
                txtdes1.Text = "COMMUNIATION ARTS 2";
                txtdes2.Text = "COMPUTER PROGRAMMING 2";
                txtdes3.Text = "DATA STRUCTURES";
                txtdes4.Text = "DISCRETE STRUCTURES";
                txtdes5.Text = "PHYSICAL EDUCATION 2";
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";
            }
            if (cbxSection.Text == "IT301A")
            {
                txtsub1.Text = "COMART3";
                txtsub2.Text = "COMPRO3";
                txtsub3.Text = "PHYSICS1";
                txtsub4.Text = "PROSTAT";
                txtsub5.Text = "PE3";
                txtdes1.Text = "COMMUNIATION ARTS 3";
                txtdes2.Text = "COMPUTER PROGRAMMING 3";
                txtdes3.Text = "PHYSICS 1";
                txtdes4.Text = "PROBABILITY AND STRUCTURES";
                txtdes5.Text = "PHYSICAL EDUCATION 3";
                txtprof1.Text = "DICK R. HARD";
                txtprof2.Text = "LALA S. GOOD";
                txtprof3.Text = "BYE O. CREAM";
                txtprof4.Text = "THEO JAMES R. ORETA";
                txtprof5.Text = "DWIGHT S. HOWARD";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtinstall.Enabled = false;
            txtcash.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtcash.Enabled = false;
            txtinstall.Enabled = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            double installment,downpayment,first,second,third,fourth,total,totals,a,b;
//condition for installment-------------------------------------------------------------------------------
            installment = Convert.ToDouble(txtinstall.Text);
            
            //first = Convert.ToDouble(lbl1st.Text);
            //second = Convert.ToDouble(lbl2nd.Text);
            //third = Convert.ToDouble(lbl3rd.Text);
            //fourth = Convert.ToDouble(lbl4th.Text);
            if (installment <3000)
            {
                MessageBox.Show("Atleast 3000 downpayment");
            }
            else
            {
                lbldown.Text = txtinstall.Text;
                downpayment = Convert.ToDouble(lbldown.Text);
                a = 27000;
                b = a - downpayment;
                totals = b / 4;
                lbl1st.Text = totals.ToString();
                lbl2nd.Text = totals.ToString();
                lbl3rd.Text = totals.ToString();
                lbl4th.Text = totals.ToString();

            }
         
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string sql = @"Data Source=AILEENPC\SQLEXPRESS;Initial Catalog=Enrollment;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string con = @"INSERT INTO [Enrolles]
                                   ([FirstName]
                                    ,[MiddleInitial]
                                      ,[LastName]
                                      ,[Course]
                                      ,[Section]
                                      ,[Address]
                                      ,[Gender]
                                      ,[contact],[id])
                                 VALUES
                                       (@FirstName
                                       ,@MiddleInitial
                                       ,@LastName 
                                       ,@Course
                                       ,@Section
                                       ,@Address
                                       ,@Gender
                                       ,@contact,@id)";
            using (SqlConnection sqlcon = new SqlConnection(sql))
            {
                sqlcon.Open();
                using (SqlCommand com = new SqlCommand(con,sqlcon))
                {
                    if (txtmi.Text==string.Empty && txtlast.Text==string.Empty &&txtname.Text=="")
                    {
                        MessageBox.Show("plss fill the Data");
                    }
                    else
                    {
                        var param = com.Parameters;
                        param.AddWithValue("@FirstName", txtname.Text);
                        param.AddWithValue("@MiddleInitial", txtmi.Text);
                        param.AddWithValue("@LastName", txtlast.Text);
                        param.AddWithValue("@Course", cbxCourse.Text);
                        param.AddWithValue("@Section", cbxSection.Text);
                        param.AddWithValue("@Address", txtadd.Text);
                        param.AddWithValue("@Gender", cbxgender.Text);
                        param.AddWithValue("@contact", txtcon.Text);
                        param.AddWithValue("@id", txtid.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Process Complete");
                        txtid.Text = "";
                        txtname.Text = "";
                        txtmi.Clear();
                        cbxCourse.Text = "";
                        cbxSection.Text = "";
                        txtadd.Clear();
                        cbxgender.Text = "";
                        txtcon.Text = "";

                    }

                }
            }
        }

        private void txtinstall_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
