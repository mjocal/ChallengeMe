using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
   public class EventoPremio:BaseEntity
    {
        public int IdPremio { get; set; }
        public int IdEvento { get; set; }

        public EventoPremio()
        {

        }
    }
}
