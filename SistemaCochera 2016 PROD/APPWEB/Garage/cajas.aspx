<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="cajas.aspx.cs" Inherits="APPWEB.Garage.cajas" %>
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
            <li class="active">Cajas</li>
        </ol>
    </div>
    <h3>
        Cajas</h3>
    <div class="col-lg-12" style="padding-left: 1px">
        <asp:ScriptManager ID="ScriptManager1" AllowCustomErrorsRedirect="false" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <script type="text/javascript">Sys.Application.add_load(Calendario); </script>
            
               
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
                                <asp:ListItem Text="Todos" Selected="True" Value="Todos"></asp:ListItem>
                                <asp:ListItem Text="Abierta" Value="Abierta"></asp:ListItem>
                                <asp:ListItem Text="Cerrada" Value="Cerrada"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
               
                <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                                Fecha<br>Apertura:
                            </td>
                            <td>
                                <input type="text" runat="server" id="txtFiltroApertura" class="calendario form-control"
                                    maxlength="10" style="width: 105px;" />
                            </td>
                            <td>
                                Fecha<br>Cierre:
                            </td>
                            <td>
                                <input type="text" runat="server" id="txtFiltroCierre" class="calendario form-control"
                                    maxlength="10" style="width: 105px;" />
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

                <asp:GridView ID="GridCajas" BorderWidth="1px"  BorderColor="#DDDDDD" 
                    runat="server" Width="100%" CellPadding="50" CellSpacing="50"
                    GridLines="Horizontal" ForeColor="#333333" AllowSorting="True" AutoGenerateColumns="False"
                    AllowPaging="True" PageSize="100" 
                    OnPageIndexChanging="GridCajas_PageIndexChanging">
                    <EmptyDataTemplate>
                        No hay cajas.
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField DataField="NroCaja" HeaderText="Nro Caja" />
                        <asp:BoundField DataField="FechaHoraApertura" HeaderText="Apertura" DataFormatString="{0:dd/MM/yyyy HH:mm}"/>
                        <asp:BoundField DataField="FechaHoraCierre" HeaderText="Cierre" DataFormatString="{0:dd/MM/yyyy HH:mm}"/>
                        <asp:BoundField DataField="TotalDescuentos" HeaderText="Descuentos" 
                            DataFormatString="(-{0:C})" >
                        <ItemStyle ForeColor="#CC3300" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TotalNeto" HeaderText="Recaudado" 
                            DataFormatString="{0:C}" >
                        <ItemStyle Font-Bold="True" ForeColor="#006600" />
                        </asp:BoundField>
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" 
                            DataField="CantidadVehiculos" HeaderText="Cant Veh" >
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
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

