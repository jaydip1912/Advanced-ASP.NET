<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="Question_04.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bodytag" runat="server">
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET - Client Side State Management- COOKIES
            </h1>
            <asp:Label ID="lblText" runat="server"  Text="Select Background Color : "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Pink</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
