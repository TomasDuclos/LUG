using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MappeoA;
using System.Drawing;
namespace BLL
{
    public class Concesionaria
    {
        AccesoAndMappeo AyM;

        public Concesionaria()
        {
            AyM = new AccesoAndMappeo();
        }

        public void AltaAuto(Auto auto)
        {
            AyM.AltaAuto(auto);
        }
        public void BajaAuto(Auto auto)
        {
            AyM.BajaAuto(auto);
        }
        public void ModificacionAuto(Auto auto)
        {
            AyM.ModificacionAuto(auto);
        }
        public List<Auto> ConsultaAuto(string Query)
        {
            List<Auto> ListaAuto=AyM.ConsultaAuto(Query);

            return ListaAuto;
        }

        //parte de gdi
        public List<ProyeccionCV> CalcularPorcentajeVendidos()
        {
            List<ProyeccionCV> ListaPro = new List<ProyeccionCV>();
            try
            {
                //supongamos que todos estan vendidos sino abria que hacer una consulta nueva para preguntar por los no vendidos
                List<Auto> ListaAuto = AyM.ConsultaAuto("");
               
                int totalGlobal = 0;

                foreach (Auto auto in ListaAuto)
                {
                    int anioVnt = auto.Egreso.Value.Year;
                    if (!ListaPro.Exists(x => x.Anio == anioVnt) || ListaPro.Count == 0)
                    {
                        ProyeccionCV proyeccion = new ProyeccionCV();
                        proyeccion.Anio = anioVnt;
                        ListaPro.Add(proyeccion);
                    }
                    totalGlobal++;
                }
                foreach (ProyeccionCV proyeccion in ListaPro)
                {
                    foreach (Auto auto in ListaAuto)
                    {
                        int anioVnt = auto.Egreso.Value.Year;
                        if (proyeccion.Anio == anioVnt)
                        {
                            proyeccion.TotalVendidoAnio++;
                            float Porcentaje = (float)(((decimal)(proyeccion.TotalVendidoAnio) / (decimal)(totalGlobal))* 100);  
                            
                            proyeccion.PorcentajeSobreTotalVendidos = (float)Math.Round(Porcentaje, 3);
                        }
                    }
                }
                GenerarColores(ListaPro);
            }
            catch (Exception)
            {
                throw;
            }
            return ListaPro;
        }
        public void GenerarColores(List<ProyeccionCV> ListaPro)
        {
            foreach (ProyeccionCV proyeccion in ListaPro)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                int a = 0;
                int b = 0;
                for (int i=0; i<10000;i++)
                {
                    a = r.Next(0, 255);
                }
                for (int i = 0; i < 10000; i++)
                {
                    b = r.Next(0, 255);
                }
                SolidBrush Sb = new SolidBrush(Color.FromArgb(a, r.Next(0, 255), b));
                proyeccion.Sb = Sb;
            }            
        }


    }
}
