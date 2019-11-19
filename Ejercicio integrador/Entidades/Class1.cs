using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inmueble
    {

        public Inmueble(string id, string direccion, decimal precio, DateTime fechaPublicacion, DateTime fechaVenta)
        {
            Id = id;
            Direccion = direccion;
            Precio = precio;
            FechaPublicacion = fechaPublicacion;
            FechaVenta = fechaVenta;
        }

        public string Id { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaVenta { get; set; }

        public object[] getArrayInmueble()
        {
            object[] arrayinmueble = { Id, Direccion,
                     Precio,FechaPublicacion,FechaVenta};
                     
            return arrayinmueble;
        }

    }
}
