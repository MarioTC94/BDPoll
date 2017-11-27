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

            this.ucPerf = new ucPerfil();
            this.ucPerf.Dock = DockStyle.Fill;

            this.panelmain.Controls.Add(ucCC);
            this.panelmain.Controls.Add(ucFA);
            this.panelmain.Controls.Add(ucIni);
            this.panelmain.Controls.Add(ucPerf);

            this.ucCC.BringToFront();


        }

        private void btnPerfil_Click(object sender, EventArgs e) {
            this.ucPerf.BringToFront();
        }

        private async void btnMisCuestionarios_Click(object sender, EventArgs e) {
            DataTable oDT = await new BusinessLogic.Cuestionario().MisCuestionarios();
            this.ucMisC = new ucMiscuestionarios(oDT);
            this.ucMisC.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(ucMisC);
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

        private void btncerrarsesion_Click(object sender, EventArgs e) {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm)); /* Crea un hilo para realizar un proceso de salida e inicio de sesión*/
            t.Start();
            this.Close();
        }
        public static void OpenLoginForm() {
            if (new Login().ShowDialog() == DialogResult.OK) {
                Application.Run(new Main());
            }
        }
    }
}
