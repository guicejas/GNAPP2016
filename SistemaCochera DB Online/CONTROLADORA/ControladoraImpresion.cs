using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// se agrega la siguiente referencia para enviar texto a impresora
using System.Runtime.InteropServices;
using System.Data.Objects;

namespace CONTROLADORA
{
    public class ControladoraImpresion
    {
        public static MODELO.Impresion BuscarImpresion(string codigo)
        {
            int cod = Convert.ToInt32(codigo);

            MODELO.Impresion oImpresion = MODELO.Contexto.ObtenerInstancia().Impresiones.FirstOrDefault(c => c.Codigo == cod);
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oImpresion); 
            return oImpresion;
        }

        public static List<MODELO.Impresion> ListarImpresiones()
        {
            return MODELO.Contexto.ObtenerInstancia().Impresiones.ToList();
        }

        public static void ImprimirTicketPrueba(string E1, string E2, string E3, string E4, string E5, string P1, string P2, string P3, string P4, string P5)
        {
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.EstiloLetraNormal();
                if (E1 != "")
                {
                    Ticket1.TextoCentroG(E1);
                }
                if (E2 != "")
                {
                    Ticket1.TextoCentroG(E2);
                }
                if (E3 != "")
                {
                    Ticket1.TextoCentroG(E3);
                }
                if (E4 != "")
                {
                    Ticket1.TextoCentroG(E4);
                }
                if (E5 != "")
                {
                    Ticket1.TextoCentroG(E5);
                }

                Ticket1.RenglonVacio();
                Ticket1.RenglonVacio();
                Ticket1.EstiloLetraChica();
                Ticket1.RenglonVacio();
                Ticket1.RenglonVacio();

                if (P1 != "")
                {
                    Ticket1.TextoCentro(P1);
                }
                if (P2 != "")
                {
                    Ticket1.TextoCentro(P2);
                }
                if (P3 != "")
                {
                    Ticket1.TextoCentro(P3);
                }
                if (P4 != "")
                {
                    Ticket1.TextoCentro(P4);
                }
                if (P5 != "")
                {
                    Ticket1.TextoCentro(P5);
                }

                Ticket1.CortaTicket(); // corta el ticket
                Ticket1.EstiloLetraNormal();

        }

        #region MetodosViejos
        public static void ImprimirTicketEntradaOLD(MODELO.Vehiculo oVehiculo)
        {

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon

            Ticket1.TextoCentroG("GARAGE NADIA"); 
            Ticket1.TextoCentroG("Balcarce 440 - Rosario");
            Ticket1.TextoCentroG("TEL: (0341) 153 374371");
            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();

            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");

            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString()+" E");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString()+"   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());

            
           // Ticket1.TextoIzquierda("VEHICULO: "+ oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString() + "        C" + oVehiculo.Clase.Codigo.ToString());
            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.EstiloLetraNormal();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierdaSC("      C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.EstiloLetraChica();

            Ticket1.RenglonVacio();
            Ticket1.LineasGuion();
            Ticket1.TextoCentro("DOMINGOS CERRADO DE 13hs A 20hs");
            Ticket1.LineasGuion();
            Ticket1.CortaTicket(); // corta el ticket
            Ticket1.EstiloLetraNormal();
        }
       
