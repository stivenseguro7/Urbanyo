using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Urbanyo.Shared.Entities
{
    public class ProjectType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo de proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(25, ErrorMessage = "El  campo {0} no puede tener más de {1} caractéres")]
        public string? name { get; set; }
    }
}
