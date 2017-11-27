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
    public partial class SelecciónVerdaderoyFalso : MetroFramework.Forms.MetroForm {

        public String DescripcionPregunta { get; set; }

        public SelecciónVerdaderoyFalso() {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            if( this.txtpregunta.Text.Trim() != null ) {
                this.DescripcionPregunta = this.txtpregunta.Text.Trim();
                this.DialogResult = DialogResult.OK;
            } else {
                MetroFramework.MetroMessageBox.Show(this, "Escriba la pregunta");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.None;
        }
    }
}
