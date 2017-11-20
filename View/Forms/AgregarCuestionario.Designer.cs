namespace View.Forms {
    partial class AgregarCuestionario {
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
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaTerminada = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.lbDetalle = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // pnAgregarCuestionario
            // 
            this.pnAgregarCuestionario.AutoScroll = true;
            this.pnAgregarCuestionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAgregarCuestionario.HorizontalScrollbar = true;
            this.pnAgregarCuestionario.HorizontalScrollbarBarColor = true;
            this.pnAgregarCuestionario.HorizontalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.HorizontalScrollbarSize = 10;
            this.pnAgregarCuestionario.Location = new System.Drawing.Point(20, 60);
            this.pnAgregarCuestionario.Name = "pnAgregarCuestionario";
            this.pnAgregarCuestionario.Size = new System.Drawing.Size(424, 421);
            this.pnAgregarCuestionario.TabIndex = 0;
            this.pnAgregarCuestionario.VerticalScrollbar = true;
            this.pnAgregarCuestionario.VerticalScrollbarBarColor = true;
            this.pnAgregarCuestionario.VerticalScrollbarHighlightOnWheel = false;
            this.pnAgregarCuestionario.VerticalScrollbarSize = 10;
            // 
            // btnRespuestaUnica
            // 
            this.btnRespuestaUnica.BackColor = System.Drawing.Color.Gray;
            this.btnRespuestaUnica.Location = new System.Drawing.Point(466, 97);
            this.btnRespuestaUnica.Name = "btnRespuestaUnica";
            this.btnRespuestaUnica.Size = new System.Drawing.Size(161, 40);
            this.btnRespuestaUnica.TabIndex = 1;
            this.btnRespuestaUnica.TabStop = false;
            this.btnRespuestaUnica.Text = "Respuesta Única";
            this.btnRespuestaUnica.UseSelectable = true;
            this.btnRespuestaUnica.Click += new System.EventHandler(this.btnRespuestaUnica_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(466, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tipo Pregunta";
            // 
            // btnRespuestaMultiple
            // 
            this.btnRespuestaMultiple.BackColor = System.Drawing.Color.Gray;
            this.btnRespuestaMultiple.Location = new System.Drawing.Point(466, 159);
            this.btnRespuestaMultiple.Name = "btnRespuestaMultiple";
            this.btnRespuestaMultiple.Size = new System.Drawing.Size(161, 40);
            this.btnRespuestaMultiple.TabIndex = 4;
            this.btnRespuestaMultiple.TabStop = false;
            this.btnRespuestaMultiple.Text = "Respuesta Múltiple";
            this.btnRespuestaMultiple.UseSelectable = true;
            this.btnRespuestaMultiple.Click += new System.EventHandler(this.btnRespuestaMultiple_Click);
            // 
            // btnfalsoyerdadero
            // 
            this.btnfalsoyerdadero.BackColor = System.Drawing.Color.Gray;
            this.btnfalsoyerdadero.Location = new System.Drawing.Point(466, 223);
            this.btnfalsoyerdadero.Name = "btnfalsoyerdadero";
            this.btnfalsoyerdadero.Size = new System.Drawing.Size(161, 40);
            this.btnfalsoyerdadero.TabIndex = 6;
            this.btnfalsoyerdadero.TabStop = false;
            this.btnfalsoyerdadero.Text = "Respuesta Falso y Verdadero";
            this.btnfalsoyerdadero.UseSelectable = true;
            this.btnfalsoyerdadero.Click += new System.EventHandler(this.btnfalsoyerdadero_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Location = new System.Drawing.Point(759, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 25);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Guardar";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(472, 330);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Titulo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(652, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Fecha Terminada";
            // 
            // dtpFechaTerminada
            // 
            this.dtpFechaTerminada.Location = new System.Drawing.Point(651, 97);
            this.dtpFechaTerminada.Name = "dtpFechaTerminada";
            this.dtpFechaTerminada.Size = new System.Drawing.Size(171, 20);
            this.dtpFechaTerminada.TabIndex = 9;
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(605, 332);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(186, 23);
            this.txtTitulo.TabIndex = 13;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbDetalle.Location = new System.Drawing.Point(472, 290);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(199, 25);
            this.lbDetalle.TabIndex = 14;
            this.lbDetalle.Text = "Detalles del Cuestionario";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(605, 373);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(186, 23);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(472, 371);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 25);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Descripción";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(472, 412);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 25);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Total";
            // 
            // AgregarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpFechaTerminada);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnfalsoyerdadero);
            this.Controls.Add(this.btnRespuestaMultiple);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRespuestaUnica);
            this.Controls.Add(this.pnAgregarCuestionario);
            this.Name = "AgregarCuestionario";
            this.Resizable = false;
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
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker dtpFechaTerminada;
        private MetroFramework.Controls.MetroTextBox txtTitulo;
        private MetroFramework.Controls.MetroLabel lbDetalle;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}