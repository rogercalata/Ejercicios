using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Reflection.Program;

namespace Reflection
{
    public class Program
    {
        static void Main(string [] arg)
        {
            Assembly myAssembly = typeof(Program).Assembly;
            Type alumnoType = myAssembly.GetType("Reflection.Alumno");
            object alumno = Activator.CreateInstance(alumnoType, 1, "Roger", "Calatayud", "343435367x");
            Console.WriteLine(((Alumno)alumno).Nombre);

            ///((Alumno)alumno).Nombre
            ///
           /// Alumno miAlumno = (Alumno)alumno;
            ///miAlumno.Nombre = "Roger";

            Console.WriteLine(((Alumno)alumno).Nombre);

            Alumno miAlumno = (Alumno)alumno;
            Console.WriteLine(miAlumno.Nombre);

            Console.ReadKey();
        }

    }
}


