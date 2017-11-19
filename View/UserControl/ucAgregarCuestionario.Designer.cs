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
            this.lbTotal = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarCuestionario = new MetroFramework.Controls.MetroButton();
            this.btnCaja = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAgregarCuestionario
            // 
            this.pnAgregarCuestionario.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTotal.Location = new System.Drawing.Point(44, 49);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(50, 25);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total:";
            // 
            // btnAgregarCuestionario
            // 
            this.btnAgregarCuestionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCuestionario.Location = new System.Drawing.Point(44, 264);
            this.btnAgregarCuestionario.Name = "btnAgregarCuestionario";
            this.btnAgregarCuestionario.Size = new System.Drawing.Size(137, 38);
            this.btnAgregarCuestionario.TabIndex = 2;
            this.btnAgregarCuestionario.Text = "Agregar Cuestionario";
            this.btnAgregarCuestionario.UseSelectable = true;
            // 
            // btnCaja
            // 
            this.btnCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaja.Location = new System.Drawing.Point(44, 323);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(137, 39);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "Pasar a Facturación";
            this.btnCaja.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCaja);
            this.metroPanel1.Controls.Add(this.btnAgregarCuestionario);
            this.metroPanel1.Controls.Add(this.lbTotal);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(518, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(214, 425);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ucAgregarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pnAgregarCuestionario);
            this.Name = "ucAgregarCuestionario";
            this.Size = new System.Drawing.Size(732, 425);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnAgregarCuestionario;
        private MetroFramework.Controls.MetroLabel lbTotal;
        private MetroFramework.Controls.MetroButton btnAgregarCuestionario;
        private MetroFramework.Controls.MetroButton btnCaja;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
