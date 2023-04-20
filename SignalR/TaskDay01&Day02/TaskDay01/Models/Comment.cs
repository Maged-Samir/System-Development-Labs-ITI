namespace TaskDay01.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
