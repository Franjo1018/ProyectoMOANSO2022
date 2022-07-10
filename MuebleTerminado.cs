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
            llenarDatosCBTipoTinte();
            groupBoxDatos.Enabled = false;
            txtCodigoMueble.Enabled = false;
        }

        public void listarMuebleTerminado()
        {
            dgvMueble.DataSource = logMuebleTerminado.Instancia.ListarMuebleTerminado();
        }

        private void llenarDatosCBTipoTinte()
        {
            cmbTipoTinte.DataSource = logTipotinte.Instancia.ListarTipoTinte();
            cmbTipoTinte.DisplayMember = "Nombre_tinte";
            cmbTipoTinte.ValueMember = "TipotinteID";
        }

        private void llenarDatosCBPlano()
        {
            cmbPlano.DataSource = logPlanodeMueble.Instancia.ListarPlanodeMueble();
            cmbPlano.DisplayMember = "PlanodemuebleID";
            cmbPlano.ValueMember = "PlanodemuebleID";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnModificar.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMuebleTerminado Mue = new entMuebleTerminado();
                Mue.PlanodemuebleID = Convert.ToInt32(cmbPlano.SelectedValue);
                Mue.Descripcion = txtDescripcion.Text.Trim();
                Mue.OrdendeproduccionID = int.Parse(txtOrden.Text.Trim());
                Mue.Color_tinte = txtColor.Text.Trim();
                Mue.TipotinteID = Convert.ToInt32(cmbTipoTinte.SelectedValue);
                logMuebleTerminado.Instancia.InsertarMuebleTerminado(Mue);
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
            txtCodigoMueble.Text = " ";
            txtDescripcion.Text = " ";
            txtOrden.Text = " ";
            txtColor.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvMueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMueble.Rows[e.RowIndex]; //
            txtCodigoMueble.Text = filaActual.Cells[0].Value.ToString();
            txtColor.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            txtOrden.Text = filaActual.Cells[3].Value.ToString();
            cmbPlano.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoTinte.Text = filaActual.Cells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    entMuebleTerminado Mue = new entMuebleTerminado();
            //    Mue.MuebleID = int.Parse(txtCodigoMueble.Text.Trim());
            //    Mue.PlanodemuebleID = int.Parse(txtPlanoMueble.Text.Trim());
            //    Mue.Descripcion = txtDescripcion.Text.Trim();
            //    Mue.OrdendeproduccionID = int.Parse(txtOrden.Text.Trim());
            //    Mue.Color_tinte = txtColor.Text.Trim();
            //    Mue.TipotinteID = Convert.ToInt32(cmbTipoTinte.SelectedValue);
            //    logMuebleTerminado.Instancia.InsertarMuebleTerminado(Mue);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarVariables();
            //groupBoxDatos.Enabled = false;
            //listarMuebleTerminado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    entMuebleTerminado Mue = new entMuebleTerminado();
            //    Mue.MuebleID = int.Parse(txtCodigoMueble.Text.Trim());
            //    logMuebleTerminado.Instancia.DeshabilitarMuebleTerminado(Mue);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarVariables();
            //groupBoxDatos.Enabled = false;
            //listarMuebleTerminado();
        }
    }
}
