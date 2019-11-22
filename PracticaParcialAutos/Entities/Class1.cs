using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entities
{
    public class Auto
    {
        public Auto(string patente, int anio, DateTime ingreso,
            DateTime? egreso)
        {
            Patente = patente;
            Anio = anio;
            Ingreso = ingreso;
            Egreso = egreso;
            Disponible = false;
            if (Egreso.ToString() == "")
            {
                Disponible = true;
            }

        }

        public string Patente { get; set; }
        public int Anio { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime? Egreso { get; set; }
        public bool Disponible { get; set; }

        public object[] GetPropertiesToArray()
        {
            object[] array= { Patente, Anio, Ingreso, Egreso, Disponible };

            return array;
        }


    }
    public class ProyeccionCV
    {
        public int Anio { get; set; }
        public int TotalVendidoAnio { get; set; }
        public float PorcentajeSobreTotalVendidos { get; set; }
        public SolidBrush Sb { get; set; }

    }

}
