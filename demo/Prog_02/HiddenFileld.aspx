<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFileld.aspx.cs" Inherits="Prog_02.HiddenFileld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET - State Management Techniques -Hidden Field
            </h1>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="5" />
            <asp:Label ID="lbltxt" runat="server" Text="" visible="false"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Show Hidden Field" OnClick="Button1_Click" />
               
        </div>
    </form>
</body>
</html>
