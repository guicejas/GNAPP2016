<%@ Page Title="" Language="C#" MasterPageFile="~/Garage/Garage.Master" AutoEventWireup="true"
    CodeBehind="index.aspx.cs" Inherits="APPWEB.Garage.index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContentGarage" runat="server">
    <form runat="server">
    <div class="br">
    </div>
    <h3>
        Disponibilidad de cocheras</h3>
    <div class="row">
        <div class="col-lg-6">
            <ul class="list-group">
                <li class="list-group-item"><span class="badge bold" runat="server" id="txtTotalVehiculos">
                    0</span> <span class="text">TOTAL VEHICULOS EN PLAYA</span> </li>
                <li class="list-group-item"><span class="badge bold" runat="server" id="txtVehiculosHora">
                    10</span> <span class="text">VEHICULOS POR HORA</span> </li>
                <li class="list-group-item"><span class="badge bold" runat="server" id="txtVehiculosEstadia">
                    4</span> <span class="text">VEHICULOS POR ESTADIA</span> </li>
                <li class="list-group-item"><span class="badge bold" runat="server" id="txtLugaresDisponibles">
                    26</span> <span class="text">LUGARES DISPONIBLES</span> </li>
            </ul>
        </div>
    </div>
    <br />
    <h3>
        Ocupación detallada</h3>
    <div class="progress">
        <div class="progress-bar progress-bar-success" style="width: 0%" runat="server" id="barraProgresoAutos">
        </div>
        <div class="progress-bar progress-bar-warning" style="width: 0%" runat="server" id="barraProgresoChatas">
        </div>
        <div class="progress-bar progress-bar-danger" style="width: 0%" runat="server" id="barraProgresoEstadias">
        </div>
        <div class="progress-bar progress-bar-other" style="width: 0%" runat="server" id="barraProgresoOtros">
        </div>
    </div>
    <div class="row">
        <div class="col-lg-2-5 col-md-3 col-sm-6 col-xs-6">
            <div class="panel panel-success">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-car fa-5x"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge" runat="server" id="cantidadAutos">
                                0</div>
                            <div>
                                AUTOS</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Ver detalles</span> <span class="pull-right"><span class="fa fa-arrow-circle-right">
                        </span></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-2-5 col-md-3 col-sm-6 col-xs-6">
            <div class="panel panel-warning">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-truck fa-5x"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge" runat="server" id="cantidadChatas">
                                0</div>
                            <div>
                                CHATAS</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Ver detalles</span> <span class="pull-right"><span class="fa fa-arrow-circle-right">
                        </span></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-2-5 col-md-3 col-sm-6 col-xs-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-motorcycle fa-5x"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge" runat="server" id="cantidadMotos">
                                0</div>
                            <div>
                                MOTOS</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Ver detalles</span> <span class="pull-right"><span class="fa fa-arrow-circle-right">
                        </span></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-2-5 col-md-3 col-sm-6 col-xs-6">
            <div class="panel panel-other">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-life-ring fa-5x"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge" runat="server" id="cantidadOtros">
                                0</div>
                            <div>
                                OTROS</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Ver detalles</span> <span class="pull-right"><span class="fa fa-arrow-circle-right">
                        </span></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-2-5 col-md-3 col-sm-6 col-xs-6">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-calendar fa-5x"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge" runat="server" id="cantidadEstadias">
                                0</div>
                            <div>
                                ESTADIAS</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">Ver detalles</span> <span class="pull-right"><span class="fa fa-arrow-circle-right">
                        </span></span>
                        <div class="clearfix">
                        </div>
                    </div>
                </a>
            </div>
        </div>
    </div>
    <br />
    <div class="col-sm-6">
        <h3>
            Vehiculos en playa</h3>
        <asp:GridView ID="GridListaVehiculos" runat="server" Width="100%" BorderWidth="1px"
            BorderColor="#dddddd" GridLines="Both" ForeColor="#333333" AllowSorting="true"
            AutoGenerateColumns="false">
            <EmptyDataTemplate>
                No hay vehiculos en playa.
            </EmptyDataTemplate>
            <Columns>
                <asp:BoundField DataField="MuestraClase" HeaderText="Clase" />
                <asp:BoundField DataField="FechaHoraEntrada" HeaderText="Fecha Entrada" DataFormatString="{0:dd/MM}" />
                <asp:BoundField DataField="FechaHoraEntrada" HeaderText="Hora Entrada" DataFormatString="{0:HH:mm}" />
                <asp:BoundField DataField="DuplicadoPatente" HeaderText="Vehiculo" />
            </Columns>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
            <RowStyle HorizontalAlign="Center" Height="2em" CssClass="table table-striped table-hover">
            </RowStyle>
        </asp:GridView>
    </div>
    <div class="col-sm-6">
        <h3>
            Movimientos de caja</h3>
        <asp:GridView ID="GridCajaParcialX" runat="server" Width="100%" BorderWidth="1px"
            BorderColor="#dddddd" GridLines="Both" ForeColor="#333333" AllowSorting="true"
            AutoGenerateColumns="false">
            <EmptyDataTemplate>
                No hay movimientos en la caja activa.
            </EmptyDataTemplate>
            <Columns>
                <asp:BoundField DataField="MuestraClase" HeaderText="Clase" />
                <asp:BoundField DataField="DuplicadoPatente" HeaderText="Vehiculo" />
                <asp:BoundField DataField="Precio" HeaderText="Importe" DataFormatString="{0:C}" />
                <asp:BoundField DataField="FechaHoraEntrada" HeaderText="Entrada" DataFormatString="{0:dd/MM HH:mm}" />
                <asp:BoundField DataField="FechaHoraSalida" HeaderText="Salida" DataFormatString="{0:dd/MM HH:mm}" />
            </Columns>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
            <RowStyle HorizontalAlign="Center" Height="2em" CssClass="table table-striped table-hover">
            </RowStyle>
        </asp:GridView>
        <asp:GridView ID="GridPagosMensualesCaja" runat="server" Width="100%" BorderWidth="1px"
            BorderColor="#dddddd" GridLines="Both" ForeColor="#333333" AllowSorting="true"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="NombreYApellido" HeaderText="Nombre y Apellido" />
                <asp:BoundField DataField="Monto" HeaderText="Importe" DataFormatString="{0:C}" />
                <asp:BoundField DataField="MesSaldado" HeaderText="Mes Pagado" DataFormatString="" />
            </Columns>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
            <RowStyle HorizontalAlign="Center" Height="2em" CssClass="table table-striped table-hover">
            </RowStyle>
        </asp:GridView>
        <blockquote class="pull-right">
            <div class="text-danger h5">Descuentos: ( $ <span id="txtDescuentos" runat="server"></span>)</div>
            <p>
                TOTAL PARCIAL</p>
            $ <span id="txtcajaParcial" runat="server"></span>
        </blockquote>
        <br />
    </div>
    <br />
    <br />
    </form>
</asp:Content>
