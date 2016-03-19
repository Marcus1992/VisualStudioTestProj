<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebClient.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 213px">
        &nbsp;&nbsp;<table><tr><td><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="UserID" OnRowDeleted="GridView1_RowDeleted1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
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
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:TestDBConnectionString %>" SelectCommand="SELECT * FROM [tbl_Users]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [tbl_Users] WHERE [UserID] = @original_UserID AND [Username] = @original_Username AND [Password] = @original_Password AND [Email] = @original_Email AND [Country] = @original_Country AND [Phone] = @original_Phone AND [UserType] = @original_UserType" InsertCommand="INSERT INTO [tbl_Users] ([Username], [Password], [Email], [Country], [Phone], [UserType]) VALUES (@Username, @Password, @Email, @Country, @Phone, @UserType)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [tbl_Users] SET [Username] = @Username, [Password] = @Password, [Email] = @Email, [Country] = @Country, [Phone] = @Phone, [UserType] = @UserType WHERE [UserID] = @original_UserID AND [Username] = @original_Username AND [Password] = @original_Password AND [Email] = @original_Email AND [Country] = @original_Country AND [Phone] = @original_Phone AND [UserType] = @original_UserType">
                <DeleteParameters>
                    <asp:Parameter Name="original_UserID" Type="Int32" />
                    <asp:Parameter Name="original_Username" Type="String" />
                    <asp:Parameter Name="original_Password" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                    <asp:Parameter Name="original_Country" Type="String" />
                    <asp:Parameter Name="original_Phone" Type="Int32" />
                    <asp:Parameter Name="original_UserType" Type="Boolean" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="Int32" />
                    <asp:Parameter Name="UserType" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Username" Type="String" />
                    <asp:Parameter Name="Password" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="Phone" Type="Int32" />
                    <asp:Parameter Name="UserType" Type="Boolean" />
                    <asp:Parameter Name="original_UserID" Type="Int32" />
                    <asp:Parameter Name="original_Username" Type="String" />
                    <asp:Parameter Name="original_Password" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                    <asp:Parameter Name="original_Country" Type="String" />
                    <asp:Parameter Name="original_Phone" Type="Int32" />
                    <asp:Parameter Name="original_UserType" Type="Boolean" />
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
                    <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestDBConnectionString %>" SelectCommand="SELECT * FROM [tbl_Message]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [tbl_Message] WHERE [MessageID] = @original_MessageID AND [Headline] = @original_Headline AND [Message] = @original_Message AND [MessageCreated] = @original_MessageCreated AND (([UserID] = @original_UserID) OR ([UserID] IS NULL AND @original_UserID IS NULL))" InsertCommand="INSERT INTO [tbl_Message] ([Headline], [Message], [MessageCreated], [UserID]) VALUES (@Headline, @Message, @MessageCreated, @UserID)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [tbl_Message] SET [Headline] = @Headline, [Message] = @Message, [MessageCreated] = @MessageCreated, [UserID] = @UserID WHERE [MessageID] = @original_MessageID AND [Headline] = @original_Headline AND [Message] = @original_Message AND [MessageCreated] = @original_MessageCreated AND (([UserID] = @original_UserID) OR ([UserID] IS NULL AND @original_UserID IS NULL))">
                    <DeleteParameters>
                        <asp:Parameter Name="original_MessageID" Type="Int32" />
                        <asp:Parameter Name="original_Headline" Type="String" />
                        <asp:Parameter Name="original_Message" Type="String" />
                        <asp:Parameter Name="original_MessageCreated" Type="DateTime" />
                        <asp:Parameter Name="original_UserID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Headline" Type="String" />
                        <asp:Parameter Name="Message" Type="String" />
                        <asp:Parameter Name="MessageCreated" Type="DateTime" />
                        <asp:Parameter Name="UserID" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Headline" Type="String" />
                        <asp:Parameter Name="Message" Type="String" />
                        <asp:Parameter Name="MessageCreated" Type="DateTime" />
                        <asp:Parameter Name="UserID" Type="Int32" />
                        <asp:Parameter Name="original_MessageID" Type="Int32" />
                        <asp:Parameter Name="original_Headline" Type="String" />
                        <asp:Parameter Name="original_Message" Type="String" />
                        <asp:Parameter Name="original_MessageCreated" Type="DateTime" />
                        <asp:Parameter Name="original_UserID" Type="Int32" />
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
