<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="Question_06.Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td><input type="text"  id="txtName"/></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><input type="text"  id="txtCity"/></td>
                </tr>
                <tr>
                    <td>
                        <input type="button" id="btn1" value="Insert" onclick="insert();" />
                        <input type="button" id="btn2" value="Display" onclick="display();" />
                        <input type="button" id="btn3" value="Delete" onclick="delete1();" />
                        <input type="button" id="btn4" value="Update" onclick="update1();" />
                    </td>
                </tr>
            </table>
            <div id="d1">

            </div>
        </div>
    </form>
    <script type="text/javascript">
        function insert() {

            var Name = document.getElementById("txtName").value;
            var City = document.getElementById("txtCity").value;
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET","Insert.aspx?nm=" + Name + "&ct=" + City + "&opr=insert", false);
            xmlhttp.send(null);

            var name = document.getElementById("txtName").value="";
            var city = document.getElementById("txtCity").value ="";
            alert('Record Inserted');
        }
    </script>
</body>
</html>
