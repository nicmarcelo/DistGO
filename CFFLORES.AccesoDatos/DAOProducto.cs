using CFFLORES.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CFFLORES.AccesoDatos
{
    public class DAOProducto
    {

        public EProducto ObtenerProducto(string codigobarra)
        {
            EProducto productoEncontrado = null;
            string sql = "SELECT * FROM producto WHERE CodigoBarra = @cod";
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DBCFFLORES;Integrated Security=SSPI;"))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigobarra));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            productoEncontrado = new EProducto()
                            {
                                codigobarra = (string)resultado["CodigoBarra"],
                                NombreProducto = (string)resultado["Nombre"],
                                Stock = Int32.Parse(resultado["Stock"].ToString())
                            };
                        }
                    }
                }
            }
            return productoEncontrado;
        }

        public EProducto CrearProducto(EProducto productoACrear)
        {
            EProducto productoCreado = null;
            string sql = "INSERT INTO producto VALUES (@cod, @nom,@stock)";
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DBCFFLORES;Integrated Security=SSPI;"))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", productoACrear.codigobarra));
                    com.Parameters.Add(new SqlParameter("@nom", productoACrear.NombreProducto));
                    com.Parameters.Add(new SqlParameter("@stock", productoACrear.Stock));
                    com.ExecuteNonQuery();
                }
            }
            productoCreado = ObtenerProducto(productoACrear.codigobarra);
            return productoCreado;
        }

        public EProducto ModificarProducto(EProducto productoACrear)
        {
            EProducto productoCreado = null;
            string sql = "update producto set Nombre = @nom, Stock = @stock where CodigoBarra = @cod ";
            using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DBCFFLORES;Integrated Security=SSPI;"))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", productoACrear.codigobarra));
                    com.Parameters.Add(new SqlParameter("@nom", productoACrear.NombreProducto));
                    com.Parameters.Add(new SqlParameter("@stock", productoACrear.Stock));
                    com.ExecuteNonQuery();
                }
            }
            productoCreado = ObtenerProducto(productoACrear.codigobarra);
            return productoCreado;
        }

    }
}
