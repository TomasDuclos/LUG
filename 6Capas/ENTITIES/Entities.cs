using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EntityPersona
    {
        public EntityPersona(string dni, string nombre, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
