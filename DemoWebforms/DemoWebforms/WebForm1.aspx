<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" 

<a href="Default.aspx">Default.aspx</a>Inherits="DemoWebforms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function printToConsole() {
            console.log("Hello, World!");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button3" runat="server" Text="Console" OnClientClick="printToConsole(); return false" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        </div>
        <div>
            <h1> USER REGISTRATION </h1>
            
            <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
            <br />
            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
            <br />
            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br /><br />
            <asp:RadioButtonList ID="Gender" runat="server">
                <asp:ListItem Text="Male" Value ="M" />
                <asp:ListItem Text="Female" Value ="F" />

            </asp:RadioButtonList>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </form>
    <asp:Label ID="Label4" runat="server"></asp:Label>
</body>
</html>
