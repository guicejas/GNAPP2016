<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="APPWEB.Garage.test" %>

<!doctype html>
<html lang="en">
<head id="Head1" runat="server">
  <meta charset="utf-8">
  <title>jQuery UI Datepicker - Default functionality</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
  <script>
      $(function () {
          $("#datepicker").datepicker({
              showOn: "button",
              buttonImage: "images/calendar.gif",
              buttonImageOnly: true,
              buttonText: "Select date",
              dateFormat: "dd-mm-yy",
              changeMonth: true,
              changeYear: true
          });
      });
  </script>
</head>
<body>
 
<p>Date: <input type="text" id="datepicker"></p>
 
 
</body>
</html>
