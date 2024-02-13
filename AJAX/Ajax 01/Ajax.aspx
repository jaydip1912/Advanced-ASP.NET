<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="Ajax_Prog01.Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>Name</td>
                    <td><input type="text" id ="txtName" /></td>
                </tr> 
                <tr>
                    <td>City</td>
                    <td><input type="text" id ="txtCity" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td><input type="button" id="btn1" value="Insert" onclick="insert();" /></td>
                </tr>
            </table>

        </div>
    </form>
    <script type="text/javascript">
        function insert() {
            var name = document.getElementById("txtName").value;
            var city = document.getElementById("txtCity").value;

            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET","insert.aspx?nm="+ name + "&ct=" + city, false);
            xmlhttp.send(null);

            var name = document.getElementById("txtName").value="";
            var city = document.getElementById("txtCity").value ="";
            alert('Recored Inserted');
        }
    </script>
</body>
</html>
