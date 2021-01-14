using Interfaces.Dal;

namespace Factory
{
    public static class Factory
    {
        public static IPartijManager GetPartijManager()
        {
            return new DAL.PartijManager();
        }
    }
}
