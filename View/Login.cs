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
  
        Register RG = new Register();

        public Login() {
            InitializeComponent();
        }

        #region Eventos
        private void Btn_IniciaSesion_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;

        }
        #endregion

        private void Btn_Registrarse_Click(object sender, EventArgs e) {
            this.Hide();
            RG.ShowDialog();
            
            
            /* try {
                 if (new BusinessLogic.Prueba().OpenConnection()) {
                     MetroFramework.MetroMessageBox.Show(this, "Conexión abierta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             } catch (Exception ex) {
                 MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/


           
        }
    }
}
