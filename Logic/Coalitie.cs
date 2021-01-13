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

        public Coalitie(string naam, string premier)
        {
            Naam = naam;
            Premier = premier;
            _partijenInCoalitie = new List<Partij>();
        }

        public void VoegPartijToeAanCoalitie(Partij partij)
        {
            _partijenInCoalitie.Add(partij);
        }
    }
}
