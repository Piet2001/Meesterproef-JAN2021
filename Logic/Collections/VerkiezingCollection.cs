using System;
using System.Collections.Generic;
using System.Text;

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
