using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbanyo.Shared.Entities
{
    public class QuestionConstruction
    {
        [Key]
        public int Id { get; set; }
        public int ProjectTypeId { get; set; }
        public int Question1 { get; set; }
        public int Question2 { get; set; }
        public int Question3 { get; set; }
        public int Question4 { get; set; }
        public int Question5 { get; set; }
        public int Question6 { get; set; }
        public int Question7 { get; set; }
        public int Question8 { get; set; }
        public string? txtAdicional { get; set; }
        public string? img { get; set; }
        public ICollection<ProjectType>? ProjectTypes { get; set; }

    }
}
