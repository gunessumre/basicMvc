using System.Collections.Generic;
using System.Web.Mvc;
using YourProjectName.Models; // Models klasörünüzü referans edin

public class CustomerOrdersController : Controller
{
    public ActionResult Index()
    {
        // Örnek müşteri
        var customer = new Customer
        {
            Id = 1,
            FirstName = "Ahmet",
            LastName = "Yılmaz",
            Email = "ahmet.yilmaz@example.com"
        };

        // Örnek siparişler
        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 5000m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 150m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Klavye", Price = 300m, Quantity = 1 }
        };

        // ViewModel oluşturma
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel); // View'a ViewModel gönder
    }
}