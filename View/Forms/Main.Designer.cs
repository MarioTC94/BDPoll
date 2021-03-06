﻿namespace View.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new MetroFramework.Controls.MetroPanel();
            this.btncerrarsesion = new MetroFramework.Controls.MetroButton();
            this.btnPerfil = new MetroFramework.Controls.MetroButton();
            this.btnMisCuestionarios = new MetroFramework.Controls.MetroButton();
            this.btnFacturacion = new MetroFramework.Controls.MetroButton();
            this.btn_ResponderCuestionario = new MetroFramework.Controls.MetroButton();
            this.btnCrearCuestionario = new MetroFramework.Controls.MetroButton();
            this.panelmain = new MetroFramework.Controls.MetroPanel();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btncerrarsesion);
            this.pnMain.Controls.Add(this.btnPerfil);
            this.pnMain.Controls.Add(this.btnMisCuestionarios);
            this.pnMain.Controls.Add(this.btnFacturacion);
            this.pnMain.Controls.Add(this.btn_ResponderCuestionario);
            this.pnMain.Controls.Add(this.btnCrearCuestionario);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.HorizontalScrollbarBarColor = true;
            this.pnMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMain.HorizontalScrollbarSize = 10;
            this.pnMain.Location = new System.Drawing.Point(20, 60);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(167, 406);
            this.pnMain.TabIndex = 0;
            this.pnMain.VerticalScrollbarBarColor = true;
            this.pnMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnMain.VerticalScrollbarSize = 10;
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncerrarsesion.Location = new System.Drawing.Point(0, 280);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(167, 56);
            this.btncerrarsesion.TabIndex = 8;
            this.btncerrarsesion.TabStop = false;
            this.btncerrarsesion.Text = "Cerrar Sesión";
            this.btncerrarsesion.UseSelectable = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.Location = new System.Drawing.Point(0, 224);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(167, 56);
            this.btnPerfil.TabIndex = 7;
            this.btnPerfil.TabStop = false;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseSelectable = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnMisCuestionarios
            // 
            this.btnMisCuestionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisCuestionarios.Location = new System.Drawing.Point(0, 168);
            this.btnMisCuestionarios.Name = "btnMisCuestionarios";
            this.btnMisCuestionarios.Size = new System.Drawing.Size(167, 56);
            this.btnMisCuestionarios.TabIndex = 6;
            this.btnMisCuestionarios.TabStop = false;
            this.btnMisCuestionarios.Text = "Mis Cuestionarios";
            this.btnMisCuestionarios.UseSelectable = true;
            this.btnMisCuestionarios.Click += new System.EventHandler(this.btnMisCuestionarios_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 112);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(167, 56);
            this.btnFacturacion.TabIndex = 5;
            this.btnFacturacion.TabStop = false;
            this.btnFacturacion.Text = "Facturación de Cuestionarios";
            this.btnFacturacion.UseSelectable = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btn_ResponderCuestionario
            // 
            this.btn_ResponderCuestionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ResponderCuestionario.Location = new System.Drawing.Point(0, 56);
            this.btn_ResponderCuestionario.Name = "btn_ResponderCuestionario";
            this.btn_ResponderCuestionario.Size = new System.Drawing.Size(167, 56);
            this.btn_ResponderCuestionario.TabIndex = 4;
            this.btn_ResponderCuestionario.TabStop = false;
            this.btn_ResponderCuestionario.Text = "Responder Cuestionario";
            this.btn_ResponderCuestionario.UseSelectable = true;
            this.btn_ResponderCuestionario.Click += new System.EventHandler(this.btn_ResponderCuestionario_Click);
            // 
            // btnCrearCuestionario
            // 
            this.btnCrearCuestionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCuestionario.Location = new System.Drawing.Point(0, 0);
            this.btnCrearCuestionario.Name = "btnCrearCuestionario";
            this.btnCrearCuestionario.Size = new System.Drawing.Size(167, 56);
            this.btnCrearCuestionario.TabIndex = 3;
            this.btnCrearCuestionario.TabStop = false;
            this.btnCrearCuestionario.Text = "Crear Cuestionario";
            this.btnCrearCuestionario.UseSelectable = true;
            this.btnCrearCuestionario.Click += new System.EventHandler(this.btnCrearCuestionario_Click);
            // 
            // panelmain
            // 
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.HorizontalScrollbarBarColor = true;
            this.panelmain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelmain.HorizontalScrollbarSize = 10;
            this.panelmain.Location = new System.Drawing.Point(187, 60);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(774, 406);
            this.panelmain.TabIndex = 1;
            this.panelmain.VerticalScrollbarBarColor = true;
            this.panelmain.VerticalScrollbarHighlightOnWheel = false;
            this.panelmain.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 486);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.pnMain);
            this.Name = "Main";
            this.Text = "Menú Principal";
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnMain;
        private MetroFramework.Controls.MetroButton btn_ResponderCuestionario;
        private MetroFramework.Controls.MetroButton btnCrearCuestionario;
        private MetroFramework.Controls.MetroButton btnPerfil;
        private MetroFramework.Controls.MetroButton btnMisCuestionarios;
        private MetroFramework.Controls.MetroButton btnFacturacion;
        private MetroFramework.Controls.MetroPanel panelmain;
        private MetroFramework.Controls.MetroButton btncerrarsesion;
    }
}