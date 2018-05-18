using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class Linq
    {
        public void Main() {
            /// where
            List<int> numeros = new List<int>() { 1, 5, 8, 96, 3, -9, -5, 95, 4 };
            var mayores_que_Cero = numeros.Where(x => x > 0).OrderBy(x=>x).ToList();

            List<Persona> personas = new List<Persona>()
            {
                new Persona("Erika",28),
                new Persona("Carlos",28),
                new Persona("karla",5),
                new Persona("Isa",3)
            };

            List<Persona> personasMayoresEdad = personas.Where(p => p.Edad >= 18).ToList<Persona>();
            Console.WriteLine("Personas MAyores de Edad con Where: ");
            Persona.Imprimir_Lista(personasMayoresEdad);

            Console.WriteLine("Lista de personas ordenadas por edad: ");
            List<Persona> personarOrdenadasEdad = personas.OrderBy(x => x.Edad).ToList();
            Persona.Imprimir_Lista(personarOrdenadasEdad);
            
        }

        
    }
}
