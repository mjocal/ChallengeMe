using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Evento : BaseEntity
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public string UbicacionEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public Image LogoEvento { get; set; }
        public int IdCategoria { get; set; }
        public int CupoEvento { get; set; }
        public string IdEntidad { get; set; }
        public DateTime FechaInicioEvento { get; set; }
        public DateTime FechaFinalEvento { get; set; }
        public DateTime FechaInicioInscripcion { get; set; }
        public DateTime FechaFinalInscripcion { get; set; }
        public decimal CostoInscripcion { get; set; }
        public string Estado_Evento { get; set; }

        public Evento()
        {
            
        }

        public Evento(int idEvento, string nombreEvento, string ubicacionEvento, string descripcionEvento, 
            Image logoEvento, int idRuta, int idCategoria, int cupoEvento, string idEntidad, 
            DateTime fechaInicioEvento, DateTime fechaFinalEvento, DateTime fechaInicioInscripcion,
            DateTime fechaFinalInscripcion, decimal costoInscripcion)
        {
            IdEvento = idEvento;
            NombreEvento = nombreEvento;
            UbicacionEvento = ubicacionEvento;
            DescripcionEvento = descripcionEvento;
            LogoEvento = logoEvento;
            
            IdCategoria = idCategoria;
            CupoEvento = cupoEvento;
            IdEntidad = idEntidad;
            FechaInicioEvento = fechaInicioEvento;
            FechaFinalEvento = fechaFinalEvento;
            FechaInicioInscripcion = fechaInicioInscripcion;
            FechaFinalInscripcion = fechaFinalInscripcion;
            CostoInscripcion = costoInscripcion;
        }

        public Evento(List<String> eventoAtts)
        {
            IdEvento = Convert.ToInt32(eventoAtts[0]);
            NombreEvento = eventoAtts[1];
            UbicacionEvento = eventoAtts[2];
            DescripcionEvento = eventoAtts[3];
            //LogoEvento = eventoAtts[4];
            IdCategoria = Convert.ToInt32(eventoAtts[5]);
            CupoEvento = Convert.ToInt32(eventoAtts[6]);
            IdEntidad = eventoAtts[7];
            FechaInicioEvento = Convert.ToDateTime(eventoAtts[8]);
            FechaFinalEvento = Convert.ToDateTime(eventoAtts[9]);
            FechaInicioInscripcion = Convert.ToDateTime(eventoAtts[10]);
            FechaFinalInscripcion = Convert.ToDateTime(eventoAtts[11]);
            CostoInscripcion = Convert.ToDecimal(eventoAtts[12]);
        }


    }
}
