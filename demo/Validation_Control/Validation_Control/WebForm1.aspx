<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validation_Control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 64px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <strong>Register Form</strong></div>
        <p>
            Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Enter Name *" ForeColor="#FF3300" ViewStateMode="Enabled"></asp:RequiredFieldValidator>
        </p>
        <p>
            Password:&nbsp;&nbsp; <asp:TextBox ID="password" runat="server" TextMode="Password">password
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="Enter Password *" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            CNF Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cpassword" runat="server" OnTextChanged="TextBox3_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cpassword" ErrorMessage="Re-Enter Password *" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="cpassword" ErrorMessage="Password Not Match *" ForeColor="Blue"></asp:CompareValidator>
        </p>
        <p>
            Email:&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="email" ErrorMessage="Enter Email *" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="Valid Email *" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            Mobile No:&nbsp;
            <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="mobile" ErrorMessage="Enter MobileNo *" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mobile" ErrorMessage="10 digite*" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
        </p>
        <p>
            Age:&nbsp;&nbsp;
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="age" ErrorMessage="Enter Age *" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" ErrorMessage="Only 18+ *" ForeColor="Blue" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn" runat="server" BackColor="Red" Text="Submit" />
        </p>
    </form>
</body>
</html>
