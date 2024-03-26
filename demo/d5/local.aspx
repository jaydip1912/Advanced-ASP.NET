<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="local.aspx.cs" Inherits="d5.local" UICulture="auto" Culture="auto" meta:resourcekey="PageResource1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" meta:resourcekey="Label2Resource1" Text="This is simLabelple text "></asp:Label>

            <br />
            <br />
            <asp:Label ID="Label3" runat="server" meta:resourcekey="Label3Resource1" Text="Enter your name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1" ></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" meta:resourcekey="Label4Resource1" Text="Enter your father name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" meta:resourcekey="TextBox2Resource1" ></asp:TextBox>

            <br />
            <asp:Label ID="Label5" runat="server" meta:resourcekey="Label5Resource1" Text="Contect"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" meta:resourcekey="TextBox3Resource1" ></asp:TextBox>
            <br />
            <br />
            Select language
            <asp:DropDownList ID="DropDownList1" runat="server" meta:resourcekey="DropDownList1Resource1" AutoPostBack="true" >
                <asp:ListItem Value="en" meta:resourcekey="ListItemResource1" >English</asp:ListItem>
                <asp:ListItem Value="gu" meta:resourcekey="ListItemResource2">Gujrati</asp:ListItem>
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
