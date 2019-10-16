using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITIES;
using INTERFACES;
using System.Data;

namespace ORM
{
    public class OrmPersona : Iabmc<EntityPersona>
    {
        DalServicio DalServicio;
        DataTable DT;

        public OrmPersona()
        {
            DalServicio = new DalServicio();
        }

        public void Alta(EntityPersona pObject)
        {
            try
            {
                DT = DalServicio.RetornarTablaVacia("Persona");
                object[] O = {pObject.Dni,pObject.Nombre,pObject.Apellido };
                DT.Rows.Add(O);
                DalServicio.GuardarEnBd(DT);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Baja(EntityPersona pObject)
        {
            DT = DalServicio.RetornarTablaVacia("Persona");
            DataRow DR = DT.NewRow();
            //Lo que hago es crear una nueva row en la tabla y la apunto con DR
            object[] NuevaFila = { pObject.Dni, pObject.Nombre, pObject.Apellido }; 
            DR.ItemArray = NuevaFila;//le digo que es un array
            DT.Rows.Add(DR);//paso dr
            DalServicio.BajaEnBd(DT);
        }

        public void Consulta(EntityPersona pObject)
        {
            throw new NotImplementedException();
        }

        public List<EntityPersona> ConsultaTodos()
        {
            DataTable DT =DalServicio.LeerTabla("select * from Persona");
            List<EntityPersona> ListaEpersonas = new List<EntityPersona>();

            foreach (DataRow DR in DT.Rows)
            {
                EntityPersona persona = new EntityPersona(DR[0].ToString(), DR[1].ToString(), DR[2].ToString());
                ListaEpersonas.Add(persona);
            }
            return ListaEpersonas;
        }

        public void Modificacion(EntityPersona pObject)
        {
            throw new NotImplementedException();
        }
    }
}
