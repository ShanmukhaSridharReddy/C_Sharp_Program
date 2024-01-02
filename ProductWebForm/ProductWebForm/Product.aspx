<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ProductWebForm.Product" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 243px;
            
        }
        table
        {
            display :flex;
            flex-direction :row;
            justify-content:center;
            align-content:center;
            
        }
    </style>
    <script type="text/javascript">
    function showCalendar() {
        var calendar = document.getElementById('<%= Calendar1.ClientID %>');
        calendar.style.display = (calendar.style.display === 'none' || calendar.style.display === '') ? 'block' : 'none';
        return false;
    }
    </script>

</head>
<body style="background-color:antiquewhite">
    <form id="form1" runat="server">
        
            

        <table class="auto-style1" style="background-color: #C0C0C0">
            <tr>
                <td colspan="2" aria-busy="False" aria-sort="none"> PRODUCT MANAGEMENT</td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    &nbsp;</td>
                <td aria-busy="False" aria-sort="none">
                    &nbsp;</td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    <asp:Label ID="Label2" runat="server" Text="ItemName"></asp:Label>
                </td>
                <td aria-busy="False" aria-sort="none">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    <asp:Label ID="Label3" runat="server" Text="Specification"></asp:Label>
                </td>
                <td aria-busy="False" aria-sort="none">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    <asp:Label ID="Label4" runat="server" Text="Unit"></asp:Label>
                </td>
                <td aria-busy="False" aria-sort="none">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>pcs</asp:ListItem>
                        <asp:ListItem>kg</asp:ListItem>
                        <asp:ListItem>Dozen</asp:ListItem>
                        <asp:ListItem>Litre</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
                </td>
                <td aria-busy="False" aria-sort="none">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Running</asp:ListItem>
                        <asp:ListItem>Unused</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">
                    <asp:Label ID="Label6" runat="server" Text="Creation Date"></asp:Label>
                </td>
                <td aria-busy="False" aria-sort="none">
                    <asp:Calendar ID="Calendar1" runat="server" Visible ="false" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="Calendar1_SelectionChanged">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:Button ID="ShowCalendarButton" runat="server" Text="Show Calendar"  OnClick="ShowCalendarButton_Click" />
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">&nbsp;</td>
                <td aria-busy="False" aria-sort="none">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Height="33px" Text="Submit" BackColor="#996600" ForeColor="#00FF99" OnClick="Button1_Click" Font-Bold ="true" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="Button5" runat="server" Text="Reset" OnClick="Button5_Click" Font-Bold ="true" BackColor="#993333" Height="33px" />
                    
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        
                </td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">&nbsp;</td>
                <td aria-busy="False" aria-sort="none">
                    &nbsp;</td>
            </tr>
            <tr>
                <td aria-busy="False" aria-sort="none">&nbsp;</td>
                <td aria-busy="False" aria-sort="none">
                    &nbsp;</td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" Width="831px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AutoGenerateColumns="False" DataKeyNames="ProductID" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" PageSize="15" HorizontalAlign="Center" >
            <Columns>
                <asp:BoundField DataField="ProductId" HeaderText="ProductId" ReadOnly="True" />
                <asp:BoundField DataField="ItemName" HeaderText="ItemName" />
                <asp:BoundField DataField="Specification" HeaderText="Specification" />
                <asp:BoundField DataField="Unit" HeaderText="Unit" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" />
                <asp:CommandField AccessibleHeaderText="Action" >
                <ControlStyle BackColor="#99FFCC" Font-Bold="True" Font-Italic="True" ForeColor="Black" />
                </asp:CommandField>
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True">
                <ControlStyle BackColor="Red" ForeColor="White" />
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#FFCC00" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </form>
</body>
</html>
