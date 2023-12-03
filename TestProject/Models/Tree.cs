namespace ContempProgFinalProject.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public string GetText()
        {
            return $"{Id} \t {Type} \t {Price} \t {Height} \t {Age}";
        }
    }
}
