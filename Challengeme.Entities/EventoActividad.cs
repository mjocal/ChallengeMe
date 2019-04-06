using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class EventoActividad:BaseEntity
    {

        public int IdActividad { get; set; }
        public int IdEvento { get; set; }

        public EventoActividad()
        {

        }
    }
}
