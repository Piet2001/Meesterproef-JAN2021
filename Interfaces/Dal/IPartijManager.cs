using System.Collections.Generic;
using Interfaces.DTO;
using Interfaces.Logic;

namespace Interfaces.Dal
{
    public interface IPartijManager
    {
        public List<PartijDTO> GetAllePartijen();
        public bool AddPartij(IPartij partij);
    }
}