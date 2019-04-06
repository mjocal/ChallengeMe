

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Challengeme.Entities
{
    public class User : BaseEntity
    {
        
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string DirUsuario { get; set; }
        public string Prov_Usuario { get; set; }
        public string Cant_Usuario { get; set; }
        public string Dist_Usuario { get; set; }
        public string Correo_Usuario { get; set; }
        public string Pass_Usuario { get; set; }
        public DateTime FNac_Usuario { get; set; }
        public Image Imagen_Usuario { get; set; }
        public DateTime FCreacion_Usuario { get; set; }
        public int IdRole { get; set; }
        public string IdEntidad { get; set; }
       

        public User()
        {

        }
        public User(List<String> userAtts)
        {
            IdUsuario = userAtts[0];
            NombreUsuario = userAtts[1];
            Pass_Usuario = userAtts[2];
            IdRole = Convert.ToInt32(userAtts[3]);
            IdEntidad = userAtts[4];

        }
    }
}
