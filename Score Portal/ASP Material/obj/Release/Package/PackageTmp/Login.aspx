<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP_Material.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Portal Olympus Beginning</title>
    <!-- Core CSS-->
    <link href="assets/plugins/bootstrap/bootstrap.css" rel="stylesheet" />
    <link href="assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link href="assets/plugins/pace/pace-theme-big-counter.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />
    <link href="assets/css/main-style.css" rel="stylesheet" />
     <!-- Social Button CSS-->
    <link href="assets/plugins/social-buttons/social-buttons.css" rel="stylesheet" />
     <!-- Timeline CSS-->
    <link href="assets/plugins/timeline/timeline.css" rel="stylesheet" />
</head>
<body class="body-Login-back">
    <form id="form1" runat="server">
    <div class="container">
       
        <div class="row">
            <div class="col-md-4 col-md-offset-4 text-center logo-margin ">
              <img src="assets/img/logo.png" alt="" width="50%"/><br /><br />
                <asp:Label class="user-text-online" runat="server"> Portal Olympus Beginning </asp:Label>
                </div>
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">                  
                    <div class="panel-heading">
                        <h3 class="panel-title">Iniciar Sesion</h3>
                    </div>
                    <div class="panel-body">
                       
                            <fieldset>
                                <div class="form-group">
                                    <p> <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label> </p>
                                    <asp:TextBox ID="Textbox_User" runat="server" class="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <p> <asp:Label ID="Label3" runat="server" Text="Recordarme"></asp:Label>
                                    <asp:CheckBox ID="chkRememberMe" runat="server" type="checkbox"/></p>
                                </div>
                                <!--
                                <div class="checkbox">
                                    <label>
                                        <input name="remember" type="checkbox" value="Remember Me">Remember Me
                                    </label>
                                </div>
                                -->
                                <asp:Label ID="Label_Mensaje" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                <asp:Button ID="Button_Entrar" runat="server" Text="Acceder" class="btn btn-lg btn-facebook btn-block" OnClick="Button_Entrar_Click" />
                            </fieldset>
                      
                    </div>
                </div>
            </div>
        </div>
    </div>

     <!-- Core Scripts -->
    <script src="assets/plugins/jquery-1.10.2.js"></script>
    <script src="assets/plugins/bootstrap/bootstrap.min.js"></script>
    <script src="assets/plugins/metisMenu/jquery.metisMenu.js"></script>
    </form>
</body>
</html>