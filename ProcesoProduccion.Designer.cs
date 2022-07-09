
namespace ProyectoMOANSO
{
    partial class ProcesoProduccion
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
            this.gbProcesoProduccion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipoProceso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcesoProduccionID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProcesoProduccion = new System.Windows.Forms.DataGridView();
            this.btnNuevoProceso = new System.Windows.Forms.Button();
            this.btnModificarProceso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbProcesoProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesoProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProcesoProduccion
            // 
            this.gbProcesoProduccion.Controls.Add(this.btnCancelar);
            this.gbProcesoProduccion.Controls.Add(this.btnModificar);
            this.gbProcesoProduccion.Controls.Add(this.btnAgregar);
            this.gbProcesoProduccion.Controls.Add(this.cmbTipoProceso);
            this.gbProcesoProduccion.Controls.Add(this.label6);
            this.gbProcesoProduccion.Controls.Add(this.txtProcesoProduccionID);
            this.gbProcesoProduccion.Controls.Add(this.label5);
            this.gbProcesoProduccion.Controls.Add(this.txtNombre);
            this.gbProcesoProduccion.Controls.Add(this.label4);
            this.gbProcesoProduccion.Controls.Add(this.cmbArea);
            this.gbProcesoProduccion.Controls.Add(this.label3);
            this.gbProcesoProduccion.Controls.Add(this.txtduracion);
            this.gbProcesoProduccion.Controls.Add(this.label2);
            this.gbProcesoProduccion.Controls.Add(this.txtDescripcion);
            this.gbProcesoProduccion.Controls.Add(this.label1);
            this.gbProcesoProduccion.Location = new System.Drawing.Point(25, 185);
            this.gbProcesoProduccion.Name = "gbProcesoProduccion";
            this.gbProcesoProduccion.Size = new System.Drawing.Size(540, 237);
            this.gbProcesoProduccion.TabIndex = 0;
            this.gbProcesoProduccion.TabStop = false;
            this.gbProcesoProduccion.Text = "Datos Proceso de Produccion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(446, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(446, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipoProceso
            // 
            this.cmbTipoProceso.FormattingEnabled = true;
            this.cmbTipoProceso.Location = new System.Drawing.Point(250, 50);
            this.cmbTipoProceso.Name = "cmbTipoProceso";
            this.cmbTipoProceso.Size = new System.Drawing.Size(99, 21);
            this.cmbTipoProceso.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo:";
            // 
            // txtProcesoProduccionID
            // 
            this.txtProcesoProduccionID.Location = new System.Drawing.Point(74, 50);
            this.txtProcesoProduccionID.Name = "txtProcesoProduccionID";
            this.txtProcesoProduccionID.Size = new System.Drawing.Size(100, 20);
            this.txtProcesoProduccionID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre: ";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(109, 113);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(99, 21);
            this.cmbArea.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area:";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(109, 148);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(100, 20);
            this.txtduracion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duracion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 181);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(153, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // dgvProcesoProduccion
            // 
            this.dgvProcesoProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesoProduccion.Location = new System.Drawing.Point(12, 12);
            this.dgvProcesoProduccion.Name = "dgvProcesoProduccion";
            this.dgvProcesoProduccion.Size = new System.Drawing.Size(553, 150);
            this.dgvProcesoProduccion.TabIndex = 1;
            this.dgvProcesoProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesoProduccion_CellClick);
            // 
            // btnNuevoProceso
            // 
            this.btnNuevoProceso.Location = new System.Drawing.Point(605, 45);
            this.btnNuevoProceso.Name = "btnNuevoProceso";
            this.btnNuevoProceso.Size = new System.Drawing.Size(75, 36);
            this.btnNuevoProceso.TabIndex = 2;
            this.btnNuevoProceso.Text = "Nuevo Proceso";
            this.btnNuevoProceso.UseVisualStyleBackColor = true;
            this.btnNuevoProceso.Click += new System.EventHandler(this.btnNuevoProceso_Click);
            // 
            // btnModificarProceso
            // 
            this.btnModificarProceso.Location = new System.Drawing.Point(605, 97);
            this.btnModificarProceso.Name = "btnModificarProceso";
            this.btnModificarProceso.Size = new System.Drawing.Size(75, 36);
            this.btnModificarProceso.TabIndex = 3;
            this.btnModificarProceso.Text = "Modificar Proceso";
            this.btnModificarProceso.UseVisualStyleBackColor = true;
            this.btnModificarProceso.Click += new System.EventHandler(this.btnModificarProceso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(617, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ProcesoProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarProceso);
            this.Controls.Add(this.btnNuevoProceso);
            this.Controls.Add(this.dgvProcesoProduccion);
            this.Controls.Add(this.gbProcesoProduccion);
            this.Name = "ProcesoProduccion";
            this.Text = "ProcesoProduccion";
            this.gbProcesoProduccion.ResumeLayout(false);
            this.gbProcesoProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesoProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcesoProduccion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipoProceso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcesoProduccionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProcesoProduccion;
        private System.Windows.Forms.Button btnNuevoProceso;
        private System.Windows.Forms.Button btnModificarProceso;
        private System.Windows.Forms.Button btnSalir;
    }
}