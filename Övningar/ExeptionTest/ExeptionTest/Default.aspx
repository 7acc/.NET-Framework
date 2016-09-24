<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExeptionTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 100px;">
        <asp:Label ID="Result" runat="server" Text="" Style="margin-top: 40px;"></asp:Label>
    </div>
    <asp:Table ID="myTable" runat="server">
        <asp:TableRow>
            <asp:TableCell Style="text-align:right; padding-right:10px;" >
               TEXT ONLY
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server"
                    ValidationExpression="^[a-zA-Z ]*$"
                    ControlToValidate="TextBox1"
                    ErrorMessage="ONLY TEXT!!!, dumbass">
                </asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  Style="text-align:right; padding-right:10px;" >
           NUMBERS ONLY
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server"
                    ValidationExpression="^[0-9]+$"
                    ControlToValidate="TextBox2"
                    ErrorMessage="ONLY NUMBERS!!!, dumbass!">
                </asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableHeaderRow>
            <asp:TableCell  Style="text-align:right; padding-right:10px;" >
           EMAIL!!!
            </asp:TableCell>
            <asp:TableCell>
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server"
                    ValidationExpression="^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"
                    ControlToValidate="TextBox3"
                    ErrorMessage="i said Email ... -_- ">
                     </asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableHeaderRow>
    </asp:Table>
    <asp:Button ID="submit" runat="server" Text="GO" OnClick="Submit" />
</asp:Content>
