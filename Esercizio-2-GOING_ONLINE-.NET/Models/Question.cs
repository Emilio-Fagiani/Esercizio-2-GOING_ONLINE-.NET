namespace Esercizio_2_GOING_ONLINE_.NET.Models
{
    public class Question
    {
        public string Author{ get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        
        public List<Answer> Answers { get; set; }
    }
}
