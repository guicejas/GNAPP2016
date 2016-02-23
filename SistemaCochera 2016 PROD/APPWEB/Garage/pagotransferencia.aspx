﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="pagotransferencia.aspx.cs" Inherits="APPWEB.Garage.pagotransferencia" %>
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
            <li><a href="mensuales.aspx">Mensuales</a></li>
            <li class="active">Registrar pago por Transferencia</li>
        </ol>
    </div>
    <h3>
        Registrar pago por Transferencia</h3>
        <asp:ScriptManager ID="ScriptManager1" AllowCustomErrorsRedirect="false" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <script type="text/javascript">                Sys.Application.add_load(Calendario); </script>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="lblTitulo" runat="server">Mensual</span></legend>

                <div class="form-group">
                    <label for="txtFechadePago" class="col-lg-2 control-label">
                        Fecha del Pago</label>
                    <div class="col-lg-10">
                    <input type="text" runat="server" id="txtFechadePago" class="calendario form-control"/>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtMesPagado" class="col-lg-2 control-label">
                        Mes Pagado</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtMesPagado" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                
                </div>
                <div class="form-group">
                    <label for="txtMontoAbonado" class="col-lg-2 control-label">
                        Monto Abonado</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtMontoAbonado" runat="server" class="form-control" />
                        </div>
                    </div>
                </div>
                
                <div class="form-group">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese el monto abonado" CssClass="label label-danger"
                        ControlToValidate="txtMontoAbonado"></asp:RequiredFieldValidator>
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="^(((0{0,1}[1-9]|[12][0-9]|3[01])([/])(0{0,1}[13578]|10|12)([/])(\d{4}))|((0{0,1}[1-9]|[12][0-9]|30)([/])(0{0,1}[469]|11)([/])(\d{4}))|((0{0,1}[1-9]|1[0-9]|2[0-8])([/])(0{0,1}2)([/])(\d{4}))|((29)(\.|-|\/)(0{0,1}2)([/])([02468][048]00))|((29)([/])(0{0,1}2)([/])([13579][26]00))|((29)([/])(0{0,1}2)([/])([0-9][0-9][0][48]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][2468][048]))|((29)([/])(0{0,1}2)([/])([0-9][0-9][13579][26])))$" ErrorMessage="Ingrese una fecha en formato dd/mm/aaaa."
                        CssClass="label label-danger" ControlToValidate="txtFechadePago" />
                    
                    <asp:RegularExpressionValidator ID="validation1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)(((\,|\.)\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el monto abonado."
                        CssClass="label label-danger" ControlToValidate="txtMontoAbonado" />

                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="(0{0,1}[123456789]|10|11|12)$" ErrorMessage="Ingrese el número del mes abonado."
                        CssClass="label label-danger" ControlToValidate="txtMesPagado" />

                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese una fecha pago" CssClass="label label-danger" ControlToValidate="txtFechadePago"></asp:RequiredFieldValidator>
                       <br /> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese una fecha pago" CssClass="label label-danger" ControlToValidate="txtMesPagado"></asp:RequiredFieldValidator>
                </div>
            </fieldset>
        </div>

    <div class="form-group col-sm-6">
                    <div class="col-lg-10 col-lg-offset-2">
                   
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click"
                        CssClass="btn btn-success" AutoPostBack="true" ValidationGroup="groupNumericos"
                        OnClientClick="return validateAndConfirm('¿Estas seguro que desea registrar el pago?');" />
                        <br /><br />
                                            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"
                        CssClass="btn btn-default"  AutoPostBack="true" CausesValidation="false" />
                </div>
    </div>
    </form>
</asp:Content>