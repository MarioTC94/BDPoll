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
    public partial class ucMiscuestionarios : MetroFramework.Controls.MetroUserControl {


        public ucMiscuestionarios(DataTable oDT) {
            InitializeComponent();

            List<String> IDCuestionarios = oDT.AsEnumerable().Select(x => x["IDCuestionario"].ToString()).Distinct().ToList();
            foreach (String IDCuestionario in IDCuestionarios) {
                List<DataRow> PreguntasCuestionario = oDT.AsEnumerable().Where(x => x["IDCuestionario"].ToString() == IDCuestionario).ToList();
                pnMain.Controls.Add(new Helpers.PanelMisCuestionarios(PreguntasCuestionario).getPanel(PreguntasCuestionario[0]["Titulo"].ToString(), PreguntasCuestionario.Count.ToString(), (PreguntasCuestionario.Count * 2).ToString()));
            }
            pnMain.AutoScroll = false;
            pnMain.HorizontalScroll.Enabled = false;
            pnMain.HorizontalScroll.Visible = false;
            pnMain.HorizontalScroll.Maximum = 0;
            pnMain.AutoScroll = true;

        }
    }
}
