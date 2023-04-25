using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_prijava_Click(object sender, EventArgs e)
        {
            string kor_ime = tb_kor_ime.Text;
            string lozinka = tb_lozinka.Text;

            if(kor_ime == "lgajdek20" && lozinka == "sifra")
            {
                MessageBox.Show("Uspješna prijava!", "Login");
            }

            else
            {
                MessageBox.Show("Neuspješna prijava!\nPogrešna lozinka ili username", "Login");
            }
        }
    }
}
