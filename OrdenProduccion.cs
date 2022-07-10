using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogicaNegocio;
using CapaEntidad;

namespace ProyectoMOANSO
{
    public partial class OrdenProduccion : Form
    {
        public OrdenProduccion()
        {
            InitializeComponent();
            listarProcesoMantenimiento();
            groupBoxDatos.Enabled = false;
            txtCodigoProceso.Enabled = false;
        }

        public void listarProcesoMantenimiento()
        {
            //dgvProceso.DataSource = logProcesoMantenimiento.Instancia.ListarProcesoMantenimiento();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            //try
            //{
            //    entProcesoMantenimiento c = new entProcesoMantenimiento();
            //    c.procedimiento = txtProcedimiento.Text.Trim();
            //    c.duracion = txtDuracion.Text.Trim();
            //    c.tipoProceso = txtTipoProceso.Text.Trim();
            //    c.descripcion = txtDescripcion.Text.Trim();
            //    c.fecRegProceso = dtPickerRegProceso.Value;
            //    logProcesoMantenimiento.Instancia.InsertarProcesoMantenimiento(c);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarVariables();
            //groupBoxDatos.Enabled = false;
            //listarProcesoMantenimiento();
        }

        private void LimpiarVariables()
        {

            txtProcedimiento.Text = " ";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
 
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    entProcesoMantenimiento c = new entProcesoMantenimiento();
            //    c.codigoProceso = int.Parse(txtCodigoProceso.Text.Trim());
            //    c.procedimiento = txtProcedimiento.Text.Trim();
            //    c.duracion = txtDuracion.Text.Trim();
            //    c.tipoProceso = txtTipoProceso.Text.Trim();
            //    c.descripcion = txtDescripcion.Text.Trim();
            //    c.fecRegProceso = dtPickerRegProceso.Value;
            //    logProcesoMantenimiento.Instancia.InsertarProcesoMantenimiento(c);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarVariables();
            //groupBoxDatos.Enabled = false;
            //listarProcesoMantenimiento();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    entProcesoMantenimiento c = new entProcesoMantenimiento();

            //    c.codigoProceso = int.Parse(txtCodigoProceso.Text.Trim());
            //    logProcesoMantenimiento.Instancia.DeshabilitarProcesoMantenimiento(c);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarVariables();
            //groupBoxDatos.Enabled = false;
            //listarProcesoMantenimiento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequerimientoMateriales f = new RequerimientoMateriales();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
        }
    }
}
