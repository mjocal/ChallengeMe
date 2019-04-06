using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
   public  class Inscripcion:BaseEntity

    {
        public int IdInscripcion {get;set;}
        public int IdEvento { get; set; }
        public string IdUsuario { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public string tipoInscripcion { get; set; }

        public Image QRInscripcion { get; set; }

        public string Estado_Inscripcion { get; set; }

        public Inscripcion()
        {

        }

    }
}
