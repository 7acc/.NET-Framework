﻿<script runat="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
</script>
<head runat="server">
    <title></title>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <br />
    <form id="form1" runat="server">



         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:Panel ID="ThePanel" runat="server" BackColor="#FFFFCC" Height="505px" HorizontalAlign="Left" ScrollBars="Both" Width="36%">
            <asp:Label ID="Label1" runat="server" Text="Jan Stenmark Generator 2.0"></asp:Label>
            <br />
            <asp:TextBox ID="TheBox" runat="server" Width="375px"></asp:TextBox>
            <asp:Button ID="Knappen" runat="server" OnClick="Stenmark_It"  Text="Stenmark It" />
           <asp:TextBox ID="TextBox2" runat="server" Width="375px"></asp:TextBox>
           
            <br />
        
        </asp:Panel>
        


    </form>
    <div draggable="false">
    </div>


</body>
</html>
