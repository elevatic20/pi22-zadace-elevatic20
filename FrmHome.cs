using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iReservate
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btn_odjava_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogiin = new FrmLogin();
            Hide();
            frmLogiin.ShowDialog();
            Close();
        }

        private void btnSmjestaj_Click(object sender, EventArgs e)
        {
            FrmSmjestaj frmSmjetaj = new FrmSmjestaj();
            Hide();
            frmSmjetaj.ShowDialog();
            Close();
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            FrmGosti frmGost = new FrmGosti();
            Hide();
            frmGost.ShowDialog();
            Close();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            FrmRezervacija FrmRezervacija = new FrmRezervacija();
            Hide();
            FrmRezervacija.ShowDialog();
            Close();
        }
    }
}
