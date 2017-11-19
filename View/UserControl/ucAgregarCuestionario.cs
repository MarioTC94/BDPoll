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
        public ucAgregarCuestionario() {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            new Forms.btnSalir().Show();
        }
    }
}
