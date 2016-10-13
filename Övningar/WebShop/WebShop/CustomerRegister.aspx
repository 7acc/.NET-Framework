<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegister.aspx.cs" Inherits="WebShop.CustomerRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

    <title>Win15 | Customer Register</title>

    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" />

    <link href="../css/animate.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />

</head>
<body class="gray-bg">
    <form id="form1" runat="server">

        <div class="middle-box text-center loginscreen animated fadeInDown">

            <div>
                <h1 class="logo-name"><i class="fa fa-code" aria-hidden="true"></i></h1>
            </div>
            <h3>Register Account</h3>

            <div id="LoginForm" class="m-t">

                <div class="form-group">
                    <%--<asp:Label ID="Label11" runat="server" Text="Create your account""></asp:Label>--%>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtName" runat="server" Text="Name" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtPhoneNo" runat="server" Text="Phone Number" class="form-control" MaxLength="10"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPhoneNo"
                         ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtAddress" runat="server" Text="Address" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress"
                        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtEmailID" runat="server" Text="Email ID" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmailID"
                        ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Text="Password" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword"
                         ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:Button ID="Button1" runat="server" Text="Register" 
                        Width="200px" onclick="btnRegister_Click" class="btn btn-primary block full-width m-b" />
                </div>

                <div class="form-group">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailID"
                        ErrorMessage="Please Enter Valid EmailId" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>

            </div>

        </div>

    </form>

    <!-- Mainly scripts -->
    <script src="../js/jquery-2.1.1.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</body>
</html>
