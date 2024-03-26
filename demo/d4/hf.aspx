<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hf.aspx.cs" Inherits="d4.hf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET Statemanagement Technique - Hiddenfield
            </h1>
            <asp:HiddenField ID="HiddenField1" Value="15" runat="server" />
            <br />
            <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Show Hiddenfield Value" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
