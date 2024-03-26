<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Test_Demo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>

    <div>
        <h2>
            Register form
        </h2>
        <table class="w-100">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Address :"></asp:Label>
                    <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
                </td>
                <td style="margin-left: 120px">
                    <asp:Label ID="Label3" runat="server" Text="Mobile :"></asp:Label>
                    <asp:TextBox ID="txtMob" runat="server" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email :"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Subject :"></asp:Label>
                    <asp:TextBox ID="txtSub" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 24px"></td>
                <td style="height: 24px"></td>
                <td style="height: 24px"></td>
                <td style="height: 24px"></td>
                <td style="height: 24px"></td>
            </tr>
            <tr>
                <td class="text-center" colspan="5" style="height: 42px">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" BorderColor="#666699" Height="40px" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" Width="100px" BorderColor="#6600CC" Height="39px" OnClick="btnReset_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>

            

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowUpdating="GridView1_RowUpdating" Width="914px" DataKeyNames="id" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" />
                    <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                </Columns>
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

            

        </div>
        

    </div>
    </main>

</asp:Content>
