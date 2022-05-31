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
    public partial class FrmSmjestaj : Form
    {
        public FrmSmjestaj()
        {
            InitializeComponent();
            DB.SetConfiguration("elevatic20_DB", "elevatic20", "bHRtf-+/");
        }

        private void FrmSmjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elevatic20_DBDataSet.Smjestaj' table. You can move, or remove it, as needed.
            this.smjestajTableAdapter.Fill(this.elevatic20_DBDataSet.Smjestaj);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();

        }

        private void btnAddSmjestaj_Click(object sender, EventArgs e)
        {
            
            string sql = $"INSERT INTO Smjestaj (ID_smjestaj, Naziv_smjestaja) VALUES ('{txtIDSmjestaja.Text}', '{txtNazivSmjestaja.Text}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            FrmHome frmHome = new FrmHome();
            Hide();
            frmHome.ShowDialog();
            Close();

        }

        private void btnDelSmjestaj_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Smjestaj WHERE ID_smjestaj = {txtIDSmjestaja.Text}";
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
            string sql = $"UPDATE Smjestaj SET ID_smjestaj = '{txtIDSmjestaja.Text}', Naziv_smjestaja = '{txtNazivSmjestaja.Text}' WHERE ID_smjestaj = {txtIDSmjestaja.Text}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
