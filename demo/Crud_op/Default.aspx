<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crud_op._Default" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <p>
        <br />
        <table align="center" style="border: medium solid #FF0000; width: 417px" >
            <tr>
                <td style="width: 150px">Customer Name</td>
                <td style="width: 189px">
                    <asp:TextBox ID="txtcustomer" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">Address</td>
                <td style="width: 189px">
                    <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">Mobile No</td>
                <td style="width: 189px">
                    <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">Email Id</td>
                <td style="width: 189px">
                    <asp:TextBox ID="txtemail" runat="server" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">&nbsp;</td>
                <td style="width: 189px">
                    <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
                    <asp:Button ID="btnreset" runat="server"  Text="Reset" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    
       
</asp:Content>

