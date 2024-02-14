<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="State_Management.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td>Enter User Name</td>
                    <td>
                        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Password </td>
                    <td>
                        <asp:TextBox ID="txtpass" TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" style="height: 29px" /></td>
                    
                </tr>
                
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label> </td>
                    
                </tr>
                
            </table>

        </div>
    </form>
</body>
</html>
