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

        AccesDB dbmapper;

        //ABMC.CT
        public void AltaInmueble(Inmueble inmueble)
        {
            try
            {
                dbmapper.AltaInmueble(inmueble);
            }
            catch (Exception)
            {
            }
        }
        public void BajaInmueble(Inmueble inmueble)
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }
        public void ModificacionInmueble(Inmueble inmueble)
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }

        public void ConsultaInmueble(Inmueble inmueble)
        {
            try
            {
                //List<Inmueble> a=new List<Inmueble>();

            }
            catch (Exception)
            {
            }
        }


    }
}
