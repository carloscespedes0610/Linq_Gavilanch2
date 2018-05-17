using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class Program
    {

        static void Main(string[] args)
        {
            Delegados delegados = new Delegados();
            // delegados.Main();

            FuncionesAnonimas fa = new FuncionesAnonimas();
            fa.Main();
            Console.Read();
        }
    }
}
