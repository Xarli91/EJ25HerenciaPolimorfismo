using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ25HerenciaPolimorfismo
{
    public class Cumpleanos : Evento
    {
        public string textoTarta { get; set; }

        public double CosteTarta()
        {
            double coste = 0;

            if (NumeroPersonas <= 8)
            {
                coste = 40;
            }
            else
            {
                coste = 75;
            }

            int numLetras = textoTarta.Length;

            if (numLetras <= 16 && NumeroPersonas <= 8)
            {
                coste += numLetras * 0.25;
            }
            else if (numLetras <= 40 && NumeroPersonas > 8)
            {
                coste += numLetras * 0.25;
            }

            return coste;
        }

        public double CalcularCosteDecoracion()
        {
            double coste = 0;

            if (OpcionLujo)
            {
                coste = 15 * NumeroPersonas;
            }
            else
            {
                coste = 7.5 * NumeroPersonas;
            }

            return coste;
        }

        public override double CalcularCoste()
        {
            double costeTotal = base.CalcularCoste() + CosteTarta() + CalcularCosteDecoracion();
            return costeTotal;
        }
    }
}
