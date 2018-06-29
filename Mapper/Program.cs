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
            public string sexo { get; set; }
            public DateTime fechaN { get; set; }
        }
        public class forma2
        {
            public int id { get; set; }
            public string NombreComp { get; set; }
            public int edad { get; set; }
            public DateTime fechaN { get; set; }

        }
        public class EJmapper
        {
            static void Main(string[] args)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<forma1, forma2>()
                ///Se encarga de juntar el nombre y apellido del primer modelo y lo pasa a nombre completo en el segundo.
                 .ForMember(dest => dest.NombreComp, sou => sou.ResolveUsing(entity => entity.Nombre + "" + entity.Apellidos))
                 ///se encarga de transformar la fecha de nacimento en la edad
                 .ForMember(dest => dest.edad, sou => sou.ResolveUsing(entity => DateTime.Today.AddTicks(-entity.fechaN.Ticks).Year - 1))
                 /// Se encarga de ignorar el registro de fecha de nacimento en el modelo2 ya que lo transformamos a edad
                 .ForMember(dest => dest.fechaN, opt=> opt.Ignore()));

                IMapper iMapper = config.CreateMapper();

                var source = new forma1 {
                    id = 1,
                    Nombre = "Roger",
                    Apellidos = "Calatayud",
                    sexo = "Hombre",
                    fechaN = new DateTime(1994, 9, 28)
            };

                var destino = iMapper.Map<forma1, forma2>(source);
                Console.WriteLine(destino.GetType());
                Console.WriteLine("Nombre completo: " + destino.NombreComp + "\nEdad: " + destino.edad);
                Console.ReadLine();
                
            }
        }
    }
}

