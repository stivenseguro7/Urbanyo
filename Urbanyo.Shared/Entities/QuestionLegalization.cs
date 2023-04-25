using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbanyo.Shared.Entities
{
    public class QuestionLegalization
    {
        public int Id { get; set; }
        public int ProjectTypeId { get; set; }
        public string? Description { get; set; }
        public ICollection<ProjectType>? ProjectTypes  { get; set; }
    }
}
