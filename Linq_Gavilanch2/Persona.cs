using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class Persona
    {
        private string nombre;
        private short edad;

        public Persona(string nombre, short edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public short Edad { get => edad; set => edad = value; }
    }
}
