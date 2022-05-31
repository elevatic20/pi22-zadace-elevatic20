using DBLayer;
using iReservate.Models;
using iReservate.Repozitoriji;
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
    public partial class FrmRezervacija : Form
    {
        public FrmRezervacija()
        {
            InitializeComponent();
            DB.SetConfiguration("elevatic20_DB", "elevatic20", "bHRtf-+/");
        }

        private void FrmRezervacija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elevatic20_DBDataSet2.Rezervacija' table. You can move, or remove it, as needed.
            this.rezervacijaTableAdapter.Fill(this.elevatic20_DBDataSet2.Rezervacija);
            // TODO: This line of code loads data into the 'elevatic20_DBDataSet1.Smjestaj' table. You can move, or remove it, as needed.
            this.smjestajTableAdapter.Fill(this.elevatic20_DBDataSet1.Smjestaj);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var gosti = RepGost.DohvatiGoste();
            cbGost.DataSource = gosti;

            var smjestajevi = RepSmjestaj.DohvatiSmjestajeve();
            cbSmjestaj.DataSource = smjestajevi;
        }
        private void cbGost_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sad = cbGost.SelectedItem as Gost;
        }

        private void cbSmjestaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sad1 = cbSmjestaj.SelectedItem as Smjestaj;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO Rezervacija (ID, Gost, Smjestaj, Broj_osoba, Od, Do, Cijena) VALUES ('{txtIdRezervacija.Text}', '{cbGost.Text}','{cbSmjestaj.Text}', '{txtBrojOsoba.Text}', '{txtOd.Text}', '{txtDo.Text}', '{txtCijena.Text}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Rezervacija WHERE ID = '{txtIdRezervacija.Text}'";
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
            string sql = $"UPDATE Rezervacija SET ID = '{txtIdRezervacija.Text}', Gost = '{cbSmjestaj.Text}', Broj_osoba = '{txtBrojOsoba.Text}', Od = '{txtOd.Text}', Do =  '{txtDo.Text}', Cijena = '{txtCijena.Text}' WHERE Id = '{txtIdRezervacija.Text}' ";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();
        }
    }
}
