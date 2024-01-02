<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="greatingMessage.aspx.cs" Inherits="GreetingWebForm.greatingMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your name :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" BackColor="#FFCC99" Font-Bold="True" ForeColor="#FF99FF" OnClick="Button1_Click" Text="Submit" />
        <p>
            &nbsp;</p>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="Black"></asp:Label>
    </form>
</body>
</html>
