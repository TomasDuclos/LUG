using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLER;

namespace VL
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        ControlerUi controlerui;

        private void UI_Load(object sender, EventArgs e)
        {
            controlerui = new ControlerUi(this);
            controlerui.ConsultaTodos();
        }

        private void button1Alta_Click(object sender, EventArgs e)
        {
            try
            {
                controlerui.Alta();
                controlerui.ConsultaTodos();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text=ex.Message;
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                controlerui.Baja();
                controlerui.ConsultaTodos();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }

        private void buttonMODIFICACION_Click(object sender, EventArgs e)
        {
            try
            {
                controlerui.Alta();
                controlerui.ConsultaTodos();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }

        private void button3CONSULTA_Click(object sender, EventArgs e)
        {
            try
            {
                controlerui.Alta();
                controlerui.ConsultaTodos();
            }
            catch (Exception ex)
            {
                textBoxErrores.Clear();
                textBoxErrores.Text = ex.Message;
            }
        }
    }
}
