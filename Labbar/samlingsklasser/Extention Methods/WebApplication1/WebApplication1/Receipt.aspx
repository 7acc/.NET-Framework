<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="WebApplication1.Receipt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     
    <link href="content/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="scripts/jquery-3.1.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>  
     <script src="scripts/LS%20scripts/Receipt.js"></script>
  

  
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container" style="background-color:red; height:200px; width:100%;">
            <div class="col-md-5"></div>
            <div class="col-md-2">
                <asp:Table id="products" runat="server">

                </asp:Table>
            </div>
            <div class="col-md-5"></div>
        </div>
         <asp:HiddenField ID="HF" runat="server"/>
        <asp:Button ID="Load" runat="server" Text="Button" OnClick="LoadBasket" Visible="false" />
       
    </form>
   
</body>
 
</html>
