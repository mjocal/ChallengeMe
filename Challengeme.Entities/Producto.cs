using System.Drawing;

namespace Challengeme.Entities
{
    public class Producto : BaseEntity
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public Image LogoProducto { get; set; }
        public string Estado_Producto { get; set; }
        

        public Producto()
        {
        }
       
     

    }
}
