using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class RutaEvento : BaseEntity
    {
        public int idRuta { set; get; }
        public string nombreRuta { set; get; }
        public string direccionRuta { set; get; }
        public ArrayList listaDePuntosDeRuta { set; get; }
    }
}
