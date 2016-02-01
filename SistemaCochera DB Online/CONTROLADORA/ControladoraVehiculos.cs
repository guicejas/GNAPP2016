using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Objects;

namespace CONTROLADORA
{
    public class ControladoraVehiculos
    {

        public static void AgregarVehiculo(MODELO.Vehiculo oVehiculo)
        {
            MODELO.Contexto.ObtenerInstancia().AddToVehiculos(oVehiculo);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
            MODELO.Contexto.ObtenerInstancia().DetectChanges();

          //  oVehiculo.NroTicket = oVehiculo.id;
        }
        public static void EliminarVehiculo(MODELO.Vehiculo oVehiculo)
        {
            MODELO.Contexto.ObtenerInstancia().DeleteObject(oVehiculo);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
        }
        public static void ModificarVehiculo(MODELO.Vehiculo oVehiculo)
        {
            MODELO.Contexto.ObtenerInstancia().Vehiculos.ApplyCurrentValues(oVehiculo);
            MODELO.Contexto.ObtenerInstancia().SaveChanges();
         
        }
        public static List<MODELO.Vehiculo> ListarVehiculos()
        {
            //var refreshableObjects = (from entry in MODELO.Contexto.ObtenerInstancia().ObjectStateManager.GetObjectStateEntries(
            //         EntityState.Added
            //        | EntityState.Deleted
            //        | EntityState.Modified
            //        | EntityState.Unchanged)
            //                          where entry.EntityKey != null
            //                          select entry.Entity).ToList();

            //MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList());

            List<MODELO.Vehiculo> lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.OrderByDescending(c => c.id).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }
        public static List<MODELO.Vehiculo> ListarVehiculosActivos()
        {
            List<MODELO.Vehiculo> lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Estado == "Activo").OrderBy(c => c.Patente).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static List<MODELO.Vehiculo> ListarEstadiasActivas()
        {
            List<MODELO.Vehiculo> lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Estado == "Activo").Where(v => v.Clase.Codigo == "9").OrderBy(c => c.Patente).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static List<MODELO.Vehiculo> ListarVehiculosCajaActiva(MODELO.Caja oCaja)
        {
            List<MODELO.Vehiculo> lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Caja.Id == oCaja.Id).OrderBy(c => c.FechaHoraSalida).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static List<MODELO.PagoMensual> ListarPagosMensualesCajaActiva(MODELO.Caja oCaja)
        {
            List<MODELO.PagoMensual> lista = MODELO.Contexto.ObtenerInstancia().PagoMensuales.Where(v => v.Caja.Id == oCaja.Id).ToList();
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, lista);
            return lista;
        }

