<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Online_Examination.Admin.WebForm3" Trace="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 755px;
        }
    </style>
</head>
<body style="height: 769px; width: 1448px; margin-right: 107px; margin:0px; background-image:url('new.jpg')">
    <form id="form1" runat="server">
       <div style="margin-right:auto; margin-left:auto;text-align:center;background-color:#33CCFF;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="44px" Text="Admin Dashboard" Width="314px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button1" runat="server" BackColor="#FF5050" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Italic="False" ForeColor="White" Height="39px" Text="Logout" Width="111px" style="border-radius:10px" OnClick="Button1_Click"/>
           </div>
               <br />
&nbsp; <asp:Panel ID="Panel2" runat="server" BackColor="#33CC33" BorderColor="#666666" BorderStyle="Solid" ForeColor="#333333" GroupingText="Admin Details" Height="28px" Width="340px" Direction="LeftToRight" HorizontalAlign="Center" BorderWidth="1px" Font-Bold="True" Font-Size="Medium">
                   <br />
                   Name :&nbsp;
                   <asp:TextBox ID="TextBox6" runat="server" Height="31px" OnTextChanged="TextBox1_TextChanged" Width="238px" BackColor="#F0F0F0" BorderStyle="None" ReadOnly="True" style="border-radius:2px"></asp:TextBox>
                   <br />
                   <br />
                   Email :&nbsp;
                   <asp:TextBox ID="TextBox7" runat="server" Height="32px" Width="237px" BackColor="#F0F0F0" BorderStyle="None" ReadOnly="True" style="border-radius:2px"></asp:TextBox>
                   <br />
&nbsp;<br /> ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:TextBox ID="TextBox8" runat="server" Height="33px" Width="239px" BackColor="#F0F0F0" BorderStyle="None" ReadOnly="True" style="border-radius:2px"></asp:TextBox>
                   <br />
                   <br />
                   Profile :
                   <asp:TextBox ID="TextBox9" runat="server" Height="32px" Width="238px" BackColor="#F0F0F0" BorderStyle="None" ReadOnly="True" style="border-radius:2px"></asp:TextBox>
                   <br />
                   <br />
                   Phone :
                   <asp:TextBox ID="TextBox10" runat="server" Height="33px" Width="233px" BackColor="#F0F0F0" BorderStyle="None" ReadOnly="True" style="border-radius:2px" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
                   <br />
                   &nbsp;</asp:Panel>

        <div style="height: 403px; margin-left:500px; margin-top: -50px; float: inherit; width: 579px; display: block;">
               <br />
               <asp:Panel ID="Panel1" runat="server" BackColor="#66CCFF" BorderColor="#666666" BorderStyle="Solid" ForeColor="Black" GroupingText="Student updation" Height="28px" Width="571px" Direction="LeftToRight" HorizontalAlign="Center" BorderWidth="1px" Font-Bold="True" Font-Size="Medium">
                   <br />
                   <asp:Button ID="Button2" runat="server" Height="40px" Text="Add Student" Width="233px" style="border-radius:10px" BackColor="#33CCFF" BorderColor="#CCCCCC" BorderStyle="None" Font-Bold="True" Font-Size="Medium" PostBackUrl="~/Student/AddStudent.aspx"/>
                   <br />
                   <br />
&nbsp;<asp:Button ID="Button3" runat="server" Height="41px" Text="Student Details" Width="232px" style="border-radius:10px" BackColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" PostBackUrl="~/Student/ViewStudent.aspx" />
                   &nbsp;<br />
                   <br />
                   <asp:Button ID="Button4" runat="server" Height="41px" Text="Question &amp; Answer" Width="232px" style="border-radius:10px" BackColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" PostBackUrl="~/Admin/Questions.aspx" />
                   <br />
                   <br />
                   <asp:Button ID="Button5" runat="server" Height="41px" Text="Question Details" Width="232px" style="border-radius:10px" BackColor="#33CCFF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" PostBackUrl="~/Admin/QuestionTable.aspx" />
                   <br />
                   <br />
                   <br />
               </asp:Panel>
            </div>
    </form>
</body>
</html>
