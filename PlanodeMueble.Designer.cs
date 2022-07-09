
namespace ProyectoMOANSO
{
    partial class PlanodeMueble
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
            this.btnNuevoPlano = new System.Windows.Forms.Button();
            this.gbPlanoMueble = new System.Windows.Forms.GroupBox();
            this.txtEstadoPlano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dTpFechaPlano = new System.Windows.Forms.DateTimePicker();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlanoiID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxImagenPlano = new System.Windows.Forms.PictureBox();
            this.dgvMaterialesPlano = new System.Windows.Forms.DataGridView();
            this.btnImagen = new System.Windows.Forms.Button();
            this.labelma = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMateriales = new System.Windows.Forms.GroupBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtMedidas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gbPlanoMueble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImagenPlano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesPlano)).BeginInit();
            this.gbMateriales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoPlano
            // 
            this.btnNuevoPlano.Location = new System.Drawing.Point(539, 15);
            this.btnNuevoPlano.Name = "btnNuevoPlano";
            this.btnNuevoPlano.Size = new System.Drawing.Size(85, 23);
            this.btnNuevoPlano.TabIndex = 0;
            this.btnNuevoPlano.Text = "Nuevo Plano";
            this.btnNuevoPlano.UseVisualStyleBackColor = true;
            this.btnNuevoPlano.Click += new System.EventHandler(this.btnNuevoPlano_Click);
            // 
            // gbPlanoMueble
            // 
            this.gbPlanoMueble.Controls.Add(this.txtEstadoPlano);
            this.gbPlanoMueble.Controls.Add(this.label3);
            this.gbPlanoMueble.Controls.Add(this.dTpFechaPlano);
            this.gbPlanoMueble.Controls.Add(this.btnGrabar);
            this.gbPlanoMueble.Controls.Add(this.label2);
            this.gbPlanoMueble.Controls.Add(this.txtPlanoiID);
            this.gbPlanoMueble.Controls.Add(this.label1);
            this.gbPlanoMueble.Location = new System.Drawing.Point(22, 25);
            this.gbPlanoMueble.Name = "gbPlanoMueble";
            this.gbPlanoMueble.Size = new System.Drawing.Size(497, 110);
            this.gbPlanoMueble.TabIndex = 1;
            this.gbPlanoMueble.TabStop = false;
            this.gbPlanoMueble.Text = "Datos Plano de Mueble";
            // 
            // txtEstadoPlano
            // 
            this.txtEstadoPlano.Location = new System.Drawing.Point(97, 77);
            this.txtEstadoPlano.Name = "txtEstadoPlano";
            this.txtEstadoPlano.Size = new System.Drawing.Size(41, 20);
            this.txtEstadoPlano.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Plano";
            // 
            // dTpFechaPlano
            // 
            this.dTpFechaPlano.Location = new System.Drawing.Point(172, 39);
            this.dTpFechaPlano.Name = "dTpFechaPlano";
            this.dTpFechaPlano.Size = new System.Drawing.Size(235, 20);
            this.dTpFechaPlano.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(402, 72);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 28);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Graba Plano";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Plano";
            // 
            // txtPlanoiID
            // 
            this.txtPlanoiID.Location = new System.Drawing.Point(78, 39);
            this.txtPlanoiID.Name = "txtPlanoiID";
            this.txtPlanoiID.Size = new System.Drawing.Size(41, 20);
            this.txtPlanoiID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plano ID";
            // 
            // BoxImagenPlano
            // 
            this.BoxImagenPlano.Location = new System.Drawing.Point(539, 111);
            this.BoxImagenPlano.Name = "BoxImagenPlano";
            this.BoxImagenPlano.Size = new System.Drawing.Size(249, 290);
            this.BoxImagenPlano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxImagenPlano.TabIndex = 2;
            this.BoxImagenPlano.TabStop = false;
            // 
            // dgvMaterialesPlano
            // 
            this.dgvMaterialesPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesPlano.Location = new System.Drawing.Point(22, 269);
            this.dgvMaterialesPlano.Name = "dgvMaterialesPlano";
            this.dgvMaterialesPlano.Size = new System.Drawing.Size(497, 169);
            this.dgvMaterialesPlano.TabIndex = 3;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(613, 415);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(108, 23);
            this.btnImagen.TabIndex = 4;
            this.btnImagen.Text = "Ingresar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // labelma
            // 
            this.labelma.AutoSize = true;
            this.labelma.Location = new System.Drawing.Point(21, 72);
            this.labelma.Name = "labelma";
            this.labelma.Size = new System.Drawing.Size(49, 13);
            this.labelma.TabIndex = 7;
            this.labelma.Text = "Cantidad";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(71, 29);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(90, 21);
            this.cmbMaterial.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material";
            // 
            // gbMateriales
            // 
            this.gbMateriales.Controls.Add(this.btnAnadir);
            this.gbMateriales.Controls.Add(this.txtMedidas);
            this.gbMateriales.Controls.Add(this.label4);
            this.gbMateriales.Controls.Add(this.txtCantidad);
            this.gbMateriales.Controls.Add(this.label5);
            this.gbMateriales.Controls.Add(this.labelma);
            this.gbMateriales.Controls.Add(this.cmbMaterial);
            this.gbMateriales.Location = new System.Drawing.Point(22, 141);
            this.gbMateriales.Name = "gbMateriales";
            this.gbMateriales.Size = new System.Drawing.Size(363, 109);
            this.gbMateriales.TabIndex = 10;
            this.gbMateriales.TabStop = false;
            this.gbMateriales.Text = "Datos Materiales";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(236, 24);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(104, 26);
            this.btnAnadir.TabIndex = 12;
            this.btnAnadir.Text = "Añadir Material";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txtMedidas
            // 
            this.txtMedidas.Location = new System.Drawing.Point(213, 73);
            this.txtMedidas.Name = "txtMedidas";
            this.txtMedidas.Size = new System.Drawing.Size(41, 20);
            this.txtMedidas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medidas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(78, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(41, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // PlanodeMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMateriales);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.dgvMaterialesPlano);
            this.Controls.Add(this.BoxImagenPlano);
            this.Controls.Add(this.gbPlanoMueble);
            this.Controls.Add(this.btnNuevoPlano);
            this.Name = "PlanodeMueble";
            this.Text = "PlanodeMueble";
            this.gbPlanoMueble.ResumeLayout(false);
            this.gbPlanoMueble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImagenPlano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesPlano)).EndInit();
            this.gbMateriales.ResumeLayout(false);
            this.gbMateriales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPlano;
        private System.Windows.Forms.GroupBox gbPlanoMueble;
        private System.Windows.Forms.PictureBox BoxImagenPlano;
        private System.Windows.Forms.DataGridView dgvMaterialesPlano;
        private System.Windows.Forms.DateTimePicker dTpFechaPlano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlanoiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.TextBox txtEstadoPlano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label labelma;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMateriales;
        private System.Windows.Forms.TextBox txtMedidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAnadir;
    }
}