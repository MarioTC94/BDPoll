using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace View.Helpers {

    class PanelAgregarPregunta {

        private MetroPanel oPanel;
        private MetroPanel oBar;
        private MetroButton btnRemove;
        private MetroLabel lbPregunta;
        private MetroLabel lbTipoPregunta;
        private List<Model.Pregunta> ListPreguntas;

        public PanelAgregarPregunta(ref List<Model.Pregunta> ListPreguntas) {
            this.ListPreguntas = ListPreguntas;

            this.lbPregunta = new MetroLabel();
            this.lbPregunta.Location = new System.Drawing.Point(14, 18);

            this.lbTipoPregunta = new MetroLabel();
            this.lbTipoPregunta.Location = new System.Drawing.Point(14, 65);

            this.btnRemove = new MetroButton();
            this.btnRemove.Text = "Remover";
            this.btnRemove.Size = new System.Drawing.Size(94, 32);
            this.btnRemove.Location = new System.Drawing.Point(305, 37);
            this.btnRemove.Click += (e, x) => {
                this.ListPreguntas.Remove(this.ListPreguntas.FirstOrDefault(x => x.))
            };

            this.oPanel = new MetroPanel();
            this.oPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oPanel.Height = 100;
        }
    }
}
