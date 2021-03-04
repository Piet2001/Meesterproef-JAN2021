using DAL;
using Interfaces.Dal;

namespace Factory
{
    public static class Factory
    {
        public static IPartijManager GetPartijManager()
        {
            return new PartijManager(Data.Connectionstring());
        }

        public static IVerkiezingsManager GetVerkiezingsManager()
        {
            return new Verkiezingsmanager();
        }
    }
}
