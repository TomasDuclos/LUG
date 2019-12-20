using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITYES;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace VISTA
{
    public partial class Form1 : Form
    {
        public event EventHandler PatenteErronea;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        Empresa empresa;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PatenteErronea += PatenteErroneaEvento;
                empresa = new Empresa();
                ConsultaFiltrada();

            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }

        }
        private void PatenteErroneaEvento(object sender, EventArgs e)
        {
            try
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = "Patente Erronea";
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }

        }

        public void Alta(Auto auto)
        {
            try
            {
                empresa.Alta(auto);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }

        }
        public void Baja(Auto auto)
        {
            try
            {
                empresa.Baja(auto);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }

        }
        public void Modificacion(Auto auto, string patenteOrig)
        {
            try
            {
                empresa.Modificacion(auto, patenteOrig);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
            
        }
        public void ConsultaFiltrada()
        {
            try
            {
                 MostarDataSource(empresa.MappeoLAaLAP(empresa.ConsultaFiltrada("")),dataGridView1);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
           
        }
        public void MostarDataSource(object Lista,  DataGridView dgv)
        {

            try
            {
                dgv.DataSource = null;
                dgv.DataSource = Lista;
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }
        public void ConsultaDHValorResidual()
        {

            try
            {
                decimal desde = decimal.Parse(Interaction.InputBox("Desde Valor Residual"));
                decimal hasta = decimal.Parse(Interaction.InputBox("Hasta Valor Residual"));

                MostarDataSource(empresa.ConsultaDHValorResidual(desde,hasta), dataGridView1);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }



        //////////////
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Regex patron = new Regex(@"[a-z]{3}\d{3}");//@"([a-z]{3}\d{3})"
                Match m = patron.Match(txpatente.Text);
                if (m.Success)
                {
                    Auto auto = new Auto(txpatente.Text, int.Parse(txAnio.Text),
                     decimal.Parse(txValor.Text), DateTime.Parse(txIngreso.Text), txEgreso.Text);

                    empresa.Alta(auto);
                    ConsultaFiltrada();//muestratodo
                }
                else
                {
                    //programar el evento
                    PatenteErronea(this,new EventArgs());
                }
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
            //alta
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //baja
            try
            {
                AutoProyeccion autoP = dataGridView1.SelectedRows[0].DataBoundItem as AutoProyeccion;
                Auto auto = autoP.Auto;
                empresa.Baja(auto);
                ConsultaFiltrada();//muestratodo
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //mod
            try
            {
                Regex patron = new Regex(@"[a-z]{3}\d{3}");
                if (patron.IsMatch(txpatente.Text))
                {
                    Auto autoNew = new Auto(txpatente.Text, int.Parse(txAnio.Text),
                     decimal.Parse(txValor.Text), DateTime.Parse(txIngreso.Text), txEgreso.Text);

                    AutoProyeccion autoP = dataGridView1.SelectedRows[0].DataBoundItem as AutoProyeccion;
                    Auto auto = autoP.Auto;

                    if (empresa.Modificacion(autoNew, auto.Patente))
                    {
                        textBoxErrores.Clear();
                        textBoxErrores.Text = "La patente ya existe";
                    } 
                    ConsultaFiltrada();//muestratodo
                }
                else
                {
                    //programar el evento
                    PatenteErronea(this, new EventArgs());
                }

            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AutoProyeccion autoP = dataGridView1.SelectedRows[0].DataBoundItem as AutoProyeccion;
                Auto auto = autoP.Auto;
                txpatente.Text = (auto.Patente).ToString();
                txAnio.Text = (auto.Anio).ToString(); 
                txValor.Text = (auto.Valor).ToString();
                txIngreso.Text = (auto.Ingreso).ToString();
                txEgreso.Text = (auto.Egreso).ToString();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaDHValorResidual();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
            
        }

        private void txFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MostarDataSource(empresa.MappeoLAaLAP(empresa.ConsultaFiltrada(txFiltro.Text)), dataGridView1);
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }



        //GDI PART
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                //MostarDataSource(empresa.CalcularCantidades(), dataGridView2);
                Graficar();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }
        public void Graficar()
        {
            List<PGDI> ListaPgdi = empresa.CalcularCantidades();
            MostarDataSource(ListaPgdi, dataGridView2);
            try
            {
                Graphics gr = this.CreateGraphics();
                

                float X=800;
                float Ancho =45;
                SolidBrush sb = new SolidBrush(Color.Red);
                SolidBrush sb2 = new SolidBrush(Color.Aqua);
                gr.FillRectangle(sb2, X-25, 35,550 ,230 );
                
                foreach (var proyeccion in ListaPgdi)
                {
                    float Altura =(float)(proyeccion.Porcentaje*2);
                    float Y= 40+(200- Altura);

                    gr.FillRectangle(sb, X, Y, Ancho, Altura);

                    Font font = new Font("Arial", 8);
                    gr.DrawString(proyeccion.Porcentaje.ToString()+"%",
                        font,sb,X,250);

                    X += 50;
                }

                //Torta
                Rectangle rectangulo = new Rectangle(1020,350,200,200);
                float comienzo = 0;
                Random r = new Random(DateTime.Now.Millisecond);
                foreach (var proyeccion in ListaPgdi)
                {
                    SolidBrush sb3 = new SolidBrush(Color.FromArgb(r.Next(0,255), r.Next(0, 255), r.Next(0, 255)));


                    float porcion = (float)((proyeccion.Porcentaje/100)*360);

                    gr.FillPie(sb3,rectangulo,comienzo,porcion);

                    comienzo += porcion;
                }
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }
    }
}
