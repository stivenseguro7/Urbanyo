using System.ComponentModel.DataAnnotations;

namespace Urbanyo.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "país")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "el campo {0} no puede tener mas de {1} caractéres.")]
        public string Name { get; set; } = null!;

        public ICollection<State>? States { get; set; }

        public int StatesNumber => States == null ? 0 : States.Count;
    }
}
