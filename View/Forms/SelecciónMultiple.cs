using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms{
    public partial class SelecciónMultiple : MetroFramework.Forms.MetroForm{

        public String DescripcionPregunta { get; set; }
        public String Opcion1 { get; set; }
        public String Opcion2 { get; set; }
        public String Opcion3 { get; set; }
        public String Opcion4 { get; set; }

        public SelecciónMultiple() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if( txtpregunta.Text.Trim() != "" && txtopcion1.Text.Trim() != "" && txtopcion2.Text.Trim() != "" && txtopcion3.Text.Trim() != "" && txtopcion4.Text.Trim() != "" ) {
                this.DescripcionPregunta = txtpregunta.Text.Trim();
                this.Opcion1 = txtopcion1.Text.Trim();
                this.Opcion2 = txtopcion2.Text.Trim();
                this.Opcion3 = txtopcion3.Text.Trim();
                this.Opcion4 = txtopcion4.Text.Trim();
                this.DialogResult = DialogResult.OK;
            } else {
                MetroFramework.MetroMessageBox.Show(this, "Coma mierda");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.None;
        }
    }
}
