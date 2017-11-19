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
using MetroFramework;
using MetroFramework.Controls;
using View.UserControl;

namespace View.Forms {
    public partial class Main : MetroForm {

        private MetroUserControl ucCC;
        private MetroUserControl ucFA;
        private MetroUserControl ucIni;
        private MetroUserControl ucMisC;
        private MetroUserControl ucPerf;
        

        public Main() {
            InitializeComponent();
            /**********************************/
            this.ucCC = new ucAgregarCuestionario();
            this.ucCC.Dock = DockStyle.Fill;

            this.ucFA = new ucFacturación();
            this.ucFA.Dock = DockStyle.Fill;

            this.ucIni = new ucInicio();
            this.ucIni.Dock = DockStyle.Fill;

            this.ucMisC = new ucMiscuestionarios();
            this.ucMisC.Dock = DockStyle.Fill;

            this.ucPerf = new ucPerfil();
            this.ucPerf.Dock = DockStyle.Fill;

            this.pnPrincipal.Controls.Add(ucCC);
            this.pnPrincipal.Controls.Add(ucFA);
            this.pnPrincipal.Controls.Add(ucIni);
            this.pnPrincipal.Controls.Add(ucMisC);
            this.pnPrincipal.Controls.Add(ucPerf);

            this.ucCC.BringToFront();


        }

        private void btnPerfil_Click(object sender, EventArgs e) {
            this.ucPerf.BringToFront();
        }

        private void btnMisCuestionarios_Click(object sender, EventArgs e) {
            this.ucMisC.BringToFront();
        }

        private void btnFacturacion_Click(object sender, EventArgs e) {
            this.ucFA.BringToFront();
        }


        private void btnCrearCuestionario_Click(object sender, EventArgs e) {
            this.ucCC.BringToFront();
        }

        private void btn_ResponderCuestionario_Click(object sender, EventArgs e) {
            this.ucIni.BringToFront();
        }
    }
}
