namespace View.UserControl {
    partial class ucFacturación {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnFacturacion = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // pnFacturacion
            // 
            this.pnFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFacturacion.HorizontalScrollbarBarColor = true;
            this.pnFacturacion.HorizontalScrollbarHighlightOnWheel = false;
            this.pnFacturacion.HorizontalScrollbarSize = 10;
            this.pnFacturacion.Location = new System.Drawing.Point(0, 0);
            this.pnFacturacion.Name = "pnFacturacion";
            this.pnFacturacion.Size = new System.Drawing.Size(750, 416);
            this.pnFacturacion.TabIndex = 0;
            this.pnFacturacion.VerticalScrollbarBarColor = true;
            this.pnFacturacion.VerticalScrollbarHighlightOnWheel = false;
            this.pnFacturacion.VerticalScrollbarSize = 10;
            // 
            // ucFacturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFacturacion);
            this.Name = "ucFacturación";
            this.Size = new System.Drawing.Size(750, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnFacturacion;
    }
}
