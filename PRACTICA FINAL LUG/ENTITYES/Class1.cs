using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYES
{
    public class Auto
    {
        public string Patente { get; set; }
        public int Anio { get; set; }
        public decimal Valor { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime? Egreso { get; set; }
        public bool EnUso { get; set; }

        public Auto(string patente, int anio, decimal valor, DateTime ingreso, string egreso)
        {
            Patente = patente;
            Anio = anio;
            Valor = valor;
            Ingreso = ingreso;
            Egreso = null;
            if (egreso != "")
            {
                Egreso = (DateTime?)(DateTime.Parse(egreso));
            }
            CalcularEnUso();
        }
        public Auto()
        {

        }
        private void CalcularEnUso()
        {
            if (Egreso is null)
            {
                EnUso = true;
            }
            else
            {
                EnUso = false;
            }
        }
        public object[] GetItemArrayToProperties()
        {
            object[] o = { Patente, Anio, Ingreso, Egreso, Valor };
            return o;
        }
        public void SetItemArrayToProperties(object[] array)
        {
            Patente = array[0].ToString();
            Anio = int.Parse(array[1].ToString());
            Ingreso = DateTime.Parse(array[2].ToString());

            Egreso = null;
            DateTime dtout;
            if (DateTime.TryParse(array[3].ToString(),out dtout))
            {
                Egreso = (DateTime?)DateTime.Parse(array[3].ToString());
            }
                   
            Valor = decimal.Parse(array[4].ToString());
            CalcularEnUso();
        }
    }
    public class AutoProyeccion
    {
        public string Patente { get; set; }
        public int Anio { get; set; }
        public decimal Valor { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime? Egreso { get; set; }
        public bool EnUso { get; set; }
        public int DiasEnEmpresa { get; set; }
        public decimal ValorResidual { get; set; }
        public Auto Auto { get; set; }

        public AutoProyeccion(string patente, int anio, decimal valor, DateTime ingreso, string egreso)
        {
            Patente = patente;
            Anio = anio;
            Valor = valor;
            Ingreso = ingreso;

            
            CalcularEnUso();
            CalcularDiasEnLaEmpresa();
            CalcularValorResidual();
        }
        public AutoProyeccion()
        {
        }
        private void CalcularEnUso()
        {
            if (Egreso is null)
            {
                EnUso = true;
            }
            else
            {
                EnUso = false;
            }
        }
        public object[] GetItemArrayToProperties()
        {
            object[] o = { Patente, Anio, Ingreso, Egreso, Valor };
            return o;
        }
        public void SetItemArrayToProperties(object[] array, Auto auto)
        {
            Patente = array[0].ToString();
            Anio = int.Parse(array[1].ToString());
            Ingreso = DateTime.Parse(array[2].ToString());

            Egreso = null;
          
            if (array[3] != null)
            {
                Egreso = (DateTime?)DateTime.Parse(array[3].ToString());
            }         
            Valor = decimal.Parse(array[4].ToString());
            Auto= auto;
            CalcularEnUso();
            CalcularDiasEnLaEmpresa();
            CalcularValorResidual();
        }
        private void CalcularDiasEnLaEmpresa()
        {
            if (Egreso is null)
            {
                DiasEnEmpresa = ((DateTime.Now) - (Ingreso)).Days;
            }
            else
            {
                DiasEnEmpresa = (((DateTime)(Egreso)) - (Ingreso)).Days;
            }

        }
        private void CalcularValorResidual()
        {
            int anios = (DateTime.Now.Year) - Anio;
            ValorResidual = Valor;
            for (int i = 0; i < anios; i++)
            {
                decimal DiezPorcientoDelValorResidual = (ValorResidual * 10) / (100);
                ValorResidual -= DiezPorcientoDelValorResidual;
            }
        }
    }
    public class PGDI
    {
        public string Rango { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public int Cantidad { get; set; }
        public float Porcentaje { get; set; }
        public PGDI()
        {
        }
        public PGDI(string rango, int cantidad, float porcentaje)
        {
            Rango = rango;
            Cantidad = cantidad;
            Porcentaje = porcentaje;
        }   
        public object[] GetItemArrayToProperties()
        {
            object[] o = { Rango, Cantidad, Porcentaje };
            return o;
        }        
    }
}
