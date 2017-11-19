namespace View.Forms {
    partial class Contestar_Cuestionario {
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
            this.pnContestarCuestionario = new MetroFramework.Controls.MetroPanel();
            this.btnEnviarCuestionario = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pnContestarCuestionario
            // 
            this.pnContestarCuestionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContestarCuestionario.HorizontalScrollbarBarColor = true;
            this.pnContestarCuestionario.HorizontalScrollbarHighlightOnWheel = false;
            this.pnContestarCuestionario.HorizontalScrollbarSize = 10;
            this.pnContestarCuestionario.Location = new System.Drawing.Point(20, 60);
            this.pnContestarCuestionario.Name = "pnContestarCuestionario";
            this.pnContestarCuestionario.Size = new System.Drawing.Size(672, 337);
            this.pnContestarCuestionario.TabIndex = 0;
            this.pnContestarCuestionario.VerticalScrollbarBarColor = true;
            this.pnContestarCuestionario.VerticalScrollbarHighlightOnWheel = false;
            this.pnContestarCuestionario.VerticalScrollbarSize = 10;
            // 
            // btnEnviarCuestionario
            // 
            this.btnEnviarCuestionario.Location = new System.Drawing.Point(578, 418);
            this.btnEnviarCuestionario.Name = "btnEnviarCuestionario";
            this.btnEnviarCuestionario.Size = new System.Drawing.Size(114, 33);
            this.btnEnviarCuestionario.TabIndex = 1;
            this.btnEnviarCuestionario.Text = "Enviar Cuestionario";
            this.btnEnviarCuestionario.UseSelectable = true;
            // 
            // Contestar_Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 464);
            this.Controls.Add(this.btnEnviarCuestionario);
            this.Controls.Add(this.pnContestarCuestionario);
            this.Name = "Contestar_Cuestionario";
            this.Text = "Remover";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnContestarCuestionario;
        private MetroFramework.Controls.MetroButton btnEnviarCuestionario;
    }
}