        public static List<MODELO.Vehiculo> ListarVehiculosSalidaClase9(MODELO.Caja oCaja)
        {
            List<MODELO.Vehiculo> lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Clase.Codigo == "9").Where(z=>z.FechaHoraSalida > oCaja.FechaHoraApertura).Where(x => x.Caja.Id != oCaja.Id).OrderBy(c => c.FechaHoraSalida).ToList();
            return lista;
        
        }

        public static MODELO.Vehiculo VerificarVehiculo(string vehiculoID)
        {
            vehiculoID = vehiculoID.Remove(1, 1);

            List<MODELO.Vehiculo> Lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Estado == "Activo").ToList();
            if (Lista.Count > 0)
            {
                List<MODELO.Vehiculo> ListaACT = Lista.Where(v => v.DuplicadoNro + v.Patente == vehiculoID).ToList();
                if (ListaACT.Count > 0)
                {
                    return ListaACT[0];
                }
                return null;
            }
            return null;
        }

        public static void GenerarEntradaVehiculo(MODELO.Vehiculo oVehiculo)
        {
            int i = 1;
            bool ok = false;


            List<MODELO.Vehiculo> Lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Estado == "Activo").ToList();
            if (Lista.Count > 0)
            {
                List<MODELO.Vehiculo> AutosDupl = Lista.Where(v => v.Patente == oVehiculo.Patente).ToList();

                if (AutosDupl.Count > 0)
                {
                    while (ok==false)
                    {
                        if (AutosDupl.Exists(v => v.DuplicadoNro == i.ToString()) == false)
                        {
                            oVehiculo.DuplicadoNro = i.ToString();
                            ok = true;
                        }
                        else
                        { 
                            i++;
                        }
                    }
                }
                else
                {
                    oVehiculo.DuplicadoNro = "1";
                }
            }

            AgregarVehiculo(oVehiculo);

        }

        public static void GenerarSalidaVehiculo(MODELO.Vehiculo oVehiculo)
        {
            oVehiculo.Estado = "Inactivo";
            ModificarVehiculo(oVehiculo);

        }


        public static int CantAutosActivos()
        {
            List<MODELO.Vehiculo> Lista = MODELO.Contexto.ObtenerInstancia().Vehiculos.Where(v => v.Estado == "Activo").ToList();
            return Lista.Count;
        }


        public static List<MODELO.Vehiculo> ListarVehiculosFiltrados(string Patente, string nroTicket, string estado, string clase, string nroCaja, object EntradaDeste, object EntradaHasta, object SalidaDesde, object SalidaHasta)
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();

            if (Patente != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Patente == Patente).ToList();
            if (nroTicket != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.NroTicket.ToString() == nroTicket).ToList();
            if (estado != "Todos")
                Filtrado = Filtrado.Where(oVeh => oVeh.Estado == estado).ToList();

            if (clase != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Clase.Codigo == clase).ToList();

            if (nroCaja != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Caja != null).Where(oVeh => oVeh.Caja.NroCaja.Value.ToString().Contains(nroCaja)).ToList();

            if (EntradaDeste != null && EntradaHasta != null)
            {
                Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraEntrada.Date >= Convert.ToDateTime(EntradaDeste)).ToList();
                Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraEntrada.Date <= Convert.ToDateTime(EntradaHasta)).ToList();
            }

            if (SalidaDesde != null && SalidaHasta != null)
            {
                Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraSalida != null).Where(oVeh => oVeh.FechaHoraSalida.Value.Date >= Convert.ToDateTime(SalidaDesde)).ToList();
                Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraSalida != null).Where(oVeh => oVeh.FechaHoraSalida.Value.Date <= Convert.ToDateTime(SalidaHasta)).ToList();
            }

            return Filtrado;
        }

        public static int CantidadAutosActivos()
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();
            List<MODELO.Vehiculo> Lista = Filtrado.Where(v => v.Estado == "Activo").Where(v => v.Clase.Descripcion.IndexOf("AUTO", System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return Lista.Count;
        }

        public static int CantidadChatasActivos()
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();
            List<MODELO.Vehiculo> Lista = Filtrado.Where(v => v.Estado == "Activo").Where(v => v.Clase.Descripcion.IndexOf("CHATA", System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return Lista.Count;
        }

        public static int CantidadMotosActivos()
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();
            List<MODELO.Vehiculo> Lista = Filtrado.Where(v => v.Estado == "Activo").Where(v => v.Clase.Descripcion.IndexOf("MOTO", System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return Lista.Count;
        }

        public static int CantidadOtrosActivos()
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();
            List<MODELO.Vehiculo> Lista = Filtrado.Where(v => v.Estado == "Activo").Where(v => v.Clase.Descripcion.IndexOf("AUTO", System.StringComparison.OrdinalIgnoreCase) < 0).Where(v => v.Clase.Descripcion.IndexOf("CHATA", System.StringComparison.OrdinalIgnoreCase) < 0).Where(v => v.Clase.Descripcion.IndexOf("MOTO", System.StringComparison.OrdinalIgnoreCase) < 0).Where(v => v.Clase.Descripcion.IndexOf("ESTADIA", System.StringComparison.OrdinalIgnoreCase) < 0).ToList();
            return Lista.Count;
        }

        public static int CantidadEstadiasActivos()
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList();
            List<MODELO.Vehiculo> Lista = Filtrado.Where(v => v.Estado == "Activo").Where(v => v.Clase.Descripcion.IndexOf("ESTADIA", System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return Lista.Count;
        }


        public static List<MODELO.Vehiculo> ListarVehiculosFiltrados(string Patente, string estado, string clase, string Entrada, string Salida,string nroCaja)
        {
            List<MODELO.Vehiculo> Filtrado = MODELO.Contexto.ObtenerInstancia().Vehiculos.OrderByDescending(c => c.id).ToList();

            if (Patente != "")
                Filtrado = Filtrado.Where(v => v.DuplicadoPatente.IndexOf(Patente, System.StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (estado != "TODOS")
                Filtrado = Filtrado.Where(oVeh => oVeh.Estado == estado).ToList();

            if (clase != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Clase.Codigo == clase).ToList();

            if (nroCaja != "")
                Filtrado = Filtrado.Where(oVeh => oVeh.Caja != null).Where(oVeh => oVeh.Caja.NroCaja.Value.ToString().Contains(nroCaja)).ToList();

            if (Entrada != "")
            {
                try
                {
                    Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraEntrada.Date == Convert.ToDateTime(Entrada)).ToList();
                }
                catch
                { }
            }

            if (Salida != "")
            {
                try
                {
                    Filtrado = Filtrado.Where(oVeh => oVeh.FechaHoraSalida != null).Where(oVeh => oVeh.FechaHoraSalida.Value.Date >= Convert.ToDateTime(Salida)).ToList();
                }
                catch
                { }
            }


            return Filtrado;
        }

        public static int ActualizarDatosModelo()
        {
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, MODELO.Contexto.ObtenerInstancia().Vehiculos.ToList());
            return 1;
        }

        public static int ActualizarDatosModelo(MODELO.Vehiculo oVehiculo)
        {
            MODELO.Contexto.ObtenerInstancia().Refresh(RefreshMode.StoreWins, oVehiculo);
            return 1;
        }

    }
}
