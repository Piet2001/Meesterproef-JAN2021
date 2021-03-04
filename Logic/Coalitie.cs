using System.Collections.Generic;
using System.Linq;
using Interfaces.Logic;

namespace Logic
{
    public class Coalitie : ICoalitie
    {
        public string Naam { get; }
        public string Premier { get; }
        public IReadOnlyCollection<IPartij> Partijen => _partijenInCoalitie.AsReadOnly();

        private List<IPartij> _partijenInCoalitie = new List<IPartij>();

        public Coalitie(string naam, List<IUitslagregel> uitslagregelsVoorCoalitie)
        {
            Naam = naam;
            Premier = uitslagregelsVoorCoalitie.OrderByDescending(x => x.Zetels).First().Partij.Lijsttrekker;
            foreach (var uitslagregel in uitslagregelsVoorCoalitie)
            {
                _partijenInCoalitie.Add(uitslagregel.Partij);
            }
        }

        public override string ToString()
        {
            string partijenString = "";
            foreach (var partij in Partijen)
            {
                partijenString += $"{partij.Orde}\n";
            }
            return $"Coalitie: {Naam}\n\nPremier: {Premier}\n\nPartijen:\n{partijenString}";
        }
    }
}
