using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testiranje_za_vj3
{
    public partial class frm_pregled_zahtjeva_CIP : Form
    {
        public frm_pregled_zahtjeva_CIP()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_novi_izvjestaj_Click(object sender, EventArgs e)
        {
            frm_unos_izmjena_zahtjeva_CIP Frm_Unos_Izmjena_Zahtjeva_CIP = new frm_unos_izmjena_zahtjeva_CIP();
            Hide();
            Frm_Unos_Izmjena_Zahtjeva_CIP.ShowDialog();
            Close();
        }
    }
}
