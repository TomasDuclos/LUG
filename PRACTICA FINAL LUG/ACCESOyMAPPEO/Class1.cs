using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTITYES;

namespace ACCESOyMAPPEO
{
    public class MyA
    {
        SqlDataAdapter Adapter;
        SqlCommandBuilder CB;
        DataTable DTAuto;
        string sc = @"Data Source=.;Initial Catalog=Auto;Integrated Security=True";
        public MyA()
        {
            DTAuto = new DataTable();
            Adapter = new SqlDataAdapter("select * from Auto",sc);
            CB = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = CB.GetInsertCommand();
            Adapter.DeleteCommand = CB.GetDeleteCommand();
            Adapter.UpdateCommand = CB.GetUpdateCommand();
            Adapter.FillSchema(DTAuto,SchemaType.Mapped);
            DataColumn dc = DTAuto.Columns[3];
            dc.AllowDBNull=true;
        }

        private void GuardarBD()
        {
            Adapter.Update(DTAuto);
        }
        public void Alta(Auto auto)
        {
            DataRow dr=DTAuto.NewRow();
            dr.ItemArray = auto.GetItemArrayToProperties();
            DTAuto.Rows.Add(dr);
            GuardarBD();
        }
        public void Baja(Auto auto)
        {
            DTAuto.Rows.Find(auto.Patente).Delete();
            GuardarBD();
        }
        public bool Modificacion(Auto auto, string patenteOrig)
        {
            bool existe = false;
            foreach (DataRow dr in DTAuto.Rows)
            {           
                if (dr[0].ToString()==auto.Patente && dr[0].ToString() != patenteOrig)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                DataRow dr = DTAuto.Rows.Find(patenteOrig);
                dr.ItemArray = auto.GetItemArrayToProperties();
                GuardarBD();
            }
            return existe;
        }
        public List<Auto> ConsultaFiltrada(string Query)
        {
            List<Auto> Lauto = new List<Auto>();
            Adapter.SelectCommand.CommandText = Query;
            DataTable dtfiltrado = new DataTable();     
            Adapter.Fill(dtfiltrado);
            foreach (DataRow dr in dtfiltrado.Rows)
            {
                Auto auto = new Auto();
                auto.SetItemArrayToProperties(dr.ItemArray);
                Lauto.Add(auto);
            }
            AdapterReinicio();
            return Lauto;
        }
        public void AdapterReinicio()
        {
            Adapter.SelectCommand.CommandText = "select * from Auto";
            Adapter.Fill(DTAuto);
        }
    }
}
