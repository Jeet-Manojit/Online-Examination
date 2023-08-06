<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDashboard.aspx.cs" Inherits="Online_Examination.Student.StudentDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 723px;
            margin-bottom: 18px;
            width: 1574px;
        }
    </style>
</head>
<body style="margin:0px">
    <form id="form1" runat="server" aria-orientation="vertical">
        <header style="height: 49px; font-size: x-large; font-weight: bold; color: #FFFFFF; background-color: #33CCFF;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Welcome Student&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" BackColor="Red" BorderStyle="None" Font-Bold="True" Height="36px" Text="Logout" Width="98px" PostBackUrl="~/Student/StudentLogin.aspx" />
        </header>
        <div style="height: 675px; width: 1383px;">
            <div style="height: 538px; width: 993px; margin-left: 200px" >

                <br />

                <br />
                <asp:Panel ID="Panel1" runat="server" Height="33px" GroupingText="Student Dashboard" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" BackColor="#009999" Font-Bold="True" style="margin-bottom: 0px">
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="158px" ImageUrl="~/logo.jpeg" Width="231px" />
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Take Test" Height="55px" Width="341px" BackColor="#33CC33" BorderStyle="None" Font-Bold="True" PostBackUrl="~/Student/Exam.aspx" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="View Result" Height="55px" Width="337px" BorderStyle="None" Font-Bold="True" OnClick="Button3_Click" PostBackUrl="~/Student/Result.aspx" />
                    <br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Update Profile" Height="55px" Width="336px" BackColor="Silver" BorderStyle="None" Font-Bold="True" OnClick="Button4_Click" />
                    <br />
                    <br />
                    <br />
                </asp:Panel>

            </div>
        </div>
    </form>
</body>
</html>
