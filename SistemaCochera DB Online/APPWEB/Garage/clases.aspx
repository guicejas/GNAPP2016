<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true"
    CodeBehind="clases.aspx.cs" Inherits="APPWEB.Garage.clases" %>

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
            <li class="active">Clases</li>
        </ol>
    </div>
    <h3>
        Clases</h3>
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="spanClase" runat="server">Clase</span></legend>
                <div class="form-group">
                    <label for="listClases" class="col-lg-2 control-label">
                        Clase</label>
                    <div class="col-lg-10">
                        <asp:DropDownList ID="listClases" runat="server" CssClass="form-control" AutoPostBack="true"
                            DataTextField="CodigoDescripcion" DataValueField="Codigo" OnSelectedIndexChanged="listClases_IndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtCodigo" class="col-lg-2 control-label">
                        Codigo Clase</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDescripcion" class="col-lg-2 control-label">
                        Descripcion</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPrecioHora" class="col-lg-2 control-label">
                        Precio por Hora</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtPrecioHora" runat="server" class="form-control" disabled
                                 />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPrecioEstadia12" class="col-lg-2 control-label">
                        Precio por 12Hs</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtPrecioEstadia12" runat="server" class="form-control" disabled
                                 />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPrecioEstadia24" class="col-lg-2 control-label">
                        Precio por 24Hs</label>
                    <div class="col-lg-10">
                        <div class="input-group">
                            <span class="input-group-addon">$</span>
                            <input type="text" id="txtPrecioEstadia24" runat="server" class="form-control" disabled
                                 />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:RegularExpressionValidator ID="validation1" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el precio por Hora."
                        CssClass="label label-danger" ControlToValidate="txtPrecioHora" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un precio por Hora" CssClass="label label-danger" ControlToValidate="txtPrecioHora"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="validation2" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el precio de 12Hs."
                        CssClass="label label-danger" ControlToValidate="txtPrecioEstadia12" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un precio por 12Hs" CssClass="label label-danger" ControlToValidate="txtPrecioEstadia12"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="validation3" ValidationGroup="groupNumericos"
                        runat="server" ValidationExpression="((\d+)((\,\d{1,2})?))$" ErrorMessage="Ingrese un monto numérico para el precio de 24Hs."
                        CssClass="label label-danger" ControlToValidate="txtPrecioEstadia24" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="groupNumericos"
                        ErrorMessage="Ingrese un precio por 24Hs" CssClass="label label-danger" ControlToValidate="txtPrecioEstadia24"></asp:RequiredFieldValidator>
                    <br />
                    <div class="col-lg-10 col-lg-offset-2">
                        <asp:Button runat="server" ID="btnEditar" Text="Editar" OnClick="btnEditar_Click"
                            CssClass="btn btn-default" AutoPostBack="true" CausesValidation="false" />
                        <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"
                            CssClass="btn btn-default" Enabled="false" AutoPostBack="true" CausesValidation="false" />
                        <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click"
                            CssClass="btn btn-success" Enabled="false" AutoPostBack="true" ValidationGroup="groupNumericos"
                            OnClientClick="return validateAndConfirm('¿Estas seguro que desea actualizar los precios?');" />
                    </div>
                </div>
            </fieldset>
        </div>
    </div>
    </form>
</asp:Content>
