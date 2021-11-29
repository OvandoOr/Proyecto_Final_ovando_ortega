using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Tipo_de_sesion : Form
    {
        int cont = 0;
        public Tipo_de_sesion()
        {
            InitializeComponent();
            timer1.Interval = 200;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (cont==15)
            {
                Capa_de_Presentacion.FormMenuPrincipal MP = new Capa_de_Presentacion.FormMenuPrincipal();

                MP.Show();
                this.Hide();
            }
            cont++;
               
        }
    }
}
