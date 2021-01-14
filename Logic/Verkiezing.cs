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
        public int CoalitieZetels => _geselecteerdeUitlsagen.Sum(x => x.Zetels);

        private List<Uitslagregel> _uitslag = new List<Uitslagregel>();
        private List<Uitslagregel> _geselecteerdeUitlsagen = new List<Uitslagregel>();

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
            return _uitslag.OrderByDescending(x => x.Zetels).ToList();
        }
        public IEnumerable<Uitslagregel> GetGeselecteerdeUitslagregels()
        {
            return _geselecteerdeUitlsagen.OrderByDescending(x => x.Zetels).ToList();
        }
        public bool SelectUitslagregel(Uitslagregel regel)
        {
            if (_geselecteerdeUitlsagen.Any(uitslagregel => uitslagregel.Partij.Orde == regel.Partij.Orde))
            {
                return false;
            }
            _geselecteerdeUitlsagen.Add(regel);
            return true;
        }

        public override string ToString()
        {
            return $"{Naam} - {Datum.ToShortDateString()}";
        }
    }
}
