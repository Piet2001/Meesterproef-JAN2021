using System.Collections.Generic;
using Interfaces.DTO;
using Interfaces.Logic;

namespace Interfaces.Dal
{
    public interface IPartijManager
    {
        public List<PartijDto> GetAllePartijen();
        public bool PartijToevoegen(IPartij partij);
        public bool UpdatePartij(IPartij partij);
    }
}