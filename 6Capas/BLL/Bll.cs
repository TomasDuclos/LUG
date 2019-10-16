using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INTERFACES;
using ENTITIES;
using ORM;
              
namespace BLL
{
    public class BllPersona : Iabmc<EntityPersona>
    {
        OrmPersona PersonaOrm;

        public BllPersona()
        {
            PersonaOrm = new OrmPersona();
        }

        public void Alta(EntityPersona pObject)
        {
            try
            {
                PersonaOrm.Alta(pObject);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Baja(EntityPersona pObject)
        {
            PersonaOrm.Baja(pObject);
        }

        public void Consulta(EntityPersona pObject)
        {
            ;
        }

        public List<EntityPersona> ConsultaTodos()
        {
            return PersonaOrm.ConsultaTodos();
        }

        public void Modificacion(EntityPersona pObject)
        {
            throw new NotImplementedException();
        }
    }
}
