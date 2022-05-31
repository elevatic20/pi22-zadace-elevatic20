using DBLayer;
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
    public partial class FrmGosti : Form
    {
        public FrmGosti()
        {
            InitializeComponent();
            DB.SetConfiguration("elevatic20_DB", "elevatic20", "bHRtf-+/");
        }

        private void FrmGosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elevatic20_DBDataSet1.Gost' table. You can move, or remove it, as needed.
            this.gostTableAdapter.Fill(this.elevatic20_DBDataSet1.Gost);
            // TODO: This line of code loads data into the 'elevatic20_DBDataSet.Smjestaj' table. You can move, or remove it, as needed.
            this.smjestajTableAdapter.Fill(this.elevatic20_DBDataSet.Smjestaj);


        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }

        private void btnDodajGosta_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO Gost (OIB, Ime, Prezime, Kontakt) VALUES ('{txtOIB.Text}', '{txtIme.Text}','{txtPrezime.Text}', '{txtKontakt.Text}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();

        }

        private void btnIzbisiGosta_Click(object sender, EventArgs e)
        {

            string sql = $"DELETE FROM Gost WHERE OIB = '{txtOIB.Text}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE Gost SET OIB = '{txtOIB.Text}', Ime = '{txtIme.Text}', Prezime = '{txtPrezime.Text}', Kontakt = '{txtKontakt.Text}' WHERE OIB = {txtOIB.Text}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }
    }
}
