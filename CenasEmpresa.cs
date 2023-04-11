using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ25HerenciaPolimorfismo
{
    public class CenasEmpresa : Evento
    {
        public bool OpcionSaludable { get; set; }

        public double CalcularCosteDecoracion()
        {
            double coste = 0;

            if (OpcionLujo)
            {
                coste = 15 * NumeroPersonas + 50;
            }
            else
            {
                coste = 7.5 * NumeroPersonas + 30;
            }

            return coste;
        }

        public void EstableceOpcionSaludable()
        {
            OpcionSaludable = true;
            CostePersona = 5;
        }

        public override double CalcularCoste()
        {
            double costo = base.CalcularCoste();
            if (OpcionSaludable)
            {
                costo *= 0.95;
            }
            return costo;
        }
    }
}
