<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login ICBF</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container-fluid">
    <form id="form1" runat="server">
        <main class="container">
            <h1>Inicio de Sesión</h1>
            <asp:Login ID="loginICBF" runat="server">
                <LayoutTemplate>
                    <div class="form-group">                                        
                        <asp:Label runat="server" AssociatedControlID="UserName" ID="UserNameLabel">Correo Electronico:</asp:Label>
                        <asp:TextBox runat="server" ID="UserName" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ValidationGroup="loginICBF" ToolTip="El nombre de usuario es obligatorio." ID="UserNameRequired">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" ID="PasswordLabel">Contraseña:</asp:Label>
                        <asp:TextBox runat="server" TextMode="Password" ID="Password" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" ErrorMessage="La contrase&#241;a es obligatoria." ValidationGroup="loginICBF" ToolTip="La contraseña es obligatoria." ID="PasswordRequired">*</asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:CheckBox runat="server" ID="RememberMe"></asp:CheckBox>
                        <asp:Label Text="Recordarmelo la próxima vez" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Literal runat="server" ID="FailureText" EnableViewState="False"></asp:Literal>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" CommandName="Login" Text="Inicio de sesión" ValidationGroup="loginICBF" ID="LoginButton" CssClass="btn btn-success btn-block" OnClick="LoginButton_Click"></asp:Button>
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </main>
    </form>
    <script type="text/javascript" src="Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="Scripts/aplication.js"></script>
</body>
</html>
