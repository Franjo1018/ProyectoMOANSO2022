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
    public partial class PersonalProduccion : Form
    {
        public PersonalProduccion()
        {
            InitializeComponent();
        }

        public void listarPersonalProduccion()
        {
            dgvPersonal.DataSource = logPersonalProduccion.Instancia.ListarPersonalProduccion();
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
                entPersonalProduccion c = new entPersonalProduccion();
                c.puesto = txtPuesto.Text.Trim();
                c.tipoPersonal = txtTipoPersonal.Text.Trim();
                c.nombre = txtNombre.Text.Trim();
                c.fecRegIngreso = dtPickerRegIngreso.Value;
                logPersonalProduccion.Instancia.InsertarPersonalProduccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarPersonalProduccion();
        }

        private void LimpiarVariables()
        {
            txtTipoPersonal.Text = "";
            txtPuesto.Text = " ";
            txtNombre.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvMueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPersonal.Rows[e.RowIndex]; //
            txtCodigoPersonal.Text = filaActual.Cells[0].Value.ToString();
            txtPuesto.Text = filaActual.Cells[1].Value.ToString();
            txtTipoPersonal.Text = filaActual.Cells[2].Value.ToString();
            txtNombre.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegIngreso.Text = filaActual.Cells[4].Value.ToString();
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
                entPersonalProduccion c = new entPersonalProduccion();
                c.codigoPersonal = int.Parse(txtCodigoPersonal.Text.Trim());
                c.puesto = txtPuesto.Text.Trim();
                c.tipoPersonal = txtTipoPersonal.Text.Trim();
                c.nombre = txtNombre.Text.Trim();
                c.fecRegIngreso = dtPickerRegIngreso.Value;
                logPersonalProduccion.Instancia.InsertarPersonalProduccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarPersonalProduccion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPersonalProduccion c = new entPersonalProduccion();

                c.codigoPersonal = int.Parse(txtCodigoPersonal.Text.Trim());
                logPersonalProduccion.Instancia.DeshabilitarPersonalProduccion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarPersonalProduccion();
        }
    }
}
