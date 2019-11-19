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
                //List<Inmueble> a=new List<Inmueble>();
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
    }
}
