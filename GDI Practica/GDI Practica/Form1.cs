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


namespace GDI_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked=true;
        }
        int Contador=0;
        GeneradorNumeros GN;
        private void Form1_Load(object sender, EventArgs e)
        {
            //crteo a generador de numeros
            GN = new GeneradorNumeros();
            //creo las rows de datagried
            for (int i = 0; i < GN.getLista().Count; i++)
            {
                dataGridView1.Rows.Add();
            }
        }
        
        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            Graphics GR=Graphics.FromHwnd(this.Handle);
            if (radioButton1.Checked is true)
            {

                GR.FillEllipse(Brushes.Red, 10, 5, 100, 100);
            }
            if (radioButton2.Checked is true)
            {

                GR.DrawEllipse(Pens.Black, 10, 5, 100, 100);
            }

        }

        public void Mostrar(List<VistaNumeros> a)
        {
            //cargo el gried con la lista proveniente del GN 
            int n = 0;
            foreach (VistaNumeros VN in a)
            {              
                dataGridView1.Rows[n].Cells[0].Value = VN.Numero;
                dataGridView1.Rows[n].Cells[1].Value = VN.Apariciones;
                dataGridView1.Rows[n].Cells[2].Value = VN.Porcentage;
                dataGridView1.Rows[n].Cells[3].Style.BackColor = VN.SB.Color;
                n++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // contador cuenta las tiradas
            Contador++;
            Mostrar(GN.RandomNumeros(Contador));
            GN.GraficarTorta(this,Contador);
            GN.GraficarBarra(this);
        }
    }
    public class VistaNumeros
    {
        //clase de vista
        public int Numero { get; set; }
        public int Apariciones { get; set; }
        public double Porcentage { get; set; }
        public SolidBrush SB { get; set; }// tiene el color que le toco
    }
    public class GeneradorNumeros
    {
        public GeneradorNumeros()
        {
            LVN = new List<VistaNumeros>();
            int a = 0;
            for (int i = 0; i < 4; i++)
            {
                VistaNumeros Vnum = new VistaNumeros();
                Random random = new Random(DateTime.Now.Millisecond);
                for (int j = 0; j < 100000; j++)
                {
                    a=random.Next(0, 255);
                }//si le sacan el for les da 3 colores casi iguales jajajajja nose porque

                SolidBrush sb = new SolidBrush(Color.FromArgb(a, random.Next(0, 255), random.Next(0, 255)));
                Vnum.SB = sb;
                Vnum.Numero = i;
                LVN.Add(Vnum);
            }
        }

        public List<VistaNumeros> LVN { get; set; }

        public List<VistaNumeros> RandomNumeros(int cont)
        {
            Random a = new Random();
            int num = a.Next(0, 4);
            calcularPorcentaje(num, cont);
            return LVN;
        }
        public void calcularPorcentaje(int num, int cont)
        {
            int Tiradas = cont;
            VistaNumeros VN = LVN.Find(x => x.Numero == num);
            VN.Apariciones++;
            foreach (VistaNumeros vn in LVN)
            {
                if (vn.Apariciones!=0)
                {
                    double a= (double)vn.Apariciones / (double)Tiradas ;
                    vn.Porcentage = Math.Round((a*100),4);
                }
            }
            
        }
        public List<VistaNumeros> getLista()
        {
            return LVN;             
        }

        public void GraficarTorta(Form formulario,int tiradas)
        {

            Graphics G = formulario.CreateGraphics();
           // Random randon = new Random();
            //SolidBrush SB = new SolidBrush(Color.FromArgb(randon.Next(0, 256), randon.Next(0, 256), randon.Next(0, 256)));
            float desde = 2;
            foreach (VistaNumeros vn in LVN)
            {
                if (vn.Apariciones != 0)// este if es por si la aparicion es 0 y rompe todo porque divide por 0
                {
                    
                    double a = (double)vn.Apariciones / (double)tiradas;// apariciones sobre tiradas
                    double porcion = Math.Round((a * 360), 6);// lo de rriba por 360

                    G.FillPie(vn.SB, 100, 5, 300, 300, desde, (float)porcion);//fillpie pide color que esta guardado en la vista x y w h desde donde va a graficar y cuanto
                    desde += (float)porcion+2;// incrementamos para que el porximo arranque un cachito adelante

                }
            }
        }
        public void GraficarBarra(Form formulario)
        {
            Graphics G = formulario.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.White);
            int i = 500;
            //rectangulo blanco
            G.FillRectangle(sb, i,10, 45*LVN.Count, 300);



            foreach (VistaNumeros vn in LVN)
            {
                if (vn.Apariciones!=0)
                {
                    float height= (float)vn.Porcentage * 3;
                    float y = 10+(300-height);
                    G.FillRectangle(vn.SB, i, y, 40,height) ;
                    
                }
                i += 45;
            }

        }


    }
}
