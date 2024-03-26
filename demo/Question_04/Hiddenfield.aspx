<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hiddenfield.aspx.cs" Inherits="Question_04.Hiddenfield" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET State Management Technique - HIDDENFIELD
            </h1>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="7" />
            <asp:Label ID="lblText" runat="server" Text="Label" Visible="false"></asp:Label>
            <br />
            <br />

            <asp:Button ID="btnShow" runat="server" Text="Show HiddenField Value" OnClick="btnShow_Click" Width="199px" />
        </div>
    </form>
</body>
</html>
