<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Localization.aspx.cs" Inherits="Question_05.Localization" Culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label5" runat="server" Text="This is simple TEXT" meta:resourcekey="Label5Resource1"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Your Name" meta:resourcekey="Label1Resource1" ></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" meta:resourcekey="TextBox1Resource1" ></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Father Name" meta:resourcekey="Label2Resource1" ></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" meta:resourcekey="TextBox2Resource1" ></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Contact" meta:resourcekey="Label3Resource1" ></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" meta:resourcekey="TextBox3Resource1" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Languge" meta:resourcekey="Label4Resource1" ></asp:Label>
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" meta:resourcekey="DropDownList1Resource1" >
                <asp:ListItem Value="en" meta:resourcekey="ListItemResource1">English</asp:ListItem>
                <asp:ListItem Value="ur" meta:resourcekey="ListItemResource2" >Urdu</asp:ListItem>
            </asp:DropDownList>
            <br />

        </div>
    </form>
</body>
</html>
