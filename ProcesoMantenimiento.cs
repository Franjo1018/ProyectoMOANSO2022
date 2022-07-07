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
    public partial class ProcesoMantenimiento : Form
    {
        public ProcesoMantenimiento()
        {
            InitializeComponent();
            listarProcesoMantenimiento();
            groupBoxDatos.Enabled = false;
            txtCodigoProceso.Enabled = false;
        }

        public void listarProcesoMantenimiento()
        {
            dgvProceso.DataSource = logProcesoMantenimiento.Instancia.ListarProcesoMantenimiento();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProcesoMantenimiento c = new entProcesoMantenimiento();
                c.procedimiento = txtProcedimiento.Text.Trim();
                c.duracion = txtDuracion.Text.Trim();
                c.tipoProceso = txtTipoProceso.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegProceso = dtPickerRegProceso.Value;
                logProcesoMantenimiento.Instancia.InsertarProcesoMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarProcesoMantenimiento();
        }

        private void LimpiarVariables()
        {
            txtTipoProceso.Text = "";
            txtProcedimiento.Text = " ";
            txtDuracion.Text = " ";
            txtDescripcion.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvProceso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProceso.Rows[e.RowIndex]; //
            txtCodigoProceso.Text = filaActual.Cells[0].Value.ToString();
            txtProcedimiento.Text = filaActual.Cells[1].Value.ToString();
            txtDuracion.Text = filaActual.Cells[2].Value.ToString();
            txtTipoProceso.Text = filaActual.Cells[3].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegProceso.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProcesoMantenimiento c = new entProcesoMantenimiento();
                c.codigoProceso = int.Parse(txtCodigoProceso.Text.Trim());
                c.procedimiento = txtProcedimiento.Text.Trim();
                c.duracion = txtDuracion.Text.Trim();
                c.tipoProceso = txtTipoProceso.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegProceso = dtPickerRegProceso.Value;
                logProcesoMantenimiento.Instancia.InsertarProcesoMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarProcesoMantenimiento();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProcesoMantenimiento c = new entProcesoMantenimiento();

                c.codigoProceso = int.Parse(txtCodigoProceso.Text.Trim());
                logProcesoMantenimiento.Instancia.DeshabilitarProcesoMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarProcesoMantenimiento();
        }
    }
}
