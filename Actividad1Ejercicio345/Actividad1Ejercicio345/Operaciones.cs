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
        double resultado;

        public Operaciones(double Lado1,double Lado2, double Lado3)
        {
            lado1 = Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
        }

        public double Sumar()
        {
            resultado = lado1 + lado2 + lado3;
            return resultado;
        }

    }
}
