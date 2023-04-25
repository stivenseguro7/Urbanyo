using System.ComponentModel.DataAnnotations;

namespace Urbanyo.Shared.Entities
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int Answer { get; set; }
        public List<int> Amount { get; set; }
        public List<string> Archivos { get; set; }
        public string Text1 { get; set; }
    }
}
