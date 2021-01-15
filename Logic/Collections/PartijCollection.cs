using System.Collections.Generic;
using Interfaces.Dal;
using Interfaces.DTO;

namespace Logic.Collections
{
    public class PartijCollection
    {
        private IPartijManager _partijManager = Factory.Factory.GetPartijManager();

        public bool PartijToevoegen(string orde, string naam, string lijsttrekker)
        {
            return  _partijManager.PartijToevoegen(new Partij(orde, naam, lijsttrekker));
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

        public bool UpdatePartij(string orde, string naam, string lijsttrekker)
        {
            return _partijManager.UpdatePartij(new Partij(orde, naam, lijsttrekker));
        }
    }
}
