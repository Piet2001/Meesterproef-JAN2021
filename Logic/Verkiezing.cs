using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Verkiezing
    {
        public string Naam { get; }
        public DateTime Datum { get; }
        private List<Deelnemer> _deelnemers = new List<Deelnemer>();

        public Verkiezing(string naam, DateTime datum)
        {
            Naam = naam;
            Datum = datum;
        }
    }
}
