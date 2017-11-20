using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControl {
    public partial class ucAgregarCuestionario : MetroFramework.Controls.MetroUserControl {

        public List<Model.Cuestionario> ListaCuestionarios { get; set; }

        public ucAgregarCuestionario() {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            Forms.AgregarCuestionario oForm = new Forms.AgregarCuestionario();
            if( oForm.ShowDialog(this) == DialogResult.OK) {
                List<Model.Pregunta> oPreguntas = oForm.ListPreguntas;
                if( oPreguntas.Any() ) {
                    Model.Cuestionario oCuestionario = new Model.Cuestionario();
                    oCuestionario.Pregunta = oPreguntas;
                    oCuestionario.TipoCustionario = 1;
                    oCuestionario.IDUsuario = BusinessLogic.Credenciales.Usuario.NombreUsuario;
                    oCuestionario.Titulo = "Titulo";
                    this.ListaCuestionarios.Add(oCuestionario);
                }
            }
        }
    }
}
