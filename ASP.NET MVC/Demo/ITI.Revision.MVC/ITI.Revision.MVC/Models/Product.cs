namespace ITI.Revision.MVC.Models
{

    //Product here is a simple representation for a static model of Mobiles 
    public class Product
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public int Qty { get; set; }
        
        public decimal Price { get; set; }

        public static List<Product> products = new List<Product>()
        {
            new Product() {ID = 1,Name="Nokia",Qty=20,Price=4000 },
            new Product() {ID = 2,Name="Samsoung",Qty=10,Price=3500},
            new Product() {ID = 3,Name="Motrla",Qty=5,Price=2000}
        };

        
    }
}
