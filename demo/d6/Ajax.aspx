<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="d6.Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="insert" />
                <asp:Button ID="Button2" runat="server" Text="update" />
                <asp:Button ID="Button3" runat="server" Text="display" />
                <asp:Button ID="Button4" runat="server" Text="Delete" />
            </td>
            
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
        <div id="d1">
        </div>
    </form>
    <script type="text/javascript">
        function insert() {
            var name = document.getElementById("TextBox1").value;
            var city = document.getElementById("TextBox").value;

            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("get", "insert.aspx?nm=" + name + "&ct=" + city + "&opr=insert", false);
            xmlhttp.send(null);

            var name = document.getElementById("TextBox1").value="";
            var city = document.getElementById("TextBox").value = "";
            alert('insert');

        }

    </script>
</body>
</html>
