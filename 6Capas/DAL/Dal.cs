using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DalServicio
    {
        DataSet DS;
        SqlDataAdapter Adaptador;
        SqlCommandBuilder CommanBuider;
        string StringConnection = @"Data Source=DESKTOP-LV7D4H6\SQLEXPRESS;Initial Catalog=PersonaYmascota;Integrated Security=True";

        public DalServicio()
        {
            DS = new DataSet();
            Adaptador =new SqlDataAdapter("select * from Persona", StringConnection);
            CommanBuider = new SqlCommandBuilder(Adaptador);
            Adaptador.InsertCommand = CommanBuider.GetInsertCommand();
            Adaptador.DeleteCommand = CommanBuider.GetDeleteCommand();
            Adaptador.UpdateCommand = CommanBuider.GetUpdateCommand();
                       
        }

        public DataTable RetornarTablaVacia(string NombreTabla)
        {
            Adaptador.SelectCommand.CommandText = $"select * from {NombreTabla}";
            DataTable DTRetorno = new DataTable();
            DTRetorno = Adaptador.FillSchema(DTRetorno, SchemaType.Mapped);

            return DTRetorno;
        }
        public void GuardarEnBd(DataTable DTaGuardar)
        {
            Adaptador.Update(DTaGuardar);
        }
        public DataTable LeerTabla(string QuerySql)
        {
            DataTable DT = new DataTable();
            Adaptador.SelectCommand.CommandText = QuerySql;
            Adaptador.Fill(DT);

            return DT;
        }
    }
}
