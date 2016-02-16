using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

namespace CONTROLADORA
{
    class ControladoraReportesPDF
    {
        public string GenerarReporteGastos()
        {

            //DateTime hora = DateTime.Now;
            //string fcha_ttal = Convert.ToDateTime(hora).Day + "/" + Convert.ToDateTime(hora).Month + "/" + Convert.ToDateTime(hora).Year;


            //Document doc = new Document(PageSize.A4, 9, 9, 10, 10);
            //string filename = "ReporteGastos.pdf";

            //iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("http://localhost:50196/Images/Trypep.png"); jpg.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;

            //Chunk renglonvacio = new Chunk(" ", FontFactory.GetFont("ARIAL", 18));

            //Paragraph inicio = new Paragraph("- SISTEMA GESTION FLOTA DE TAXIS - TRYPEP SISTEMAS - 2014 -", FontFactory.GetFont("ARIAL", 8, 2));



            //Chunk encab = new Chunk("INFORME DE GASTOS POR VEHICULO   " + fcha_ttal + "", FontFactory.GetFont("ARIAL", 18, 1, BaseColor.BLACK));


            //Paragraph hola = new Paragraph("hola");


            //try
            //{
            //    FileStream file = new FileStream
            //   (filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            //    PdfWriter.GetInstance(doc, file);
            //    doc.Open();

            //    inicio.Alignment = 1;
            //    doc.Add(inicio);

            //    encab.SetBackground(BaseColor.LIGHT_GRAY);
            //    doc.Add(new Paragraph(encab));
            //    doc.Add(new Paragraph(renglonvacio));

            //    //DataGridView grilla = dgvDatos;

            //    //se crea un objeto PdfTable con el numero de columnas del

            //    //dataGridView

            //    PdfPTable datatable = new PdfPTable(4);

            //    //asignamos algunas propiedades para el diseño del pdf
            //    datatable.DefaultCell.Padding = 3;


            //    float[] values = new float[4];

            //    values[0] = (float)100;
            //    values[1] = (float)80;
            //    values[2] = (float)250;
            //    values[3] = (float)150;

            //    float[] headerwidths = values;

            //    datatable.SetWidths(headerwidths);

            //    datatable.WidthPercentage = 100;

            //    datatable.DefaultCell.BorderWidth = 2;

            //    datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


            //    //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF

            //    datatable.AddCell(new Paragraph("VEHICULO", FontFactory.GetFont("ARIAL", 14, 1)));
            //    datatable.AddCell(new Paragraph("MODELO", FontFactory.GetFont("ARIAL", 14, 1)));
            //    datatable.AddCell(new Paragraph("DESCRIPCION GASTO", FontFactory.GetFont("ARIAL", 14, 1)));
            //    datatable.AddCell(new Paragraph("TOTAL", FontFactory.GetFont("ARIAL", 14, 1)));




            //    datatable.HeaderRows = 1;

            //    datatable.DefaultCell.BorderWidth = 1;


            //    //SE GENERA EL CUERPO DEL PDF

            //    List<Modelo.Vehiculo> oVehiculos = ctrlVehiculos.ListarVehiculosGastos(HttpContext.Current.Request.Cookies["userInfoSGOFT"]["flotaId"].ToString());

            //    if (oVehiculos.Count > 0)
            //    {
            //        for (int i = 0; i < oVehiculos.Count; i++)
            //        {
            //            //datatable.AddCell(oVehiculos[i].Patente);
            //            datatable.AddCell(new Paragraph(oVehiculos[i].Patente, FontFactory.GetFont("ARIAL", 12, 1)));
            //            datatable.AddCell(oVehiculos[i].Año.ToString());

            //            List<Modelo.Gasto> oGastos = Controladora.ControladoraGastos.getINSTANCIA.ListarGastosdeVehiculo(oVehiculos[i].Patente);

            //            if (oGastos.Count > 0)
            //            {

            //                datatable.AddCell(oGastos[0].Descripcion);
            //                datatable.AddCell("$ " + oGastos[0].Monto.ToString());

            //                datatable.CompleteRow();

            //                for (int j = 1; j < oGastos.Count; j++)
            //                {
            //                    datatable.AddCell("");
            //                    datatable.AddCell("");
            //                    datatable.AddCell(oGastos[j].Descripcion);
            //                    datatable.AddCell("$ " + oGastos[j].Monto.ToString());
            //                    datatable.CompleteRow();

            //                }



            //                datatable.AddCell("");
            //                datatable.AddCell("");

            //            }
            //            datatable.DefaultCell.BorderWidth = 2;
            //            datatable.AddCell(new Paragraph("TOTAL", FontFactory.GetFont("ARIAL", 12, 3)));
            //            datatable.AddCell(new Paragraph("$ " + oGastos.Sum(x => x.Monto).ToString(), FontFactory.GetFont("ARIAL", 12, 3)));
            //            datatable.DefaultCell.BorderWidth = 1;
            //            datatable.CompleteRow();
            //            if (i < oVehiculos.Count - 1)
            //            {
            //                datatable.AddCell("");
            //                datatable.CompleteRow();
            //            }
            //        }

            //        //SE AGREGA LA PDFPTABLE AL DOCUMENTO
            //        //doc.Add(datatable);
            //    }

            //    //SE AGREGA FIN DE DOCUMENTO
            //    doc.Add(datatable);
            //    doc.Add(new Paragraph(renglonvacio));
            //    doc.Add(jpg);
            //    Paragraph fin = new Paragraph("Este documento es propiedad de Trypep Sistemas y queda prohibida su reproducción total o parcial.\n La información contenida en este documento es confidencial.", FontFactory.GetFont("ARIAL", 8, 2));
            //    fin.Alignment = 1;
            //    doc.Add(fin);



            //    Process.Start(filename);
            //    doc.Close();
            //}

            //catch //(Exception ex)
            //{

            //    //this.Redirect("Error.aspx?error=" + ex.Message);
            //}

            //return filename;

            return "a";


        }
    }
}
