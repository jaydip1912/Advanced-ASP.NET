<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StoreProcedure._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>


        <table class="w-100">
            <tr>
                <td colspan="2" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: x-large; font-weight: bold; color: #000000">Complete CRUD Operation in Asp.Net C# With SQL Using Stored Procedure</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblproduct" runat="server" Text="Prodect ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" BackColor="#FFFF99" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Item Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Specification"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 24px">
                    <asp:Label ID="Label3" runat="server" Text="Unit"></asp:Label>
                </td>
                <td style="height: 24px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" Width="200px">
                        <asp:ListItem>PCS</asp:ListItem>
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>LTR</asp:ListItem>
                        <asp:ListItem>ITEMS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Stutas"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Unused</asp:ListItem>
                        <asp:ListItem>Running</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Creation Date</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                </td>
                <td style="height: 41px; text-align: justify !important;" colspan="2" class="text-center">
                    <asp:Button ID="btninsert" runat="server" Font-Size="Medium" ForeColor="White" Text="Insert" OnClick="btninsert_Click" Width="90px" BackColor="#009933" />
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" OnClick="Button1_Click" Text="Update" />
&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BackColor="Red" ForeColor="White" OnClick="Button2_Click" Text="Delete" OnClientClick="return confirm ('Are you sure ? ')" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" BackColor="Black" ForeColor="White" OnClick="Button4_Click" Text="Load" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="619px">
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




</asp:Content>
