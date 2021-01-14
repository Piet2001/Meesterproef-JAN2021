using System.Collections.Generic;
using Interfaces.Dal;
using Interfaces.DTO;

namespace Logic.Collections
{
    public class PartijCollection
    {
        private IPartijManager _partijManager = Factory.Factory.GetPartijManager();

        public bool AddPartij(string orde, string naam, string lijsttrekker)
        {
            bool toegevoegd = _partijManager.AddPartij(new Partij(orde, naam, lijsttrekker));

            return toegevoegd;
        }

        public IReadOnlyCollection<Partij> GetAllePartijen()
        {
            List<PartijDto> dtos = _partijManager.GetAllePartijen();
            List<Partij> partijen = new List<Partij>();
            foreach (var partijDto in dtos)
            {
                partijen.Add(new Partij(partijDto.Orde, partijDto.Naam, partijDto.Lijsttrekker));
            }

            return partijen;
        }
    }
}
