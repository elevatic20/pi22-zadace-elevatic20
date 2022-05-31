using DBLayer;
using iReservate.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReservate.Repozitoriji
{
    public class RepSmjestaj
    {
        public static Smjestaj DohvatiSmjestaj(int id)
        {
            Smjestaj smjestaj = null;
            string sql = $"SELECT * FROM Smjestaj WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                smjestaj = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return smjestaj;
        }
        public static List<Smjestaj> DohvatiSmjestajeve()
        {
            var smjestajevi = new List<Smjestaj>();

            string sql = "SELECT * FROM Smjestaj";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Smjestaj smjestaj = CreateObject(reader);
                smjestajevi.Add(smjestaj);
            }

            reader.Close();
            DB.CloseConnection();

            return smjestajevi;
        }


        private static Smjestaj CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_smjetaj"].ToString());
            string nazivSmjestaja = reader["Naziv_smjestaja"].ToString();

            var smjestaj = new Smjestaj()
            {
                Id_smjetaj = id,
                Naziv_smjestaja = nazivSmjestaja
            };
            return smjestaj;
        }
    }
}
