using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Entidades
{
    public class Inmueble
    {

        public Inmueble(string id, string direccion, decimal precio, DateTime fechaPublicacion, DateTime? fechaVenta)
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
        public DateTime? FechaVenta { get; set; }

        public object[] getArrayInmueble()
        {
            object[] arrayinmueble = { Id, Direccion,
                     Precio,FechaPublicacion,FechaVenta};
                     
            return arrayinmueble;
        }
    }
    public class ProyeccionGDIinmueble
    {
        public int Anio{get;set;}
        public decimal GananciaIVendidos { get; set; }
        public float PorcSobreGananciaTotalVendido { get; set; }

        public SolidBrush sb { get; set; }
    }
}
