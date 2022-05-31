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
    public class RepGost
    {
        public static Gost DohvatiGosta(int id) //Dohvacanje gosta po id-u
        {
            Gost gost = null;

            string sql = $"SELECT * FROM Gost WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                gost = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return gost;
        }

        public static List<Gost> DohvatiGoste() 
        {
            var gosti = new List<Gost>(); 

            string sql = "SELECT * FROM Gost"; 
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Gost gost = CreateObject(reader); 
                gosti.Add(gost);
            }

            reader.Close();
            DB.CloseConnection();

            return gosti;
        }

        private static Gost CreateObject(SqlDataReader reader)
        {
            string OIB = reader["OIB"].ToString();
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Kontakt = reader["Kontakt"].ToString();

            var gost = new Gost
            {
                OIB = OIB,
                Ime = Ime,
                Prezime = Prezime,
                Kontakt=Kontakt
            };

            return gost;
        }
    }
}
