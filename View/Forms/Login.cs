using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using BusinessLogic.Credenciales;

namespace View.Forms{

    public partial class Login : MetroForm {

        public Login() {
            InitializeComponent();
        }

        #region Eventos
        private void Btn_IniciaSesion_Click(object sender, EventArgs e) {
            try {
                if (new BusinessLogic.Login().tryLogin(Txt_Usuario.Text.Trim(), Txt_Contraseña.Text.Trim())) {
                    MetroFramework.MetroMessageBox.Show(this, "!Bienvenido " + Usuario.Nombre + "!" ,"Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                } else {
                    this.DialogResult = DialogResult.None;
                    MetroFramework.MetroMessageBox.Show(this, "Usuario y contraseña invalidos, intentelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception ex) {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void Btn_Registrarse_Click(object sender, EventArgs e) {
           if(new Register().ShowDialog() == DialogResult.OK) {
                this.DialogResult = DialogResult.OK;
            }

    }

        /* try {
             if (new BusinessLogic.Prueba().OpenConnection()) {
                 MetroFramework.MetroMessageBox.Show(this, "Conexión abierta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         } catch (Exception ex) {
             MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }*/

    }
}

