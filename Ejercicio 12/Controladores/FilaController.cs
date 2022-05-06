using Ejercicio_12.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12.Controladores
{
    internal class FilaController
    {
        private Fila fila;        
        private bool diaCero = true;
        private string[] filaString;


        public FilaController(int prod, int costo, int precio, int costoMulta, int costoPermiso)
        {
            this.fila = new Fila( prod, costo, precio, costoMulta, costoPermiso );
        }

        public string[] siguienteFila()
        {            

            if ( diaCero )
            {
                diaCero = false;

                filaString = new string[] { fila.Reloj.ToString(), "", "" , "", "", "", "", fila.VendidasAc.ToString(), "",
                fila.SurtidasAc.ToString(), "", fila.UtilidadAc.ToString(), "", "" , fila.UtilidadPermisoAc.ToString() };
                
                return filaString;
            }
            else
            {
                fila.siguienteFila();

                filaString = new string[] { fila.Reloj.ToString(), fila.RndDemanda.ToString(), fila.Demanda.ToString(), fila.ProbabilidadMulta.ToString(), fila.RndMulta.ToString(),
                fila.Multa.ToString(), fila.Vendidas.ToString(), fila.VendidasAc.ToString(), fila.Surtidas.ToString(), fila.SurtidasAc.ToString(), fila.Utilidad.ToString(),
                fila.UtilidadAc.ToString(), fila.Permiso.ToString(), fila.UtilidadConPermiso.ToString(), fila.UtilidadPermisoAc.ToString() };

                return filaString;

            }

        }

       public double calcularPromedioVendidas()
        {
            double promedioVendidas = (double)fila.VendidasAc / fila.Reloj;
            return Math.Truncate(promedioVendidas * 100) / 100;
        }

        public double calcularPromedioSurtidas()
        {
            double promedioSurtidas = (double)fila.SurtidasAc / fila.Reloj;
            return Math.Truncate(promedioSurtidas * 100) / 100;
        }

        public double calcularPromedioUtilidad()
        {
            double promedioUtilidadPermiso = (double)fila.UtilidadAc / fila.Reloj;
            return Math.Truncate(promedioUtilidadPermiso * 100) / 100;
        }

        public double calcularPromedioUtilidadPermiso()
        {
            double promedioUtilidadPermiso = (double)fila.UtilidadPermisoAc / fila.Reloj;
            return Math.Truncate(promedioUtilidadPermiso * 100) / 100;
        }

    }
}
