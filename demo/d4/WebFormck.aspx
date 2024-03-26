<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormck.aspx.cs" Inherits="d4.WebFormck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bodytag" runat="server">
    <form id="form1" runat="server">
        <div>
            <h1>
                Asp.net Statementmanagement technique - Cookies
            </h1>
            Select background color : <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Pink</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Yellow</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
