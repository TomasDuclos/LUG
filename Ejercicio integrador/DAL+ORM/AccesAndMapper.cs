﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
            Adapter.InsertCommand = ComandBuilder.GetUpdateCommand(); 
            Adapter.DeleteCommand = ComandBuilder.GetDeleteCommand();
            Adapter.UpdateCommand = ComandBuilder.GetUpdateCommand();

            Adapter.FillSchema(DS, SchemaType.Mapped);
            //con el fillSchema no hace falta poner la ky a mano

            //DataColumn[] column = { DS.Tables[0].Columns[0] };
            //DS.Tables[0].PrimaryKey = column;
           
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                DR.ItemArray = inmueble.getArrayInmueble();
                //DR[1] =inmueble.Direccion;
                //DR[2] = inmueble.Precio;
                //DR[3] = inmueble.FechaPublicacion;
                //if (inmueble.FechaVenta.ToString()=="")
                //{
                   // DateTime? FVNull = null;
                    //DR[4] = FVNull;
                //}
                
                GuardarBd();
            }
            catch (Exception)
            {
            }
        }

        public List<Inmueble> ConsultaInmueble(string Query)
        {
            List<Inmueble> LInmueble = new List<Inmueble>();
            try
            {
                Adapter.SelectCommand.CommandText = Query;
                DataTable dtfilter = new DataTable();
                Adapter.Fill(dtfilter);
                foreach (DataRow dr in dtfilter.Rows)
                {
                    DateTime? dtFV = null;
                    if (dr[4].ToString() != "")
                    {
                        dtFV = (DateTime?)dr[4];
                    }

                    Inmueble inmueble = new Inmueble(
                        dr[0].ToString(), dr[1].ToString(),
                        (decimal)dr[2], (DateTime)dr[3], dtFV);

                    LInmueble.Add(inmueble);
                }

                Adapter.SelectCommand.CommandText = "select * from Inmueble";
            }
            catch (Exception)
            {
            }
            return LInmueble;
        }
        public List<Inmueble> GetListaInmueble()
        {
            List<Inmueble> LInmueble = new List<Inmueble>();
            try
            {
                Adapter.SelectCommand.CommandText="select * from Inmueble";
                Adapter.Fill(DS.Tables[0]);
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    DateTime? dtFV = null;
                    if (dr[4].ToString()!="")
                    {
                        dtFV = (DateTime?)dr[4];
                    }
                    
                    Inmueble inmueble = new Inmueble(
                        dr[0].ToString(), dr[1].ToString(),
                        (decimal)dr[2], (DateTime)dr[3], dtFV);

                    LInmueble.Add(inmueble);
                }
            }
            catch (Exception)
            {

            }
            return LInmueble;
        }
    }
}
