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
    public partial class Register : MetroFramework.Forms.MetroForm{
        public Register() {
            InitializeComponent();
            InitializeComboBox();
        }


        public async void InitializeComboBox() {
            var Catalogo = new BusinessLogic.clsCatalogos();
            //----------------------------------------------------------
            CB_TipoPersona.DataSource = await Catalogo.getTipoPersona();
            CB_TipoPersona.DisplayMember = "DescripcionTipoPersona";
            CB_TipoPersona.ValueMember = "IDTipoPersona";
            //----------------------------------------------------------

        }

    }
}
