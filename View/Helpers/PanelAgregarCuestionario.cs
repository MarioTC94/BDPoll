using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace View.Helpers {
    public class PanelAgregarCuestionario {

        private MetroPanel oPanel;
        private MetroPanel oBar;
        private MetroButton btnRemove;
        private MetroLabel lbTitulo;
        private MetroLabel lbCantPreguntas;
        private MetroLabel lbTotal;
        private List<Model.Cuestionario> ListCuestionario;
        //-----------------------------------
        private int IDCuestionario;

        public PanelAgregarCuestionario(ref List<Model.Cuestionario> ListCuestionario, int IDCuestionario) {
            this.IDCuestionario = IDCuestionario;

            this.lbTitulo = new MetroLabel();
            this.lbTitulo.Text = "Titulo: ";
            this.lbTitulo.Size = this.lbTitulo.MinimumSize;
            this.lbTitulo.Location = new System.Drawing.Point(16, 15);

            this.lbCantPreguntas = new MetroLabel();
            this.lbCantPreguntas.Text = "Cantidad de preguntas: ";
            this.lbCantPreguntas.Size = this.lbCantPreguntas.MinimumSize;
            this.lbCantPreguntas.Location = new System.Drawing.Point(16, 46);

            this.lbTotal = new MetroLabel();
            this.lbTotal.Text = "Total: $";
            this.lbTotal.Size = this.lbTotal.MinimumSize;
            this.lbTotal.Location = new System.Drawing.Point(16, 82);

            this.oPanel = new MetroPanel();
            this.oPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oPanel.Height = 113;

            this.oBar = new MetroPanel();
            this.oBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.oBar.Height = 5;
            this.oBar.BackColor = MetroColors.Blue;

            this.btnRemove = new MetroButton();
            this.btnRemove.Text = "Remover";
            this.btnRemove.Size = new System.Drawing.Size(94, 32);
            this.btnRemove.Location = new System.Drawing.Point(533, 46);
            this.btnRemove.Click += (x, y) => {
              //  this.ListCuestionario.Select(x => x.IDCuestionario = IDCuestionario);
                this.oPanel.Parent.Controls.Remove(this.oPanel);
            };

            this.oPanel.Controls.Add(btnRemove);
            this.oPanel.Controls.Add(lbTitulo);
            this.oPanel.Controls.Add(lbCantPreguntas);
            this.oPanel.Controls.Add(lbTotal);
        }
       
    }
}
