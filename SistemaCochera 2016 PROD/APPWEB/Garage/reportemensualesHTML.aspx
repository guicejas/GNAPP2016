<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportemensualesHTML.aspx.cs"
    Inherits="APPWEB.Garage.reportemensualesHTML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../Styles/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <link href="../Styles/glyphicons.css" rel="stylesheet" />
    <link href="../Styles/font-awesome.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
    <title>Reporte de Mensuales</title>
</head>
<body>
    <div class="container body-content">
            <form id="form1" runat="server">
    <p id="spanFecha" runat="server" class="text-right"></p>
        <blockquote>
        <h2>
            Reporte de Mensuales</h2>

        <h3>
            <span id="spanFiltros" runat="server"></span>
        </h3>
        </blockquote>

        <div id="divCode" runat="server">
        </div>
        
        </form>
        <a href="index.aspx">Volver</a>
        <br /><br />
    </div>
    
</body>
</html>
