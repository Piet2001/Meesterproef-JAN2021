using System;
using System.Collections.Generic;
using Interfaces.Dal;
using Interfaces.DTO;
using Interfaces.Logic;

namespace DAL
{
    public class Verkiezingsmanager : IVerkiezingsManager
    {
        private readonly List<IVerkiezing> _verkiezingen = new List<IVerkiezing>();
        public List<VerkiezingsDto> GetAlleVerkiezingen()
        {
            List<VerkiezingsDto> dtos = new List<VerkiezingsDto>();
            foreach (var verkiezing in _verkiezingen)
            {
                dtos.Add(new VerkiezingsDto()
                {
                    Naam = verkiezing.Naam,
                    Datum = verkiezing.Datum,
                    Zetels = verkiezing.Zetels
                });
            }
            return dtos;
        }

        public bool VerkiezingToevoegen(IVerkiezing verkiezing)
        {
            _verkiezingen.Add(verkiezing);
            return true;
        }

        public bool Updateverkiezing(IVerkiezing verkiezing)
        {
            throw new NotImplementedException();
        }
    }
}
