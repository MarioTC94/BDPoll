namespace View.UserControl {
    partial class ucAgregarCuestionario {
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
            this.pnAgregarCuestionario = new MetroFramework.Controls.MetroPanel();
            this.btFacturacion = new MetroFramework.Controls.MetroButton();
            this.btagregarcuestionario = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pnAgregarCuestionario
            // 
            this.pnAgregarCuestionario.HorizontalScrollbarBarColor = true;
            this.pnAgregarCuestionario.HorizontalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.HorizontalScrollbarSize = 10;
            this.pnAgregarCuestionario.Location = new System.Drawing.Point(0, 0);
            this.pnAgregarCuestionario.Name = "pnAgregarCuestionario";
            this.pnAgregarCuestionario.Size = new System.Drawing.Size(591, 425);
            this.pnAgregarCuestionario.TabIndex = 0;
            this.pnAgregarCuestionario.VerticalScrollbarBarColor = true;
            this.pnAgregarCuestionario.VerticalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.VerticalScrollbarSize = 10;
            // 
            // btFacturacion
            // 
            this.btFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btFacturacion.Location = new System.Drawing.Point(758, 214);
            this.btFacturacion.Name = "btFacturacion";
            this.btFacturacion.Size = new System.Drawing.Size(125, 39);
            this.btFacturacion.TabIndex = 3;
            this.btFacturacion.TabStop = false;
            this.btFacturacion.Text = "Pasar a Facturación";
            this.btFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFacturacion.UseSelectable = true;
            this.btFacturacion.Click += new System.EventHandler(this.btFacturacion_Click);
            // 
            // btagregarcuestionario
            // 
            this.btagregarcuestionario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btagregarcuestionario.Location = new System.Drawing.Point(758, 156);
            this.btagregarcuestionario.Name = "btagregarcuestionario";
            this.btagregarcuestionario.Size = new System.Drawing.Size(125, 38);
            this.btagregarcuestionario.TabIndex = 2;
            this.btagregarcuestionario.TabStop = false;
            this.btagregarcuestionario.Text = "Agregar Cuestionario";
            this.btagregarcuestionario.UseSelectable = true;
            this.btagregarcuestionario.Click += new System.EventHandler(this.btagregarcuestionario_Click);
            // 
            // ucAgregarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAgregarCuestionario);
            this.Controls.Add(this.btFacturacion);
            this.Controls.Add(this.btagregarcuestionario);
            this.Name = "ucAgregarCuestionario";
            this.Size = new System.Drawing.Size(921, 425);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnAgregarCuestionario;
        private MetroFramework.Controls.MetroButton btFacturacion;
        private MetroFramework.Controls.MetroButton btagregarcuestionario;
    }
}
