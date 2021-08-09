using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAspNetCore5.Models
{
    public class Libro
    {[Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Titulo Es Obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "TITULO")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El Descripcion Es Obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "DESCRIPCION")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La Fecha de Lanzamiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "fecha lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [Required(ErrorMessage = "El Autor es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Autor")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }
    }
}
