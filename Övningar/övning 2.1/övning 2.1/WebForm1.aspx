﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="övning_2._1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div id="MainThing">
                <asp:Button ID="Change_Button" runat="server" Text="Change" OnClick="Change_Button_Click"                    />
            <asp:Panel ID="ThePanel" runat="server" BackColor="#FFFFCC" Height="505px" HorizontalAlign="Left" ScrollBars="Both" Width="24%">
                <asp:Label ID="Label1" runat="server" Text="" Font-Bold="True" Font-Names="Segoe UI Black"></asp:Label>
                <br />
                <asp:TextBox ID="TheBox" runat="server" Width="375px"></asp:TextBox>
                <asp:Button ID="Knappen" runat="server" OnClick="Knappen_Click_Stenmark_It" Text="Stenmark It" />
                <asp:TextBox ID="TextBox2" runat="server" Width="379px" Height="352px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>

                <br />

            </asp:Panel>
            <!-- /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// -->

               <asp:Panel ID="Panel2" runat="server" BackColor="#FFFFCC" Height="505px" HorizontalAlign="Left" ScrollBars="Both" Width="24%" Visible="false">
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
        <asp:Label ID="Label2" runat="server" Text="Converted: "></asp:Label>
        <asp:TextBox ID="Converted_textbox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Convert_Button" runat="server" Text="Convert" OnClick="Convert_button_Click"/>
        </p>
        </asp:Panel>


        </div>
    </form>
</body>
</html>
