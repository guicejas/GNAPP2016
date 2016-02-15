<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true"
    CodeBehind="vehiculos.aspx.cs" Inherits="APPWEB.Garage.vehiculos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentGarage" runat="server">

<link rel="stylesheet" href="http://code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
  <script src="http://code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
  <script>
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
    <div class="br"></div>

    <div>
        <ol class="breadcrumb">
            <li><a href="index.aspx">Inicio</a></li>
            <li class="active">Vehiculos</li>
        </ol>
    </div>
    <h3>
        Vehiculos</h3>
    <div class="col-lg-12" style="padding-left: 1px">
        <asp:ScriptManager ID="ScriptManager1" AllowCustomErrorsRedirect="false" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <script type="text/javascript">                Sys.Application.add_load(Calendario); </script>
            
               
               <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                                Patente:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroPatente" Width="105px" MaxLength="5" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                                Clase:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroClase" Width="60px" MaxLength="2" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                                Fecha<br>Entrada:
                            </td>
                            <td>
                                <input type="text" runat="server" id="txtFiltroEntrada" class="calendario form-control"
                                    maxlength="10" style="width: 105px;" />
                            </td>
                            <td>
                                Fecha<br>Salida:
                            </td>
                            <td>
                                <input type="text" runat="server" id="txtFiltroSalida" class="calendario form-control"
                                    maxlength="10" style="width: 105px;" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                            Nro Caja:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroCaja" Width="100px" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                            Estado:
                            </td>
                            <td>
                                <asp:DropDownList ID="txtFiltroEstado" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Todos" Selected="True" Value="TODOS"></asp:ListItem>
                                <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                                <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                                <asp:Button runat="server" ID="btnFiltrar" Text="Filtrar" OnClick="btnFiltrar_Click"
                                    CssClass="btn" />
                            </td>
                            <td>
                                <asp:Button runat="server" ID="btnReestablecer" Text="Reestablecer" OnClick="btnReestablecer_Click"
                                    CssClass="btn" />
                            </td>
                        </tr>
                    </table>
                          <br />

                </div>

                <br />

                <asp:GridView ID="GridVehiculos" BorderWidth="1px"  BorderColor="#dddddd" runat="server" Width="100%" CellPadding="50" CellSpacing="50"
                    GridLines="Horizontal" ForeColor="#333333" AllowSorting="true" AutoGenerateColumns="false"
                    AllowPaging="True" PageSize="100" OnPageIndexChanging="GridVehiculos_PageIndexChanging">
                    <EmptyDataTemplate>
                        No hay vehiculos.
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="NroTicket" HeaderText="Ticket" />
                        <asp:BoundField DataField="DuplicadoPatente" HeaderText="Patente" />
                        <asp:BoundField DataField="FechaHoraEntrada" HeaderText="Entrada" DataFormatString="{0:dd/MM/yyyy HH:mm}"/>
                        <asp:BoundField DataField="FechaHoraSalida" HeaderText="Salida" DataFormatString="{0:dd/MM/yyyy HH:mm}"/>
                        <asp:BoundField DataField="Precio" HeaderText="Importe" DataFormatString="{0:C}" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" DataField="MuestraClase" HeaderText="Clase" />
                        <asp:BoundField DataField="MuestraCaja" HeaderText="Caja" />
                    </Columns>
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
                    <PagerStyle BackColor="#284775" ForeColor="White" Font-Size="X-Large" Wrap="true"
                        HorizontalAlign="Center"></PagerStyle>
                    <PagerSettings Mode="NumericFirstLast" PageButtonCount="4" FirstPageText="Primer"
                        LastPageText="Ultima" />
                        <RowStyle  Height="2em" BorderColor="#dddddd"></RowStyle>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</asp:Content>
