<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportefacturacionHTML.aspx.cs"
    Inherits="APPWEB.Garage.reportefacturacionHTML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../Styles/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <link href="../Styles/glyphicons.css" rel="stylesheet" />
    <link href="../Styles/font-awesome.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
    <title>Reporte de Facturación</title>
</head>
<body>
    <div class="container body-content">
        <form id="form1" runat="server">
        <p id="spanFecha" runat="server" class="text-right">
        </p>
        <blockquote style="padding-top: 0px; padding-bottom: 0px;">
            <h2>
                Reporte para Facturación</h2>
        </blockquote>
        <div class="col-sm-6 noprint">
            <div class="form-group">
                <label class="col-lg-2 control-label">
                    <b>Tipo de Factura</b></label>
                <div class="col-lg-10">
                    <asp:RadioButtonList ID="radioTipoFactura" runat="server" CssClass="radio-inline" AutoPostBack="True">
                        <asp:ListItem Text="Todos" Value="TODOS" Selected="True" />
                        <asp:ListItem Text="A" Value="A" />
                        <asp:ListItem Text="B" Value="B" />
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div class="col-sm-6 noprint">
            <div class="form-group">
                <label class="col-lg-2 control-label">
                    <b>Tipo de Mensualidad</b></label>
                <div class="col-lg-10">
                    <asp:RadioButtonList ID="radiotipoMensual" runat="server" CssClass="radio-inline" AutoPostBack="True">
                        <asp:ListItem Text="Todos" Value="TODOS" Selected="True" />
                        <asp:ListItem Text="24Hs" Value="24HS" />
                        <asp:ListItem Text="Diurnos" Value="DIURNO" />
                        <asp:ListItem Text="Nocturnos" Value="NOCTURNO" />
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
          <br/>
        <div class="col-sm-12" style="margin-top: 25px; margin-bottom: 50px;">
            <div id="divCode" runat="server">
            </div>
            <br />
            <a href="index.aspx">Volver</a><br />
            <br />
        </div>
        </form>
    </div>
</body>
</html>
