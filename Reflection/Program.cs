using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] arg)
        {



            Assembly myAssembly = typeof(Program).Assembly;

                Type alumnoType = myAssembly.GetType("Reflection.Alumno");
                object alumno = Activator.CreateInstance(alumnoType, 1, "Roger", "Calatayud", "343435367x");

                Alumno miAlumno = (Alumno)alumno;

                Console.WriteLine(miAlumno.Nombre);

                Console.ReadKey();

            XmlDocument doc = new XmlDocument();
            doc.Load("ReflectionConfiguration.xml");
            //Aplicando XPATH a el documento creado.....
            XmlNodeList xnodes = doc.SelectNodes("Types / Type ");
            //Impimiendo los resultados obtenidos
            Console.WriteLine();
            for (int i = 0; i < xnodes.Count; i++)
            {
                Console.WriteLine(xnodes[i].InnerText);
            }
            Console.ReadKey();
        }
        }
    }


