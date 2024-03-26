<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
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
            var name = document.getElementById("txtName").value;
            var city = document.getElementById("txtCity").value;

            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET","insert.aspx?nm="+ name + "&ct=" + city+"&opr=insert", false);
            xmlhttp.send(null);

            var name = document.getElementById("txtName").value="";
            var city = document.getElementById("txtCity").value ="";
            alert('Recored Inserted');
        }
        function display()
        {
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?opr=display" , false);
            xmlhttp.send(null);

            document.getElementById("d1").innerHTML = xmlhttp.responseText;
        }
        function delete1() {
            var name = document.getElementById("txtName").value;
            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?nm="+name +"&opr=delete1", false);
            xmlhttp.send(null);

            var name = document.getElementById("txtName").value = "";
            alert('DELETE');
            display();
        }
        function update1() {
            var oldname = document.getElementById("txtName").value;
            var newname = document.getElementById("txtCity").value;


            var xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "insert.aspx?oldname=" +oldname + "&newname=" + newname+ "&opr=update1", false);
            xmlhttp.send(null);

            document.getElementById("txtName").value = "";
            document.getElementById("txtName").value = "";


            alert('Update');
            display();
        }

    </script>
</body>
</html>
