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
            groupBoxDatos.Enabled = false;
            txtCodigoPedido.Enabled = false;
        }

        public void listarPedido()
        {
            dgvPedido.DataSource = logPedido.Instancia.ListarPedido();
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
                entPedido c = new entPedido();
                c.tipoPedido = txtTipoPedido.Text.Trim();
                c.nombrecliente = txtNombreCliente.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegInicio = dtPickerRegInicio.Value;
                c.fecRegTermino = dtPickerRegTermino.Value;
                logPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            listarPedido();
        }

        private void LimpiarVariables()
        {
            txtTipoPedido.Text = "";
            txtNombreCliente.Text = " ";
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
            txtTipoPedido.Text = filaActual.Cells[1].Value.ToString();
            txtNombreCliente.Text = filaActual.Cells[2].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegInicio.Text = filaActual.Cells[4].Value.ToString();
            dtPickerRegTermino.Text = filaActual.Cells[5].Value.ToString();
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
                entPedido c = new entPedido();
                c.codigoPedido = int.Parse(txtCodigoPedido.Text.Trim());
                c.tipoPedido = txtTipoPedido.Text.Trim();
                c.nombrecliente = txtNombreCliente.Text.Trim();
                c.descripcion = txtDescripcion.Text.Trim();
                c.fecRegInicio = dtPickerRegInicio.Value;
                c.fecRegTermino = dtPickerRegTermino.Value;
                logPedido.Instancia.InsertarPedido(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
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
            groupBoxDatos.Enabled = false;
            listarPedido();
        }
    }
}
