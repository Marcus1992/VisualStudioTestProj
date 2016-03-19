<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="passwordRecovery.aspx.cs" Inherits="WebClient.passwordRecovery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="labelEmail" runat="server" Font-Bold="true" Font-Size="Large" Text="Enter your email"></asp:Label>
        <br />
        <br />
        &nbsp;
        <asp:TextBox ID="TextBoxEmail" runat="server" Width="176px"></asp:TextBox>
        <br />
        &nbsp;
        <asp:Button ID="ButtonSend" runat="server" Text="Send" Height="22px" Width="75px" OnClick="ButtonSend_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonBack" runat="server" Text="Back" Height="22px" Width="75px" OnClick="ButtonBack_Click" />
        <br />
        <asp:Label ID="LabelFeedBack" runat="server" Text="label" Visible="false"></asp:Label>

    </div>
    </form>
</body>
</html>
