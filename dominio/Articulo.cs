using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace Dominio
{
    public class Articulo
    { 
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }
        public decimal Precio { get; set; }

        public Marca DescripcionM { get; set; }

        public Categoria DescripcionC { get; set; }

        // crear clase Marca(seleccionable de una lista desplegable). e importar.
        // crear clase Categoría(seleccionable de una lista desplegable. e importar.
    }
}
