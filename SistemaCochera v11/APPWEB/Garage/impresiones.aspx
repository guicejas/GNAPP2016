<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="impresiones.aspx.cs" Inherits="APPWEB.Garage.impresiones" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentGarage" runat="server">

 <form id="Form1" runat="server">
    <div class="br">
    </div>
    <div>
        <ol class="breadcrumb">
            <li><a href="index.aspx">Inicio</a></li>
            <li class="active">Impresiones</li>
        </ol>
    </div>
    <h3>
        Clases</h3>
    <br />
    <div class="form-group col-sm-6">
        <div class="form-horizontal">
            <fieldset>
                <legend><span id="spanImpresion" runat="server">Impresiones</span></legend>
                <div class="form-group">
                    <label for="listImpresiones" class="col-lg-2 control-label">
                        Impresión</label>
                    <div class="col-lg-10">
                        <asp:DropDownList ID="listImpresiones" runat="server" CssClass="form-control" AutoPostBack="true"
                            DataTextField="CodigoDescripcion" DataValueField="Codigo" OnSelectedIndexChanged="listImpresiones_IndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtEncabezado1" class="col-lg-2 control-label">
                        Encabezado</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtEncabezado1" MaxLength="31"  runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtEncabezado2" MaxLength="31" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtEncabezado3" MaxLength="31" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtEncabezado4" MaxLength="31" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtEncabezado5" MaxLength="31" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                    </div>
                </div>
                    <div class="form-group">
                    <label for="txtPie1" class="col-lg-2 control-label">
                        Pie</label>
                    <div class="col-lg-10">
                        <asp:TextBox ID="txtPie1" MaxLength="40" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtPie2" MaxLength="40" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtPie3" MaxLength="40" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtPie4" MaxLength="40" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                        <asp:TextBox ID="txtPie5" MaxLength="40" runat="server" CssClass="form-control text-center" Font-Names="Consolas" Enabled="false"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-lg-10 col-lg-offset-2">
                        <asp:Button runat="server" ID="btnEditar" Text="Editar" OnClick="btnEditar_Click"
                            CssClass="btn btn-default" AutoPostBack="true" />
                        <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click"
                            CssClass="btn btn-default" Enabled="false" />
                        <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click"
                            CssClass="btn btn-success" Enabled="false" AutoPostBack="true" OnClientClick="return confirm('¿Estas seguro que deseas modificar la impresión?');" />
                    </div>
                </div>
            </fieldset>
        </div>
    </div>
    </form>
</asp:Content>