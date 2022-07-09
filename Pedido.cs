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
            llenarDatosCBCliente();
            llenarDatosCBTipoPedido();
            listarPedido();
            gbDatosPedido.Enabled = false;
            txtCodigoPedido.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
        }

        public void listarPedido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
        }

        private void llenarDatosCBTipoPedido()
        {
            cmbTipoPedido.DataSource = logTipopedido.Instancia.ListarTipoPedido();
            cmbTipoPedido.DisplayMember = "Nombre_tipo_pedido";
            cmbTipoPedido.ValueMember = "TipopedidoID";
        }

        private void llenarDatosCBCliente()
        {
            cmbClienteID.DataSource = logCliente.Instancia.ListarCliente();
            cmbClienteID.DisplayMember = "ClienteID";
            cmbClienteID.ValueMember = "ClienteID";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }


        private void LimpiarVariables()
        {
            
            txtCantidad.Text = " ";
            txtDescripcion.Text = " ";
            txtCodigoPedido.Text = " ";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = false;
            btnAgregar.Visible = false;
            btnAgregar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
            btnModificar.Visible = false;
            btnModificar.Enabled = false;
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = true;
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPedido Ped = new entPedido();
                Ped.cantidad = int.Parse(txtCantidad.Text.Trim());
                Ped.descripcion = txtDescripcion.Text.Trim();
                Ped.estado_pedido = int.Parse(txtEstadoPedido.Text.Trim());
                Ped.fecRegPedido = dtPickerRegPedido.Value;
                Ped.fecRegSolicitada = dtPickerRegSolicitada.Value;
                Ped.clienteID = Convert.ToInt32(cmbClienteID.SelectedValue);
                Ped.tipoPedidoID = Convert.ToInt32(cmbTipoPedido.SelectedValue);
                logPedido.Instancia.InsertarPedido(Ped);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosPedido.Enabled = false;
            listarPedido();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPedido Ped = new entPedido();
                Ped.cantidad = int.Parse(txtCantidad.Text.Trim());
                Ped.descripcion = txtDescripcion.Text.Trim();
                Ped.estado_pedido = int.Parse(txtEstadoPedido.Text.Trim());
                Ped.fecRegPedido = dtPickerRegPedido.Value;
                Ped.fecRegSolicitada = dtPickerRegSolicitada.Value;
                Ped.pedidoID = int.Parse(txtCodigoPedido.Text.Trim());
                Ped.clienteID = Convert.ToInt32(cmbClienteID.SelectedValue);
                Ped.tipoPedidoID = Convert.ToInt32(cmbTipoPedido.SelectedValue);
                logPedido.Instancia.EditarPedido(Ped);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatosPedido.Enabled = false;
            listarPedido();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            gbDatosPedido.Enabled = true;
            btnModificar.Visible = true;
            btnModificar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPedido.Rows[e.RowIndex]; //
            txtCantidad.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[1].Value.ToString();
            txtEstadoPedido.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegPedido.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegSolicitada.Text = filaActual.Cells[4].Value.ToString();
            txtCodigoPedido.Text = filaActual.Cells[5].Value.ToString();
            cmbClienteID.Text = filaActual.Cells[6].Value.ToString();
            cmbTipoPedido.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnDesabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPedido Pe = new entPedido();
                Pe.pedidoID = int.Parse(txtCodigoPedido.Text.Trim());
                logPedido.Instancia.DeshabilitarPedido(Pe);
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
