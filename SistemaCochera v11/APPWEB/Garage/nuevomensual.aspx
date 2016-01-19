<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="nuevomensual.aspx.cs" Inherits="APPWEB.Garage.nuevomensual" %>
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
            <li class="active">Nuevo Mensual</li>
        </ol>
    </div>
    <h3>
        Nuevo Mensual</h3>
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span>Mensual</span></legend>
                <div class="form-group">
                    <label for="txtCodigo" class="col-lg-2 control-label">
                        CODIGO</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtNombreyApellido" class="col-lg-2 control-label">
                        Nombre y Apellido</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtNombreyApellido" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtVehiculo" class="col-lg-2 control-label">
                        Vehiculo</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtVehiculo" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPatente" class="col-lg-2 control-label">
                        Patente</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtPatente" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDomicilio" class="col-lg-2 control-label">
                        Domicilio</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtTelefono" class="col-lg-2 control-label">
                        Telefono</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="listTipoMensualidad" class="col-lg-2 control-label">
                        Tipo Mensualidad</label>
                    <div class="col-lg-10">
                       <asp:DropDownList ID="listTipoMensualidad" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <label for="txtPrecioMensualidad" class="col-lg-2 control-label">
                        Precio Mensualidad</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtPrecioMensualidad" runat="server" class="form-control"/>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <label for="txtRazonSocial" class="col-lg-2 control-label">
                        Razon Social</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtCUIL" class="col-lg-2 control-label">
                        CUIL/CUIT</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDomicilioFiscal" class="col-lg-2 control-label">
                        Domicilio Fiscal</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtDomicilioFiscal" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="listTipoFactura" class="col-lg-2 control-label">
                        Tipo Factura</label>
                    <div class="col-lg-10">
                    <asp:DropDownList ID="listTipoFactura" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtObservaciones" class="col-lg-2 control-label">
                        Observaciones</label>
                    <div class="col-lg-10">
                        <textarea id="txtObservaciones" runat="server" class="form-control" cols="20" rows="2"></textarea>
                    </div>
                </div>
                
              
                <div class="form-group">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un precio de mensualidad" CssClass="label label-danger" ControlToValidate="txtPrecioMensualidad"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validation1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el precio."
                        CssClass="label label-danger" ControlToValidate="txtPrecioMensualidad" />                        
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un nombre de mensual" CssClass="label label-danger" ControlToValidate="txtNombreyApellido"></asp:RequiredFieldValidator>
                   </div>
                       <div class="col-lg-10 col-lg-offset-2">
                        <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"
                            CssClass="btn btn-default" AutoPostBack="true" CausesValidation="false" />
                        <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click"
                            CssClass="btn btn-success" AutoPostBack="true" ValidationGroup="groupNumericos"
                            OnClientClick="return validateAndConfirm('¿Estas seguro que desea dar de alta el mensual?');" />
                    </div>
                </div>
            </fieldset>
        </div>
    </div>
    </form>
</asp:Content>
