﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaUpravljanjeGradskimPrijevozom.Models
{
    public class Vozilo : PodacioVozilu
    {
        public int BrSjedala { get; set; }
        public int BrKilometara { get; set; }
    }
}