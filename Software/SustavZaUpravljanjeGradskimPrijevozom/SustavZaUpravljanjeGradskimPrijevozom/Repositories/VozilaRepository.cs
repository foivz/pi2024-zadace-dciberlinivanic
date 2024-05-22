using DBLayer;
using SustavZaUpravljanjeGradskimPrijevozom.Models;
using System;
using System.Collections.Generic;
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
            int serijskibroj = int.Parse(reader["SerijskiBroj"].ToString());
            string marka = reader["Marka"].ToString();
            string registracija = reader["Registracija"].ToString();
            int brojKilometara = int.Parse(reader["BrojKilometara"].ToString());
            int brojSjedala = int.Parse(reader["BrojSjedala"].ToString());
            int garazniBroj = int.Parse(reader["GarazniBroj"].ToString());
            string tipvozila = reader["TipVozila"].ToString();
            var vozilo = new Vozilo
            {
                SerijskiBroj = serijskibroj,
                Marka = marka,
                Registracija = registracija,
                BrKilometara = brojKilometara,
                BrSjedala = brojSjedala,
                GarazniBroj = garazniBroj,
                TipVozila = tipvozila
              

            };
            return vozilo;
        }
    }
}
