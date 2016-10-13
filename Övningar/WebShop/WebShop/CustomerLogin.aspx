<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="WebShop.CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <title>Win15 | Customer Login</title>
    <link href="Content/font-awesome.min.css" rel="stylesheet" />

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
   
    <link href="Content/animate.css" rel="stylesheet" />

 
</head>
<body class="gray-bg">
    <form id="form1" runat="server">

        <div class="middle-box text-center loginscreen animated fadeInDown">
            <div>
                <h1 class="logo-name"><i class="fa fa-code" aria-hidden="true"></i></h1>
            </div>
            <h3>Welcome Customer</h3>

            <div id="LoginForm" class="m-t">

                <div class="form-group">
                    <asp:TextBox ID="txtLoginId" runat="server" Text="Your E-mail" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLoginId"
                        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Text="Password" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label ID="lblAlert" runat="server" Font-Names="Aharoni" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLoginId"
                        ErrorMessage="Please Enter Valid EmailId" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>

                <br />
                <div>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" class="btn btn-primary block full-width m-b" />
                </div>

                <p class="text-muted text-center"><small>Do not have an account?</small></p>

                <asp:LinkButton ID="btnRegister" runat="server" OnClick="btnRegister_Click"
                   CausesValidation="false" class="btn btn-sm btn-white btn-block">New User Register Here !!</asp:LinkButton>

            </div>
            <p class="m-t"><small>&copy; 2016 Win15 Webbutveckling</small> </p>

        </div>
    </form>

    <!-- Mainly scripts -->
    <script src="../js/jquery-2.1.1.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</body>
</html>
