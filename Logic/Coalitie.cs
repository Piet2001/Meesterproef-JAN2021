using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Coalitie
    {
        public string Naam { get; }
        public string Premier { get; }
        public IReadOnlyCollection<Partij> Partijen { get => _partijenInCoalitie.AsReadOnly(); }

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
