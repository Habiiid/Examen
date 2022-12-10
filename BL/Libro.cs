using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {

        public static ML.Result GetAll()
        {
           ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string querySP = "LibroGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = querySP;
                        cmd.CommandType = CommandType.StoredProcedure;

                        context.Open();

                        DataTable libroTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(libroTable);

                        if(libroTable.Rows.Count > 0)
                        {
                            result.Object = new List<Object>();

                            foreach (DataRow row in libroTable.Rows)
                            {
                                ML.Libro libro = new ML.Libro();

                                libro.Nombre = row[0].ToString();

                                libro.Autor = new ML.Autor();
                                libro.Autor.IdAutor = int.Parse(row[1].ToString());

                                libro.NumeroPaginas = int.Parse(row[2].ToString());
                                libro.FechaPublicacion = row[3].ToString();

                                libro.Editorial = new ML.Editorial();
                                libro.Editorial.IdEditorial = int.Parse(row[4].ToString());

                                libro.Genero = new ML.Genero();
                                libro.Genero.IdGenero = int.Parse(row[5].ToString());
                                libro.Edicion = row[6].ToString();

                                result.Objetcs.Add(libro);
                            }
                        }
                    }
                    result.Correct = true;
                }
            }catch (Exception ex)
            {
                result.Message = "Algo salio mal" + ex.Message;
                
            }
            
            
            return result;
        }

    }
}
