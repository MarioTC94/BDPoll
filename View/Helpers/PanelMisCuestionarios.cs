using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data;

namespace View.Helpers {

   public  class PanelMisCuestionarios {

        private MetroPanel oPanel;
        private MetroPanel oBar;
        private MetroButton btnVerDetalle;
        private MetroLabel lbTitulo;
        private MetroLabel lbCantPreguntas;
        private MetroLabel lbTotal;
        //-----------------------------------

        public PanelMisCuestionarios(List<DataRow> ListPreguntas) {
            this.lbTitulo = new MetroLabel();
            this.lbTitulo.Text = "Título: ";
            this.lbTitulo.Location = new System.Drawing.Point(31, 24);

            this.lbCantPreguntas = new MetroLabel();
            this.lbCantPreguntas.Text = "Cantidad de preguntas: ";
            this.lbCantPreguntas.Location = new System.Drawing.Point(31, 57);

            this.lbTotal = new MetroLabel();
            this.lbTotal.Text = "Total: $";
            this.lbTotal.Location = new System.Drawing.Point(31, 88);

            this.oPanel = new MetroPanel();
            this.oPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oPanel.Height = 130;

            this.oBar = new MetroPanel();
            this.oBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oBar.Height = 5;
            this.oBar.UseCustomBackColor = true;
            this.oBar.BackColor = MetroColors.Blue;
            this.oPanel.Controls.Add(oBar);

            this.btnVerDetalle = new MetroButton();
            this.btnVerDetalle.Text = "Ver Detalles";
            this.btnVerDetalle.Size = this.btnVerDetalle.PreferredSize;
            this.btnVerDetalle.Location = new System.Drawing.Point(421, 53);
            this.btnVerDetalle.Click += (x, y) => {
                new Forms.DetalleMisCuestionarios(ListPreguntas).ShowDialog();
            };
            this.oPanel.Controls.Add(btnVerDetalle);
            this.oPanel.Controls.Add(lbTitulo);
            this.oPanel.Controls.Add(lbCantPreguntas);
            this.oPanel.Controls.Add(lbTotal);
        }

        public MetroPanel getPanel(String Titulo, String CantidadPreguntas, String Total) {
            lbTitulo.Text += Titulo;
            lbTitulo.Size = lbTitulo.PreferredSize;

            lbCantPreguntas.Text += CantidadPreguntas;
            lbCantPreguntas.Size = lbCantPreguntas.PreferredSize;

            lbTotal.Text += Total;
            lbTotal.Size = lbTotal.PreferredSize;

            return this.oPanel;
        }
    }
}
