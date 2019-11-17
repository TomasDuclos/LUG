using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public interface Iabmc<T> 
    {
        void Alta(T pObject);
        void Baja(T pObject);
        void Modificacion(T pObject, T pObject2);
        void Consulta(T pObject);
        List<T> ConsultaTodos();
        //List<T> ConsultaDesdeHasta(T pObject1, T pObject2);
    }
    public interface Iabmc
    {
        void Alta();
        void Baja();
        void Modificacion();
        void Consulta();
        void ConsultaTodos();
        //void ConsultaDesdeHasta();
    }
}
