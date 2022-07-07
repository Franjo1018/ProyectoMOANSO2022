
namespace ProyectoMOANSO
{
    partial class MuebleTerminado
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
            this.cbkEstadoMueble = new System.Windows.Forms.CheckBox();
            this.dtPickerRegMueble = new System.Windows.Forms.DateTimePicker();
            this.txtPlanoMueble = new System.Windows.Forms.TextBox();
            this.txtTipoMueble = new System.Windows.Forms.TextBox();
            this.txtCodigoMueble = new System.Windows.Forms.TextBox();
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
            this.dgvMueble = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMueble)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.cbkEstadoMueble);
            this.groupBoxDatos.Controls.Add(this.dtPickerRegMueble);
            this.groupBoxDatos.Controls.Add(this.txtPlanoMueble);
            this.groupBoxDatos.Controls.Add(this.txtTipoMueble);
            this.groupBoxDatos.Controls.Add(this.txtCodigoMueble);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Location = new System.Drawing.Point(34, 180);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(655, 180);
            this.groupBoxDatos.TabIndex = 14;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "datos del mueble";
            // 
            // cbkEstadoMueble
            // 
            this.cbkEstadoMueble.AutoSize = true;
            this.cbkEstadoMueble.Location = new System.Drawing.Point(379, 41);
            this.cbkEstadoMueble.Name = "cbkEstadoMueble";
            this.cbkEstadoMueble.Size = new System.Drawing.Size(110, 17);
            this.cbkEstadoMueble.TabIndex = 18;
            this.cbkEstadoMueble.Text = "estado de mueble";
            this.cbkEstadoMueble.UseVisualStyleBackColor = true;
            // 
            // dtPickerRegMueble
            // 
            this.dtPickerRegMueble.Location = new System.Drawing.Point(119, 137);
            this.dtPickerRegMueble.Name = "dtPickerRegMueble";
            this.dtPickerRegMueble.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegMueble.TabIndex = 17;
            // 
            // txtPlanoMueble
            // 
            this.txtPlanoMueble.Location = new System.Drawing.Point(73, 99);
            this.txtPlanoMueble.Name = "txtPlanoMueble";
            this.txtPlanoMueble.Size = new System.Drawing.Size(265, 20);
            this.txtPlanoMueble.TabIndex = 15;
            // 
            // txtTipoMueble
            // 
            this.txtTipoMueble.Location = new System.Drawing.Point(96, 69);
            this.txtTipoMueble.Name = "txtTipoMueble";
            this.txtTipoMueble.Size = new System.Drawing.Size(242, 20);
            this.txtTipoMueble.TabIndex = 14;
            // 
            // txtCodigoMueble
            // 
            this.txtCodigoMueble.Location = new System.Drawing.Point(119, 39);
            this.txtCodigoMueble.Name = "txtCodigoMueble";
            this.txtCodigoMueble.Size = new System.Drawing.Size(219, 20);
            this.txtCodigoMueble.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 137);
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
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo Mueble";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo Mueble";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(574, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(574, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(574, 62);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(691, 151);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesabilitar
            // 
            this.btnDesabilitar.Location = new System.Drawing.Point(691, 105);
            this.btnDesabilitar.Name = "btnDesabilitar";
            this.btnDesabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDesabilitar.TabIndex = 12;
            this.btnDesabilitar.Text = "desabilitar";
            this.btnDesabilitar.UseVisualStyleBackColor = true;
            this.btnDesabilitar.Click += new System.EventHandler(this.btnDesabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(691, 63);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(691, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMueble
            // 
            this.dgvMueble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMueble.Location = new System.Drawing.Point(34, 24);
            this.dgvMueble.Name = "dgvMueble";
            this.dgvMueble.ReadOnly = true;
            this.dgvMueble.Size = new System.Drawing.Size(618, 150);
            this.dgvMueble.TabIndex = 9;
            this.dgvMueble.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMueble_CellClick);
            // 
            // MuebleTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMueble);
            this.Name = "MuebleTerminado";
            this.Text = "MuebleTerminado";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMueble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.CheckBox cbkEstadoMueble;
        private System.Windows.Forms.DateTimePicker dtPickerRegMueble;
        private System.Windows.Forms.TextBox txtPlanoMueble;
        private System.Windows.Forms.TextBox txtTipoMueble;
        private System.Windows.Forms.TextBox txtCodigoMueble;
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
        private System.Windows.Forms.DataGridView dgvMueble;
    }
}