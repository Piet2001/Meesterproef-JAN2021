using System.Collections.Generic;
using Interfaces.Logic;

namespace Logic
{
    public class Coalitie : ICoalitie
    {
        public string Naam { get; }
        public string Premier { get; }
        public IReadOnlyCollection<IPartij> Partijen => _partijenInCoalitie.AsReadOnly();

        private List<Partij> _partijenInCoalitie;

        public Coalitie(string naam, string premier, List<Partij> coalitiePartijen)
        {
            Naam = naam;
            Premier = premier;
            _partijenInCoalitie = coalitiePartijen;
        }
    }
}
