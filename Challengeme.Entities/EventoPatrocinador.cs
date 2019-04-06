using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class EventoPatrocinador:BaseEntity
    {

        public int IdPatrocinador { get; set; }
        public int IdEvento { get; set; }
        public string TipoPatrocinio { get; set; }


        public EventoPatrocinador()
        {

        }
    }
}
