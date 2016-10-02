<%@ Page Language="C#" MasterPageFile="Master_Page.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WebShop.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MasterPagecontent" runat="Server">

    <div class="container" style="margin-top: 150px;" runat="server">
        <div id="IMGContainer" class="col-md-6" runat="server">
            <asp:Image ID="ProductImage" runat="server" Style="height: 500px" />
        </div>
        <div id="details" class="col-lg-6" runat="server">
            <div id="DescriptionContent" class="row" runat="server">
                <div class="descC" runat="server">
                    <h1 id="ProductName" runat="server"></h1>
                    <p id="description" runat="server"></p>
                </div>
            </div>
            <div class="" id="UtilityContent" runat="server">
                <asp:DropDownList ID="SizeDDL" runat="server" OnSelectedIndexChanged="SizeDDL_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
                <div id="colors" class="colors" runat="server">
                   
                </div>

                <asp:Label ID="inStoreLabel" runat="server" Text=""></asp:Label>
                <div>
                    <asp:Button ID="addToBasket" runat="server" Text="lägg till kundkorgen" OnClick="AddToBasket_OnClick" /></div>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_OnClick" />
            </div>
        </div>
    </div>


</asp:Content>
