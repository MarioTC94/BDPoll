namespace View.Forms {
    partial class DetalleMisCuestionarios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnMisPreguntas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnMisPreguntas
            // 
            this.pnMisPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMisPreguntas.Location = new System.Drawing.Point(20, 60);
            this.pnMisPreguntas.Name = "pnMisPreguntas";
            this.pnMisPreguntas.Size = new System.Drawing.Size(917, 418);
            this.pnMisPreguntas.TabIndex = 0;
            // 
            // DetalleMisCuestionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 498);
            this.Controls.Add(this.pnMisPreguntas);
            this.Name = "DetalleMisCuestionarios";
            this.Text = "Detalle de mis Cuestionarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMisPreguntas;
    }
}