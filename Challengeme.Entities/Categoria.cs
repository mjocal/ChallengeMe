using System;
using System.Collections.Generic;

namespace Challengeme.Entities
{
    public class Categoria : BaseEntity
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Estado_Categoria { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id)
        {
            IdCategoria = id;
        }

        public Categoria(int idCategoria, string nombreCategoria)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
        }

        public Categoria(List<String> userAtts)
        {
            IdCategoria = Convert.ToInt32(userAtts[0]);
            NombreCategoria = userAtts[1];
        }

    }
}
