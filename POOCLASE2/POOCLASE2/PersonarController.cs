using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace POOCLASE2
{
    internal class PersonarController
    {
        static  List<Persona> personaList = new List<Persona>();

        public PersonarController()
        {
            personaList.Add(new Persona("1", "Lucas", "Lopez", 23));
        }

        public List<Persona> get_personas() { return personaList; }
        public List<Persona> get_persona(int indice) { return personaList[indice]; }
        public int get_size() { return personaList.Count; }
        public Boolean delete(int indice) { return personaList.Remove(personaList[indice]); }
        public Boolean add_persona(String DNI, String Nombre, String Apellido, int Edad)
        {
            int cant1 =personaList.Count;
            personaList.Add(new Persona(DNI, Nombre, Apellido, Edad));
            int cant2 = personaList.Count;
            if(cant1!=cant2) { return true; }
            else { return false; }

        }
    }
}
