using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    [MetadataType(typeof(UsuariosDataAnnotations))]


    public partial class Usuarios {}




    public class UsuariosDataAnnotations
    {

        public int id { get; set; }

        [RegularExpression("^[a-zA-Z](\n*[a-zA-Z]*)*[a-zA-Z]+$", ErrorMessage = "Solo letras sin espacios")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El {0} debe llevar maximo {1} y minimo {2} letras ")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El {0} es necesario")]
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }

    }
}
