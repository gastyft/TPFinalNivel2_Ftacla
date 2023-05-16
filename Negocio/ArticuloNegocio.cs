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
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl Imagen, C.Descripcion Categoria, M.Descripcion Marca, A.ImagenUrl Imagen, A.Precio Precio,A.IdMarca, A.IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id=A.IdMarca "); ///Query datebase de consulta
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                  
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.DescripcionC = new Categoria();
                    aux.DescripcionC.DescripcionC = (string)datos.Lector["Categoria"];
                    aux.DescripcionC.Id = (int)datos.Lector["IdCategoria"];
                    aux.DescripcionM = new Marca();
                    aux.DescripcionM.Id = (int)datos.Lector["IdMarca"];
                    aux.DescripcionM.DescripcionM = (string)datos.Lector["Marca"];
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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values ('"+ nuevo.Codigo + "','" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',@IdMarca,@IdCategoria,@Imagen,'" + nuevo.Precio + "')");
                datos.setearParametro("@idMarca", nuevo.DescripcionM.Id);
                datos.setearParametro("@idCategoria", nuevo.DescripcionC.Id);
                datos.setearParametro("@Imagen", nuevo.Imagen);
                datos.ejecutarAccion();
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
        public void modificar(Articulo arti)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, ImagenUrl = @img, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio=@precio Where Id = @id");
                datos.setearParametro("@codigo", arti.Codigo);
                datos.setearParametro("@nombre", arti.Nombre);
                datos.setearParametro("@desc", arti.Descripcion);
                datos.setearParametro("@img",arti.Imagen);
                datos.setearParametro("@idmarca", arti.DescripcionM.Id);
                datos.setearParametro("@idCategoria", arti.DescripcionC.Id);
                datos.setearParametro("@id", arti.Id);
                datos.setearParametro("@precio", arti.Precio);

                datos.ejecutarAccion();
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

