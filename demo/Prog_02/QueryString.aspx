<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="Prog_02.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
          
        }
    </style>
</head>
<body>
    <div>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>Enter First Name</td>
            <td><asp:TextBox runat="server" ID="txt1"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Enter Last Name</td>
            <td><asp:TextBox ID="txt2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /></td>
        </tr>
       <tr>
           <tb>

           </tb>
       </tr>
    </table>
    
        
    </form>
    </div>
</body>
</html>
