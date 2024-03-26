<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="Prog_02.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    
        .auto-style1 {
            text-align: center;
        }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                ASP.NET - Client Side State Management -View State
            </h1>
            
            <table >
                <tr>
                    <td>Enter your Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Display" runat="server" Text="Display" OnClick="Display_Click" />
                    </td>
                </tr>
                <tr>
                    <td> Data in View State</td>
                    <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td> Number of PostBack</td>
                    <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                </tr>
            </table>
            
            <br />
            
        </div>
    </form>
</body>
</html>
