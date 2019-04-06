using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Permisos:BaseEntity
    {
        public int IdPermiso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Area { get; set; }
        public string Estado_Permiso { get; set; }
        

        public Permisos()
        {

        }


    }
}
