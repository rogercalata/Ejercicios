using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public Alumno(string Nombre, string Apellidos, string Dni, string correo, string telefono)
        { 
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Dni = Dni;
            this.correo = correo;
            this.telefono = telefono;

        }
        
    }
}
