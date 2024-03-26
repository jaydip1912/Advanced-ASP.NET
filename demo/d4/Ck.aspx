<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ck.aspx.cs" Inherits="d4.Ck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bodytag" runat="server">
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET Statemanagement Technique Cookies
            </h1>

            <br />
            Select Background Color :
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>Pink</asp:ListItem>
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
