using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TaskDay01.Models;

namespace TaskDay01.Hubs
{
    public class ProductHub:Hub
    {
        private readonly ApplicationDbContext _context;

        public ProductHub(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DecreaseProductQuantity(int productId)
        {
            var product = _context.Products.Find(productId);
            product.Quantity -= 1;
            _context.SaveChanges();
            // Notify all connected clients about the updated quantity
            await Clients.All.SendAsync("ProductQuantityUpdated", productId, product.Quantity);
        }


        public void CreateComment(string name, string text, int productId)
        {
                _context.Comments.Add(new Comment { ProductId = productId, Text = text, Name = name });

                if (_context.SaveChanges() > 0)
                {
                    Clients.All.SendAsync("NotifyNewComment", name, text, productId);
                }
        }

        //public void AddNew(Product product)
        //{
        //    _context.Products.Add(product);
        //    Clients.All.SendAsync("NotifyNewProduct", product);
        //}

       
    }
}
