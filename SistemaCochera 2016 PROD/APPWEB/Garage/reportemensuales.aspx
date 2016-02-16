<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="reportemensuales.aspx.cs" Inherits="APPWEB.Garage.reportemensuales" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentGarage" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
    <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
    <script type="text/javascript">

        function validateAndConfirm(message) {
            var validated = Page_ClientValidate('groupMensual');
            if (validated) {
                return confirm(message);
            }
        }

        function validateAndConfirm(message) {
            var validated = Page_ClientValidate('groupPeriodo');
            if (validated) {
                return confirm(message);
            }
        }

        function Calendario() {
            $(function () {
                $(".calendario").datepicker({
                    dateFormat: "dd/mm/yy",
                    changeMonth: true,
                    changeYear: true,
                    showAnim: "slideDown"
                });
            });
        }
    </script>
    <form id="Form1" runat="server">
    <div class="br">
    </div>
    <div>
        <ol class="breadcrumb">
            <li><a href="index.aspx">Inicio</a></li>
            <li class="active">Reporte de Mensuales</li>
        </ol>
    </div>
    <h3>
        Reporte de Mensuales</h3>
    <br />
    <asp:ScriptManager ID="ScriptManager1" AllowCustomErrorsRedirect="false" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <script type="text/javascript">                Sys.Application.add_load(Calendario); </script>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="lblTitulo" runat="server">Anual / Mensual</span></legend>
                <div class="form-group">
                    <label for="txtMesMensual" class="col-lg-2 control-label">
                        Mes</label>
                    <div class="col-lg-10">
                        <asp:DropDownList ID="listMesMensual" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtAnoMensual" class="col-lg-2 control-label">
                        Año</label>
                    <div class="col-lg-10">
                        <input type="text" id="txtAnoMensual" runat="server" class="form-control" maxlength="4" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="groupMensual"
                        ErrorMessage="Ingrese año para generar el reporte" CssClass="label label-danger"
                        ControlToValidate="txtAnoMensual"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="groupMensual"
                        runat="server" ValidationExpression="^(19|20)\d{2}$" ErrorMessage="Ingrese correctamente el año deseado"
                        CssClass="label label-danger" ControlToValidate="txtAnoMensual" />
                </div>
                <asp:Button runat="server" ID="btnGenerarMensual" Text="Generar" OnClick="btnGenerarMensual_Click"
                    CssClass="btn btn-success" AutoPostBack="true" ValidationGroup="groupMensual" />
                    <br />
            </fieldset>
        </div>
    </div>
    
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="Span1" runat="server">Período</span></legend>
                <div class="form-group">
                    <label for="txtFechaDesde" class="col-lg-2 control-label">
                        Fecha Desde</label>
                    <div class="col-lg-10">
                        <input type="text" runat="server" id="txtFechaDesde" class="calendario form-control"
                            maxlength="10" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtFechaHasta" class="col-lg-2 control-label">
                        Fecha Hasta</label>
                    <div class="col-lg-10">
                        <input type="text" runat="server" id="txtFechaHasta" class="calendario form-control"
                            maxlength="10" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupPeriodo"
                        ErrorMessage="Ingrese fecha DESDE" CssClass="label label-danger" ControlToValidate="txtFechaDesde"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="groupPeriodo"
                        runat="server" ValidationExpression="^(((0{0,1}[1-9]|[12][0-9]|3[01])([/])(0{0,1}[13578]|10|12)([/])(\d{4}))|((0{0,1}[1-9]|[12][0-9]|30)([/])(0{0,1}[469]|11)([/])(\d{4}))|((0{0,1}[1-9]|1[0-9]|2[0-8])([/])(0{0,1}2)([/])(\d{4}))|((29)(\.|-|\/)(0{0,1}2)([/])([02468][048]00))|((29)([/])(0{0,1}2)([/])([13579][26]00))|((29)([/])(0{0,1}2)([/])([0-9][0-9][0][48]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][2468][048]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][13579][26])))$"
                        ErrorMessage="Ingrese una fecha DESDE en formato dd/mm/aaaa." CssClass="label label-danger"
                        ControlToValidate="txtFechaDesde" />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="groupPeriodo"
                        ErrorMessage="Ingrese fecha HASTA" CssClass="label label-danger" ControlToValidate="txtFechaHasta"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ValidationGroup="groupPeriodo"
                        runat="server" ValidationExpression="^(((0{0,1}[1-9]|[12][0-9]|3[01])([/])(0{0,1}[13578]|10|12)([/])(\d{4}))|((0{0,1}[1-9]|[12][0-9]|30)([/])(0{0,1}[469]|11)([/])(\d{4}))|((0{0,1}[1-9]|1[0-9]|2[0-8])([/])(0{0,1}2)([/])(\d{4}))|((29)(\.|-|\/)(0{0,1}2)([/])([02468][048]00))|((29)([/])(0{0,1}2)([/])([13579][26]00))|((29)([/])(0{0,1}2)([/])([0-9][0-9][0][48]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][2468][048]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][13579][26])))$"
                        ErrorMessage="Ingrese una fecha HASTA en formato dd/mm/aaaa." CssClass="label label-danger"
                        ControlToValidate="txtFechaHasta" />
                </div>
                <asp:Button runat="server" ID="btnGenerarPeriodo" Text="Generar" OnClick="btnGenerarPeriodo_Click"
                    CssClass="btn btn-success" AutoPostBack="true" ValidationGroup="groupPeriodo" />
            </fieldset>
        </div>
    </div>
    </form>
</asp:Content>

