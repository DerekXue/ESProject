<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            height: 230px;
            background-color: #3366FF;
        }
        .auto-style4 {
            width: 222px;
            height: 40px;
            text-align: center;
        }
        .auto-style5 {
            width: 222px;
            height: 168px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DataList ID="DataList1" runat="server" DataKeyField="Id" DataSourceID="SqlDataSource1" Height="339px" RepeatColumns="4" RepeatDirection="Horizontal" Width="525px">
            <ItemTemplate>
                <table border="1" class="auto-style1">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("VideoPath") %>'></asp:Literal>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
       
    </form>
</body>
</html>
