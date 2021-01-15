using System.Collections.Generic;
using Interfaces.DTO;
using Interfaces.Logic;

namespace Interfaces.Dal
{
    public interface IVerkiezingsManager
    {
        public List<VerkiezingsDto> GetAlleVerkiezingen();
        public bool VerkiezingToevoegen(IVerkiezing verkiezing);
        public bool Updateverkiezing(IVerkiezing verkiezing);
    }
}