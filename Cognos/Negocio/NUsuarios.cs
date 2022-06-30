using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Negocio
{
    public class NUsuarios
    {
        DUsuarios users = new DUsuarios();

        public List<Usuarios> Consultar()
        {
            List<Usuarios> lstAlumnos = new List<Usuarios>();
            lstAlumnos = users.Consultar();
            return lstAlumnos;
        }



        public Usuarios Consultar(int id)
        {
            Usuarios alumno = new Usuarios();
            alumno = users.Consultar(id);
            return alumno;
        }



        public void Agregar(Usuarios user)
        {
            users.Agregar(user);
        }

        public void Actualizar(Usuarios user)
        {
            users.Actualizar(user);
        }

        public void Eliminar(Usuarios user)
        {
            users.Eliminar(user);
        }


    }
}
