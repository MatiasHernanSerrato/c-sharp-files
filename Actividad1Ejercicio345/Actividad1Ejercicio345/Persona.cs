using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1Ejercicio345
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string name, int age)
        {
            this.Nombre = name;
            this.Edad = age;
        }


    }
}
