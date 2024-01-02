<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentInfo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <div style="font-size:x-large" align="center">
     Student Info Manage Form
     <br />
     

     

     <table class="w-100">
         <tr>
             <td style="width: 329px">
                 <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="Student Id"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="TextBox1" runat="server" CssClass="offset-sm-0" Font-Size="Medium" Width="206px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 329px">
                 <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Student Name"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server" CssClass="offset-sm-0" Font-Size="Medium" Width="206px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 329px">
                 <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Address"></asp:Label>
             </td>
             <td>
                 <asp:DropDownList ID="DropDownList1" runat="server" CssClass="offset-sm-0" Width="195px">
                     <asp:ListItem>usa</asp:ListItem>
                     <asp:ListItem>canada</asp:ListItem>
                     <asp:ListItem>uk</asp:ListItem>
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td style="width: 329px">
                 <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="Age"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server" CssClass="offset-sm-0" Font-Size="Medium" Width="206px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 329px">
                 <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Contact"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="TextBox4" runat="server" CssClass="offset-sm-0" Font-Size="Medium" Width="206px"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td style="width: 329px">&nbsp;</td>
             <td>&nbsp;</td>
         </tr>
          <tr>
     <td style="width: 329px">&nbsp;</td>
     <td>
         <asp:Button ID="Button1" runat="server" BackColor="#6600CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Insert" Width="114px" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" BackColor="#6600CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Update" Width="114px" OnClick="Button2_Click" />
         <asp:Button ID="Button3" runat="server" BackColor="#6600CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Delete" Width="114px" OnClick="Button3_Click" />
         <asp:Button ID="Button4" runat="server" BackColor="#6600CC" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Search" Width="114px" OnClick="Button4_Click" />
              </td>
 </tr>
         <tr>
    <td style="width: 329px">&nbsp;</td>
    <td>&nbsp;</td>
</tr>
    <tr>
    <td style="width: 329px">&nbsp;</td>
    <td>
       
        </td>
</tr>
     </table>
 <asp:GridView ID="GridView1" runat="server" Width="1044px">
 </asp:GridView>
     

     

 </div>
</asp:Content>
