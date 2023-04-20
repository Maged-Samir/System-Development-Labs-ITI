namespace TaskDay01.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public ICollection<Comment>? Comments { get; set; }=new HashSet<Comment>();
    }
}
