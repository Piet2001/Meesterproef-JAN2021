using System;
using System.Collections.Generic;
using Interfaces.Dal;

namespace Logic.Collections
{
    public class PartijCollection
    {
        private IPartijManager _partijManager = Factory.Factory.GetPartijManager();

        public bool AddPartij(string orde, string naam, string lijsttrekker)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Partij> GetAllePartijen()
        {
            throw new NotImplementedException();
        }
    }
}
