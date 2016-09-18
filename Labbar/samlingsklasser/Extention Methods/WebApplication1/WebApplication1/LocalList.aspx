<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocalList.aspx.cs" Inherits="WebApplication1.LocalList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="content/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="scripts/jquery-3.1.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/LS%20scripts/JS_LocalList.js"></script>
    <title></title>
</head>
<body>
    <div class="container" style="width: 100%; height: 400px;"></div>
    <form id="form3" runat="server">
        <div class="container-fluid" style="background-color: orangered; width: 100%; height: 150px; padding: 40px 5px 30px 20px">
            <div class="col-md-3"></div>
            <div class="col-md-2 ">
                <p class="info" style="font-size: 18px">
                    Press "Restore" and the values from the previous page will be loaded from LocalStorage.
                </p>
            </div>
            <div class="col-md-2">
                <div>
                    <table>
                          <tr>
                              <th>Product</th>
                              <th>Amount</th>                             
                          </tr>                       
                        <tr>                        
                            <th>Umbrella: </th>
                            <td>
                                <asp:DropDownList ID="UmbrellaDD" runat="server" style="margin-left:15px;">
                                    <asp:ListItem Value="0"></asp:ListItem>
                                    <asp:ListItem Value="1"></asp:ListItem>
                                    <asp:ListItem Value="2"></asp:ListItem>
                                    <asp:ListItem Value="3"></asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem Value="5"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <th>Alligators: </th>
                            <td>
                                <asp:DropDownList ID="AlligatorDD" runat="server" style="margin-left:15px;">
                                    <asp:ListItem Value="0"></asp:ListItem>
                                    <asp:ListItem Value="1"></asp:ListItem>
                                    <asp:ListItem Value="2"></asp:ListItem>
                                    <asp:ListItem Value="3"></asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem Value="5"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <th>Electrical fly-swatter: </th>
                            <td>
                                <asp:DropDownList ID="FlySwatterDD" runat="server" style="margin-left:15px;">
                                    <asp:ListItem Value="0"></asp:ListItem>
                                    <asp:ListItem Value="1"></asp:ListItem>
                                    <asp:ListItem Value="2"></asp:ListItem>
                                    <asp:ListItem Value="3"></asp:ListItem>
                                    <asp:ListItem Value="4"></asp:ListItem>
                                    <asp:ListItem Value="5"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                <div style="margin-top: 5px;">
                </div>
            </div>
            <div class="col-md-2"></div>
            <div class="col-md-3"></div>
        </div>

        <div class="container">
            <div class="col-md-4 "></div>

            <div class="col-md-4 ">
                <asp:Button ID="Save" Text="Save Basket" runat="server" />
                 <asp:Button ID="Receipt" Text="To Receipt" runat="server" OnClick="Receipt_Click" />
            </div>
            <div class="col-md-4 "></div>
        </div>


    </form>
    
</body>
    
</html>
