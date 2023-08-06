using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Student
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
            }

            SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where email = '" + Session["email"] + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                TextBox1.Text = rdr["rollno"].ToString();
                TextBox2.Text = rdr["firstname"].ToString();
                TextBox3.Text = rdr["lastname"].ToString();
                TextBox4.Text = rdr["branch"].ToString();
                TextBox5.Text = "5";
                TextBox6.Text = "5";
                if (Session["total_marks"] == null)
                {
                    TextBox7.Text = "";
                }
                else
                {
                    TextBox7.Text = Session["total_marks"].ToString();
                }
            }
            con.Close();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}