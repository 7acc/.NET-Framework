<%@ Page Language="C#" MasterPageFile="Master_Page.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebShop.ShoppingCart" %>

<asp:Content ID="shopingcart" ContentPlaceHolderID="MasterPagecontent" runat="Server">
    <asp:GridView ID="CartGrid" runat="server" Style="margin-top: 300px" OnRowDataBound="CartGrid_OnRowDataBound">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:TemplateField HeaderText="IMG">
                <ItemTemplate>
                <asp:Image ID="img" runat="server" Height="100px" />
                    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

