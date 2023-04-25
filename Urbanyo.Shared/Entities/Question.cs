using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urbanyo.Shared.Entities
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int Answer { get; set; }
        public List<int> Amount { get; set; }
        public List<string> Archivos { get; set; }
        public string Text1 { get; set; }
    }
}
