namespace View.Forms {
    partial class SelecciónVerdaderoyFalso {
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
            this.txtpregunta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtpregunta
            // 
            // 
            // 
            // 
            this.txtpregunta.CustomButton.Image = null;
            this.txtpregunta.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.txtpregunta.CustomButton.Name = "";
            this.txtpregunta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpregunta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpregunta.CustomButton.TabIndex = 1;
            this.txtpregunta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpregunta.CustomButton.UseSelectable = true;
            this.txtpregunta.CustomButton.Visible = false;
            this.txtpregunta.Lines = new string[0];
            this.txtpregunta.Location = new System.Drawing.Point(120, 86);
            this.txtpregunta.MaxLength = 32767;
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.PasswordChar = '\0';
            this.txtpregunta.PromptText = "Escriba la pregunta..";
            this.txtpregunta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpregunta.SelectedText = "";
            this.txtpregunta.SelectionLength = 0;
            this.txtpregunta.SelectionStart = 0;
            this.txtpregunta.ShortcutsEnabled = true;
            this.txtpregunta.Size = new System.Drawing.Size(348, 23);
            this.txtpregunta.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpregunta.TabIndex = 3;
            this.txtpregunta.UseSelectable = true;
            this.txtpregunta.WaterMark = "Escriba la pregunta..";
            this.txtpregunta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpregunta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Pregunta";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(391, 202);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Cancelar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(391, 143);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Aceptar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SelecciónVerdaderoyFalso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 276);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtpregunta);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SelecciónVerdaderoyFalso";
            this.Text = "Selección Verdadero y Falso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtpregunta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}