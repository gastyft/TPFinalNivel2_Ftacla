using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace Dominio
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }
        public string Precio { get; set; }

        public Marca Marca { get; set; }

        public Categoria Nombre_categoria { get; set; }

        // crear clase Marca(seleccionable de una lista desplegable). e importar.
        // crear clase Categoría(seleccionable de una lista desplegable. e importar.
    }
}
