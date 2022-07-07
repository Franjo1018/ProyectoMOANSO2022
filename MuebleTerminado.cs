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
    public partial class MuebleTerminado : Form
    {
        public MuebleTerminado()
        {
            InitializeComponent();
            listarMuebleTerminado();
            groupBoxDatos.Enabled = false;
            txtCodigoMueble.Enabled = false;
        }

        public void listarMuebleTerminado()
        {
            dgvMueble.DataSource = logMuebleTerminado.Instancia.ListarMuebleTerminado();
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
                entMuebleTerminado c = new entMuebleTerminado();
                c.tipoMueble = txtTipoMueble.Text.Trim();
                c.planoMueble = txtPlanoMueble.Text.Trim();
                c.fecRegMueble = dtPickerRegMueble.Value;
                c.estadoMueble = cbkEstadoMueble.Checked;
                logMuebleTerminado.Instancia.InsertarMuebleTerminado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarMuebleTerminado();
        }

        private void LimpiarVariables()
        {
            txtTipoMueble.Text = "";
            txtPlanoMueble.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvMueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMueble.Rows[e.RowIndex]; //
            txtCodigoMueble.Text = filaActual.Cells[0].Value.ToString();
            txtTipoMueble.Text = filaActual.Cells[1].Value.ToString();
            txtPlanoMueble.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegMueble.Text = filaActual.Cells[3].Value.ToString();
            cbkEstadoMueble.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
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
                entMuebleTerminado c = new entMuebleTerminado();
                c.codigoMueble = int.Parse(txtCodigoMueble.Text.Trim());
                c.tipoMueble = txtTipoMueble.Text.Trim();
                c.planoMueble = txtPlanoMueble.Text.Trim();
                c.fecRegMueble = dtPickerRegMueble.Value;
                c.estadoMueble = cbkEstadoMueble.Checked;
                logMuebleTerminado.Instancia.InsertarMuebleTerminado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarMuebleTerminado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMuebleTerminado c = new entMuebleTerminado();

                c.codigoMueble = int.Parse(txtCodigoMueble.Text.Trim());
                cbkEstadoMueble.Checked = false;
                c.estadoMueble = cbkEstadoMueble.Checked;
                logMuebleTerminado.Instancia.DeshabilitarMuebleTerminado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarMuebleTerminado();
        }
    }
}
