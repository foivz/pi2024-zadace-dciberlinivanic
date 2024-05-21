using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaUpravljanjeGradskimPrijevozom.Models
{
    public abstract class PodacioVozilu
    {
        public int SerijskiBroj { get; set; }
        public string Marka { get; set; }
        public string Registracija { get; set; }
        public override string ToString()
        {
            return Marka + "," + Registracija;
        }
    }
}
