using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace View.Forms{

    public partial class Login : MetroForm {

        private Register RG = new Register();

        public Login() {
            InitializeComponent();
        }

        #region Eventos
        private void Btn_IniciaSesion_Click(object sender, EventArgs e) {
            try {
                if (new BusinessLogic.Login().tryLogin(Txt_Usuario.Text.Trim(), Txt_Contraseña.Text.Trim())) {
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
            this.Hide();
            RG.ShowDialog(this);

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

