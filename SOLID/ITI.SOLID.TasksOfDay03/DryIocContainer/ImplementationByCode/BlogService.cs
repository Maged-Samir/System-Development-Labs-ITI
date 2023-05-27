using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryIoc.ImplementationByCode
{
    public class BlogService
    {
        private readonly ILogger _logger;
        private readonly IEmailService _emailService;

        public BlogService(ILogger logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        public void CreateBlogPost(string title, string content, string author)
        {
            // Code to create a blog post
            _logger.Log($"Creating blog post: {title} by {author}");
            _emailService.SendEmail("admin@example.com", "New Blog Post", $"A new blog post '{title}' has been created by {author}.");
        }
    }
}
