using System.ComponentModel.DataAnnotations;

namespace Urbanyo.Shared.Entities
{
    public class Project
    {
        [Key] 
        public int Id { get; set; }
        public int ProjectTypeId { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Nombre del proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El  campo {0} no puede tener más de {1} caractéres")]
        public string? NameProj { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public bool State { get; set; }
        public ICollection<User>? Users { get; set; }
        public  ICollection<ProjectType>? ProjectTypes { get; set; }
        public ICollection<State>? States { get; set; }
        public  ICollection<City>? Citys { get; set; }
    }
}
