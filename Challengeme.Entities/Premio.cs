using System;
using System.Collections.Generic;

namespace Challengeme.Entities
{
    public class Premio : BaseEntity
    {
        public int IdPremio { get; set; }
        public string NombrePremio { get; set; }
        public string DescripcionPremio { get; set; }
        public string Estado_Premio { get; set; }

        public Premio()
        {

        }

        public Premio(int id)
        {
            IdPremio = id;
        }

        public Premio(int idPremio, string nombrePremio, string descripcionPremio)
        {
            IdPremio = idPremio;
            NombrePremio = nombrePremio;
            DescripcionPremio = descripcionPremio;
        }

        public Premio(List<String> userAtts)
        {
            IdPremio = Convert.ToInt32(userAtts[0]);
            NombrePremio = userAtts[1];
            DescripcionPremio = userAtts[2];
        }
    }
}
