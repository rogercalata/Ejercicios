using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Mapper
{
    class Program
    {
        public class forma1
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
        }
        public class forma2
        {
            public int id { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
        }
        public class EJmapper
        {
            static void Main(string[] args)
            {
                var conf = new MapperConfiguration(cfg => cfg.CreateMap<forma1, forma2>());
                IMapper iMapper = conf.CreateMapper();

                var source = new forma1();
                source.id = 1;
                source.Nombre = "Roger";
                source.Apellidos = "Calatayud";
                var destino = iMapper.Map<forma1, forma2>(source);
                Console.WriteLine(destino.GetType());
                Console.WriteLine("Nombre de autor" + destino.Nombre + " " + destino.Apellidos);
                Console.ReadLine();

            }
        }
    }
}
