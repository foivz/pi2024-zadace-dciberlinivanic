using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaUpravljanjeGradskimPrijevozom.Models
{
    internal class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korime { get; set;}
        public string Sifra {  get; set;}

        public string PunoIme
        {
            get { return $"{Korime}"; }
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}
