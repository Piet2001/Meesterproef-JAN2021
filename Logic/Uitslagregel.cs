using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Uitslagregel
    {
        public Partij Partij { get; }
        public int Stemmen { get; }
        public double Percentage { get; }
        public int Zetels { get; }

        public Uitslagregel(Partij partij, int stemmen, double percentage, int zetels)
        {
            Partij = partij;
            Stemmen = stemmen;
            Percentage = percentage;
            Zetels = zetels;
        }
    }
}
