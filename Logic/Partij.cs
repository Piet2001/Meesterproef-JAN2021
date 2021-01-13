using System;

namespace Logic
{
    public class Partij
    {
        public string Orde { get; }
        public string Naam { get; }
        public string Lijsttrekker { get; }

        public Partij(string orde, string naam, string lijsttrekker)
        {
            Orde = orde;
            Naam = naam;
            Lijsttrekker = lijsttrekker;
        }
    }
}
