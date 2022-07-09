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
    public partial class PlanodeMueble : Form
    {
        public PlanodeMueble()
        {
            InitializeComponent();
            llenarDatosCBMaterial();
            //PlanoID();
            gbPlanoMueble.Enabled = false;
            gbMateriales.Enabled = false;
        }

        public void PlanoID()
        {
            int id = logPlanodeMueble.Instancia.PlanoID();
            txtPlanoiID.Text = Convert.ToString(id);
        }

        public void listarMateriales()
        {
            int id;
            id = int.Parse(txtPlanoiID.Text.Trim());
            dgvMaterialesPlano.DataSource = logDetallemueble.Instancia.ListarDetalleMueble(id);
        }
        private void llenarDatosCBMaterial()
        {
            cmbMaterial.DataSource = logMaterial.Instancia.ListarMaterial();
            cmbMaterial.DisplayMember = "Nombre_material";
            cmbMaterial.ValueMember = "MaterialID";
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                BoxImagenPlano.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {    
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                BoxImagenPlano.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                entPlanodeMueble PlMu = new entPlanodeMueble();
                PlMu.estado_plano = txtEstadoPlano.Text.Trim();
                PlMu.fecha_plano = dTpFechaPlano.Value;
                PlMu.foto = ms.GetBuffer();

                logPlanodeMueble.Instancia.InsertarPlanodeMueble(PlMu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            
            
        }

        private void btnNuevoPlano_Click(object sender, EventArgs e)
        {
            gbPlanoMueble.Enabled = true;
            gbMateriales.Enabled = true;
            LimpiarVariables();
        }

        public void LimpiarVariables()
        {
            txtCantidad.Text = " ";
            txtEstadoPlano.Text = " ";
            txtMedidas.Text = " ";
            txtPlanoiID.Text = " ";

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                entDetallemueble DeMu = new entDetallemueble();
                DeMu.cantidad = int.Parse(txtCantidad.Text.Trim());
                DeMu.medidas = txtMedidas.Text.Trim();
                DeMu.planodeMuebleID = int.Parse(txtPlanoiID.Text.Trim());
                DeMu.materialID = Convert.ToInt32(cmbMaterial.SelectedValue);
                logDetallemueble.Instancia.InsertarDetalleMueble(DeMu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarMateriales();
        }
    }
}
