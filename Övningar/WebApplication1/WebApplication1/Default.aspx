<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1" method="post">

        <asp:Label ID="Label1" runat="server" Text="Labelsssss" Style="position: absolute"></asp:Label>

        <asp:TextBox ID="txtboxName" runat="server" Style="margin-left: 100px;"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtboxName"
            ErrorMessage=" name is a required field."
            ForeColor="Red">
        </asp:RequiredFieldValidator>
        <br />
        <p>
        
        </p>


        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Submit_OnClick" />

        <br />
        <asp:Label ID="Submitted" runat="server"></asp:Label>

    </form>
</asp:Content>
