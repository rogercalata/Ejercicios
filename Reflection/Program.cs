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





            XmlDocument doc = new XmlDocument();
            doc.Load("ReflectionConfiguration.xml");

            XmlNodeList nodelist = doc.GetElementsByTagName("Type"); // get all <Type> nodes
            string ListElmAlum = nodelist[0].InnerText;
            Assembly myAssembly = typeof(Program).Assembly;

                Type alumnoType = myAssembly.GetType("Reflection.Alumno");
                object alumno = Activator.CreateInstance(alumnoType, 1, "Roger", "Calatayud", "343435367x");

                Alumno miAlumno = (Alumno)alumno;

                Console.WriteLine(miAlumno.Nombre);

                Console.ReadKey();
            }
        }
    }


