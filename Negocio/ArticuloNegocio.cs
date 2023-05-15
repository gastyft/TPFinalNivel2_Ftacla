using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;
using System.Data.SqlTypes;
using System.ComponentModel;

namespace Negocio
{
    public class ArticuloNegocio
    {


        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl Imagen, C.Descripcion Categoria, M.Descripcion Marca, A.ImagenUrl Imagen, A.Precio Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id=A.IdMarca "); ///Query datebase de consulta
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id= datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; 
                    aux.DescripcionC = new Categoria(); 
                    aux.DescripcionC.DescripcionC = (string)datos.Lector["Categoria"];
                    aux.DescripcionM = new Marca();
                    aux.DescripcionM.DescripcionM= (string)datos.Lector["Marca"];
                       if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];
                    aux.Precio = (decimal)datos.Lector["Precio"];



                   
                    lista.Add(aux);
                }



                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

