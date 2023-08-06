using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Student
{
    public partial class Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }
                
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student where email = '" + Session["email"] + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    TextBox1.Text = rdr["rollno"].ToString();
                    TextBox2.Text = rdr["firstname"].ToString();
                    TextBox3.Text = rdr["lastname"].ToString();
                    TextBox4.Text = rdr["branch"].ToString();
                    TextBox5.Text = rdr["phone"].ToString();
                    TextBox6.Text = rdr["email"].ToString();
                    TextBox7.Text = rdr["pwd"].ToString();
                }
                con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update student set firstname= '"+TextBox2.Text+"' where rollno = "+TextBox1.Text+" ", con);
            //', lastname = '"+TextBox3.Text+"', branch = '"+TextBox4.Text+"', phone = "+TextBox5.Text+", email = '"+TextBox6.Text+"', pwd = '"+TextBox7.Text+"' 
            int i = cmd.ExecuteNonQuery();
            Label18.Visible = true;
            con.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}