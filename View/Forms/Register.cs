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
using BusinessLogic;



namespace View.Forms {
    public partial class Register : MetroForm {

        public clsCatalogos Catalogo = new clsCatalogos();

        public Register() {

            InitializeComponent();
            InitializeComboBox();
        }


        public async void InitializeComboBox() {

            /*Catalogo que se le da a cada ComboBox para obtener información de cada Insert que se realizó
            en la base de datos */

        //----------------------------------------------------------
            CB_TipoPersona.DataSource = await Catalogo.getTipoPersona();
            CB_TipoPersona.DisplayMember = "DescripcionTipoPersona";
            CB_TipoPersona.ValueMember = "IDTipoPersona";
            //----------------------------------------------------------

            CB_TipoEmail.DataSource = await Catalogo.getTipoEmail();
            CB_TipoEmail.DisplayMember = "DescripcionTipoEmail";
            CB_TipoEmail.ValueMember = "IDTipoEmail";

            //----------------------------------------------------------


            CB_TipoTelefono.DataSource = await Catalogo.getTipoTelefono();
            CB_TipoTelefono.DisplayMember = "DescripcionTipoTelefono";
            CB_TipoTelefono.ValueMember = "IDTipoTelefono";

            //-----------------------------------------------------------

            CB_Genero.DataSource = await Catalogo.getGenero();
            CB_Genero.DisplayMember = "DescripcionGenero";
            CB_Genero.ValueMember = "IDGenero";

            //-----------------------------------------------------------

            CB_Country.DataSource = await Catalogo.getCountry();
            CB_Country.DisplayMember = "NameCountry";
            CB_Country.ValueMember = "IDCountry";

            //------------------------------------------------------------
            CB_State.DataSource = await Catalogo.getState((int) CB_Country.SelectedValue);
            CB_State.DisplayMember = "NameState";
            CB_State.ValueMember = "IDState";

            //------------------------------------------------------------
            CB_City.DataSource = await Catalogo.getCity((int) CB_State.SelectedValue);
            CB_City.DisplayMember = "NameCity";
            CB_City.ValueMember = "IDCity";

            //-------------------------------------------------------------

            CB_TipoDirecion.DataSource = await Catalogo.getTipoDireccion();
            CB_TipoDirecion.DisplayMember = "DescripcionTipoDireccion";
            CB_TipoDirecion.ValueMember = "IDTipoDireccion";

            //--------------------------------------------------------------

        }

        private void Btn_Salir_Click(object sender, EventArgs e) {

            if (MetroFramework.MetroMessageBox.Show(this, "Estás seguro que deseas salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Hide();
                Login LG = new Login();
                LG.ShowDialog();
            }
        }

        private async void Btn_Aceptar_Click(object sender, EventArgs e) {
            try {
                if (await new clsRegistro().AutenticarUsuario (Txt_Cedula.Text.Trim(), (int) CB_TipoPersona.SelectedValue,
                    Txt_Nombre.Text.Trim(), Txt_Apellido1.Text.Trim(), Txt_Apellido2.Text.Trim(), (DateTime) Dtp_FechaNacimiento.Value,
                    (int) CB_Genero.SelectedValue, Txt_Email.Text.Trim(), (byte) CB_TipoEmail.SelectedValue, Txt_Telefono.Text.Trim(),
                    (byte) CB_TipoTelefono.SelectedValue, Txt_Usuario.Text.Trim(), Txt_Contraseña.Text.Trim(), (int) CB_Country.SelectedValue,
                    (int) CB_State.SelectedValue, (int) CB_City.SelectedValue, (byte) CB_TipoDirecion.SelectedValue,
                    Txt_DireccionExacta.Text.Trim())) {

                    MetroFramework.MetroMessageBox.Show(this, "Cliente Registrado Correctamente..", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ( (MetroForm) Parent ).DialogResult = DialogResult.OK;
                    this.Dispose();
                } else {
                    MetroFramework.MetroMessageBox.Show(this, "No se pudo registrar sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception ex) {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    


        private async void CB_Country_SelectionChangeCommitted(object sender, EventArgs e) {

            CB_State.DataSource = await Catalogo.getState((int) CB_Country.SelectedValue);
            CB_City.DataSource = await Catalogo.getCity((int) CB_State.SelectedValue);

        }

        private async void CB_State_SelectionChangeCommitted(object sender, EventArgs e) {
            
            CB_City.DataSource = await Catalogo.getCity((int) CB_State.SelectedValue);
            
        }

    }
}
