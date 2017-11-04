namespace View
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Usuario = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LB_Contraseña = new MetroFramework.Controls.MetroLabel();
            this.Txt_Usuario = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Contraseña = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Registrarse = new MetroFramework.Controls.MetroButton();
            this.Btn_IniciaSesion = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Usuario
            // 
            this.LB_Usuario.AutoSize = true;
            this.LB_Usuario.Location = new System.Drawing.Point(91, 115);
            this.LB_Usuario.Name = "LB_Usuario";
            this.LB_Usuario.Size = new System.Drawing.Size(53, 19);
            this.LB_Usuario.TabIndex = 0;
            this.LB_Usuario.Text = "Usuario";
            this.LB_Usuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.Txt_Contraseña);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.Txt_Usuario);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(172, 100);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(315, 126);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LB_Contraseña
            // 
            this.LB_Contraseña.AutoSize = true;
            this.LB_Contraseña.Location = new System.Drawing.Point(91, 188);
            this.LB_Contraseña.Name = "LB_Contraseña";
            this.LB_Contraseña.Size = new System.Drawing.Size(75, 19);
            this.LB_Contraseña.TabIndex = 2;
            this.LB_Contraseña.Text = "Contraseña";
            this.LB_Contraseña.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Txt_Usuario
            // 
            // 
            // 
            // 
            this.Txt_Usuario.CustomButton.Image = null;
            this.Txt_Usuario.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.Txt_Usuario.CustomButton.Name = "";
            this.Txt_Usuario.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.Txt_Usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Usuario.CustomButton.TabIndex = 1;
            this.Txt_Usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Usuario.CustomButton.UseSelectable = true;
            this.Txt_Usuario.CustomButton.Visible = false;
            this.Txt_Usuario.Lines = new string[0];
            this.Txt_Usuario.Location = new System.Drawing.Point(12, 15);
            this.Txt_Usuario.MaxLength = 32767;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.PasswordChar = '\0';
            this.Txt_Usuario.PromptText = "Usuario o Contraseña..";
            this.Txt_Usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Usuario.SelectedText = "";
            this.Txt_Usuario.SelectionLength = 0;
            this.Txt_Usuario.SelectionStart = 0;
            this.Txt_Usuario.ShortcutsEnabled = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(279, 35);
            this.Txt_Usuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Usuario.TabIndex = 2;
            this.Txt_Usuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Txt_Usuario.UseSelectable = true;
            this.Txt_Usuario.WaterMark = "Usuario o Contraseña..";
            this.Txt_Usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Contraseña
            // 
            // 
            // 
            // 
            this.Txt_Contraseña.CustomButton.Image = null;
            this.Txt_Contraseña.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.Txt_Contraseña.CustomButton.Name = "";
            this.Txt_Contraseña.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.Txt_Contraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Contraseña.CustomButton.TabIndex = 1;
            this.Txt_Contraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Contraseña.CustomButton.UseSelectable = true;
            this.Txt_Contraseña.CustomButton.Visible = false;
            this.Txt_Contraseña.Lines = new string[0];
            this.Txt_Contraseña.Location = new System.Drawing.Point(12, 81);
            this.Txt_Contraseña.MaxLength = 32767;
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '\0';
            this.Txt_Contraseña.PromptText = "Digite su contraseña...";
            this.Txt_Contraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Contraseña.SelectedText = "";
            this.Txt_Contraseña.SelectionLength = 0;
            this.Txt_Contraseña.SelectionStart = 0;
            this.Txt_Contraseña.ShortcutsEnabled = true;
            this.Txt_Contraseña.Size = new System.Drawing.Size(278, 35);
            this.Txt_Contraseña.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Contraseña.TabIndex = 4;
            this.Txt_Contraseña.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Txt_Contraseña.UseSelectable = true;
            this.Txt_Contraseña.WaterMark = "Digite su contraseña...";
            this.Txt_Contraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Contraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources.if_lock_477138;
            this.pictureBox2.Location = new System.Drawing.Point(257, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.if_user_173122__1_;
            this.pictureBox1.Location = new System.Drawing.Point(259, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Registrarse
            // 
            this.Btn_Registrarse.Location = new System.Drawing.Point(412, 254);
            this.Btn_Registrarse.Name = "Btn_Registrarse";
            this.Btn_Registrarse.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrarse.TabIndex = 3;
            this.Btn_Registrarse.Text = "Registrarse";
            this.Btn_Registrarse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_Registrarse.UseSelectable = true;
            // 
            // Btn_IniciaSesion
            // 
            this.Btn_IniciaSesion.Location = new System.Drawing.Point(532, 254);
            this.Btn_IniciaSesion.Name = "Btn_IniciaSesion";
            this.Btn_IniciaSesion.Size = new System.Drawing.Size(75, 23);
            this.Btn_IniciaSesion.TabIndex = 4;
            this.Btn_IniciaSesion.Text = "Inicia Sesión";
            this.Btn_IniciaSesion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_IniciaSesion.UseSelectable = true;
            this.Btn_IniciaSesion.Click += new System.EventHandler(this.Btn_IniciaSesion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 289);
            this.Controls.Add(this.Btn_IniciaSesion);
            this.Controls.Add(this.Btn_Registrarse);
            this.Controls.Add(this.LB_Contraseña);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.LB_Usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LB_Usuario;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox Txt_Usuario;
        private MetroFramework.Controls.MetroLabel LB_Contraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox Txt_Contraseña;
        private MetroFramework.Controls.MetroButton Btn_Registrarse;
        private MetroFramework.Controls.MetroButton Btn_IniciaSesion;
    }
}

