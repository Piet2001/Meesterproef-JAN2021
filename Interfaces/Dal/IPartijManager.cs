using System.Collections.Generic;
using Interfaces.DTO;

namespace Interfaces.Dal
{
    public interface IPartijManager
    {
        public List<PartijDTO> GetAllProducts();
    }
}