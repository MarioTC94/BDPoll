using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace View.Helpers {

    public class PanelAgregarPregunta {

        

        public MetroPanel oPanel;
        private MetroButton btnRemove;
        private MetroLabel lbPregunta;
        private MetroLabel lbTipoPregunta;
        private Model.Pregunta oPregunta;

        public PanelAgregarPregunta(Model.Pregunta oPregunta, MetroPanel pnAgregarCuestionario) {
            this.oPregunta = oPregunta;

            this.lbPregunta = new MetroLabel();
            this.lbPregunta.Location = new System.Drawing.Point(14, 18);

            this.lbTipoPregunta = new MetroLabel();
            this.lbTipoPregunta.Location = new System.Drawing.Point(14, 65);

            this.btnRemove = new MetroButton();
            this.btnRemove.Text = "Remover";
            this.btnRemove.Size = new System.Drawing.Size(94, 32);
            this.btnRemove.Location = new System.Drawing.Point(305, 37);

            this.btnRemove.Click += (e, z) => {
                Forms.txtTitulo.ListPreguntas.Remove(oPregunta);
                pnAgregarCuestionario.Controls.Remove(oPanel);

            };

            this.oPanel = new MetroPanel();
            this.oPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oPanel.Height = 100;

            this.oPanel.Controls.Add(lbPregunta);
            this.oPanel.Controls.Add(lbTipoPregunta);
            this.oPanel.Controls.Add(btnRemove);
        }

        public MetroPanel getPanel(String TipoPregunta, String Pregunta) {
            this.lbPregunta.Text = "Pregunta: " + Pregunta;
            this.lbPregunta.Size = this.lbPregunta.PreferredSize;
            this.lbTipoPregunta.Text = TipoPregunta;
            this.lbTipoPregunta.Size = this.lbTipoPregunta.PreferredSize;
            return this.oPanel;
        }
    }
}
