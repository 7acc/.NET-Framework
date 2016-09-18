<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restore.aspx.cs" Inherits="WebApplication1.Restore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link href="content/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="scripts/jquery-3.1.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/LS scripts/JS.js"></script>
    <title></title>
</head>
<body>
    
     <div class="container" style="width: 100%; height: 400px;"></div>
    <form id="form2" runat="server">
        <div class="container-fluid" style="background-color: orangered; width: 100%; height: 150px; padding: 40px 5px 30px 20px">
            <div class="col-md-3"></div>
            <div class="col-md-2 ">
                <p class="info" style="font-size: 18px">
                    Press "Restore" and the values from the previous page will be loaded from LocalStorage.
                </p>
            </div>
            <div class="col-md-2">
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Name" Style="position: absolute; font-size: 15px; font-weight: bolder;"></asp:Label>
                    <asp:TextBox ID="T1" name="T1" runat="server" Style="margin-left: 110px;"></asp:TextBox><br />
                </div>
                <div style="margin-top: 5px;">
                    <asp:Label ID="Label2" runat="server" Text="Number" Style="position: absolute; font-size: 15px; font-weight: bold;"></asp:Label>
                    <asp:TextBox ID="T2" runat="server" Style="margin-left: 110px;"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-2"></div>
            <div class="col-md-3"></div>
        </div>

            <div class="container">
                <div class="col-md-4 "></div>
                
                <div class="col-md-4 ">
                    <asp:Button ID="Button2" Text="restore" runat="server" OnClick="Button2_Click" />
                </div>
                <div class="col-md-4 "></div>
            </div>


        </form>
    
    
</body>
</html>
