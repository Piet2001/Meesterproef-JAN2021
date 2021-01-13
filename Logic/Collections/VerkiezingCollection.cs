using System;

namespace Logic.Collections
{
    public class VerkiezingCollection
    {
        public void AddVerkiezing(string naam, DateTime datum, int zetels)
        {
            var verkiezing = new Verkiezing(naam, datum, zetels);
        }
    }
}
