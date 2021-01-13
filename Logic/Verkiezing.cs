using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Verkiezing
    {
        public string Naam { get; }
        public DateTime Datum { get; }
        public int Zetels { get; }
        public Coalitie Coalitie { get; }
        private List<Uitslagregel> _uitslag = new List<Uitslagregel>();
        private int Vrijezetels => Zetels - _uitslag.Sum(x => x.Zetels);

        public Verkiezing(string naam, DateTime datum, int zetels)
        {
            Naam = naam;
            Datum = datum;
            Zetels = zetels;
        }

        public bool AddUitslagregel(Partij partij, int stemmen, double percentage, int zetels)
        {
            if (zetels <= Vrijezetels)
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
            return _uitslag;
        }

        public bool CheckPossibleCoalitie(List<Uitslagregel> sellectedUitslagregels)
        {
            throw new NotImplementedException();
        }
    }
}
