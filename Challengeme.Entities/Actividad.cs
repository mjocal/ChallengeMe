using System;
using System.Collections.Generic;

namespace Challengeme.Entities
{
    public class Actividad : BaseEntity
    {
        public int IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public string DescripcionActividad { get; set; }
        public string Estado_Actividad { get; set; }

        public Actividad()
        {

        }

        public Actividad(int id)
        {
            IdActividad = id;
        }

        public Actividad(int idCategoria, string nombreActividad, string descripcionActividad)
        {
            IdActividad = idCategoria;
            NombreActividad = nombreActividad;
            DescripcionActividad = descripcionActividad;
        }

        public Actividad(List<string> userAtts)
        {
            IdActividad = Convert.ToInt32(userAtts[0]);
            NombreActividad = userAtts[1];
            DescripcionActividad = userAtts[2];
        }
    }
}
