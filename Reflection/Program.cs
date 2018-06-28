using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Reflection.Program;

namespace Reflection
{
    class Program
    {
        public static void Main()
        {
            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f','g','h','i','j','k' };
            object[][] arguments = new object[3][] { new object[] { characters },
                                               new object[] { characters, 0, 7 },
                                               new object[] { characters[0], 20 } };

            for (int ctr = 0; ctr <= arguments.GetUpperBound(0); ctr++)
            {
                object[] args = arguments[ctr];
                object result = Activator.CreateInstance(typeof(String), args);
                Console.WriteLine("{0}: {1}", result.GetType().Name, result);
                
            }
            
            Console.ReadKey();
        }
        
    }
}


