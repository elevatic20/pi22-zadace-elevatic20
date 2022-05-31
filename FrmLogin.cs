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
    public partial class FrmLogin : Form
    {
        string username = "zaposlenik";
        string password = "zaposlenik";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorime.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtKorime.Text == username && txtLozinka.Text == password)
                {
                    MessageBox.Show("Usmješna prijava", "Uspješno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmHome frmHome = new FrmHome();
                    Hide();
                    frmHome.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Unijeli ste krive podatke!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    } 
}
