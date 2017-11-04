using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View {

    public partial class Login : MetroFramework.Forms.MetroForm {
        public Login() {
            InitializeComponent();
        }

        #region Eventos
        private void Btn_IniciaSesion_Click(object sender, EventArgs e) {
            //ddfgdfgdfgdfgdfgdfgdfgdfdg
            this.DialogResult = DialogResult.OK;
            //Sino
            this.DialogResult = DialogResult.None;
        }
        #endregion
    }
}
