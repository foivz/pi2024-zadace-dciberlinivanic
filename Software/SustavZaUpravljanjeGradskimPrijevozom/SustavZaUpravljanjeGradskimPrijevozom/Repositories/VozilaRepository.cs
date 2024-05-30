using DBLayer;
using SustavZaUpravljanjeGradskimPrijevozom.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaUpravljanjeGradskimPrijevozom.Repositories
{
    public class VozilaRepository
    {
        public static List<Vozilo> GetVozilos()
        {
            List<Vozilo> vozilos = new List<Vozilo>();
            string sql = "SELECT * FROM Vozila";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Vozilo vozilo = CreateObject(reader);
                vozilos.Add(vozilo);
            }
            reader.Close();
            DB.CloseConnection();
            return vozilos;
        }
        private static Vozilo CreateObject(SqlDataReader reader)
        {
            string marka = reader["Marka"].ToString();
            string registracija = reader["Registracija"].ToString();
            int brojKilometara = int.Parse(reader["BrojKilometara"].ToString());
            int brojSjedala = int.Parse(reader["BrojSjedala"].ToString());
            int garazniBroj = int.Parse(reader["GarazniBroj"].ToString());
            string tipvozila = reader["Tip"].ToString();
            string korime = reader["Korime"].ToString();
            var vozilo = new Vozilo
            {
                Marka = marka,
                Registracija = registracija,
                BrKilometara = brojKilometara,
                BrSjedala = brojSjedala,
                GarazniBroj = garazniBroj,
                Tip = tipvozila,
                Korime = korime
              

            };
            return vozilo;
        }
        public static List<Vozilo> PretraziVozila(string searchText)
        {
            List<Vozilo> vozila = new List<Vozilo>();

            string sql = $"SELECT * FROM Vozila WHERE Marka LIKE '%{searchText}%' OR Tip LIKE '%{searchText}%'";

            DB.OpenConnection();

            SqlDataReader reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Vozilo vozilo = new Vozilo
                {
                    GarazniBroj = int.Parse(reader["GarazniBroj"].ToString()),
                    Marka = reader["Marka"].ToString(),
                    Registracija = reader["Registracija"].ToString(),
                    BrKilometara = int.Parse(reader["BrojKilometara"].ToString()),
                    BrSjedala = int.Parse(reader["BrojSjedala"].ToString()),
                    Korime = reader["Korime"].ToString(),
                    Tip = reader["Tip"].ToString()
                };

                vozila.Add(vozilo);
            }

            reader.Close();
            DB.CloseConnection();

            return vozila;
        }

        public static void Brisanje(int garazniBroj)
        {
            string sql = $"DELETE FROM Vozila WHERE GarazniBroj = {garazniBroj}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void Unos (string marka, string registracija, string kilometri, string brojsjedala,string tipvozila, string zaposlenik)
        {
            string sql = $"INSERT INTO Vozila (Marka,Registracija,BrojKilometara,Korime,Tip,BrojSjedala) VALUES('{marka}','{registracija}','{kilometri}','{zaposlenik}','{tipvozila}','{brojsjedala}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void Azuriranje(string marka, string registracija, string kilometri, string zaposlenik, string tipvozila, string brojsjedala,int garaznibroj)
        {
            string sql = $"UPDATE Vozila SET Marka = '{marka}', Registracija = '{registracija}', BrojKilometara = '{kilometri}', Korime = '{zaposlenik}', Tip = '{tipvozila}', BrojSjedala = '{brojsjedala}' WHERE GarazniBroj = '{garaznibroj}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
