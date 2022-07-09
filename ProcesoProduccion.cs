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
    public partial class ProcesoProduccion : Form
    {
        public ProcesoProduccion()
        {
            InitializeComponent();
            ListarProcesoProduccion();
            llenarDatosCBArea();
            llenarDatosCBTipoProceso();
            gbProcesoProduccion.Enabled = false;
            txtProcesoProduccionID.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        public void ListarProcesoProduccion()
        {
            dgvProcesoProduccion.DataSource = logProcesoProduccion.Instancia.ListarProcesoProduccion();
        }

        private void llenarDatosCBArea()
        {
            cmbArea.DataSource = logArea.Instancia.ListarArea();
            cmbArea.DisplayMember = "Nombre_area";
            cmbArea.ValueMember = "AreaID";
        }

        private void llenarDatosCBTipoProceso()
        {
            cmbTipoProceso.DataSource = logTipoproceso.Instancia.ListarTipoProceso();
            cmbTipoProceso.DisplayMember = "Nombre_tipo_proceso";
            cmbTipoProceso.ValueMember = "TipoprocesoID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProcesoProduccion PrPr = new entProcesoProduccion();
                PrPr.descripcion = txtDescripcion.Text.Trim();
                PrPr.duracion = Convert.ToInt32(txtduracion.Text.Trim());
                PrPr.nombre_proceso = txtNombre.Text.Trim();
                PrPr.areaID = Convert.ToInt32(cmbArea.SelectedValue);
                PrPr.tipoProcesoID = Convert.ToInt32(cmbTipoProceso.SelectedValue);
                logProcesoProduccion.Instancia.InsertarProcesoProduccion(PrPr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProcesoProduccion.Enabled = false;
            ListarProcesoProduccion();
        }

        private void LimpiarVariables()
        {
            txtDescripcion.Text = " ";
            txtduracion.Text = " ";
            txtNombre.Text = " ";
            txtProcesoProduccionID.Text = " ";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProcesoProduccion PrPr = new entProcesoProduccion();
                PrPr.descripcion = txtDescripcion.Text.Trim();
                PrPr.duracion = Convert.ToInt32(txtduracion.Text.Trim());
                PrPr.nombre_proceso = txtNombre.Text.Trim();
                PrPr.ProcesoProduccionID = Convert.ToInt32(txtProcesoProduccionID.Text.Trim());
                PrPr.areaID = Convert.ToInt32(cmbArea.SelectedValue);
                PrPr.tipoProcesoID = Convert.ToInt32(cmbTipoProceso.SelectedValue);
                logProcesoProduccion.Instancia.InsertarProcesoProduccion(PrPr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProcesoProduccion.Enabled = false;
            ListarProcesoProduccion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbProcesoProduccion.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProcesoProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProcesoProduccion.Rows[e.RowIndex]; 
            txtDescripcion.Text = filaActual.Cells[0].Value.ToString();
            txtduracion.Text = filaActual.Cells[1].Value.ToString();
            txtNombre.Text = filaActual.Cells[2].Value.ToString();
            txtProcesoProduccionID.Text = filaActual.Cells[3].Value.ToString();
            cmbArea.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoProceso.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnNuevoProceso_Click(object sender, EventArgs e)
        {
            gbProcesoProduccion.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void btnModificarProceso_Click(object sender, EventArgs e)
        {
            gbProcesoProduccion.Enabled = true;
            btnModificar.Visible = true;
            btnModificar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }
    }
}
