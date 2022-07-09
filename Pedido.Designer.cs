
namespace ProyectoMOANSO
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosPedido = new System.Windows.Forms.GroupBox();
            this.txtEstadoPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClienteID = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtPickerRegPedido = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPickerRegSolicitada = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.gbDatosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosPedido
            // 
            this.gbDatosPedido.Controls.Add(this.txtEstadoPedido);
            this.gbDatosPedido.Controls.Add(this.label8);
            this.gbDatosPedido.Controls.Add(this.cmbClienteID);
            this.gbDatosPedido.Controls.Add(this.txtCantidad);
            this.gbDatosPedido.Controls.Add(this.label7);
            this.gbDatosPedido.Controls.Add(this.cmbTipoPedido);
            this.gbDatosPedido.Controls.Add(this.txtDescripcion);
            this.gbDatosPedido.Controls.Add(this.dtPickerRegPedido);
            this.gbDatosPedido.Controls.Add(this.label6);
            this.gbDatosPedido.Controls.Add(this.label4);
            this.gbDatosPedido.Controls.Add(this.dtPickerRegSolicitada);
            this.gbDatosPedido.Controls.Add(this.txtCodigoPedido);
            this.gbDatosPedido.Controls.Add(this.label5);
            this.gbDatosPedido.Controls.Add(this.label3);
            this.gbDatosPedido.Controls.Add(this.label2);
            this.gbDatosPedido.Controls.Add(this.label1);
            this.gbDatosPedido.Controls.Add(this.btnAgregar);
            this.gbDatosPedido.Controls.Add(this.btnCancelar);
            this.gbDatosPedido.Controls.Add(this.btnModificar);
            this.gbDatosPedido.Location = new System.Drawing.Point(11, 185);
            this.gbDatosPedido.Name = "gbDatosPedido";
            this.gbDatosPedido.Size = new System.Drawing.Size(655, 180);
            this.gbDatosPedido.TabIndex = 20;
            this.gbDatosPedido.TabStop = false;
            this.gbDatosPedido.Text = "Datos de Pedido";
            // 
            // txtEstadoPedido
            // 
            this.txtEstadoPedido.Location = new System.Drawing.Point(407, 139);
            this.txtEstadoPedido.Name = "txtEstadoPedido";
            this.txtEstadoPedido.Size = new System.Drawing.Size(30, 20);
            this.txtEstadoPedido.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Estado Pedido";
            // 
            // cmbClienteID
            // 
            this.cmbClienteID.FormattingEnabled = true;
            this.cmbClienteID.Location = new System.Drawing.Point(75, 85);
            this.cmbClienteID.Name = "cmbClienteID";
            this.cmbClienteID.Size = new System.Drawing.Size(53, 21);
            this.cmbClienteID.TabIndex = 26;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(227, 83);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtCantidad.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cantidad";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Location = new System.Drawing.Point(87, 58);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPedido.TabIndex = 22;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // dtPickerRegPedido
            // 
            this.dtPickerRegPedido.Location = new System.Drawing.Point(318, 41);
            this.dtPickerRegPedido.Name = "dtPickerRegPedido";
            this.dtPickerRegPedido.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegPedido.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha Solicitada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descripcion";
            // 
            // dtPickerRegSolicitada
            // 
            this.dtPickerRegSolicitada.Location = new System.Drawing.Point(318, 103);
            this.dtPickerRegSolicitada.Name = "dtPickerRegSolicitada";
            this.dtPickerRegSolicitada.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegSolicitada.TabIndex = 17;
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Location = new System.Drawing.Point(99, 28);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(63, 20);
            this.txtCodigoPedido.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo Pedido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(574, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(574, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(574, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(793, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDesabilitar
            // 
            this.btnDesabilitar.Location = new System.Drawing.Point(776, 247);
            this.btnDesabilitar.Name = "btnDesabilitar";
            this.btnDesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDesabilitar.TabIndex = 18;
            this.btnDesabilitar.Text = "Desabilitar";
            this.btnDesabilitar.UseVisualStyleBackColor = true;
            this.btnDesabilitar.Click += new System.EventHandler(this.btnDesabilitar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(776, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 46);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Modificar Pedido";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(682, 187);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(75, 42);
            this.btnNuevoPedido.TabIndex = 16;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(11, 12);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(840, 150);
            this.dgvPedido.TabIndex = 15;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 369);
            this.Controls.Add(this.gbDatosPedido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.dgvPedido);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.gbDatosPedido.ResumeLayout(false);
            this.gbDatosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPedido;
        private System.Windows.Forms.DateTimePicker dtPickerRegSolicitada;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.DateTimePicker dtPickerRegPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.ComboBox cmbClienteID;
        private System.Windows.Forms.TextBox txtEstadoPedido;
        private System.Windows.Forms.Label label8;
    }
}