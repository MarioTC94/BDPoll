namespace View.UserControl {
    partial class ucMiscuestionarios {
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
            this.pnmisCuestionarios = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // pnmisCuestionarios
            // 
            this.pnmisCuestionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmisCuestionarios.HorizontalScrollbarBarColor = true;
            this.pnmisCuestionarios.HorizontalScrollbarHighlightOnWheel = false;
            this.pnmisCuestionarios.HorizontalScrollbarSize = 10;
            this.pnmisCuestionarios.Location = new System.Drawing.Point(0, 0);
            this.pnmisCuestionarios.Name = "pnmisCuestionarios";
            this.pnmisCuestionarios.Size = new System.Drawing.Size(729, 432);
            this.pnmisCuestionarios.TabIndex = 0;
            this.pnmisCuestionarios.VerticalScrollbarBarColor = true;
            this.pnmisCuestionarios.VerticalScrollbarHighlightOnWheel = false;
            this.pnmisCuestionarios.VerticalScrollbarSize = 10;
            // 
            // ucMiscuestionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnmisCuestionarios);
            this.Name = "ucMiscuestionarios";
            this.Size = new System.Drawing.Size(729, 432);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnmisCuestionarios;
    }
}
