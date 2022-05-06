using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12.Clases
{
    internal class Fila
    {
        //Tabla de probabilidades para la demanda
        private double[,] probDemanda = { { 10, 0.1 }, { 20, 0.3 }, { 25, 0.7 }, { 30, 0.8 }, { 50, 0.9 }, { 70, 0.95 }, { 100, 1 } };

        // Valores fijos del dominio
        private int produccion, costo, precio, costoMulta, costoPermiso;

        //Valores a calcular
        private int reloj = 0, demanda, multa, vendidas, vendidasAc = 0, surtidas, surtidasAc = 0, utilidad, utilidadAc = 0, permiso, utilidadConPermiso, utilidadPermisoAc = 0;
        private double rndDemanda, rndMulta, probabilidadMulta;

        public int Reloj { get { return reloj; } set { reloj = value; } }
        public int Demanda { get { return demanda; } set { demanda = value; } }
        public int Multa { get { return multa; } set { multa = value; } }
        public int Vendidas { get { return vendidas; } set { vendidas = value; } }
        public int VendidasAc { get { return vendidasAc; } set { vendidasAc = value; } }
        public int Surtidas { get { return surtidas; } set { surtidas = value; } }
        public int SurtidasAc { get { return surtidasAc; } set { surtidasAc = value; } }
        public int Utilidad { get { return utilidad; } set { utilidad = value; } }
        public int UtilidadAc { get { return utilidadAc; } set { utilidadAc = value; } }
        public int Permiso { get { return permiso; } set { permiso = value; } }
        public int UtilidadConPermiso { get { return utilidadConPermiso; } set { utilidadConPermiso = value; } }
        public int UtilidadPermisoAc { get { return utilidadPermisoAc; } set { utilidadPermisoAc = value; } }
        public double RndDemanda { get { return rndDemanda; } set { rndDemanda = value; } }
        public double ProbabilidadMulta { get { return probabilidadMulta; } set { probabilidadMulta = value; } }
        public double RndMulta { get { return rndMulta; } set { rndMulta = value; } }

        
        private Fila filaAnterior;
        public Fila FilaAnterior { get { return filaAnterior; } set { filaAnterior = value; } }

        
        private Random random = new Random();


        public Fila( int produccion, int costo, int precio, int costoMulta, int costoPermiso)
        {
            this.produccion = produccion;
            this.costo = costo;
            this.precio = precio;
            this.costoMulta = costoMulta;
            this.costoPermiso = costoPermiso;
            
        }
        
        private void calcularDemanda()
        {
            rndDemanda = Math.Truncate(100 * random.NextDouble()) / 100;
            for(int i = 0; i < probDemanda.Length; i++)
            {
                if (rndDemanda < probDemanda[i, 1])
                {
                    demanda = Int32.Parse(probDemanda[i, 0].ToString());
                    break;
                }
            }
        }

        private void calcularMulta()
        {
            double rnd = random.NextDouble();
            probabilidadMulta =Math.Truncate(100 * (0.2 + rnd * (0.4 - 0.2))) / 100;

            rndMulta = Math.Truncate(100 * random.NextDouble()) / 100;

            if (rndMulta < probabilidadMulta) 
            {
                multa = this.costoMulta;
                rndMulta = 0;

            }
            else
            {
                multa = 0;
            }
                        
        }

        private void calcularVendidasYSurtidas()
        {
            if (demanda < produccion)
            {
                vendidas = demanda;                
            }
            else
            {
                vendidas = produccion;                 
            }
            surtidas = produccion - vendidas;
        }

        private void calcularUtilidad()
        {
            utilidad = vendidas * precio - costo * produccion - multa;
            
        }

        private void calcularUtilidadConPermiso()
        {
            calcularPermiso();
            utilidadConPermiso = vendidas * precio - costo * produccion - permiso;
        }

        private void calcularPermiso()
        {
            if (filaAnterior.reloj % 7 == 0) 
            { 
                permiso = costoPermiso; 
            }
            else
            {
                permiso = 0;
            }
        }

        private void calcularAcumuladores()
        {
            vendidasAc = filaAnterior.vendidasAc + vendidas;
            surtidasAc = filaAnterior.surtidasAc + surtidas;
            utilidadAc = filaAnterior.utilidadAc + utilidad;
            utilidadPermisoAc = filaAnterior.utilidadPermisoAc + utilidadConPermiso;
        }

        private Fila duplicarFila()
        {
            return (Fila)this.MemberwiseClone();
        }

        public Fila siguienteFila()
        {
            filaAnterior = duplicarFila();

            reloj++;
            calcularDemanda();

            if (demanda < produccion)
            {
                calcularMulta();
            } 
            else 
            {
                probabilidadMulta = 0; 
                rndMulta = 0;
            }
            
            calcularVendidasYSurtidas();
            calcularUtilidad();
            calcularUtilidadConPermiso();
            calcularAcumuladores();

            return this;

        }

    }
}
