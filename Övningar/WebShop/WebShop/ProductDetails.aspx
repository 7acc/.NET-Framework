<%@ Page Language="C#" MasterPageFile="Master_Page.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WebShop.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MasterPagecontent" runat="Server">

    <div class="container" style="margin-top: 150px;" runat="server">
        <div id="IMGContainer" class="col-md-6" runat="server">
            <asp:Image ID="ProductImage" runat="server" Style="height: 500px" />
        </div>
        <div id="details" class="col-lg-6" runat="server">
            <div id="DescriptionContent" class="row" runat="server">
                <div id="DecriptionContainer" runat="server">
                    <h1 id="ProductName" runat="server"></h1>
                    <p id="description" runat="server"></p>
                </div>
                <div id="UtilityContent" class="row" runat="server">2</div>
            </div>
        </div>
    </div>


</asp:Content>
