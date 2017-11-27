using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace View.Forms {

    public partial class DetalleMisCuestionarios : MetroForm {

        public DetalleMisCuestionarios(List<DataRow> Preguntas) {
            InitializeComponent();

            List<DataRow> ListSeleccionMultiple = Preguntas.Where(x => x["IDTipoPregunta"].ToString() == "1").ToList();
            List<DataRow> ListSeleccionUnica = Preguntas.Where(x => x["IDTipoPregunta"].ToString() == "2").ToList();
            List<DataRow> ListVerdaderoFalso = Preguntas.Where(x => x["IDTipoPregunta"].ToString() == "3").ToList();


            List<String> ListIDPreguntaMultiple = ListSeleccionMultiple.Select(x => x["IDPregunta"].ToString()).Distinct().ToList();

            foreach (String IDPregunta in ListIDPreguntaMultiple) {

                String Pregunta = Preguntas.FirstOrDefault(( x => x["IDPregunta"].ToString() == IDPregunta ))["DescripcionPregunta"].ToString();

                List<String> ListIDOpcion = Preguntas.Select(x => x["DescripcionPregunta"].ToString()).Distinct().ToList();
                String opcion1 = ListIDOpcion[0];
                String opcion2 = ListIDOpcion[1];
                String opcion3 = ListIDOpcion[2];
                String opcion4 = ListIDOpcion[3];
                this.pnMisPreguntas.Controls.Add(new Helpers.PanelMisPreguntas().getPanel(Pregunta, opcion1, opcion2, opcion3, opcion4));
            }

            List<String> ListIDPreguntaUnica = ListSeleccionUnica.Select(x => x["IDPregunta"].ToString()).Distinct().ToList();

            foreach (String IDPregunta in ListIDPreguntaUnica) {

                String Pregunta = Preguntas.FirstOrDefault(( x => x["IDPregunta"].ToString() == IDPregunta ))["DescripcionPregunta"].ToString();

                List<String> ListIDOpcion = Preguntas.Select(x => x["DescripcionPregunta"].ToString()).Distinct().ToList();
                String opcion1 = ListIDOpcion[0];
                String opcion2 = ListIDOpcion[1];
                String opcion3 = ListIDOpcion[2];
                String opcion4 = ListIDOpcion[3];
                this.pnMisPreguntas.Controls.Add(new Helpers.PanelMisPreguntas().getPanel(Pregunta, opcion1, opcion2, opcion3, opcion4));
            }


            List<String> ListIDPreguntaVerFal = ListVerdaderoFalso.Select(x => x["IDPregunta"].ToString()).Distinct().ToList();
            foreach (String IDPregunta in ListIDPreguntaMultiple) {

                String Pregunta = Preguntas.FirstOrDefault(( x => x["IDPregunta"].ToString() == IDPregunta ))["DescripcionPregunta"].ToString();
                this.pnMisPreguntas.Controls.Add(new Helpers.PanelMisPreguntas().getPanel(Pregunta, "Verdaderas: ", "Falsas: ", "", ""));
            }
        }
    }
}
