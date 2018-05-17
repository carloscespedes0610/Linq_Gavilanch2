using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Gavilanch2
{
    class Delegados
    {
        /// delegados: permiten almacenar una funcion o procedimiento
        private delegate string DelegadoString(int x);
        private delegate void DelegateVoid(int x);
        private delegate void DelegateVoidPersona(Persona p);

        public void Main() {
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


            /* func es un delegado especifico que hace referencia o se utiliza solo en funciones, siendo
             el ultimo parametro el tipo de salida de la funcion y los demas anteriores tipos de parametros
             de entrada*/
            Console.WriteLine("*********** Func y Action *******************");
            Func<int, string> func_functionRetornaString = FuncionRetornaString;
            Console.WriteLine("Func: " + func_functionRetornaString(74));

            /*
             * el Action es un delegado especifico que se utiliza el procedimiento siendo todos los tipos
             * parametros de entradas
             */
            Action<int> act_imprimirValor = ImprimirValor;
            Console.WriteLine("Action");
            act_imprimirValor(96);

            Console.WriteLine();
            Console.WriteLine("***********delegados con clase PErsona");

            /*
             * aqui vemos un delegado usando objeto de la clase persona
             */

            var imprimirPersona = new DelegateVoidPersona(ImprimirPersona);
            imprimirPersona(new Persona("carlos", 28));

            /*
             * el delegado Predicado es uno especifico que solo retorna un boolean y solo tiene 1 parametro
             * de entrada
             */
            Console.WriteLine("************** Predicado **********");
            Predicate<Persona> predicado_persona = EsMayorDeEdad;
            Console.WriteLine("Es Mayor de Edad: " + predicado_persona(new Persona("carlos", 78)));

        }


        private static bool EsMayorDeEdad(Persona p)
        {
            return p.Edad >= 18;
        }


        private static void ImprimirPersona(Persona p)
        {
            Console.WriteLine(p.Nombre + ", edad: " + p.Edad.ToString());
        }


        private static void ImprimirValor(int valor)
        {
            Console.Write(valor);
        }

        private static string FuncionRetornaString(int valor)
        {
            return valor.ToString();
        }

        private static string FuncionRetornaStringMasUno(int valor)
        {
            return (valor + 1).ToString();
        }

        // los delegados tambien sirven para establecer Templates en los procedimientos y funciones

        private static void Template(DelegadoString delegado, int x, int y)
        {
            string cadena = "";
            cadena = delegado(x) + delegado(y) + " impreso con DelegadoString Template";
            Console.WriteLine(cadena);
        }
    }
}
