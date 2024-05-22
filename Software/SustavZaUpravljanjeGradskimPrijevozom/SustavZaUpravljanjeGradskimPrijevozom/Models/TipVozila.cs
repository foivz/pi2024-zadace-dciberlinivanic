using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaUpravljanjeGradskimPrijevozom.Models
{
    public class TipVozila
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public int BrojSjedala { get; set; }
        public override string ToString()
        {
            return Tip;
        }
    }
}
