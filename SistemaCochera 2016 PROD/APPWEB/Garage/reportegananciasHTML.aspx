<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reportegananciasHTML.aspx.cs" Inherits="APPWEB.Garage.reportegananciasHTML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/bootstrap.css" rel="stylesheet" />
    <link href="../Styles/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <link href="../Styles/glyphicons.css" rel="stylesheet" />
    <link href="../Styles/font-awesome.css" rel="stylesheet" />
    <link href="../Styles/garageStyles.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/jquery-2.1.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.js"></script>
    <title>Reporte de Ganancias</title>
</head>
<body>
    <div class="container body-content">
    <h2>Reporte de Ganancias</h2>
    <form id="form1" runat="server">
    <h4><span id="spanFiltros" runat="server"></span></h4>
    <div id="divCode" runat="server">

    </div>
    </form>
    </div>
</body>
</html>
