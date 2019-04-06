using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Ruta : BaseEntity
    {
        public int IdPago { get; set; }
        public string IdUsuario { get; set; }
        public string MetodoDePago { get; set; }
        public string EstadoDePago { get; set; }
        public decimal MontoDePago { get; set; }
        public decimal ImpuestoDePago { get; set; }
        public decimal DescuentoDePago { get; set; }
        public decimal TotalPago { get; set; }
        public string DetalleDePago { get; set; }
        public DateTime FechaPago { get; set; }

        public Ruta() { }

        //public Ruta(int idPago, string idUsuario, string metodoDePago, string estadoDePago, double montoDePago,
        //    double descuentoDePago, double totalPago, string detallePago, DateTime fechaPago)
        //{
        //    IdPago = idPago;
        //    IdUsuario = idUsuario;
        //    MetodoDePago = metodoDePago;
        //    EstadoDePago = estadoDePago;
        //    MontoDePago = montoDePago;
        //    DescuentoDePago = descuentoDePago;
        //    TotalPago = totalPago;
        //    DetalleDePago = detallePago;
        //    FechaPago = fechaPago;
        //}
    }
}
