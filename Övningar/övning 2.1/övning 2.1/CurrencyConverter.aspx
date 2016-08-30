<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="övning_2._1.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    
          <asp:Panel ID="ThePanel" runat="server" BackColor="#FFFFCC" Height="505px" HorizontalAlign="Left" ScrollBars="Both" Width="24%">
        <asp:Label ID="convertFrom_label" runat="server" Text="From"></asp:Label>
    <asp:dropdownlist runat="server" ID="DropDownList_From">
        <asp:ListItem Value="1">Dollars</asp:ListItem>
         <asp:ListItem Value="0,12">kronor</asp:ListItem>
            <asp:ListItem Value="1,31">Pounds</asp:ListItem>
            <asp:ListItem Value="1,12">Euro</asp:ListItem>
           
        </asp:dropdownlist><br />
        <asp:Label ID="convertTo_label" runat="server" Text="To"></asp:Label>
        <asp:DropDownList ID="DropDownList_To" runat="server">
            <asp:ListItem Value="1">Dollars</asp:ListItem>
           
             <asp:ListItem Value="8,5">kronor</asp:ListItem>
            <asp:ListItem Value="0.77">Pounds</asp:ListItem>
            <asp:ListItem Value="0,9">Euro</asp:ListItem>
        </asp:DropDownList>
 
        <p>
            <asp:Label ID="Amount_Label" runat="server" Text="Amount"></asp:Label>
            <asp:TextBox ID="Amount_TextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Converted: "></asp:Label>
        <asp:TextBox ID="Converted_textbox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Convert_Button" runat="server" Text="Convert" OnClick="Convert_button_Click"/>
        </p>
        </asp:Panel>
    </form>
</body>
</html>
