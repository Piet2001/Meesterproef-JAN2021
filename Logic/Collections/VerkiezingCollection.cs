using System;
using System.Collections.Generic;

namespace Logic.Collections
{
    public class VerkiezingCollection
    {
        private List<Verkiezing> verkiezingen = new List<Verkiezing>();

        public void AddVerkiezing(/*string naam, DateTime datum, int zetels*/)
        {
            verkiezingen.Add(new Verkiezing("Test verkiezing", new DateTime(2021, 01, 14), 150));

            //var verkiezing = new Verkiezing(naam, datum, zetels);
        }

        public IReadOnlyCollection<Verkiezing> GetAlleVerkiezingen()
        {
            return verkiezingen;
        }
    }
}
