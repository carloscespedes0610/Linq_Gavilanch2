using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class Program
    {
        /// delegados: permiten almacenar una funcion o procedimiento
        delegate string DelegadoString(int x);
        delegate void DelegateVoid(int x);

        static void Main(string[] args)
        {
            var funcionRetornastring = new DelegadoString(FuncionRetornaString);
            var funcionRetornaStringMasUno = new DelegadoString(FuncionRetornaStringMasUno);

            Console.WriteLine("FuncionRetornaString: " + funcionRetornastring(14));
            Console.WriteLine("funcionRetornaStringMasUno: " + funcionRetornaStringMasUno(14));

            var procedimientoImprimirValor = new DelegateVoid(ImprimirValor);
            Console.WriteLine("procedimientoImprimirValor: ");
            procedimientoImprimirValor(16);


            // utilizaremos el metodo template con diferentes algoritmos o funciones
            Console.WriteLine("template con FuncionRetornaString: ");
            Template(funcionRetornastring, 5, 4);

            Console.WriteLine("Template con FuncionRetornaStringMasUno: ");
            Template(funcionRetornaStringMasUno, 5, 4);

            Console.WriteLine("*********** Func y Action *******************");
            Func<int, string> func_functionRetornaString = FuncionRetornaString;
            Console.WriteLine("Func: " + func_functionRetornaString(74));

            Action<int> act_imprimirValor = ImprimirValor;
            Console.WriteLine("Action");
            act_imprimirValor(96);

            Console.Read();
        }


        static void ImprimirValor(int valor)
        {
            Console.Write(valor);
        }

        static string FuncionRetornaString(int valor)
        {
            return valor.ToString();
        }

        static string FuncionRetornaStringMasUno(int valor)
        {
            return (valor + 1).ToString();
        }

        // los delegados tambien sirven para establecer Templates en los procedimientos y funciones

        static void Template(DelegadoString delegado, int x, int y)
        {
            string cadena = "";
            cadena = delegado(x) + delegado(y) + " impreso con DelegadoString Template";
            Console.WriteLine(cadena);
        }
    }
}
