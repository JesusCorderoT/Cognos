using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public partial class Usuarios
    {

        public Usuarios() { }

        public Usuarios(int id, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string correo, string usuario, string contrasena)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }


    }
}
