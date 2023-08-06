using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Student
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student values("+TextBox1.Text+",'"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"',"+TextBox5.Text+",'"+TextBox6.Text+"','"+TextBox7.Text+"')", con);
            int i = cmd.ExecuteNonQuery();
            Label16.Visible = true;

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
        }
    }
}