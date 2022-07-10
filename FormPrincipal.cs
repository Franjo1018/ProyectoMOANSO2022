using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMOANSO
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void planoDeMuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanodeMueble f = new PlanodeMueble();
            f.Show();
        }

        private void muebleTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuebleTerminado f = new MuebleTerminado();
            f.Show();
        }

        private void procesoDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesoProduccion f = new ProcesoProduccion();
            f.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido f = new Pedido();
            f.Show();
        }

        private void personalDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalProduccion f = new PersonalProduccion();
            f.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenProduccion f = new OrdenProduccion();
            f.Show();
        }
    }
}
