using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Student
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student where email ='"+TextBox1.Text+"' and pwd = '"+TextBox2.Text+"' ", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Session["email"] = TextBox1.Text;
                Response.Redirect("Studentdashboard.aspx");
            }
            else
            {
                Label4.Visible = true;
            }
        }
    }
}