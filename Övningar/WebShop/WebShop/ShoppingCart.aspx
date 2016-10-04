<%@ Page Language="C#" MasterPageFile="Master_Page.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebShop.ShoppingCart" %>

<asp:Content ID="shopingcart" ContentPlaceHolderID="MasterPagecontent" runat="Server">
    <div class="container" style="margin-bottom: 140px">
        <div class="row">
            
            <div class="col-md-2"></div>
            <div id="cartDiv" class="col-md-8" runat="server" style="margin-top: 140px"><h1 id="cartH1">Din Kundvagn</h1></div>
            <div class="col-md-2"></div>
        </div>
        <div class="row">
            <div class="col-md-2"></div>
            <div id="TotalPrice" class="col-md-8" runat="server">           
                
            </div>  
         
            <div class="col-md-2"> 
                  <asp:Button ID="ToCart" runat="server" Text="Till Kassan" />

            </div>
        </div>
    </div>
</asp:Content>

