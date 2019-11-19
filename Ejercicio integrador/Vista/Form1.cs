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
using Entidades;
using System.Text.RegularExpressions;

namespace Vista
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Inmobiliaria inmobiliaria;

        private void Form1_Load(object sender, EventArgs e)
        {
            inmobiliaria = new Inmobiliaria();
            MostrarDGVinmuebles();
        }

        //ABMC.CT
        public void AltaInmueble()
        {
            try
            {
                //Inmueble nuyevo = new Inmueble();
                
                //inmobiliaria.AltaInmueble()
            }
            catch (Exception)
            {
            }
        }
        public void BajaInmueble()
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }
        public void ModificacionInmueble()
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }

        public void ConsultaInmueble()
        {
            try
            {
                //List<Inmueble> a=new List<Inmueble>();

            }
            catch (Exception)
            {
            }
        }
        //ALTA
        private void button4_Click(object sender, EventArgs e)
        {          
            try
            {
                Regex pattern = new Regex(@"^(([A-Za-z]{3}[-]\d{3}))$");//[rango de numeros]{cantidad de numeros}
                if (pattern.IsMatch(textBoxId.Text))
                {
                    string id = textBoxId.Text;/////////////codigo si esta bien
                    DateTime? Fv = null;
                    if (TXTBOXFV.Text != "")
                    {
                        Fv = DateTime.Parse(TXTBOXFV.Text);
                    }
                    Inmueble inmueble = new Inmueble(id,textBoxDIR.Text, decimal.Parse(textBoxprecio.Text),
                        DateTime.Parse(textBoxFP.Text), Fv);

                   // inmueble.FechaVenta = Fv;

                    inmobiliaria.AltaInmueble(inmueble);
                    MostrarDGVinmuebles();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //MOD
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Inmueble inmuebleSelect = dataGridView1.SelectedRows[0].DataBoundItem as Inmueble;
                Inmueble inmueble = new Inmueble(inmuebleSelect.Id, textBoxDIR.Text, decimal.Parse(textBoxprecio.Text),
                DateTime.Parse(textBoxFP.Text), DateTime.Parse(TXTBOXFV.Text));

                inmobiliaria.ModificacionInmueble(inmueble);
                MostrarDGVinmuebles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //BAJA
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Inmueble inmuebleSelect = dataGridView1.SelectedRows[0].DataBoundItem as Inmueble;

                inmobiliaria.BajaInmueble(inmuebleSelect);
                MostrarDGVinmuebles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CONSULTA
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarDGVinmuebles()
        {
            inmobiliaria.CargarListaInmueble();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = inmobiliaria.LI;
        }
    }
}
