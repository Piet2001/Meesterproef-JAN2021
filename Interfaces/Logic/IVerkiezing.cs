using System;

namespace Interfaces.Logic
{
    public interface IVerkiezing
    {
        public string Naam { get; }
        public DateTime Datum { get; }
        public int Zetels { get; }
        public ICoalitie Coalitie { get; }
    }
}
