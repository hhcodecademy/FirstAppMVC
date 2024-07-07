using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = SeedProducts(); 
            return View(products);
        }
        public string GetContent() {


            string content = "Every public method in a controller is callable as an HTTP endpoint. In the sample above, both methods return a string. Note the comments preceding each method.\r\n\r\nAn HTTP endpoint:\r\n\r\nIs a targetable URL in the web application, such as https://localhost:5001/HelloWorld.\r\nCombines:\r\nThe protocol used: HTTPS.\r\nThe network location of the web server, including the TCP port: localhost:5001.\r\nThe target URI: HelloWorld.";
            return content;
        }

        private List<Product> SeedProducts()
        {
            List<Product> products = new List<Product>();
            for (int i = 1; i < 11; i++)
            {
                Product product = new Product();
                product.Id = i;
                product.Description = Guid.NewGuid().ToString();
                product.Title = GeneratedTitle();
                product.Price = new Random().NextInt64(10, 100);
                product.Stock = new Random().NextInt64(10, 20);
                product.Rating = new Random().NextInt64(1, 5);
                products.Add(product);
            }
            return products;
        }

        private string GeneratedTitle()
        {
            Thread.Sleep(1000);
            DateTime dateTime = DateTime.Now;
            string title = dateTime.Year.ToString() + dateTime.Month.ToString() + dateTime.Day.ToString() +
                dateTime.Hour.ToString() + dateTime.Minute.ToString() + dateTime.Microsecond.ToString() + dateTime.Nanosecond.ToString();
            return title;
        }

    }
}
