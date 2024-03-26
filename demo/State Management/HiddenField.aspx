<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="State_Management.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ASP.NET - Statemanagment Technique - Hidden Field</h1>
            <asp:HiddenField ID="HiddenField1" runat="server"  Value="7"/>
            <asp:Label ID="lbltxt" runat="server" Text="Label" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Show HiddenField Value" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
