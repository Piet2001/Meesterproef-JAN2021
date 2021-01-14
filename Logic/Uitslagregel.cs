using Interfaces.Logic;

namespace Logic
{
    public class Uitslagregel:IUitslagregel
    {
        public IPartij Partij { get; }
        // Maak setter private bij het public maken van stemmen,percentage
        private int Stemmen { get; set; }
        private double Percentage { get; set; }
        public int Zetels { get; private set; }

        public Uitslagregel(IPartij partij, int stemmen, double percentage, int zetels)
        {
            Partij = partij;
            Stemmen = stemmen;
            Percentage = percentage;
            Zetels = zetels;
        }

        public void Update(int stemmen, double percentage, int zetels)
        {
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
