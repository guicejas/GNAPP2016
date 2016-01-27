<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true"
    CodeBehind="vermensual.aspx.cs" Inherits="APPWEB.Garage.vermensual" %>

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
            <li class="active">Ver Mensual</li>
        </ol>
    </div>
    <h3>
        Ver Mensual</h3>
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span>Mensual</span></legend>
                <div class="form-group">
                    <label for="txtCodigo" class="col-lg-2 control-label">
                        CODIGO</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control " Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtNombreyApellido" class="col-lg-2 control-label">
                        Nombre y Apellido</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtNombreyApellido" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtVehiculo" class="col-lg-2 control-label">
                        Vehiculo</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtVehiculo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPatente" class="col-lg-2 control-label">
                        Patente</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtPatente" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDomicilio" class="col-lg-2 control-label">
                        Domicilio</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtTelefono" class="col-lg-2 control-label">
                        Telefono</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="listTipoMensualidad" class="col-lg-2 control-label">
                        Tipo Mensualidad</label>
                    <div class="col-lg-10">
                        <asp:DropDownList ID="listTipoMensualidad" runat="server" CssClass="form-control"
                            Enabled="false">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPrecioMensualidad" class="col-lg-2 control-label">
                        Precio Mensualidad</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtPrecioMensualidad" runat="server" class="form-control"
                                disabled />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtRazonSocial" class="col-lg-2 control-label">
                        Razon Social</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtCUIL" class="col-lg-2 control-label">
                        CUIL/CUIT</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCUIL" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDomicilioFiscal" class="col-lg-2 control-label">
                        Domicilio Fiscal</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtDomicilioFiscal" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="listTipoFactura" class="col-lg-2 control-label">
                        Tipo Factura</label>
                    <div class="col-lg-10">
                        <asp:DropDownList ID="listTipoFactura" runat="server" CssClass="form-control" Enabled="false">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtObservaciones" class="col-lg-2 control-label">
                        Observaciones</label>
                    <div class="col-lg-10">
                        <textarea id="txtObservaciones" runat="server" class="form-control" cols="20" rows="2"
                            disabled></textarea>
                    </div>
                </div>
                <div class="form-group">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un precio de mensualidad" CssClass="label label-danger"
                        ControlToValidate="txtPrecioMensualidad"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="validation1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el precio."
                        CssClass="label label-danger" ControlToValidate="txtPrecioMensualidad" />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un nombre de mensual" CssClass="label label-danger" ControlToValidate="txtNombreyApellido"></asp:RequiredFieldValidator>
                </div>
            </fieldset>
        </div>
    </div>
    <div class="form-group col-sm-6">
        <asp:Button runat="server" ID="btnPagoMensualidad" Text="REGISTRAR PAGO POR TRANSFERENCIA"
            OnClick="btnRegistrarPago_Click" CssClass="btn btn-success" Enabled="true" />
        <div>
            <h3>
                Historial de Pagos</h3>
            <asp:GridView ID="GridHistorialPagos" runat="server" Width="100%" BorderWidth="1px"
                BorderColor="#dddddd" GridLines="Both" ForeColor="#333333" AllowSorting="true"
                AutoGenerateColumns="false">
                <EmptyDataTemplate>
                    No hay pagos registrados para el cliente.
                </EmptyDataTemplate>
                <Columns>
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha de Pago" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Monto" HeaderText="Monto" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="MesSaldado" HeaderText="Mes Saldado" />
                    <asp:BoundField DataField="NroCaja" HeaderText="Nro Caja" />
                </Columns>
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
                <RowStyle HorizontalAlign="Center" Height="2em" CssClass="table table-striped table-hover">
                </RowStyle>
            </asp:GridView>

                    <blockquote class="pull-right">
            <div class="text-success h4">Ultimo mes pago: <span id="txtUltimoMesPago" runat="server"></span></div>
            <div class="text-success h4">Fecha ultimo pago: <span id="txtFechaUltimoMesPago" runat="server"></span></div>
        </blockquote>
        <br />
        </div>
    </div>
    </form>
</asp:Content>
