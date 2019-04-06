using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class EventoProducto : BaseEntity
    {
        public int IdProducto { get; set; }
        public string TipoPatrocinio { get; set; }
        public int CantidadProducto { get; set; }
       
        public decimal ValorTotalProducto { get; set; }
        public int IdEvento { get; set; }
        public int IdPatrocinador { get; set; }

        public EventoProducto()
        {
            
        }

        public EventoProducto(int idProducto, string tipoPatrocinio, int cantidadProducto, decimal costoProducto, decimal valorTotalProducto, int idPatrocinador, int idEvento)
        {
            this.IdProducto = idProducto;
            this.TipoPatrocinio = tipoPatrocinio;
            this.CantidadProducto = cantidadProducto;
           
            this.ValorTotalProducto = valorTotalProducto;
            this.IdPatrocinador = idPatrocinador;
            this.IdEvento = idEvento;
        }
    }
}
