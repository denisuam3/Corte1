using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.models
{
    internal class Registro
    {
        Person[] personas = new Person[30];

        public void AgregarPersona(Person persona, int posicion)
        {
            personas[posicion] = persona;
        }

        public Person[] GetPersonas()
        {
            return personas;
        }

        
    }
}