        public static void ImprimirTicketSalidaOLD(MODELO.Vehiculo oVehiculo)
        {

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.TextoCentroG("GARAGE NADIA");
            Ticket1.TextoCentroG("Balcarce 440 - Rosario");
            Ticket1.TextoCentroG("TEL: (0341) 153 374371");
            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();
            Ticket1.TextoCentro("CUIT: 20-10496463-0");
            Ticket1.TextoCentro("RESP. MONOTRIBUTISTA");

            Ticket1.RenglonVacio();
           // Ticket1.LineasGuion();
            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");
           // Ticket1.LineasGuion();


            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " S");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());
            Ticket1.TextoIzquierda("SALIDA:  " + oVehiculo.FechaHoraSalida.Value.ToShortDateString() + "   " + oVehiculo.FechaHoraSalida.Value.ToShortTimeString());

            // Ticket1.TextoIzquierda("VEHICULO: "+ oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString() + "        C" + oVehiculo.Clase.Codigo.ToString());
            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.TextoIzquierdaSC("       C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoCentroGG("$ " + oVehiculo.Precio.ToString());
            Ticket1.RenglonVacio();
            Ticket1.CortaTicket(); // corta el ticket
            Ticket1.EstiloLetraNormal();
        }

        public static void ImprimirTicketClase9OLD(MODELO.Vehiculo oVehiculo)
        {

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.TextoCentroG("GARAGE NADIA");
            Ticket1.TextoCentroG("Balcarce 440 - Rosario");
            Ticket1.TextoCentroG("TEL: (0341) 153 374371");
            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();
            // Ticket1.LineasGuion();
            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");
            // Ticket1.LineasGuion();

            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " E");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());


            // Ticket1.TextoIzquierda("VEHICULO: "+ oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString() + "        C" + oVehiculo.Clase.Codigo.ToString());
            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierdaSC("     C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoCentroGG("$ " + oVehiculo.Precio.ToString());
            
            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierda("VALIDO HASTA: ________________________");

            Ticket1.RenglonVacio();
          //  Ticket1.EstiloLetraChica();
            Ticket1.LineasGuion();
            Ticket1.TextoCentro("DOMINGOS CERRADO DE 13hs A 20hs");
            Ticket1.LineasGuion();
            Ticket1.CortaTicket(); // corta el ticket

            Ticket1.EstiloLetraNormal();

            
        }
        #endregion

        public static void ImprimirTicketEntrada(MODELO.Vehiculo oVehiculo)
        {
            MODELO.Impresion oImpresion = MODELO.Contexto.ObtenerInstancia().Impresiones.FirstOrDefault(x => x.Codigo == 1);
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.EstiloLetraNormal();
            if (oImpresion.Encabezado1 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado1);
            if (oImpresion.Encabezado2 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado2);
            if (oImpresion.Encabezado3 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado3);
            if (oImpresion.Encabezado4 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado4);
            if (oImpresion.Encabezado5 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado5);

            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();

            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");

            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " E");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());

            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.EstiloLetraNormal();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierdaSC("      C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.EstiloLetraChica();

            Ticket1.RenglonVacio();

            if (oImpresion.Pie1 != "")
                Ticket1.TextoCentro(oImpresion.Pie1);
            if (oImpresion.Pie2 != "")
                Ticket1.TextoCentro(oImpresion.Pie2);
            if (oImpresion.Pie3 != "")
                Ticket1.TextoCentro(oImpresion.Pie3);
            if (oImpresion.Pie4 != "")
                Ticket1.TextoCentro(oImpresion.Pie4);
            if (oImpresion.Pie5 != "")
                Ticket1.TextoCentro(oImpresion.Pie5);

            Ticket1.CortaTicket();
            Ticket1.EstiloLetraNormal();
        }

        public static void ImprimirTicketClase9(MODELO.Vehiculo oVehiculo)
        {

            MODELO.Impresion oImpresion = MODELO.Contexto.ObtenerInstancia().Impresiones.FirstOrDefault(x => x.Codigo == 2);
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.EstiloLetraNormal();
            if (oImpresion.Encabezado1 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado1);
            if (oImpresion.Encabezado2 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado2);
            if (oImpresion.Encabezado3 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado3);
            if (oImpresion.Encabezado4 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado4);
            if (oImpresion.Encabezado5 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado5);

            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();

            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");

            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " E");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());


            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierdaSC("     C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoCentroGG("$ " + oVehiculo.Precio.ToString());

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierda("VALIDO HASTA: ________________________");

            Ticket1.RenglonVacio();

            if (oImpresion.Pie1 != "")
                Ticket1.TextoCentro(oImpresion.Pie1);
            if (oImpresion.Pie2 != "")
                Ticket1.TextoCentro(oImpresion.Pie2);
            if (oImpresion.Pie3 != "")
                Ticket1.TextoCentro(oImpresion.Pie3);
            if (oImpresion.Pie4 != "")
                Ticket1.TextoCentro(oImpresion.Pie4);
            if (oImpresion.Pie5 != "")
                Ticket1.TextoCentro(oImpresion.Pie5);

            Ticket1.CortaTicket();
            Ticket1.EstiloLetraNormal();


        }

        public static void ImprimirTicketSalida(MODELO.Vehiculo oVehiculo)
        {

            MODELO.Impresion oImpresion = MODELO.Contexto.ObtenerInstancia().Impresiones.FirstOrDefault(x => x.Codigo == 3);
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.EstiloLetraNormal();
            if (oImpresion.Encabezado1 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado1);
            if (oImpresion.Encabezado2 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado2);
            if (oImpresion.Encabezado3 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado3);
            if (oImpresion.Encabezado4 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado4);
            if (oImpresion.Encabezado5 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado5);

            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraChica();
            Ticket1.TextoCentro("CUIT: 20-10496463-0");
            Ticket1.TextoCentro("RESP. INSCRIPTO");

            Ticket1.RenglonVacio();
            Ticket1.TextoCentro("CONTROL DE HORARIO - USO INTERNO");
            
            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " S");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());
            Ticket1.TextoIzquierda("SALIDA:  " + oVehiculo.FechaHoraSalida.Value.ToShortDateString() + "   " + oVehiculo.FechaHoraSalida.Value.ToShortTimeString());

            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.TextoIzquierdaSC("       C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoCentroGG("$ " + oVehiculo.Precio.ToString());
            Ticket1.RenglonVacio();

            if (oImpresion.Pie1 != "")
                Ticket1.TextoCentro(oImpresion.Pie1);
            if (oImpresion.Pie2 != "")
                Ticket1.TextoCentro(oImpresion.Pie2);
            if (oImpresion.Pie3 != "")
                Ticket1.TextoCentro(oImpresion.Pie3);
            if (oImpresion.Pie4 != "")
                Ticket1.TextoCentro(oImpresion.Pie4);
            if (oImpresion.Pie5 != "")
                Ticket1.TextoCentro(oImpresion.Pie5);

            Ticket1.CortaTicket();
            Ticket1.EstiloLetraNormal();
        }

        public static void ImprimirTicketClase9Duplicado(MODELO.Vehiculo oVehiculo)
        {

            MODELO.Impresion oImpresion = MODELO.Contexto.ObtenerInstancia().Impresiones.FirstOrDefault(x => x.Codigo == 4);
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.EstiloLetraNormal();
            if (oImpresion.Encabezado1 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado1);
            if (oImpresion.Encabezado2 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado2);
            if (oImpresion.Encabezado3 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado3);
            if (oImpresion.Encabezado4 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado4);
            if (oImpresion.Encabezado5 != "")
                Ticket1.TextoCentroG(oImpresion.Encabezado5);
            
            Ticket1.EstiloLetraChica();
            Ticket1.RenglonVacio();
            Ticket1.TextoCentro("** ** DUPLICADO DE ESTADIAS ** **");
            Ticket1.RenglonVacio();

            Ticket1.TextoIzquierda("TICKET #" + oVehiculo.NroTicket.ToString() + " E");
            Ticket1.TextoIzquierda("ENTRADA: " + oVehiculo.FechaHoraEntrada.ToShortDateString() + "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString());

            Ticket1.TextoIzquierdaSC("VEHICULO: ");
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoIzquierdaSC(oVehiculo.DuplicadoNro.ToString() + "-" + oVehiculo.Patente.ToString());
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierdaSC("     C" + oVehiculo.Clase.Codigo.ToString() + "\n");

            Ticket1.RenglonVacio();
            Ticket1.TextoIzquierdaSC("TEL: " + oVehiculo.Telefono + "\n");

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraNegritaF();
            Ticket1.TextoCentroGG("$ " + oVehiculo.Precio.ToString());

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraChica();
            Ticket1.TextoIzquierda("VALIDO HASTA: ________________________");

            if (oImpresion.Pie1 != "")
                Ticket1.TextoCentro(oImpresion.Pie1);
            if (oImpresion.Pie2 != "")
                Ticket1.TextoCentro(oImpresion.Pie2);
            if (oImpresion.Pie3 != "")
                Ticket1.TextoCentro(oImpresion.Pie3);
            if (oImpresion.Pie4 != "")
                Ticket1.TextoCentro(oImpresion.Pie4);
            if (oImpresion.Pie5 != "")
                Ticket1.TextoCentro(oImpresion.Pie5);

            Ticket1.CortaTicket(); // corta el ticket

            Ticket1.EstiloLetraNormal();

        }


        public static void ImprimirVehiculosActivos(List<MODELO.Vehiculo> oVehiculos)
        {
            int cantidad = oVehiculos.Count;

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.EstiloLetraNormal();
            Ticket1.TextoCentroG("VEHICULOS EN PLAYA");
            Ticket1.TextoCentroG(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraGrande();
            Ticket1.TextoIzquierda("CL  DIA   HORA    PAT    NOTAS");
            Ticket1.TextoIzquierda("-------------------------------");


            for (int i=0; i < cantidad; i++)
            {
                Ticket1.TextoIzquierda(oVehiculos[i].Clase.Codigo.ToString() + "  " + oVehiculos[i].ImprimeFechaE() + "  " + oVehiculos[i].ImprimeHoraE() + "  " + oVehiculos[i].DuplicadoNro + "-" + oVehiculos[i].Patente + "\n");
            }
            Ticket1.EstiloLetraNormal();
            Ticket1.CortaTicket(); // corta el ticket

        }



        public static void ImprimirEstadiasActivas(List<MODELO.Vehiculo> oVehiculos)
        {
            int cantidad = oVehiculos.Count;

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.EstiloLetraNormal();
            Ticket1.TextoCentroG("ESTADIAS EN PLAYA");
            Ticket1.TextoCentroG(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraGrande();
            Ticket1.TextoIzquierda("CL  DIA   HORA    PAT    NOTAS");
            Ticket1.TextoIzquierda("-------------------------------");


            for (int i = 0; i < cantidad; i++)
            {
                Ticket1.EstiloLetraGrande();
                Ticket1.TextoIzquierda(oVehiculos[i].Clase.Codigo.ToString() + "  " + oVehiculos[i].ImprimeFechaE() + "  " + oVehiculos[i].ImprimeHoraE() + "  " + oVehiculos[i].DuplicadoNro + "-" + oVehiculos[i].Patente + "\n");
                Ticket1.EstiloLetraNormal();
                Ticket1.TextoIzquierda("TE: " + oVehiculos[i].Telefono + "\n");
            }
            Ticket1.EstiloLetraNormal();
            Ticket1.CortaTicket(); // corta el ticket

        }


        public static void ImprimirMovimientosCaja(List<MODELO.Vehiculo> oVehiculos, List<MODELO.Vehiculo> oVehiculosC9, MODELO.Caja oCaja)
        {
            int cantidad = oVehiculos.Count;

            int cantidadC9 = oVehiculosC9.Count;

            int cantidadPagosM = oCaja.PagoMensual.Count;
            int cantidadDesc = oCaja.Descuento.Count;


            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.EstiloLetraNormal();
            Ticket1.TextoCentroG("** MOV DE CAJA # "+oCaja.NroCaja+" **");
            Ticket1.TextoCentroG(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            Ticket1.RenglonVacio();

                for (int i = 0; i < cantidadC9; i++)
                {
                    Ticket1.TextoIzquierda("C" + oVehiculosC9[i].Clase.Codigo.ToString() + "   " + oVehiculosC9[i].DuplicadoNro.ToString() + "-" + oVehiculosC9[i].Patente.ToString() + "  >$" + oVehiculosC9[i].Precio.ToString() + "< Cj#" + oVehiculosC9[i].Caja.Id.ToString());
                    Ticket1.TextoIzquierda(oVehiculosC9[i].ImprimeFechaE() + "  " + oVehiculosC9[i].ImprimeHoraE() + "      " + oVehiculosC9[i].ImprimeFechaS() + "  " + oVehiculosC9[i].ImprimeHoraS() + "\n");
                }
                for (int j = 0; j < cantidad; j++)
                {
                    Ticket1.TextoIzquierda("C" + oVehiculos[j].Clase.Codigo.ToString() + "   " + oVehiculos[j].DuplicadoNro + "-" + oVehiculos[j].Patente + "   $" + oVehiculos[j].Precio.ToString());
                    Ticket1.TextoIzquierda(oVehiculos[j].ImprimeFechaE() + "  " + oVehiculos[j].ImprimeHoraE() + "      " + oVehiculos[j].ImprimeFechaS() + "  " + oVehiculos[j].ImprimeHoraS() + "\n");
                }
                for (int k = 0; k < cantidadPagosM; k++)
                {
                    Ticket1.TextoIzquierda("C" + oCaja.PagoMensual.ElementAt(k).Mensual.NombreApellido.ToString());
                    Ticket1.TextoIzquierda("$" + oCaja.PagoMensual.ElementAt(k).Monto.ToString() + "  Mes:" + oCaja.PagoMensual.ElementAt(k).MesSaldado.ToString() + "  " + oCaja.PagoMensual.ElementAt(k).ImprimeFecha() + "  " + oCaja.PagoMensual.ElementAt(k).ImprimeHora() + "\n");
                }

            Ticket1.RenglonVacio();

            Ticket1.EstiloLetraGrande();
            Ticket1.TextoCentroG("$" + oCaja.Total.ToString());
            Ticket1.EstiloLetraNormal();
            Ticket1.RenglonVacio();
            Ticket1.TextoIzquierda("DESCUENTOS");
            for (int l = 0; l < cantidadDesc; l++)
            {
                Ticket1.TextoIzquierda("($" + oCaja.Descuento.ElementAt(l).Monto.ToString() + ")  _______________");
                Ticket1.RenglonVacio();
            }

            Ticket1.EstiloLetraGrande();
            Ticket1.TextoCentroG("TOTAL: $" + oCaja.TotalNeto.ToString());
            Ticket1.EstiloLetraNormal();
            Ticket1.RenglonVacio();
            
            Ticket1.CortaTicket(); // corta el ticket
             
        }

        public static void ImprimirCierreCaja(List<MODELO.Vehiculo> oVehiculos, List<MODELO.Vehiculo> oVehiculosC9, MODELO.Caja oCaja)
        {
            int cantidad = oVehiculos.Count;

            int cantidadC9 = oVehiculosC9.Count;

            int cantidadPagosM = oCaja.PagoMensual.Count;
            int cantidadDesc = oCaja.Descuento.Count;

            CreaTicket Ticket1 = new CreaTicket();
            //Ticket1.AbreCajon();  //abre el cajon
            Ticket1.EstiloLetraNormal();
            Ticket1.TextoCentroG("** MOV DE CAJA # " + oCaja.NroCaja + " **");
            Ticket1.TextoCentroG(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            Ticket1.RenglonVacio();

            for (int i = 0; i < cantidadC9; i++)
            {
                Ticket1.TextoIzquierda("C" + oVehiculosC9[i].Clase.Codigo.ToString() + "   " + oVehiculosC9[i].DuplicadoNro.ToString() + "-" + oVehiculosC9[i].Patente.ToString() + "  >$" + oVehiculosC9[i].Precio.ToString() + "< Cj#" + oVehiculosC9[i].Caja.Id.ToString());
                Ticket1.TextoIzquierda(oVehiculosC9[i].ImprimeFechaE() + "  " + oVehiculosC9[i].ImprimeHoraE() + "      " + oVehiculosC9[i].ImprimeFechaS() + "  " + oVehiculosC9[i].ImprimeHoraS() + "\n");
            }
            for (int j = 0; j < cantidad; j++)
            {
                Ticket1.TextoIzquierda("C" + oVehiculos[j].Clase.Codigo.ToString() + "   " + oVehiculos[j].DuplicadoNro + "-" + oVehiculos[j].Patente + "   $" + oVehiculos[j].Precio.ToString());
                Ticket1.TextoIzquierda(oVehiculos[j].ImprimeFechaE() + "  " + oVehiculos[j].ImprimeHoraE() + "      " + oVehiculos[j].ImprimeFechaS() + "  " + oVehiculos[j].ImprimeHoraS() + "\n");
            }
            for (int k = 0; k < cantidadPagosM; k++)
            {
                Ticket1.TextoIzquierda("C" + oCaja.PagoMensual.ElementAt(k).Mensual.NombreApellido.ToString());
                Ticket1.TextoIzquierda("$" + oCaja.PagoMensual.ElementAt(k).Monto.ToString() + "  Mes:" + oCaja.PagoMensual.ElementAt(k).MesSaldado.ToString() + "  " + oCaja.PagoMensual.ElementAt(k).ImprimeFecha() + "  " + oCaja.PagoMensual.ElementAt(k).ImprimeHora() + "\n");
            }

            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraGrande();
            Ticket1.TextoCentroG("$" + oCaja.Total.ToString());
            Ticket1.EstiloLetraNormal();
            Ticket1.RenglonVacio();
            Ticket1.TextoIzquierda("DESCUENTOS");
            for (int l = 0; l < cantidadDesc; l++)
            {
                Ticket1.TextoIzquierda("($" + oCaja.Descuento.ElementAt(l).Monto.ToString() + ")  _______________");
                Ticket1.RenglonVacio();
            }

            Ticket1.EstiloLetraGrande();
            Ticket1.TextoCentroG("TOTAL: $" + oCaja.TotalNeto.ToString());
            Ticket1.EstiloLetraNormal();
            Ticket1.RenglonVacio();
            Ticket1.RenglonVacio();
            Ticket1.TextoCentroG("-------------------------------");
            Ticket1.TextoCentroG("** CERRANDO CAJA # " + oCaja.NroCaja + " **");
            Ticket1.RenglonVacio();
            Ticket1.TextoIzquierda("F. APERT.: " + oCaja.FechaHoraApertura.Value.ToShortDateString() + " " + oCaja.FechaHoraApertura.Value.ToShortTimeString());
            Ticket1.TextoIzquierda("F. CIERRE: " + oCaja.FechaHoraCierre.Value.ToShortDateString() + " " + oCaja.FechaHoraCierre.Value.ToShortTimeString());
            Ticket1.RenglonVacio();
            Ticket1.EstiloLetraGrande();
            Ticket1.TextoCentroG("TOTAL:  $" + oCaja.TotalNeto.ToString());
            Ticket1.EstiloLetraNormal();
            Ticket1.RenglonVacio();
            Ticket1.TextoCentroG("** ABRIENDO CAJA # " + (ControladoraSistema.Sistema().NumeracionCajas) + " **");
            Ticket1.TextoCentroG("-------------------------------");



            Ticket1.CortaTicket(); // corta el ticket

        }





        #region Clase para generar ticket
        // La clase "CreaTicket" tiene varios metodos para imprimir con diferentes formatos (izquierda, derecha, centrado, desripcion precio,etc), a
        // continuacion se muestra el metodo con ejemplo de parametro que acepta, longitud maxima y un ejemplo de como imprimira, esta clase esta
        // basada en una impresora Epson de matriz de puntos con impresion maxima de 40 caracteres por renglon
        // METODO                                      MAX_LONG                        EJEMPLOS
        //--------------------------------------------------------------------------------------------------------------------------
        // TextoIzquierda("Empleado 1")                    40                      Empleado 1      
        // TextoDerecha("Caja 1")                          40                                                        Caja 1
        // TextoCentro("Ticket")                           40                                         Ticket   
        // TextoExtremos("Fecha 6/1/2011","Hora:13:25")     18 y 18                 Fecha 6/1/2011                Hora:13:25
        // EncabezadoVenta()                                n/a                     Articulo        Can    P.Unit    Importe
        // LineasGuion()                                    n/a                     ----------------------------------------
        // AgregaArticulo("Aspirina","2",45.25,90.5)        16,3,10,11              Aspirina          2    $45.25     $90.50
        // LineasTotales()                                  n/a                                                ----------
        // AgregaTotales("Subtotal",235.25)                 25 y 15                Subtotal                         $235.25
        // LineasAsterisco()                                n/a                     ****************************************
        // LineasIgual()                                    n/a                     ========================================
        // CortaTicket()
        // AbreCajon()
        public class CreaTicket
        {
            string ticket = "";
            string parte1, parte2;
            string impresora = MODELO.Contexto.ObtenerInstancia().Sistemas.FirstOrDefault().NombreImpresora; //"EPSON TM-T88V Receipt"; // nombre exacto de la impresora como esta en el panel de control
           // string impresora = "Microsoft XPS Document Writer"; // nombre exacto de la impresora como esta en el panel de control
           
            
            int max, cort;

            public void LineasGuion()
            {
                ticket = "------------------------------------------\n";   // agrega lineas separadoras -
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
            }

            public void RenglonVacio()
            {
                ticket = "\n";   // agrega renglon en blanco
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
            }

            public void LineasAsterisco()
            {
                ticket = "****************************************\n";   // agrega lineas separadoras *
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
            }
            public void LineasIgual()
            {
                ticket = "========================================\n";   // agrega lineas separadoras =
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
            }
            public void LineasTotales()
            {
                ticket = "                             -----------\n"; ;   // agrega lineas de total
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime linea
            }
            public void EncabezadoTicketEntrada()
            {
                ticket = "C     Vehiculo           Fecha y Hora\n";   // agrega lineas de  encabezados
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            public void EncabezadoTicketSalida()
            {
                ticket = "Vehiculo   HoraE    HoraS    Importe\n";   // agrega lineas de  encabezados
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void EncabezadoListadoVehiculos()
            {
                ticket = "Vehiculo   HoraE    HoraS    Importe\n";   // agrega lineas de  encabezados
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void TextoIzquierdaGG(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > 20)                                 // **********
                {
                    cort = max - 20;
                    parte1 = par1.Remove(20, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void TextoIzquierdaSC(string par1)                          // agrega texto a la izquierda
            {
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void TextoDerecha(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
                for (int i = 0; i < max; i++)
                {
                    ticket += " ";                          // agrega espacios para alinear a la derecha
                }
                ticket += parte1 + "\n";                    //Agrega el texto
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            public void TextoCentro(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)                                 // **********
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********
                ticket += parte1 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            public void TextoCentroG(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 31)                                 // **********
                {
                    cort = max - 31;
                    parte1 = par1.Remove(31, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(31 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********
                ticket += parte1 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void TextoCentroGG(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 31)                                 // **********
                {
                    cort = max - 20;
                    parte1 = par1.Remove(20, cort);          // si es mayor que 40 caracteres, lo corta
                }
                else { parte1 = par1; }                      // **********
                max = (int)(20 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios antes del texto a centrar
                }                                            // **********
                ticket += parte1 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void TextoExtremos(string par1, string par2)
            {
                max = par1.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega el primer parametro
                max = par2.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
                }
                else { parte2 = par2; }
                max = 40 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                 // **********
                {
                    ticket += " ";                            // Agrega espacios para poner par2 al final
                }                                             // **********
                ticket += parte2 + "\n";                     // agrega el segundo parametro al final
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }
            public void AgregaTotales(string par1, double total)
            {
                max = par1.Length;
                if (max > 25)                                 // **********
                {
                    cort = max - 25;
                    parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;
                parte2 = total.ToString("c");
                max = 40 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                // **********
                {
                    ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
                }                                            // **********
                ticket += parte2 + "\n";
                RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
            }

            public void EntradaVehiculo(MODELO.Vehiculo oVehiculo)
            {
                if (oVehiculo.Patente.ToString().Length <= 3 && oVehiculo.DuplicadoNro.ToString().Length <= 2) // valida que cant precio y total esten dentro de rango
                {
                    ticket += "Entrada: "+oVehiculo.FechaHoraEntrada.ToShortDateString();
                    ticket += "   " + oVehiculo.FechaHoraEntrada.ToShortTimeString();
                    ticket += "\n";

                    ticket += "Vehiculo: ";
                    ticket = oVehiculo.DuplicadoNro.ToString();
                    ticket += "-";
                    ticket += oVehiculo.Patente.ToString();

                    ticket += "        ";

                    ticket = oVehiculo.Clase.Codigo.ToString();
                    ticket += "\n";
                    RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
                }
                else
                {
                    MessageBox.Show("Valores fuera de rango");
                    RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
                }
            }

            public void AgregaArticulo(string par1, string horae, string horas, double total)
            {
                if (horae.ToString().Length <= 5 && horas.ToString().Length <= 5 && total.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
                {
                    max = par1.Length;
                    if (max > 16)                                 // **********
                    {
                        cort = max - 16;
                        parte1 = par1.Remove(16, cort);          // corta a 16 la descripcion del articulo
                    }
                    else { parte1 = par1; }                      // **********
                    ticket = parte1;                             // agrega articulo
                    max = (3 - horae.ToString().Length) + (16 - parte1.Length);
                    for (int i = 0; i < max; i++)                // **********
                    {
                        ticket += " ";                           // Agrega espacios para poner el valor de cantidad
                    }
                    ticket += horae.ToString();                   // agrega cantidad
                    max = 10 - (horas.ToString().Length);
                    for (int i = 0; i < max; i++)                // **********
                    {
                        ticket += " ";                           // Agrega espacios
                    }                                            // **********
                    ticket += horas.ToString(); // agrega precio
                    max = 11 - (total.ToString().Length);
                    for (int i = 0; i < max; i++)                // **********
                    {
                        ticket += " ";                           // Agrega espacios
                    }                                            // **********
                    ticket += total.ToString("c") + "\n"; // agrega precio
                    RawPrinterHelper.SendStringToPrinter(impresora, ticket); // imprime texto
                }
                else
                {
                    MessageBox.Show("Valores fuera de rango");
                    RawPrinterHelper.SendStringToPrinter(impresora, "Error, valor fuera de rango\n"); // imprime texto
                }
            }
            public void CortarPapel()
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)105);
                sequence.Append((char)0);
                sequence.Append((char)25);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void EstiloLetraNormal() //COMUN
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)0);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            
            public void EstiloLetraChica() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)1);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void EstiloLetraNegritaF() //NEGRITA FUERTE
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)128);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void EstiloLetraNegritaS() //NEGRITA SUAVE
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)32);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void EstiloLetraGrande() //GRANDE
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)16);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo2() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)2);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo3() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)3);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo4() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)4);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo5() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)5);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }
            public void Estilo6() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)6);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }
            public void Estilo7() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)7);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }
            public void Estilo8() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)33);
                sequence.Append((char)8);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo9() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)14);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo10() //NEGRITA
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)15);

                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo11() //COMUN
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)18);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }

            public void Estilo12() //CHICO
            {
                StringBuilder sequence = new StringBuilder();
                sequence.Append((char)27);
                sequence.Append((char)71);
                string a = sequence.ToString();
                RawPrinterHelper.SendStringToPrinter(impresora, a); // corta
            }




            public void CortaTicket()
            {
                string corte = "\x1B" + "m";                  // caracteres de corte
                string avance = "\x1B" + "d" + "\x05";        // avanza 5 renglones
                RawPrinterHelper.SendStringToPrinter(impresora, avance); // avanza
                RawPrinterHelper.SendStringToPrinter(impresora, corte); // corta
            }
            public void AbreCajon()
            {
                string cajon0 = "\x1B" + "p" + "\x00" + "\x0F" + "\x96";                  // caracteres de apertura cajon 0
                string cajon1 = "\x1B" + "p" + "\x01" + "\x0F" + "\x96";                 // caracteres de apertura cajon 1
                RawPrinterHelper.SendStringToPrinter(impresora, cajon0); // abre cajon0
                //RawPrinterHelper.SendStringToPrinter(impresora, cajon1); // abre cajon1
            }
        }
        #endregion
        #region Clase para enviar a imprsora texto plano
        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "My C#.NET RAW Document";
                di.pDataType = "RAW";

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
        #endregion


    }







}
