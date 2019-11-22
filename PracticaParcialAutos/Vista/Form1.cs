using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using BLL;
using Entities;
namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Concesionaria concesionaria;

        private void Form1_Load(object sender, EventArgs e)
        {
            concesionaria = new Concesionaria();
            Mostrar("");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex patron = new Regex(@"([A-Za-z]{3}\d{3})");
            if (patron.IsMatch(txpatente.Text))
            {
                DateTime? dtEgreso = null;
                if (txEgreso.Text!="")
                {
                    dtEgreso = DateTime.Parse(txEgreso.Text);
                }

                Auto auto = new Auto(txpatente.Text,int.Parse(txAnio.Text),
                    DateTime.Parse(txIngreso.Text), dtEgreso);

                concesionaria.AltaAuto(auto);
                Mostrar("");//falta codear
            }
            else { txInforme.Text = "Patente con Formato Incorrecto"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auto auto = dataGridView1.SelectedRows[0].DataBoundItem as Auto;
            concesionaria.BajaAuto(auto);
            Mostrar("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Auto auto = dataGridView1.SelectedRows[0].DataBoundItem as Auto;

            DateTime? dtEgreso = null;
            if (txEgreso.Text != "")
            {
                dtEgreso = DateTime.Parse(txEgreso.Text);
            }

            Auto autoMod = new Auto(auto.Patente, int.Parse(txAnio.Text),
                DateTime.Parse(txIngreso.Text), dtEgreso);

            concesionaria.ModificacionAuto(autoMod);
            Mostrar("");//falta codear
        }
        public void ConsultaAuto(string Query)
        {

        }

        public void Mostrar(string texto)
        {
            List<Auto> ListaAuto=concesionaria.ConsultaAuto(texto);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaAuto;
        }

        private void txFiltro_TextChanged(object sender, EventArgs e)
        {
            Regex patron = new Regex(@"([A-Za-z])");
            if (patron.IsMatch(txFiltro.Text))
            {
                if (txFiltro.Text != "")
                {
                    Mostrar(txFiltro.Text);
                }
                else
                {
                    Mostrar("");
                }
            }           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Mostrar("");
            txFiltro.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Auto auto = (Auto)dataGridView1.SelectedRows[0].DataBoundItem ;
            txpatente.Text = auto.Patente;
            txAnio.Text = auto.Anio.ToString();
            txEgreso.Text = auto.Egreso.ToString();
            txIngreso.Text = auto.Ingreso.ToString();
        }

        public void GraficarGdiBarras()
        {
            List<ProyeccionCV> ListaProyeccion =concesionaria.CalcularPorcentajeVendidos();

            Graphics Gr = this.CreateGraphics();            
            //Gr.FillRectangle(., X, Y, Ancho, Alto);
            float X =275;
            float Ancho =45;
            
            foreach (ProyeccionCV proyeccion in ListaProyeccion)
            {
                float Alto =(float)(proyeccion.PorcentajeSobreTotalVendidos)*2;
                float Y = 4+(200- Alto);                
              
                Gr.FillRectangle(proyeccion.Sb, X,Y, Ancho, Alto);
                X += 50;

                //Gr.DrawString(proyeccion.PorcentajeSobreTotalVendidos+"%",
                    //,,,);
            }
            
            //torta

            //List<ProyeccionCV> ListaProyeccion = concesionaria.CalcularPorcentajeVendidos();

            Graphics Grr = this.CreateGraphics();
            //Gr.FillRectangle(., X, Y, Ancho, Alto)

            Rectangle rectangulo = new Rectangle(400, 50, 150, 150);
            float comienzo = 0;
            foreach (ProyeccionCV proyeccion in ListaProyeccion)
            {
                float porcion = (float)((decimal)(proyeccion.PorcentajeSobreTotalVendidos) / 100) * 360;

                Grr.FillPie(proyeccion.Sb, rectangulo, comienzo, porcion);
                comienzo += porcion;
            }


            MostrarProyeccion(ListaProyeccion);
        }
        public void MostrarProyeccion(List<ProyeccionCV> ListaProyeccion)
        {
            int i = 0;
            foreach (ProyeccionCV proyeccion in ListaProyeccion)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = proyeccion.Anio;
                dataGridView2.Rows[i].Cells[1].Value = proyeccion.TotalVendidoAnio;
                dataGridView2.Rows[i].Cells[2].Value = proyeccion.PorcentajeSobreTotalVendidos;
                dataGridView2.Rows[i].Cells[3].Style.BackColor = proyeccion.Sb.Color;
                i++;
            }
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            GraficarGdiBarras();
            
        }

        
    }
}
