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
            listarPersonalProduccion();
            llenarDatosCBArea();
            llenarDatosCBTipoPersonal();
            txtPersonalID.Enabled = false;
            gbPersonalProduccion.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;           
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        public void listarPersonalProduccion()
        {
            dgvPersonal.DataSource = logPersonalProduccion.Instancia.ListarPersonalProduccion();
        }

        private void LimpiarVariables()
        {
            txtNombres.Text = " ";
            txtApellidos.Text = " ";
            txtEstadoPersonal.Text = " ";
            txtPersonalID.Text = " ";
        }
        private void llenarDatosCBArea()
        {
            cmbArea.DataSource = logArea.Instancia.ListarArea();
            cmbArea.DisplayMember = "Nombre_area";
            cmbArea.ValueMember = "AreaID";
        }

        private void llenarDatosCBTipoPersonal()
        {
            cmbTipoPersonal.DataSource = logTipopersonal.Instancia.ListarTipoPersonal();
            cmbTipoPersonal.DisplayMember = "Nombre_tipo_personal";
            cmbTipoPersonal.ValueMember = "TipoPersonalID";
        }

        

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            gbPersonalProduccion.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPersonalProduccion Per = new entPersonalProduccion();
                Per.apellidos_personal = txtApellidos.Text.Trim();
                Per.estado_personal = txtEstadoPersonal.Text.Trim();
                Per.nombres_personal = txtNombres.Text.Trim();
                Per.areaID = Convert.ToInt32(cmbArea.SelectedValue);
                Per.tipoPersonalID = Convert.ToInt32(cmbTipoPersonal.SelectedValue);
                logPersonalProduccion.Instancia.InsertarPersonalProduccion(Per);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPersonalProduccion.Enabled = false;
            listarPersonalProduccion();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPersonalProduccion Per = new entPersonalProduccion();
                Per.apellidos_personal = txtApellidos.Text.Trim();
                Per.estado_personal = txtEstadoPersonal.Text.Trim();
                Per.nombres_personal = txtNombres.Text.Trim();
                Per.personalID = Convert.ToInt32(txtPersonalID.Text.Trim());
                Per.areaID = Convert.ToInt32(cmbArea.SelectedValue);
                Per.tipoPersonalID = Convert.ToInt32(cmbTipoPersonal.SelectedValue);
                logPersonalProduccion.Instancia.EditarPersonalProduccion(Per);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPersonalProduccion.Enabled = false;
            listarPersonalProduccion();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            gbPersonalProduccion.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbPersonalProduccion.Enabled = true;
            btnModificar.Visible = true;
            btnModificar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPersonal.Rows[e.RowIndex]; //
            txtApellidos.Text = filaActual.Cells[0].Value.ToString();
            txtEstadoPersonal.Text = filaActual.Cells[1].Value.ToString();
            txtNombres.Text = filaActual.Cells[2].Value.ToString();
            txtPersonalID.Text = filaActual.Cells[3].Value.ToString();
            cmbArea.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoPersonal.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnDesabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPersonalProduccion Per = new entPersonalProduccion();

                Per.personalID = int.Parse(txtPersonalID.Text.Trim());
                logPersonalProduccion.Instancia.DeshabilitarPersonalProduccion(Per);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbPersonalProduccion.Enabled = false;
            listarPersonalProduccion();
        }
    }
}
