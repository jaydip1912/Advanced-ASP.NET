<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="d4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Asp.Net statemamagement technique Hidden Field
            </h1>

            <asp:HiddenField ID="HiddenField1" Value="7" runat="server" />
            <br />
            <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Show HiddenField Value" Width="195px" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
