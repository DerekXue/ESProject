<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="VideoGallary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style6 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
      <table style="font-family:Arial">
    <tr>
        <td colspan="2" style="width:800px; height:80px; background-color:#ccffcc; 
            text-align:center">
            <h1>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Welcome to Car Rental"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="X-Large" NavigateUrl="~/Login.aspx">To Login</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" Font-Size="X-Large" NavigateUrl="~/Registration.aspx">To Registration</asp:HyperLink>
            </h1>
        </td>
    </tr>
    <tr>
        <td style="height:500px; background-color:#ccffff; width:1800px; vertical-align:top">
                
            <div>
                <asp:Image ID="Image3" runat="server" Height="193px" ImageUrl="~/Photos/bmw-i8-350x200_sixt.png" Width="325px" />
                <asp:Image ID="Image4" runat="server" Height="186px" ImageUrl="~/Photos/download (1).jpg" Width="286px" />
                <asp:Image ID="Image5" runat="server" Height="185px" ImageUrl="~/Photos/46c51a619f4782987646c360114ac1d1.png" Width="290px" />
                <asp:Image ID="Image6" runat="server" Height="181px" ImageUrl="~/Photos/new-audi-a7-sportback-5dr-front-three-quarter.jpg" Width="333px" />
                <asp:Image ID="Image7" runat="server" Height="198px" ImageUrl="~/Photos/iris.png" Width="400px" />
                <asp:Image ID="Image8" runat="server" Height="166px" ImageUrl="~/Photos/USC90HOC011A021001.jpg" Width="349px" />
            <br />
            <br />
        </div>
        <div class="auto-style6">
       
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" SelectCommand="SELECT * FROM [tblVideos]"></asp:SqlDataSource>

        </td>
    </tr>
    <tr>
        <td colspan="2" style="background-color:#ccffcc; text-align:center">
            &nbsp;</td>
    </tr>
</table>


    </form>
</body>
</html>



       