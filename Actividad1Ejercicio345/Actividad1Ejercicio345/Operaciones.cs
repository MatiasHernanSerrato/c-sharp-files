using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Ejercicio345
{
    public class Operaciones
    {
        private double lado1 { get; set; }
        private double lado2 { get; set; }
        private double lado3 { get; set; }

        public Operaciones(double lado1,double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public double Sumar()
        {
            return lado1 + lado2 + lado3;
        }

    }
}
