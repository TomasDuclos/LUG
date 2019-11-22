using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ORM;
using Entidades;

namespace BLL
{
    public class Inmobiliaria   
    {
        public List<Inmueble> LI { get; set; }

        AccesDB accesDB;

        public Inmobiliaria()
        {
            accesDB = new AccesDB();
        }

        //ABMC.CT
        public void AltaInmueble(Inmueble inmueble)
        {
            try
            {
                accesDB.AltaInmueble(inmueble);

            }
            catch (Exception)
            {
            }
        }
        public void BajaInmueble(Inmueble inmueble)
        {
            try
            {
                accesDB.BajaInmueble(inmueble);
            }
            catch (Exception)
            {
            }
        }
        public void ModificacionInmueble(Inmueble inmueble)
        {
            try
            {
                accesDB.ModificacionInmueble(inmueble);
            }
            catch (Exception)
            {
            }
        }

        public void ConsultaInmueble(string texto)
        {
            try
            {
                //List<Inmueble> listaFiltrada=new List<Inmueble>();
                
                accesDB.ConsultaInmueble(texto);
            }
            catch (Exception)
            {
            }
        }

        public List<Inmueble> CargarListaInmueble()
        {
            LI = new List<Inmueble>();
            try
            {
                LI = accesDB.GetListaInmueble();
            }
            catch (Exception)
            {
            }
            return LI;
        }
        public List<Inmueble> BusquedaFiltro(string texto)
        {
            List<Inmueble> listaFiltrada=new List<Inmueble>();
            try
            {
               
                string Query = "select * from Inmueble " +
                    "where Id like '"+@texto+"%'";

                listaFiltrada = accesDB.ConsultaInmueble(Query);
            }
            catch (Exception)
            {

            }
            return listaFiltrada;
        }

        //GDI PART CALCAULAR PORCENTAJES
        public List<ProyeccionGDIinmueble> GetListaProyeccionVendidos()
        {
            List<ProyeccionGDIinmueble> LProyeccion = new List<ProyeccionGDIinmueble>();
            decimal TotalPrecio = 0;

            List<Inmueble> listaFiltrada = accesDB.ConsultaInmueble(@"select *
                                    from Inmueble
                                    where FechaVenta IS not NULL ");

            foreach (Inmueble inmueble in listaFiltrada)
            {
                ProyeccionGDIinmueble proyeccion = new ProyeccionGDIinmueble();

                DateTime dt = (DateTime)inmueble.FechaVenta;
                if (!LProyeccion.Exists(x=>x.Anio==dt.Year) || LProyeccion.Count==0)
                {
                    proyeccion.Anio=dt.Year;
                    LProyeccion.Add(proyeccion);
                }

                TotalPrecio += (inmueble.Precio);
            }
            foreach (ProyeccionGDIinmueble Proyeccion in LProyeccion)
            {

                foreach (Inmueble inmueble in listaFiltrada)
                {
                    DateTime dt = (DateTime)inmueble.FechaVenta;
                    int Anio = dt.Year;
                    if (Proyeccion.Anio == Anio)
                    {
                        Proyeccion.GananciaIVendidos += inmueble.Precio;
                        Proyeccion.PorcSobreGananciaTotalVendido =
                            (float)(((Proyeccion.GananciaIVendidos) / TotalPrecio))*100;
                    }
                }
            }
            return LProyeccion;
        }



    }

}
