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
                
                facade.MethodNombre();
                Console.ReadKey();
                Console.Clear();
                facade.MethodDatos();
                Console.ReadKey();
                Console.Clear();
                facade.MethodTodo();

                // Wait for user

                Console.ReadKey();
            }
        }

        /// <summary>

        /// SubSystem que escribe nombre

        /// </summary>
        
        public class SubSystemNombre

        {
            Alumno nombre = new Alumno("Roger", "Calatayud", "34353424x", "rogercalata@gmail.com", "9334546373");
            public void MethodNombre()
            {
                Console.WriteLine(nombre.Nombre);
                Console.WriteLine(nombre.Apellidos);
                
            }
        }

        /// <summary>

        /// SubSystem que escribe datos personales

        /// </summary>

        class SubSystemDatos

        {
            Alumno datos = new Alumno("Roger", "Calatayud", "34353424x", "rogercalata@gmail.com","9334546373");

            public void MethodDatos()
            {
                Console.WriteLine(datos.correo);
                Console.WriteLine(datos.Dni);
                Console.WriteLine(datos.telefono);
            }
        }

        /// <summary>

        /// SubSystem que escribe Correo

        /// </summary>

        class SubSystemTodo

        {
            Alumno datos = new Alumno("Roger", "Calatayud", "34353424x", "rogercalata@gmail.com", "9334546373");
            public void MethodTodo()
            {
                Console.WriteLine(datos.Nombre);
                Console.WriteLine(datos.Apellidos);
                Console.WriteLine(datos.correo);
                Console.WriteLine(datos.Dni);
                Console.WriteLine(datos.telefono);
            }
        }
        
        /// <summary>

        /// The 'Facade' class

        /// </summary>

        class Facade

        {
            private SubSystemNombre _nombre;
            private SubSystemDatos _datos;
            private SubSystemTodo _todo;


            public Facade()
            {
                _nombre = new SubSystemNombre();
                _datos = new SubSystemDatos();
                _todo = new SubSystemTodo();

            }

            public void MethodNombre()
            {
                Console.WriteLine("Nombre y apellido");
                _nombre.MethodNombre();
            }

            public void MethodDatos()
            {
                Console.WriteLine("Datos adicionales");
                _datos.MethodDatos();
            }
            public void MethodTodo()
            {
                Console.WriteLine("Todos los Datos");
                _todo.MethodTodo();
            }
        }
    }
}

