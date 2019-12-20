using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ENTITYES;

namespace VISTA
{
    public partial class ABM : UserControl
    {
        public ABM()
        {
            InitializeComponent();
        }
        Auto auto;
        private void ABM_Load(object sender, EventArgs e)
        {
            auto = new Auto();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //alta
            Regex patron = new Regex(@"[a-zA-Z]{3}\d{3}");
            if (patron.IsMatch(txpatente.Text))
            {
                Auto nuevo = new Auto(txpatente.Text,int.Parse(txAnio.Text),
                 decimal.Parse(txValor.Text),DateTime.Parse(txAnio.Text),txEgreso.Text);                    
            }
            else
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //baja
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mod
        }


    }
}
