using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Ranking:BaseEntity

    {
        public int IdRanking { get; set; }
        public int PosicionUsuario { get; set; }
        public string IdUsuario { get; set; }
        public int IdEvento { get; set; }
        public string Estado_Ranking { get; set; }


        public Ranking()
        {

        }

    }
}
