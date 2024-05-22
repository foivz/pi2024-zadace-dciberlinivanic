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
    public class TipVozilaRepository
    {
        public static List<TipVozila> GetTipVozila()
        {
            List<TipVozila> tipVozilas = new List<TipVozila>();
            string sql = "SELECT * FROM TipVozila";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                TipVozila tipvozila = CreateObject(reader);
               tipVozilas.Add(tipvozila);
            }
            reader.Close();
            DB.CloseConnection();
            return tipVozilas;
        }
        private static TipVozila CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string tip = reader["Tip"].ToString();
            int brojsjedala = int.Parse(reader["BrojSjedala"].ToString());

            var tipvozila = new TipVozila
            {
                Id = id,
                Tip = tip,
                BrojSjedala = brojsjedala,
            };
            return tipvozila;
        }
    }
}
