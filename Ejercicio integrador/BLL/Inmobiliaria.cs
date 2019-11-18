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


    }
}
