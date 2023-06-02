using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCLASE2
{
    internal class Persona
    {
        String nombre { get; set; }

        public string Nombre
        {
            get { return this.nombre; }
        }
        String apellido { get; set; }
        public string Apellido
        {
            get { return this.apellido; }
        }
        int edad { get; set; }
        public int Edad
        {
            get { return this.edad; }
        }
        string Dni { get; set; }
        public string DNI
        {
            get { return this.Dni; }
        }

        public Persona(String DNI, String Nombre, String Apellido,int Edad) {
            this.nombre = Nombre;
            this.apellido = Apellido; 
            this.edad = Edad; 
            this.Dni = DNI;
        }
        override
        public String ToString()
        {
            return DNI + "  " + Nombre +"  "+Apellido + "  " +Edad;

        }

    }
}
