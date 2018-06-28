using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // obtenemos informacion sobre el tipo de variable:  
            int i = 42;
            string Reflection = "Es un tipo String";
            //Obtenemos el tipo de variable.
            System.Type tipo = Reflection.GetType();
            System.Type tipo1 = i.GetType();
            //Escribimos el tipo de variables.
            System.Console.WriteLine("tipo de variable de i : " + tipo1);
            System.Console.WriteLine("tipo de variable de Reflection : " + tipo);
            
            Console.ReadKey();
        }
    }
}
