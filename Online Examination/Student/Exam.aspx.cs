using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Examination.Student
{
    public partial class Exam : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Trusted_Connection = Yes; database = OnlineExam; server = DESKTOP-GF3SCF6");

        protected void Page_Load(object sender, EventArgs e)
        {
            string ET = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from question where qno = "+1+"", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                
                Label4.Text = rdr["ques"].ToString();
                RadioButtonList1.Items[0].Text = rdr[2].ToString();
                RadioButtonList1.Items[1].Text = rdr[3].ToString();
                RadioButtonList1.Items[2].Text = rdr[4].ToString();
                RadioButtonList1.Items[3].Text = rdr[5].ToString();
                Session["ques1"] = rdr["ques"].ToString() ;
                Session["ans1"] = rdr["correct"].ToString() ;
                Session["key1"] = rdr["keyword"].ToString() ;
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from question where qno = " + 2 + "", con);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {

                Label6.Text = rdr["ques"].ToString();
                RadioButtonList2.Items[0].Text = rdr[2].ToString();
                RadioButtonList2.Items[1].Text = rdr[3].ToString();
                RadioButtonList2.Items[2].Text = rdr[4].ToString();
                RadioButtonList2.Items[3].Text = rdr[5].ToString();
                Session["ques2"] = rdr["ques"].ToString();
                Session["ans2"] = rdr["correct"].ToString();
                Session["key2"] = rdr["keyword"].ToString();
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from question where qno = " + 3 + "", con);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {

                Label8.Text = rdr["ques"].ToString();
                RadioButtonList3.Items[0].Text = rdr[2].ToString();
                RadioButtonList3.Items[1].Text = rdr[3].ToString();
                RadioButtonList3.Items[2].Text = rdr[4].ToString();
                RadioButtonList3.Items[3].Text = rdr[5].ToString();
                Session["ques3"] = rdr["ques"].ToString();
                Session["ans3"] = rdr["correct"].ToString();
                Session["key3"] = rdr["keyword"].ToString();
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from question where qno = " + 4 + "", con);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {

                Label10.Text = rdr["ques"].ToString();
                RadioButtonList4.Items[0].Text = rdr[2].ToString();
                RadioButtonList4.Items[1].Text = rdr[3].ToString();
                RadioButtonList4.Items[2].Text = rdr[4].ToString();
                RadioButtonList4.Items[3].Text = rdr[5].ToString();
                Session["ques4"] = rdr["ques"].ToString();
                Session["ans4"] = rdr["correct"].ToString();
                Session["key4"] = rdr["keyword"].ToString();
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("select * from question where qno = " + 5 + "", con);
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {

                Label12.Text = rdr["ques"].ToString();
                RadioButtonList5.Items[0].Text = rdr[2].ToString();
                RadioButtonList5.Items[1].Text = rdr[3].ToString();
                RadioButtonList5.Items[2].Text = rdr[4].ToString();
                RadioButtonList5.Items[3].Text = rdr[5].ToString();
                Session["ques5"] = rdr["ques"].ToString();
                Session["ans5"] = rdr["correct"].ToString();
                Session["key5"] = rdr["keyword"].ToString();
                ET = "5";
            }
            con.Close();

            if (!IsPostBack)
            {
                int examTime = 1;
                int.TryParse(ET, out examTime);
                Session["Timer"] = DateTime.Now.AddMinutes(examTime).ToString();
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string a1 = Session["ans1"].ToString();
            string a2 = Session["ans2"].ToString();
            string a3 = Session["ans3"].ToString();
            string a4 = Session["ans4"].ToString();
            string a5 = Session["ans5"].ToString();

            int marks = 0;

            if (RadioButtonList1.SelectedIndex > -1)
            {
                if(RadioButtonList1.SelectedItem.Text == a1)
                {
                    marks++;
                }
            }
            if(RadioButtonList2.SelectedIndex > -1)
            {
                if(RadioButtonList2.SelectedItem.Text == a2)
                {
                    marks++;
                }
            }
            if (RadioButtonList3.SelectedIndex > -1)
            {
                if(RadioButtonList3.SelectedItem.Text == a3)
                {
                    marks++;
                }
            }
            if(RadioButtonList4.SelectedIndex > -1)
            {
                if(RadioButtonList4.SelectedItem.Text == a4)
                {
                    marks++;
                }
            }
            if(RadioButtonList5.SelectedIndex > -1)
            {
                if (RadioButtonList5.SelectedItem.Text == a5)
                {
                    marks++;
                }
            }
            Session["total_marks"] = marks;

            Server.Transfer("StudentDashboard.aspx",true);
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(DateTime.Now, DateTime.Parse(Session["Timer"].ToString())) < 0)
            {
                Label13.Text = "Time Left : " + ((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString() + " Minute " + (((Int32)DateTime.Parse(Session["Timer"].ToString()).Subtract(DateTime.Now).TotalSeconds) % 60).ToString() + " Seconds";
            }
            else
            {
                //Server.Transfer("LoginPage.aspx", true);

                Label13.Text = "Time Out!";


            }
        }
    }
}