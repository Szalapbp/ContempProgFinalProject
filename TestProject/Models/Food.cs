namespace ContempProgFinalProject.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string GetText()
        {
            return $"{Id} \t {Name} \t {Origin} \t {Price} \t {Quantity}";
        }
    }
}
