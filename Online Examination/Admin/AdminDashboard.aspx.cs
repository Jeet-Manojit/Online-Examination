using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from admin where email = '" + Session["email"] +"'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                TextBox6.Text = rdr[1].ToString();
                TextBox7.Text = rdr[2].ToString();
                TextBox8.Text = rdr[0].ToString();
                TextBox9.Text = rdr[3].ToString();
                TextBox10.Text = rdr[4].ToString();
            }
            con.Close();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}