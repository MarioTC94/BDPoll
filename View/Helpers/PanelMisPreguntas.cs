using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace View.Helpers {

    public class PanelMisPreguntas {

        private MetroPanel oPanel;
        private MetroPanel oBar;
        private MetroLabel lbPregunta, lbOpcion1, lbOpcion2, lbOpcion3, lbOpcion4;
        //-----------------------------------
        private UserControl.ucAgregarCuestionario FormWithList;

        public PanelMisPreguntas() {
            this.lbPregunta = new MetroLabel();
            this.lbPregunta.Text = "Pregunta: ";
            this.lbPregunta.Location = new System.Drawing.Point(30,14);

            this.lbOpcion1 = new MetroLabel();
            this.lbOpcion1.Text = "Opción 1: ";
            this.lbOpcion1.Location = new System.Drawing.Point(30, 62);

            this.lbOpcion2 = new MetroLabel();
            this.lbOpcion2.Text = "Opción 2: ";
            this.lbOpcion2.Location = new System.Drawing.Point(30, 110);

            this.lbOpcion3 = new MetroLabel();
            this.lbOpcion3.Text = "Opción 3: ";
            this.lbOpcion3.Location = new System.Drawing.Point(30, 149);

            this.lbOpcion4 = new MetroLabel();
            this.lbOpcion4.Text = "Opción 4: ";
            this.lbOpcion4.Location = new System.Drawing.Point(30,189);


            this.oPanel = new MetroPanel();
            this.oPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oPanel.Height = 214;

            this.oBar = new MetroPanel();
            this.oBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oBar.Height = 5;
            this.oBar.UseCustomBackColor = true;
            this.oBar.BackColor = MetroColors.Blue;
            this.oPanel.Controls.Add(oBar);

            this.oPanel.Controls.Add(lbPregunta);
            this.oPanel.Controls.Add(lbOpcion1);
            this.oPanel.Controls.Add(lbOpcion2);
            this.oPanel.Controls.Add(lbOpcion3);
            this.oPanel.Controls.Add(lbOpcion4);
        }

        public MetroPanel getPanel(String Pregunta, String Opcion1, String Opcion2, String Opcion3, String Opcion4) {
            lbPregunta.Text += Pregunta;
            lbPregunta.Size = lbPregunta.PreferredSize;

            lbOpcion1.Text += Opcion1;
            lbOpcion1.Size = lbOpcion1.PreferredSize;

            lbOpcion2.Text += Opcion2;
            lbOpcion2.Size = lbOpcion2.PreferredSize;

            lbOpcion3.Text += Opcion3;
            lbOpcion3.Size = lbOpcion3.PreferredSize;

            lbOpcion4.Text += Opcion4;
            lbOpcion4.Size = lbOpcion4.PreferredSize;


            return this.oPanel;
        }
    }
}
