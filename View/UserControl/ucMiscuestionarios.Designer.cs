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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnmisCuestionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnmisCuestionarios
            // 
            this.pnmisCuestionarios.Controls.Add(this.pnMain);
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
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(729, 432);
            this.pnMain.TabIndex = 2;
            // 
            // ucMiscuestionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnmisCuestionarios);
            this.Name = "ucMiscuestionarios";
            this.Size = new System.Drawing.Size(729, 432);
            this.pnmisCuestionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnmisCuestionarios;
        private System.Windows.Forms.Panel pnMain;
    }
}
