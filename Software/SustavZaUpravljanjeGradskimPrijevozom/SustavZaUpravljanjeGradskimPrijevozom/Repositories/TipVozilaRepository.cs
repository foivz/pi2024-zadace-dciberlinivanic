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
        public static TipVozila GetTipVozila(string Tip)
        {
            TipVozila tipvozila = null;
            string sql = $"SELECT * FROM TipVozila WHERE Tip = {Tip}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) 
            {
                reader.Read();
                tipvozila = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return tipvozila;
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
