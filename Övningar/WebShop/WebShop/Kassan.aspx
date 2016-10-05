<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Kassan.aspx.cs" Inherits="WebShop.Kassan" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MasterPageContent" runat="server">

    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>

    <div class="container-fluid" id="Content">
        <div class="container" style="margin-top: 140px; margin-bottom:140px">
            <div class="row">

                <div class="col-md-12">
                </div>

            </div>

        </div>
        <div class="container">

            <div class="col-md-12">

                <h1>Din Beställning</h1>

                <hr style="height: 2px; border: none; color: #333; background-color: #333;" />

                <div style="font-size: x-large" runat="server" id="mydiv">
                </div>
            </div>

        </div>

        <div class="container">


            <div class="col-md-12" style="font-size: x-large; font-weight: bolder" runat="server" id="mydiv2">
            </div>


            <%-- buttons --%>

            <div class="col-md-12">
                <asp:Button ID="Btnback" runat="server" PostBackUrl="~/ShoppingCart.aspx" Text="Ångra eller ändra i Ordern" />
                <asp:Button ID="btnCheckOut" runat="server" PostBackUrl="~/ShoppingCart.aspx" Text="Skicka Ordern"
                    OnClick="btnCheckOut_Click" />

            </div>


        </div>

    </div>

</asp:Content>
