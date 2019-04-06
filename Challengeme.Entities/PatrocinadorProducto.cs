using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
   public class PatrocinadorProducto:BaseEntity
    {
        public int idPatrocinador{get;set;}
        public int idProducto { get; set; }

        public PatrocinadorProducto()
        {

        }

    }
}
