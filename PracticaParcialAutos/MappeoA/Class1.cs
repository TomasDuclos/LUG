using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace MappeoA
{
    public class AccesoAndMappeo
    {
        SqlDataAdapter Adapter;
        SqlCommandBuilder CBuilder;
        DataSet Ds;
        DataTable DTAuto;
        string SConnection = @"Data Source=.;Initial Catalog=Auto;Integrated Security=True";
        public AccesoAndMappeo()
        {
            Ds = new DataSet();
            DTAuto = new DataTable();
            Adapter = new SqlDataAdapter("Select * from Auto",SConnection);
            CBuilder = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = CBuilder.GetInsertCommand();
            Adapter.DeleteCommand = CBuilder.GetDeleteCommand();
            Adapter.UpdateCommand = CBuilder.GetUpdateCommand();
            Adapter.FillSchema(DTAuto, SchemaType.Mapped);

        }
        public void GuardarBD()
        {
            Adapter.FillSchema(DTAuto, SchemaType.Mapped);
            Adapter.Update(DTAuto);
        }
        public void AltaAuto(Auto auto)
        {
            DataRow dr = DTAuto.NewRow();
            dr.ItemArray = auto.GetPropertiesToArray();
            DTAuto.Rows.Add(dr);

            GuardarBD();
        }
        public void BajaAuto(Auto auto)
        {
            DTAuto.Rows.Find(auto.Patente).Delete();  
            GuardarBD();
        }
        public void ModificacionAuto(Auto auto)
        {
            DataRow dr=DTAuto.Rows.Find(auto.Patente);
            dr.ItemArray = auto.GetPropertiesToArray();
            GuardarBD();
        }
        public List<Auto> ConsultaAuto(string Query)
        {
            List<Auto> ListaAuto =new List<Auto>();
            Adapter.SelectCommand.CommandText = (@"select * from Auto
                                           where Patente like '"+Query+"%'");
            DataTable dt = new DataTable();
            Adapter.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                DateTime? dtEgreso = null;
                if (dr[3].ToString() != "")
                {
                    dtEgreso = DateTime.Parse(dr[3].ToString());
                }

                Auto auto = new Auto(dr[0].ToString(), int.Parse(dr[1].ToString()), 
                    DateTime.Parse(dr[2].ToString()), dtEgreso);

                ListaAuto.Add(auto);
            }
            Adapter.Fill(DTAuto);
            return ListaAuto;
        }
        //conseguir los no vnedidos
    }
}
