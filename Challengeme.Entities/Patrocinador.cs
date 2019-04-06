using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;

namespace Challengeme.Entities
{
    public class Patrocinador : BaseEntity
    {
        public int IdPatrocinador { get; set; }
        public string NombrePatrocinador { get; set; }
        //public decimal MontoPatrocinador { get; set; }
        public Image LogoPatrocinador { get; set; }
        public string Estado_Patrocinador { get; set; }
        //public HttpPostedFileWrapper ImageFile { get; set; }

        public Patrocinador()
        {

        }

        public Patrocinador(int id)
        {
            IdPatrocinador = id;
        }

        public Patrocinador(int idPatrocinador, string nombrePatrocinador, Image logoPatrocinador)
        {
            IdPatrocinador = idPatrocinador;
            NombrePatrocinador = nombrePatrocinador;
            //MontoPatrocinador = montoPatrocinador;
            LogoPatrocinador = logoPatrocinador;
        }

        public Patrocinador(List<String> userAtts)
        {
            IdPatrocinador = Convert.ToInt32(userAtts[0]);
            NombrePatrocinador = userAtts[1];
            //MontoPatrocinador = Convert.ToDecimal(userAtts[2]);
            LogoPatrocinador = Image.FromFile(userAtts[2]);
        }
    }
}