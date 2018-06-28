using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        class MainApp
        {
            /// <summary>
            /// Esta App muestra los datos de dos formas segun el metodo, de forma reducida o completa.
            /// he utilizado una estructura de patrón facade con subsytems
            /// </summary>
            public static void Main()
            {
                Facade facade = new Facade();
                
                facade.MethodA();
                Console.ReadKey();
                Console.Clear();
                facade.MethodB();

                // Wait for user

                Console.ReadKey();
            }
        }

        /// <summary>

        /// SubSystem que escribe nombre

        /// </summary>
        
        public class SubSystemOne 

        {
            Alumno nombre = new Alumno("Roger", "Calatayud", "34353424x", "rogercalata@gmail.com", "9334546373");
            public void MethodOne()
            {
                Console.WriteLine(nombre.Nombre);
                
            }
        }

        /// <summary>

        /// SubSystem que escribe Apellido

        /// </summary>

        class SubSystemTwo

        {
            Alumno apellido = new Alumno("Roger", "Calatayud", "34353424x", "rogercalata@gmail.com","9334546373");

            public void MethodTwo()
            {
                Console.WriteLine(apellido.Apellidos);
            }
        }

        /// <summary>

        /// SubSystem que escribe Correo

        /// </summary>

        class SubSystemThree

        {
            public void MethodThree()
            {
                Console.WriteLine("Correo");
            }
        }

        /// <summary>

        /// SubSystem que escribe Telefono

        /// </summary>

        class SubSystemFour

        {
            public void MethodFour()
            {
                Console.WriteLine("Telefono");
            }
        }
        /// <summary>

        /// The 'Subsystem ClassE' class

        /// </summary>

        class SubSystemFive

        {
            public void MethodFive()
            {
                Console.WriteLine("DNI");
            }
        }
        
        /// <summary>

        /// The 'Facade' class

        /// </summary>

        class Facade

        {
            private SubSystemOne _one;
            private SubSystemTwo _two;
            private SubSystemThree _three;
            private SubSystemFour _four;
            private SubSystemFive _five;

            public Facade()
            {
                _one = new SubSystemOne();
                _two = new SubSystemTwo();
                _three = new SubSystemThree();
                _four = new SubSystemFour();
                _five = new SubSystemFive();
            }

            public void MethodA()
            {
                Console.WriteLine("Datos reducidos");
                _one.MethodOne();
                _two.MethodTwo();
                _four.MethodFour();
            }

            public void MethodB()
            {
                Console.WriteLine("Datos completos");
                _one.MethodOne();
                _two.MethodTwo();
                _three.MethodThree();
                _four.MethodFour();
                _five.MethodFive();
            }
        }
    }
}

