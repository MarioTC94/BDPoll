namespace View.UserControl {
    partial class ucInicio {
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
            this.pnInicio = new MetroFramework.Controls.MetroPanel();
            this.lbSaludo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // pnInicio
            // 
            this.pnInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInicio.HorizontalScrollbarBarColor = true;
            this.pnInicio.HorizontalScrollbarHighlightOnWheel = false;
            this.pnInicio.HorizontalScrollbarSize = 10;
            this.pnInicio.Location = new System.Drawing.Point(0, 0);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(482, 368);
            this.pnInicio.TabIndex = 0;
            this.pnInicio.VerticalScrollbarBarColor = true;
            this.pnInicio.VerticalScrollbarHighlightOnWheel = false;
            this.pnInicio.VerticalScrollbarSize = 10;
            // 
            // lbSaludo
            // 
            this.lbSaludo.AutoSize = true;
            this.lbSaludo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbSaludo.Location = new System.Drawing.Point(525, 61);
            this.lbSaludo.Name = "lbSaludo";
            this.lbSaludo.Size = new System.Drawing.Size(52, 25);
            this.lbSaludo.TabIndex = 1;
            this.lbSaludo.Text = "Hola!";
            // 
            // ucContestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSaludo);
            this.Controls.Add(this.pnInicio);
            this.Name = "ucContestar";
            this.Size = new System.Drawing.Size(636, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnInicio;
        private MetroFramework.Controls.MetroLabel lbSaludo;
    }
}
