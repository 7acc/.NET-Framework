<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Föreläsning_1_asp_web_forms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron"> 
  <asp:TextBox ID="Boxen" runat="server" Height="32px" Width="448px"></asp:TextBox>
        <asp:Button ID="Knappen" runat="server" Text="Stenmark It" CssClass="alert-warning" OnClick="Knappen_Click_Stenmark" />
        <br />

<asp:Label ID="Result_Content" runat="server" Visible ="False" BackColor="#FCF8E3" BorderColor="#D4B953" BorderStyle="Solid" BorderWidth="1px" ></asp:Label>
        <br />

        <br />
        <br />
         <h1>ASP.NET</h1>        
    </div>
</asp:Content>
