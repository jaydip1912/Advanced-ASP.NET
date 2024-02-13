<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="State_Management.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body id="bodytag" runat="server">
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET - Client Side State Management - COOKIES
            </h1>

            <table>
                <tr>
                    <td>Select Background Color : 
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="red">Red</asp:ListItem>
                            <asp:ListItem Value="blue">Blue</asp:ListItem>
                            <asp:ListItem Value="green">Green</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
