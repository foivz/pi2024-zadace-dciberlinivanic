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
    internal class ZaposlenikRepository
    {
        public static List<Zaposlenik> GetZapsolenik()
        {
            List<Zaposlenik> zaposleniks = new List<Zaposlenik>();
            string sql = "SELECT * FROM Zaposlenik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zaposlenik zaposlenik = CreateObject(reader);
                zaposleniks.Add(zaposlenik);
            }
            reader.Close();
            DB.CloseConnection();
            return zaposleniks;
        }
        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string korime = reader["Korime"].ToString();
            string Sifra = reader["Sifra"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Korime = korime,
                Sifra = Sifra
            };
            return zaposlenik;
        }
    }
}
