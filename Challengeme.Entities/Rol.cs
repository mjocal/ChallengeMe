using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Rol:BaseEntity
    {
        public int IdRol { get; set; }
        public string Nombre_Role { get; set; }
        public string Descripcion_Role { get; set; }
      

        public Rol()
        {

        }

        public Rol(int Id)
        {
            this.IdRol = Id;
        }

    }
}
