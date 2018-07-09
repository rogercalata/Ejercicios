using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

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
            XmlNodeList elemlist = doc.GetElementsByTagName("Type");
            string ns = elemlist[0].InnerText;

            XPathDocument doc_xml = new XPathDocument("ReflectionConfiguration.xml");
            XPathNavigator nav = doc_xml.CreateNavigator();
            XPathNavigator texto_nodos = nav.SelectSingleNode("/Types/Type[@id='Alumno']");
            Assembly myassembly = typeof(Alumno).Assembly;
            Type constructor = myassembly.GetType(texto_nodos.ToString());
            Alumno instance = Activator.CreateInstance<Alumno>();
            object alumno = Activator.CreateInstance(constructor, instance.IdAlumno, instance.Nombre, instance.Apellido, instance.Dni);
            var objetoAlumno = ((Alumno)alumno);
            return objetoAlumno;
            /*
            //Aplicando XPATH a el documento creado.....
            XmlNodeList xnodes = doc.SelectNodes("Types / Type ");
            //Impimiendo los resultados obtenidos
            Console.WriteLine();
            for (int i = 0; i < xnodes.Count; i++)
            {
                Console.WriteLine(xnodes[i].InnerText);
            }
            Console.ReadKey();
            //
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            String strExpression;

            // Open the XML.
            docNav = new XPathDocument(@"ReflectionConfiguration.xml");
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            strExpression = "Types / Type[Reflection.Alumno]";
            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(strExpression);
            Console.WriteLine("Lista de alumnos:");
            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                Console.WriteLine("alumno: {0}", NodeIter.Current.Value);
            };
            Console.ReadKey();*/
        }
    }
    }


