using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class FuncionesAnonimas
    {
        public void Main() {
            /*
             * primer x: es el parametro de entrada de la funcion
             * {cuerpo de la funcion}
             */
            Func<int, int> duplicar = x=> { return x * 2; };
            Console.WriteLine("duplicar: "+duplicar(35));

            Func<int, int, int> multiplicar = (x, y) => { int m = x * y; return m; };
            Console.WriteLine("multiplicar: " + multiplicar(5, 4));

        }
    }
}
