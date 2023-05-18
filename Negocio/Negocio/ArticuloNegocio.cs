using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.Xml.Linq;

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
                datos.setearConsulta("Insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',@IdMarca,@IdCategoria,@ImagenUrl," + nuevo.Precio + " )");
                datos.setearParametro("@idMarca", nuevo.DescripcionM.Id);
                datos.setearParametro("@idCategoria", nuevo.DescripcionC.Id);
                datos.setearParametro("@ImagenUrl", nuevo.Imagen);
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
                datos.setearParametro("@img", arti.Imagen);
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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from articulos where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    public List<Articulo> filtrar(string campo, string criterio, string filtro)
            {
                List<Articulo> lista = new List<Articulo>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion Descripcion, ImagenUrl Imagen, C.Descripcion Categoria, M.Descripcion Marca, A.ImagenUrl Imagen, A.Precio Precio,A.IdMarca, A.IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria And M.Id=A.IdMarca And ";
                    if (campo == "Precio")
                    {
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro;
                                break;
                        }
                    }
                    else if (campo == "Nombre")
                    {
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                    }
                    else if (campo == "Marca")
                    {
                        switch (criterio)
                        {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                      
                        }
                    }
                    else 
                    {
                        switch (criterio)
                        {
                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                    }

                    datos.setearConsulta(consulta);
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
                        aux.Precio = (decimal)datos.Lector["Precio"];
                        if (!(datos.Lector["Imagen"] is DBNull))
                            aux.Imagen = (string)datos.Lector["Imagen"];
                    
                    lista.Add(aux);
                    }

                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        } 


        /*  public void eliminarLogico(int id)
       {
           try
           {
               AccesoDatos datos = new AccesoDatos();
               datos.setearConsulta("update ARTICULOS set Activo = 0 Where id = @id");
               datos.setearParametro("@id", id);
               datos.ejecutarAccion();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }  */

    }


