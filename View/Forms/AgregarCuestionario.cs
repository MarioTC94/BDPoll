using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms {
    public partial class AgregarCuestionario : MetroFramework.Forms.MetroForm {

        public List<Model.Pregunta> ListPreguntas { get; } //$2
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechaFinal { get; set; }

        public AgregarCuestionario() {
            InitializeComponent();
            ListPreguntas = new List<Model.Pregunta>();
        }

        private void btnRespuestaUnica_Click(object sender, EventArgs e) {
            SelecciónUnica oForm = new SelecciónUnica();
            if( oForm.ShowDialog() == DialogResult.OK ) {
                Model.Pregunta oPregunta = new Model.Pregunta() {
                    DescripcionPregunta = oForm.DescripcionPregunta,
                };
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion1 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion2 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion3 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion4 });
                oPregunta.IDTipoPregunta = 2;
                oPregunta.TipoPregunta = new Model.TipoPregunta() { IDTipoPregunta = 2, DescripcionTipoPregunta = "Respuesta Unica" };
                ListPreguntas.Add(oPregunta);
                this.pnAgregarCuestionario.Controls.Add(new Helpers.PanelAgregarPregunta(oPregunta, this.pnAgregarCuestionario, this).getPanel("Respuesta Unica", oForm.DescripcionPregunta));
            }
        }

        private void btnRespuestaMultiple_Click(object sender, EventArgs e) {
            SelecciónMultiple oForm = new SelecciónMultiple();
            if( oForm.ShowDialog() == DialogResult.OK ) {
                Model.Pregunta oPregunta = new Model.Pregunta() {
                    DescripcionPregunta = oForm.DescripcionPregunta,
                };
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion1 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion2 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion3 });
                oPregunta.Opciones.Add(new Model.Opciones() { DescripcionOpcion = oForm.Opcion4 });
                oPregunta.IDTipoPregunta = 1;
                ListPreguntas.Add(oPregunta);
                this.pnAgregarCuestionario.Controls.Add(new Helpers.PanelAgregarPregunta(oPregunta, this.pnAgregarCuestionario, this).getPanel("Respuesta Multiple", oForm.DescripcionPregunta));
            }
        }

        private void btnfalsoyerdadero_Click(object sender, EventArgs e) {
            SelecciónVerdaderoyFalso oForm = new SelecciónVerdaderoyFalso();
            if( oForm.ShowDialog() == DialogResult.OK ) {
                Model.Pregunta oPregunta = new Model.Pregunta() {
                    DescripcionPregunta = oForm.DescripcionPregunta,
                };
                ListPreguntas.Add(oPregunta);
                this.pnAgregarCuestionario.Controls.Add(new Helpers.PanelAgregarPregunta(oPregunta, this.pnAgregarCuestionario, this).getPanel("Respuesta Multiple", oForm.DescripcionPregunta));

            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            this.Titulo = txtTitulo.Text.Trim();
            this.Descripcion = txtTitulo.Text.Trim();
            this.FechaFinal = dtpFechaTerminada.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void metroLabel6_Click(object sender, EventArgs e) {

        }
    }
}
