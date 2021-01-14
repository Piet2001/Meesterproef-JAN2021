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
        private List<Uitslagregel> _uitslag = new List<Uitslagregel>();
        public int VrijeZetels => Zetels - _uitslag.Sum(x => x.Zetels);

        public Verkiezing(string naam, DateTime datum, int zetels)
        {
            Naam = naam;
            Datum = datum;
            Zetels = zetels;
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
            return _uitslag;
        }

        public bool CheckPossibleCoalitie(List<Uitslagregel> sellectedUitslagregels)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Naam} - {Datum.ToShortDateString()}";
        }
    }
}
