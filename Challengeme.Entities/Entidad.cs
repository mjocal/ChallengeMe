using System.Drawing;

namespace Challengeme.Entities
{
    public class Entidad : BaseEntity
    {
        public string IdEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string TipoEntidad { get; set; }
        public string NombreComercialEntidad { get; set; }
        public string DireccionEntidad { get; set; }
        public string TelefonoEntidad { get; set; }
        public Image LogoEntidad { get; set; }
        public string CorreoEntidad { get; set; }
        public string Estado_Entidad { get; set; }

        public Entidad()
        {

        }

        public Entidad(string id)
        {
            IdEntidad = id;
        }

        public Entidad(string idEntidad, string nombreEntidad, string tipoEntidad, string nombreComercialEntidad, 
                       string direccionEntidad, string telefonoEntidad, Image logoEntidad, string correoEntidad)
        {
            IdEntidad = idEntidad;
            NombreEntidad = nombreEntidad;
            TipoEntidad = tipoEntidad;
            NombreComercialEntidad = nombreComercialEntidad;
            DireccionEntidad = direccionEntidad;
            TelefonoEntidad = telefonoEntidad;
            LogoEntidad = logoEntidad;
            CorreoEntidad = correoEntidad;
        }


        //public Entidad(List<String> userAtts)
        //{
        //    IdEntidad = userAtts[0];
        //    NombreEntidad = userAtts[1];
        //    TipoEntidad = userAtts[2];
        //    NombreComercialEntidad = userAtts[3];
        //    DireccionEntidad = userAtts[4];
        //    TelefonoEntidad = userAtts[5];
        //    LogoEntidad = userAtts[6];
        //    CorreoEntidad = userAtts[7];
        //}
    }
}
