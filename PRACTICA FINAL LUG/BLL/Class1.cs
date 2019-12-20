using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYES;
using ACCESOyMAPPEO;

namespace BLL
{
    public class Empresa
    {
        MyA mya;
        
        public Empresa()
        {
            mya = new MyA();
        }

        public void Alta(Auto auto)
        {
            mya.Alta(auto);
        }
        public void Baja(Auto auto)
        {   
            mya.Baja(auto);
        }
        public bool Modificacion(Auto auto, string patenteOrig)
        {
            return mya.Modificacion(auto,patenteOrig);
        }
        public List<Auto> ConsultaFiltrada(string texto)//escala y todo
        {
            string query= @"select * from Auto
                            where Patente like '"+texto+"%'";
            return mya.ConsultaFiltrada(query);                  
        }
        public List<AutoProyeccion> MappeoLAaLAP(List<Auto> LA)
        {
            List<AutoProyeccion> LAP = new List<AutoProyeccion>();

            foreach (Auto auto in LA)
            {
                AutoProyeccion autoProyeccion = new AutoProyeccion();
                autoProyeccion.SetItemArrayToProperties(auto.GetItemArrayToProperties(),auto);
                LAP.Add(autoProyeccion);
            }

            return LAP;
        }
        public List<AutoProyeccion> ConsultaDHValorResidual(decimal desde, decimal hasta)
        {
            List<AutoProyeccion> LAP = new List<AutoProyeccion>();
            try
            {

                foreach (AutoProyeccion autoP in MappeoLAaLAP(ConsultaFiltrada("")))
                {
                    if (desde<=autoP.ValorResidual && hasta >= autoP.ValorResidual)
                    {
                        LAP.Add(autoP);
                    }
                }
            }
            catch (Exception )
            {
            }
            return LAP;
        }

        //GDI PART

        public List<PGDI> GenerarRangos()
        {
            List<PGDI> ListaPgdi = new List<PGDI>();
            try
            {             
                int desde = 1;
                int hasta = 500;
                for (int i = 0; i < 10; i++)
                {
                    PGDI pgdi = new PGDI();
                    pgdi.Rango = desde + " - " + hasta;
                    pgdi.Desde = desde;
                    pgdi.Hasta = hasta;
                    ListaPgdi.Add(pgdi);

                    desde += 500;
                    hasta += 500;
                }
            }
            catch (Exception )
            {
            }
            return ListaPgdi;
        }
        public List<PGDI> CalcularCantidades()
        {
            List<PGDI> ListaPgdi =GenerarRangos();
            try
            {
                List<AutoProyeccion> LAP = MappeoLAaLAP(ConsultaFiltrada(""));
                int CantidadTotal = LAP.Count();

                foreach (var pdgi in ListaPgdi)
                {

                    foreach (var autoP in LAP)
                    {
                        if (autoP.DiasEnEmpresa>=pdgi.Desde && autoP.DiasEnEmpresa <= pdgi.Hasta)
                        {
                            pdgi.Cantidad++;

                            pdgi.Porcentaje = (float)(pdgi.Cantidad * 100) / CantidadTotal;
                            pdgi.Porcentaje = (float)Math.Round(pdgi.Porcentaje, 2);
                        }                       
                    }
                }
            }
            catch (Exception)
            {
            }
            return ListaPgdi;

        }
    }
}
