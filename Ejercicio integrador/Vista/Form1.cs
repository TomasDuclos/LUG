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
        }

        //ABMC.CT
        public void AltaInmueble()
        {
            try
            {
                Inmueble nuyevo = new Inmueble();
          
                inmobiliaria.AltaInmueble()
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
    }
}
