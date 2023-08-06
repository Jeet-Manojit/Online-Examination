using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admin where email ='"+TextBox1.Text+"' and pwd = '"+TextBox2.Text+"'", con);
            SqlDataReader srd = cmd.ExecuteReader();
            if (srd.Read())
            {
                Session["email"] = TextBox1.Text;
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                Label5.Visible = true;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Coming soon !!!");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}