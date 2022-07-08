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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            listarPedido();
            gbDatosPedido.Enabled = false;
            txtCodigoPedido.Enabled = false;
        }

        public void listarPedido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entPedido c = new entPedido();
               
                c.nombrecliente = txtIDCliente.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegInicio = dtPickerRegPedido.Value;
                c.fecRegTermino = dtPickerRegSolicitada.Value;
                logPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosPedido.Enabled = false;
            listarPedido();
        }

        private void LimpiarVariables()
        {
            
            txtIDCliente.Text = " ";
            txtDescripcion.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvMueble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPedido.Rows[e.RowIndex]; //
            txtCodigoPedido.Text = filaActual.Cells[0].Value.ToString();
           
            txtIDCliente.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegPedido.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegSolicitada.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedido c = new entPedido();
                c.codigoPedido = int.Parse(txtCodigoPedido.Text.Trim());
               
                c.nombrecliente = txtIDCliente.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegInicio = dtPickerRegPedido.Value;
                c.fecRegTermino = dtPickerRegSolicitada.Value;
                logPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosPedido.Enabled = false;
            listarPedido();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedido c = new entPedido();

                c.codigoPedido = int.Parse(txtCodigoPedido.Text.Trim());
                logPedido.Instancia.DeshabilitarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosPedido.Enabled = false;
            listarPedido();
        }
    }
}
