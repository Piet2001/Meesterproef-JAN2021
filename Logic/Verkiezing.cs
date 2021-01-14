using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces.Logic;

namespace Logic
{
    public class Verkiezing : IVerkiezing
    {
        public string Naam { get; }
        public DateTime Datum { get; }
        public int Zetels { get; }
        public ICoalitie Coalitie { get; }
        public int VrijeZetels => Zetels - _uitslag.Sum(x => x.Zetels);
        private int minzetels;




        private List<Uitslagregel> _uitslag = new List<Uitslagregel>();
        private List<Uitslagregel> _geselecteerdeUitlsagen = new List<Uitslagregel>();

        public Verkiezing(string naam, DateTime datum, int zetels)
        {
            Naam = naam;
            Datum = datum;
            Zetels = zetels;

            if (zetels % 2 == 0)
            {
                minzetels = Zetels / 2 + 1;
            }
            else
            {
                minzetels = (int)Math.Ceiling(Zetels / 2.0);
            }
        }

        public bool AddUitslagregel(Partij partij, int stemmen, double percentage, int zetels)
        {
            if (zetels <= VrijeZetels)
            {
                if (_uitslag.Any(uitslagregel => uitslagregel.Partij.Orde == partij.Orde))
                {
                    return false;
                }
                var deelnemer = new Uitslagregel(partij, stemmen, percentage, zetels);
                _uitslag.Add(deelnemer);
                return true;
            }

            return false;
        }

        public IEnumerable<Uitslagregel> GetUitslagregels()
        {
            return _uitslag.OrderByDescending(x => x.Zetels).ToList();
        }
        public IEnumerable<Uitslagregel> GetGeselecteerdeUitslagregels()
        {
            return _geselecteerdeUitlsagen.OrderByDescending(x => x.Zetels).ToList();
        }
        public bool AddSelectedUitslagregel(Uitslagregel regel)
        {
            if (_geselecteerdeUitlsagen.Any(uitslagregel => uitslagregel.Partij.Orde == regel.Partij.Orde))
            {
                return false;
            }
            _geselecteerdeUitlsagen.Add(regel);
            return true;
        }

        public bool CoalitiePossible()
        {
            return minzetels <= _geselecteerdeUitlsagen.Sum(x => x.Zetels);
        }

        public override string ToString()
        {
            return $"{Naam} - {Datum.ToShortDateString()}";
        }
    }
}
