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


namespace View {
    public partial class Register : MetroForm{

        public Register() {
            
            InitializeComponent();
            InitializeComboBox();
        }


        public async void InitializeComboBox() {

            /*Catalogo que se le da a cada ComboBox para obtener información de cada Insert que se realizó
            en la base de datos */

            var Catalogo = new BusinessLogic.clsCatalogos();
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

            CB_State.DisplayMember = "NameState";
            CB_State.ValueMember = "IDState";

            //------------------------------------------------------------

            CB_City.DisplayMember = "NameCity";
            CB_City.ValueMember = "IDCity";

            //-------------------------------------------------------------

            CB_TipoDirecion.DataSource = await Catalogo.getTipoDireccion();
            CB_TipoDirecion.DisplayMember = "DescripcionTipoDireccion";
            CB_TipoDirecion.ValueMember = "IDTipoDireccion";

            //--------------------------------------------------------------

            

        }

        private void Btn_Salir_Click(object sender, EventArgs e) {
            Login LG = new Login();
            Register RG = new Register();

            if (MetroFramework.MetroMessageBox.Show(this, "Estás seguro que deseas salir?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Hide();
                RG.Closed += (s, args) => this.Close();
                LG.ShowDialog();
            }
        }

        private async void Btn_Aceptar_Click(object sender, EventArgs e) {

            
        }
    }
}
