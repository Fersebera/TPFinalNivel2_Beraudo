using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Marca")]
        public Marca Brand { get; set; }
        [DisplayName("Categoría")]
        public Categoria Category { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }

    }
}
