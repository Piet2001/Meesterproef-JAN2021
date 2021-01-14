namespace Logic
{
    public class Uitslagregel
    {
        public Partij Partij { get; }
        private int Stemmen { get; }
        private double Percentage { get; }
        public int Zetels { get; }

        public Uitslagregel(Partij partij, int stemmen, double percentage, int zetels)
        {
            Partij = partij;
            Stemmen = stemmen;
            Percentage = percentage;
            Zetels = zetels;
        }

        public override string ToString()
        {
            return $"{Partij.Orde} - Stemmen: {Stemmen} - Percentage: {Percentage} - Zetels: {Zetels}";
        }
    }
}
