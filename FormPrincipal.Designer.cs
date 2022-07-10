
namespace ProyectoMOANSO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeMuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muebleTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.mantenedoresToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(698, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeProduccionToolStripMenuItem,
            this.planoDeMuebleToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // ordenDeProduccionToolStripMenuItem
            // 
            this.ordenDeProduccionToolStripMenuItem.Name = "ordenDeProduccionToolStripMenuItem";
            this.ordenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ordenDeProduccionToolStripMenuItem.Text = "Orden de Produccion";
            // 
            // planoDeMuebleToolStripMenuItem
            // 
            this.planoDeMuebleToolStripMenuItem.Name = "planoDeMuebleToolStripMenuItem";
            this.planoDeMuebleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.planoDeMuebleToolStripMenuItem.Text = "Plano de Mueble";
            this.planoDeMuebleToolStripMenuItem.Click += new System.EventHandler(this.planoDeMuebleToolStripMenuItem_Click);
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDeProduccionToolStripMenuItem,
            this.procesoDeProduccionToolStripMenuItem,
            this.muebleTerminadoToolStripMenuItem,
            this.pedidoToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // personalDeProduccionToolStripMenuItem
            // 
            this.personalDeProduccionToolStripMenuItem.Name = "personalDeProduccionToolStripMenuItem";
            this.personalDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.personalDeProduccionToolStripMenuItem.Text = "Personal de Produccion";
            this.personalDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.personalDeProduccionToolStripMenuItem_Click);
            // 
            // procesoDeProduccionToolStripMenuItem
            // 
            this.procesoDeProduccionToolStripMenuItem.Name = "procesoDeProduccionToolStripMenuItem";
            this.procesoDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.procesoDeProduccionToolStripMenuItem.Text = "Proceso de Produccion";
            this.procesoDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.procesoDeProduccionToolStripMenuItem_Click);
            // 
            // muebleTerminadoToolStripMenuItem
            // 
            this.muebleTerminadoToolStripMenuItem.Name = "muebleTerminadoToolStripMenuItem";
            this.muebleTerminadoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.muebleTerminadoToolStripMenuItem.Text = "Mueble Terminado";
            this.muebleTerminadoToolStripMenuItem.Click += new System.EventHandler(this.muebleTerminadoToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Produccion de Muebles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeMuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muebleTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}

