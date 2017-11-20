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
            this.pnCuestionarios = new MetroFramework.Controls.MetroPanel();
            this.btagregarcuestionario = new MetroFramework.Controls.MetroButton();
            this.pnAgregarCuestionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAgregarCuestionario
            // 
            this.pnAgregarCuestionario.Controls.Add(this.btFacturacion);
            this.pnAgregarCuestionario.Controls.Add(this.pnCuestionarios);
            this.pnAgregarCuestionario.Controls.Add(this.btagregarcuestionario);
            this.pnAgregarCuestionario.HorizontalScrollbarBarColor = true;
            this.pnAgregarCuestionario.HorizontalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.HorizontalScrollbarSize = 10;
            this.pnAgregarCuestionario.Location = new System.Drawing.Point(0, 0);
            this.pnAgregarCuestionario.Name = "pnAgregarCuestionario";
            this.pnAgregarCuestionario.Size = new System.Drawing.Size(732, 425);
            this.pnAgregarCuestionario.TabIndex = 0;
            this.pnAgregarCuestionario.VerticalScrollbarBarColor = true;
            this.pnAgregarCuestionario.VerticalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.VerticalScrollbarSize = 10;
            // 
            // btFacturacion
            // 
            this.btFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btFacturacion.Location = new System.Drawing.Point(583, 249);
            this.btFacturacion.Name = "btFacturacion";
            this.btFacturacion.Size = new System.Drawing.Size(137, 39);
            this.btFacturacion.TabIndex = 3;
            this.btFacturacion.Text = "Pasar a Facturación";
            this.btFacturacion.UseSelectable = true;
            // 
            // pnCuestionarios
            // 
            this.pnCuestionarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnCuestionarios.HorizontalScrollbarBarColor = true;
            this.pnCuestionarios.HorizontalScrollbarHighlightOnWheel = false;
            this.pnCuestionarios.HorizontalScrollbarSize = 10;
            this.pnCuestionarios.Location = new System.Drawing.Point(0, 0);
            this.pnCuestionarios.Name = "pnCuestionarios";
            this.pnCuestionarios.Size = new System.Drawing.Size(561, 425);
            this.pnCuestionarios.TabIndex = 2;
            this.pnCuestionarios.VerticalScrollbar = true;
            this.pnCuestionarios.VerticalScrollbarBarColor = true;
            this.pnCuestionarios.VerticalScrollbarHighlightOnWheel = false;
            this.pnCuestionarios.VerticalScrollbarSize = 10;
            // 
            // btagregarcuestionario
            // 
            this.btagregarcuestionario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btagregarcuestionario.Location = new System.Drawing.Point(583, 106);
            this.btagregarcuestionario.Name = "btagregarcuestionario";
            this.btagregarcuestionario.Size = new System.Drawing.Size(137, 38);
            this.btagregarcuestionario.TabIndex = 2;
            this.btagregarcuestionario.Text = "Agregar Cuestionario";
            this.btagregarcuestionario.UseSelectable = true;
            this.btagregarcuestionario.Click += new System.EventHandler(this.btagregarcuestionario_Click);
            // 
            // ucAgregarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAgregarCuestionario);
            this.Name = "ucAgregarCuestionario";
            this.Size = new System.Drawing.Size(732, 425);
            this.pnAgregarCuestionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnAgregarCuestionario;
        private MetroFramework.Controls.MetroButton btFacturacion;
        private MetroFramework.Controls.MetroPanel pnCuestionarios;
        private MetroFramework.Controls.MetroButton btagregarcuestionario;
    }
}
