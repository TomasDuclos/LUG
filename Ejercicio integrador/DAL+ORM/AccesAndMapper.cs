using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace DAL_ORM
{
    public class AccesDB
    {
        string ConectionString = @"Data Source=DESKTOP-LV7D4H6\SQLEXPRESS;Initial Catalog=Inmobiliaria;Integrated Security=True";
        DataSet DS;
        SqlDataAdapter Adapter;
        SqlCommandBuilder ComandBuilder;

        public AccesDB()
        {
            DS = new DataSet();
            Adapter = new SqlDataAdapter("select * FROM Inmueble", ConectionString);
            ComandBuilder = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = ComandBuilder.GetInsertCommand();
            Adapter.DeleteCommand = ComandBuilder.GetDeleteCommand();
            Adapter.UpdateCommand = ComandBuilder.GetUpdateCommand();
            Adapter.Fill(DS, "Inmueble");

            DataColumn[] column = { DS.Tables[0].Columns[0] };
            DS.Tables[0].PrimaryKey = column;
        }
        //Guardar en Bd
        public void GuardarBd()
        {
            Adapter.Update(DS.Tables[0]);
        }


        //ABMC.CT
        public void AltaInmueble(Inmueble inmueble)
        {
            try
            {
                // llega objeto crea table manda la table a que se guarde         
                DataRow DR =DS.Tables[0].NewRow();
                DR.ItemArray = inmueble.getArrayInmueble();
                DS.Tables[0].Rows.Add(DR);
                GuardarBd();
            }
            catch (Exception)
            {
            }
        }
        public void BajaInmueble(Inmueble inmueble)
        {
            try
            {
                //tengo el objeto a dar de baja, creo la table y la envio a que le den de baja
                DS.Tables[0].Rows.Find(inmueble.Id).Delete();
                GuardarBd();
            }
            catch (Exception)
            {
            }
        }
        public void ModificacionInmueble(Inmueble inmueble)
        {
            try
            {
                DataRow DR=DS.Tables[0].Rows.Find(inmueble.Id);
                DR[1] =inmueble.Direccion;
                DR[2] = inmueble.Precio;
                DR[3] = inmueble.FechaPublicacion;
                DR[4] = inmueble.FechaVenta;
                GuardarBd();
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

            }
            catch (Exception)
            {
            }
        }

    }
}
