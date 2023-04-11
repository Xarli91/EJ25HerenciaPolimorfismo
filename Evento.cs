using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ25HerenciaPolimorfismo
{
    public class Evento
    {
        public int NumeroPersonas { get; set; }
        public double CosteDecoracion { get; set; }
        public bool OpcionLujo { get; set; }
        public double CostePersona { get; set; }

        public void Constructor(int numeroPersonas, double costeDecoracion, bool opcionLujo, double costePersona)
        {
            NumeroPersonas = numeroPersonas;
            CosteDecoracion = costeDecoracion;
            OpcionLujo = opcionLujo;
            CostePersona = costePersona;
        }

        public virtual double CalcularCoste()
        {
            return NumeroPersonas * CostePersona + CosteDecoracion;
        }
    }
}
