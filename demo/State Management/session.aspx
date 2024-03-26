<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="State_Management.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center">
                ASP.NET - Server side state management -Session Page
            </h1>
            <asp:Label ID="lbnname" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
