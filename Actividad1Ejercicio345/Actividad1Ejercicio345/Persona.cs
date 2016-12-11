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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Persona(string name, int age)
        {
            this.nombre = name;
            this.edad = age;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad);
        }

    }
}
