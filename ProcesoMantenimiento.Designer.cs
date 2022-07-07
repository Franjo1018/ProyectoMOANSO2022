
namespace ProyectoMOANSO
{
    partial class ProcesoMantenimiento
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dtPickerRegProceso = new System.Windows.Forms.DateTimePicker();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.txtCodigoProceso = new System.Windows.Forms.TextBox();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvProceso = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoProceso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtDescripcion);
            this.groupBoxDatos.Controls.Add(this.label6);
            this.groupBoxDatos.Controls.Add(this.txtTipoProceso);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.dtPickerRegProceso);
            this.groupBoxDatos.Controls.Add(this.txtDuracion);
            this.groupBoxDatos.Controls.Add(this.txtProcedimiento);
            this.groupBoxDatos.Controls.Add(this.txtCodigoProceso);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Location = new System.Drawing.Point(25, 178);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(655, 180);
            this.groupBoxDatos.TabIndex = 20;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "datos del Proceso de Mantenimiento";
            // 
            // dtPickerRegProceso
            // 
            this.dtPickerRegProceso.Location = new System.Drawing.Point(362, 66);
            this.dtPickerRegProceso.Name = "dtPickerRegProceso";
            this.dtPickerRegProceso.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegProceso.TabIndex = 17;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(73, 99);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(265, 20);
            this.txtDuracion.TabIndex = 15;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Location = new System.Drawing.Point(96, 69);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(242, 20);
            this.txtProcedimiento.TabIndex = 14;
            // 
            // txtCodigoProceso
            // 
            this.txtCodigoProceso.Location = new System.Drawing.Point(119, 39);
            this.txtCodigoProceso.Name = "txtCodigoProceso";
            this.txtCodigoProceso.Size = new System.Drawing.Size(219, 20);
            this.txtCodigoProceso.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "fecha de registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Procedimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo Proceso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(574, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(574, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(574, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(682, 149);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnDesabilitar
            // 
            this.btnDesabilitar.Location = new System.Drawing.Point(682, 103);
            this.btnDesabilitar.Name = "btnDesabilitar";
            this.btnDesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDesabilitar.TabIndex = 18;
            this.btnDesabilitar.Text = "desabilitar";
            this.btnDesabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(682, 61);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(682, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvProceso
            // 
            this.dgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProceso.Location = new System.Drawing.Point(25, 22);
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.ReadOnly = true;
            this.dgvProceso.Size = new System.Drawing.Size(618, 150);
            this.dgvProceso.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo Proceso";
            // 
            // txtTipoProceso
            // 
            this.txtTipoProceso.Location = new System.Drawing.Point(93, 127);
            this.txtTipoProceso.Name = "txtTipoProceso";
            this.txtTipoProceso.Size = new System.Drawing.Size(245, 20);
            this.txtTipoProceso.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(362, 138);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(287, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // ProcesoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProceso);
            this.Name = "ProcesoMantenimiento";
            this.Text = "ProcesoMantenimiento";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.DateTimePicker dtPickerRegProceso;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.TextBox txtCodigoProceso;
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvProceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoProceso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
    }
}