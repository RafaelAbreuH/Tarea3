using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3.Data
{
    public class Clientes
    {
        [Key]
        public int ClientesId { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "La Cedula es obligatoria")]
        [StringLength(11, ErrorMessage = "La longitud de cedula debe ser de 11")]
        public string Cedula { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefono no puede estar vacio"), Phone]
        public string Telefono { get; set; }

        public string Ciudad { get; set; }
        public DateTime Nacimiento { get; set; }

        public Clientes()
        {
            ClientesId = 0;
            Nombres = String.Empty;
            Cedula = String.Empty;
            Email = String.Empty;
            Telefono = String.Empty;
            Ciudad = String.Empty;
            Nacimiento = DateTime.Now;
        }
    }
}
