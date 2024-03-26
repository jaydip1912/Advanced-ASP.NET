<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoreProcedure.aspx.cs" Inherits="Question_03.StoreProcedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            height: 459px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

      <br />
    <table class="auto-style1" align="center">
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Label ID="lblTitle" runat="server" Font-Size="X-Large" ForeColor="#CC0000" Text="Complete CRUD Operation in ASP.NET C# With SQL Using Store Procedure"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPID" runat="server" Text="Product ID" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtId" runat="server" Width="200px" Font-Size="Medium"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Button ID="btnSearch" runat="server" Font-Size="Large" Text="Search" Width="100px" OnClick="btnSearch_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblIName" runat="server" Text="Item Name" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="200px" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSpecification" runat="server" Text="Specification" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSpecification" runat="server" Width="200px" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUnit" runat="server" Text="Unit" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddUnit" runat="server" Width="200px" Font-Size="Medium">
                    <asp:ListItem>PCS</asp:ListItem>
                    <asp:ListItem>Kg</asp:ListItem>
                    <asp:ListItem>LTR</asp:ListItem>
                    <asp:ListItem>Iteam</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblStatus" runat="server" Text="Status" Font-Size="Large"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:RadioButtonList ID="rbStatus" runat="server" RepeatDirection="Horizontal" Width="200px" Font-Size="Medium">
                    <asp:ListItem>Running</asp:ListItem>
                    <asp:ListItem>UnUsed</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCDate" runat="server" Text="Creation Date" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCDate" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style4">
                <asp:Button ID="btnInsert" runat="server" Text="Insert" Font-Size="Large" OnClick="btnInsert_Click" Width="100px" />
&nbsp;&nbsp;
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Font-Size="Large" Width="100px" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" Font-Size="Large" Width="100px" OnClick="btnDelete_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnLoad" runat="server" Text="Load" Font-Size="Large" Width="100px" OnClick="btnLoad_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnReset" runat="server" Text="Reset" Font-Size="Large" OnClick="btnReset_Click" Width="100px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style4">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    </div>
</form>
    <p>
        &nbsp;</p>
</body>
</html>
