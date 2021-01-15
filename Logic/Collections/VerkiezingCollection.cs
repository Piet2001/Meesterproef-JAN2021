using System;
using System.Collections.Generic;
using System.Security;
using Interfaces.Dal;
using Interfaces.DTO;
using Interfaces.Logic;

namespace Logic.Collections
{
    public class VerkiezingCollection
    {
        private IVerkiezingsManager _verkiezingsManager = Factory.Factory.GetVerkiezingsManager();
        public void VerkiezingAanmaken(string naam, DateTime datum, int zetels)
        {
            var verkiezing = new Verkiezing(naam, datum, zetels);
            _verkiezingsManager.VerkiezingToevoegen(verkiezing);
        }
        
        public IReadOnlyCollection<IVerkiezing> GetAlleVerkiezingen()
        {
            List<VerkiezingsDto> dtos = _verkiezingsManager.GetAlleVerkiezingen();
            List<Verkiezing> verkiezingen = new List<Verkiezing>();
            foreach (var verkiezingsDto in dtos)
            {
                verkiezingen.Add(new Verkiezing(verkiezingsDto.Naam,verkiezingsDto.Datum,verkiezingsDto.Zetels));
            }

            return verkiezingen;
        }
    }
}
