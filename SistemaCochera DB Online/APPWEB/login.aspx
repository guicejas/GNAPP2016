<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="APPWEB.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Garage Login</title>
    <link href="Styles/bootstrap.css" rel="stylesheet" />
    <link href="Styles/glyphicons.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
</head>
<body>
    <div class="container body-content" style="margin-top: 75px">
        <div class="col-sm-4 col-sm-offset-4">
        <div id="mensaje" runat="server">
                <button type="button" class="close" data-dismiss="alert">×</button>
                <span id="mensajeTexto" runat="server"></span>
            </div>
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">
                        LOGIN</h3>
                </div>
                <div class="panel-body">
                    <form runat="server" id="formLogin">
                    <fieldset>
                        <div class="form-group">
                            <input runat="server" id="inputUsuario" class="form-control" placeholder="Usuario" name="usuario" type="text" autofocus required/>
                        </div>
                        <div class="form-group">
                            <input runat="server" id="inputPassword" class="form-control" placeholder="Password" name="password" type="password"
                                value="" required />
                        </div>
                        <div class="checkbox">
                            <label>
                                <input id="recordarme" runat="server" name="recordarme" type="checkbox" value="Recordarme" />Recordarme
                            </label>
                        </div>
                        <!-- Change this to a button or input when using this as a form -->
                        <asp:Button UseSubmitBehavior="true" CssClass="btn btn-lg btn-success btn-block"
                            runat="server" OnClick="LoginSistema_Authenticate" ID="btnIngresar" Text="Ingresar" />
                    </fieldset>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
