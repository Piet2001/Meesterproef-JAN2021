using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Dal;
using Interfaces.DTO;
using Interfaces.Logic;

namespace DAL
{
    public class Verkiezingsmanager : IVerkiezingsManager
    {
        private List<IVerkiezing> verkiezingen = new List<IVerkiezing>();
        public List<VerkiezingsDto> GetAlleVerkiezingen()
        {
            List<VerkiezingsDto> dtos = new List<VerkiezingsDto>();
            foreach (var verkiezing in verkiezingen)
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
            verkiezingen.Add(verkiezing);
            return true;
        }

        public bool Updateverkiezing(IVerkiezing verkiezing)
        {
            throw new NotImplementedException();
        }
    }
}
