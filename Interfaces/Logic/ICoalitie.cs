using System.Collections.Generic;

namespace Interfaces.Logic
{
    public interface ICoalitie
    {
        public string Naam { get; }
        public string Premier { get; }
        public IReadOnlyCollection<IPartij> Partijen { get; }
    }
}