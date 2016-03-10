<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebClient.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 213px">
        &nbsp;&nbsp;<table><tr><td><asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="UserID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:CheckBoxField DataField="UserType" HeaderText="UserType" SortExpression="UserType" />
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
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ExamDBConnectionString %>" DeleteCommand="DELETE FROM [tbl_Users] WHERE [UserID] = @UserID" InsertCommand="INSERT INTO [tbl_Users] ([Username], [Password], [Country], [Phone], [UserType]) VALUES (@Username, @Password, @Country, @Phone, @UserType)" SelectCommand="SELECT * FROM [tbl_Users]" UpdateCommand="UPDATE [tbl_Users] SET [Username] = @Username, [Password] = @Password, [Country] = @Country, [Phone] = @Phone, [UserType] = @UserType WHERE [UserID] = @UserID">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="Int32" />
                    <asp:Parameter Name="UserType" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="Int32" />
                    <asp:Parameter Name="UserType" Type="Boolean" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            </td><td><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="MessageID">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="MessageID" HeaderText="MessageID" InsertVisible="False" ReadOnly="True" SortExpression="MessageID" />
                    <asp:BoundField DataField="Headline" HeaderText="Headline" SortExpression="Headline" />
                    <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
                    <asp:BoundField DataField="MessageCreated" HeaderText="MessageCreated" SortExpression="MessageCreated" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ExamDBConnectionString %>" DeleteCommand="DELETE FROM [tbl_Message] WHERE [MessageID] = @MessageID" InsertCommand="INSERT INTO [tbl_Message] ([Headline], [Message], [MessageCreated]) VALUES (@Headline, @Message, @MessageCreated)" SelectCommand="SELECT * FROM [tbl_Message]" UpdateCommand="UPDATE [tbl_Message] SET [Headline] = @Headline, [Message] = @Message, [MessageCreated] = @MessageCreated WHERE [MessageID] = @MessageID">
                    <DeleteParameters>
                        <asp:Parameter Name="MessageID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Headline" Type="String" />
                        <asp:Parameter Name="Message" Type="String" />
                        <asp:Parameter Name="MessageCreated" Type="DateTime" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Headline" Type="String" />
                        <asp:Parameter Name="Message" Type="String" />
                        <asp:Parameter Name="MessageCreated" Type="DateTime" />
                        <asp:Parameter Name="MessageID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td></tr>
            </table>
    </div>
        <p>
            &nbsp;</p>
    <p>
            <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Back" />
        </p>
    </form>
    </body>
</html>
