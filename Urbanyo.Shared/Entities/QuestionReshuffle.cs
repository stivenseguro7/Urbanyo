using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbanyo.Shared.Entities
{
    public class QuestionReshuffle
    {
        [Key]
        public int Id { get; set; }
        public int ProjectTypeId { get; set; }  
        public bool Question1 { get; set; }
        public string? ParcialReshuffle{ get; set; }
        public ICollection<ProjectType>?ProjectTypes{ get; set; }  
   
    }
}
