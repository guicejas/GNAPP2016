<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true" CodeBehind="mensuales.aspx.cs" Inherits="APPWEB.Garage.mensuales" %>
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
            <li class="active">Mensuales</li>
        </ol>
    </div>
    <h3>
        Mensuales</h3>
        <br>

            <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="nuevomensual.aspx" class="btn btn-success"><span class="fa fa-plus"></span> Agregar Mensual</asp:HyperLink>
    </p>
    <br>
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
                                Nombre y<br>Apellido:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroNombreApellido" Width="200px"  MaxLength="50" CssClass="form-control"></asp:TextBox>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </div>
                   <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                            </td>
                            <td>
                            </td>
                            <td>
                                Razon<br>Social:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroRazonSocial" Width="200px"  MaxLength="50" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="col-lg-4 col-sm-6 col-xs-12" style="padding-left: 1px">
                    <table class="tableFilters">
                        <tr>
                            <td>
                                Patente:
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFiltroPatente" Width="130px" MaxLength="7" CssClass="form-control"></asp:TextBox>
                            </td>
 <td>
                            Tipo:
                            </td>
                            <td>
                                <asp:DropDownList ID="txtFiltroTipo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Todos" Selected="True" Value="TODOS"></asp:ListItem>
                                <asp:ListItem Text="24HS" Value="24HS"></asp:ListItem>
                                <asp:ListItem Text="Diurno" Value="DIURNO"></asp:ListItem>
                                <asp:ListItem Text="Nocturno" Value="NOCTURNO"></asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                
                <div class="col-lg-6 col-sm-6 col-xs-12" style="padding-left: 1px">
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

                <asp:GridView ID="GridMensuales" BorderWidth="1px"  BorderColor="#dddddd" runat="server" Width="100%" CellPadding="50" CellSpacing="50"
                    GridLines="Horizontal" DataKeyNames="Id" ForeColor="#333333" AllowSorting="true" AutoGenerateColumns="false"
                    AllowPaging="True" PageSize="100" OnSelectedIndexChanging="SelectedIndexChanging" OnPageIndexChanging="GridMensuales_PageIndexChanging" OnRowDeleting="GridMensuales_RowDeleting" OnRowEditing="GridMensuales_RowEditing">
                    <EmptyDataTemplate>
                        No hay mensuales.
                    </EmptyDataTemplate>
                    <Columns>
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" DataField="Codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="NombreApellido" HeaderText="Nombre y Apellido"  />
                        <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                        <asp:BoundField DataField="Vehiculo" HeaderText="Vehiculo" />
                        <asp:BoundField DataField="Patente" HeaderText="Patente" />
                        <asp:BoundField ItemStyle-HorizontalAlign="Center" DataField="TipoMensual" HeaderText="Tipo" />
                        <asp:TemplateField ShowHeader="True" HeaderText="Ver">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CommandName="Select" CausesValidation="False" ID="linkVer"><img src="../Img/search.png" alt="Ver" /></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ShowHeader="True" HeaderText="Borrar">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CommandName="Delete" CausesValidation="False" ID="linkBorrar" OnClientClick="return confirm('Estas seguro que deseas eliminar este mensual?');"><img src="../Img/delete.png" alt="Borrar" /></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" EditImageUrl="~/Img/dollar.png" HeaderText=" Pago " ButtonType="Image"/>
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
