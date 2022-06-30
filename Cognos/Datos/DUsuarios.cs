using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class DUsuarios
    {
        string _cnnString = ConfigurationManager.ConnectionStrings["CognosConnection"].ConnectionString;
        SqlCommand comando;
        Usuarios users = new Usuarios();
        List<Usuarios> _listUsers = new List<Usuarios>();


        //-------------------------------------------------Consultar Todos los usuarios-----------------------------------------------
        public List<Usuarios> Consultar()
        {
            string query = $"PO_SelectUsuarios";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {

                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@id", -1));
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listUsers.Add(new Usuarios()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        nombre = reader["nombre"].ToString(),
                        apellidoPaterno = reader["apellidoPaterno"].ToString(),
                        apellidoMaterno = reader["apellidoMaterno"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                        correo = reader["correo"].ToString(),
                        usuario = reader["usuario"].ToString(),
                        contrasena = reader["contrasena"].ToString(),
                    });
                }
                con.Close();
            }
            return _listUsers;
        }




        //-------------------------------------------------Consultar un usuario-----------------------------------------------


        public Usuarios Consultar(int id)
        {
            Usuarios es = new Usuarios();
            string queryu = $"PO_SelectUsuarios";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {

                comando = new SqlCommand(queryu, con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader adpter = comando.ExecuteReader();
                while (adpter.Read())
                {

                    es = new Usuarios()
                    {
                        id = Convert.ToInt32(adpter["id"]),
                        nombre = adpter["nombre"].ToString(),
                        apellidoPaterno = adpter["apellidoPaterno"].ToString(),
                        apellidoMaterno = adpter["apellidoMaterno"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(adpter["fechaNacimiento"]),
                        correo = adpter["correo"].ToString(),
                        usuario = adpter["usuario"].ToString(),
                        contrasena = adpter["contrasena"].ToString(),
                    };


                }


                con.Close();
            }
            return es;
        }


        //-------------------------------------------------Agregar usuarios-----------------------------------------------


        public void Agregar(Usuarios users)
        {

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                string queryA = $"PO_InsertUsuarios";
                comando = new SqlCommand(queryA, con);
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", users.nombre);
                comando.Parameters.AddWithValue("@apellidoPaterno", users.apellidoPaterno);
                comando.Parameters.AddWithValue("@apellidoMaterno", users.apellidoMaterno);
                comando.Parameters.AddWithValue("@fechaNacimiento", users.fechaNacimiento);
                comando.Parameters.AddWithValue("@correo", users.correo);
                comando.Parameters.AddWithValue("@usuario", users.usuario);
                comando.Parameters.AddWithValue("@contrasena", users.contrasena);
                comando.ExecuteNonQuery();
                con.Close();
            }

        }

        //-------------------------------------------------Actualizar usuarios-----------------------------------------------


        public Usuarios Actualizar(Usuarios users)
        {

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                string queryAc = $"PO_UpdateUsuarios";
                comando = new SqlCommand(queryAc, con);
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", users.nombre);
                comando.Parameters.AddWithValue("@apellidoPaterno", users.apellidoPaterno);
                comando.Parameters.AddWithValue("@apellidoMaterno", users.apellidoMaterno);
                comando.Parameters.AddWithValue("@fechaNacimiento", users.fechaNacimiento);
                comando.Parameters.AddWithValue("@correo", users.correo);
                comando.Parameters.AddWithValue("@usuario", users.usuario);
                comando.Parameters.AddWithValue("@contrasena", users.contrasena);
                comando.ExecuteNonQuery();
                con.Close();
            }
            return users;
        }

        //-------------------------------------------------Borrar usuarios-----------------------------------------------

        public void Eliminar(Usuarios users)
        {

            string queryd = $"PO_DeleteUsuarios";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(queryd, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", users.id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }


    }







}
