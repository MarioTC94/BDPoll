namespace View.Forms {
    partial class Agregar_Cuestionario {
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
            this.pnAgregarCuestionario = new MetroFramework.Controls.MetroPanel();
            this.btnRespuestaUnica = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnRespuestaMultiple = new MetroFramework.Controls.MetroButton();
            this.btnfalsoyerdadero = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // pnAgregarCuestionario
            // 
            this.pnAgregarCuestionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAgregarCuestionario.HorizontalScrollbarBarColor = true;
            this.pnAgregarCuestionario.HorizontalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.HorizontalScrollbarSize = 10;
            this.pnAgregarCuestionario.Location = new System.Drawing.Point(20, 60);
            this.pnAgregarCuestionario.Name = "pnAgregarCuestionario";
            this.pnAgregarCuestionario.Size = new System.Drawing.Size(400, 319);
            this.pnAgregarCuestionario.TabIndex = 0;
            this.pnAgregarCuestionario.VerticalScrollbarBarColor = true;
            this.pnAgregarCuestionario.VerticalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.VerticalScrollbarSize = 10;
            // 
            // btnRespuestaUnica
            // 
            this.btnRespuestaUnica.Location = new System.Drawing.Point(496, 124);
            this.btnRespuestaUnica.Name = "btnRespuestaUnica";
            this.btnRespuestaUnica.Size = new System.Drawing.Size(161, 40);
            this.btnRespuestaUnica.TabIndex = 1;
            this.btnRespuestaUnica.Text = "Respues Única";
            this.btnRespuestaUnica.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(496, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tipo Pregunta";
            // 
            // btnRespuestaMultiple
            // 
            this.btnRespuestaMultiple.Location = new System.Drawing.Point(496, 204);
            this.btnRespuestaMultiple.Name = "btnRespuestaMultiple";
            this.btnRespuestaMultiple.Size = new System.Drawing.Size(161, 40);
            this.btnRespuestaMultiple.TabIndex = 4;
            this.btnRespuestaMultiple.Text = "Respues Múltiple";
            this.btnRespuestaMultiple.UseSelectable = true;
            // 
            // btnfalsoyerdadero
            // 
            this.btnfalsoyerdadero.Location = new System.Drawing.Point(496, 271);
            this.btnfalsoyerdadero.Name = "btnfalsoyerdadero";
            this.btnfalsoyerdadero.Size = new System.Drawing.Size(161, 40);
            this.btnfalsoyerdadero.TabIndex = 6;
            this.btnfalsoyerdadero.Text = "Respuesta Falso y Verdadero";
            this.btnfalsoyerdadero.UseSelectable = true;
            // 
            // Agregar_Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 399);
            this.Controls.Add(this.btnfalsoyerdadero);
            this.Controls.Add(this.btnRespuestaMultiple);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRespuestaUnica);
            this.Controls.Add(this.pnAgregarCuestionario);
            this.Name = "Agregar_Cuestionario";
            this.Text = "Agregar Cuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnAgregarCuestionario;
        private MetroFramework.Controls.MetroButton btnRespuestaUnica;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnRespuestaMultiple;
        private MetroFramework.Controls.MetroButton btnfalsoyerdadero;
    }
}