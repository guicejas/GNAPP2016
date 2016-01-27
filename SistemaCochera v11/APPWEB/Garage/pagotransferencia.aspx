<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="pagotransferencia.aspx.cs" Inherits="APPWEB.Garage.pagotransferencia" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentGarage" runat="server">
    <script>

        function validateAndConfirm(message) {
            var validated = Page_ClientValidate('groupNumericos');
            if (validated) {
                return confirm(message);
            }
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
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="lblTitulo" runat="server">Mensual</span></legend>

                <div class="form-group">
                    <label for="txtFechadePago" class="col-lg-2 control-label">
                        Fecha del Pago</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtFechadePago" runat="server" CssClass="form-control"></asp:TextBox>
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
                    <asp:RegularExpressionValidator ID="validation1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el monto abonado."
                        CssClass="label label-danger" ControlToValidate="txtMontoAbonado" />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese una fecha pago" CssClass="label label-danger" ControlToValidate="txtFechadePago"></asp:RequiredFieldValidator>
                       <br /> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese una fecha pago" CssClass="label label-danger" ControlToValidate="txtMesPagado"></asp:RequiredFieldValidator>
                </div>
            </fieldset>
        </div>
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