using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
  public class RolPermiso:BaseEntity
    {
        public int IdRol { get; set; }
        public int IdPermiso { get; set; }

        public RolPermiso()
        {

        }

    }
}
