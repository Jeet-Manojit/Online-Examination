using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Admin
{
    public partial class Questions : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into question values(" + TextBox7.Text + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','"+TextBox8.Text+"')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Label10.Visible = true;
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox7.Text = " ";
            TextBox8.Text = " ";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox7.Text = " ";
            TextBox8.Text = " ";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update question set ques = '"+TextBox1.Text+"' where qno = "+TextBox7.Text+"",con);
            cmd.ExecuteNonQuery();
            //option1 = '" + TextBox2.Text + "  option2 = '" + TextBox3.Text + "' option3 = '" + TextBox4.Text + "' option4 = '" + TextBox5.Text + "' correct = '" + TextBox6.Text + "' keyword ='"+TextBox8.Text+"'
            con.Close();
            Label10.Visible = true;
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox7.Text = " ";
            TextBox8.Text = " ";
        }
    }
}