<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="övning_2._1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="MainThing">

        <asp:Panel ID="ThePanel" runat="server" BackColor="#FFFFCC" Height="505px" HorizontalAlign="Left" ScrollBars="Both" Width="24%">
            <asp:Label ID="Label1" runat="server" Text="" Font-Bold="True" Font-Names="Segoe UI Black"></asp:Label>
            <br />
            <asp:TextBox ID="TheBox" runat="server" Width="375px"></asp:TextBox>
            <asp:Button ID="Knappen" runat="server" OnClick="Knappen_Click_Stenmark_It"  Text="Stenmark It" />
             <asp:TextBox ID="TextBox2" runat="server" Width="379px" Height="352px" TextMode="MultiLine" ReadOnly="True" ></asp:TextBox>
          
           
            <br />
        
        </asp:Panel>
        
    
    </div>
    </form>
</body>
</html>
