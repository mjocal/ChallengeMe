using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class PuntoRuta : BaseEntity
    {
        public int idPuntoRuta { set; get; }
        public int idRuta { set; get; }
        public string nombrePunto { set; get; }
        public string latitudRuta { set; get; }
        public string longitudRuta { set; get; }
    }
}
