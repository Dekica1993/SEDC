using Microsoft.AspNetCore.Mvc;
using PizzaApp.Mappers;
using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> ordersFromDb = StaticDb.Orders;

        //    List<OrderViewModel> orderViewModels = new List<OrderViewModel>();

            // foreach(Order order in ordersFromDb)
            //{
            //    var temporaryOrderViewModel = new OrderViewModel()
            //    {
            //        PizzaName = order.Pizza.Name,
            //        FullName = $"{order.User.FirstName} {order.User.LastName}",
            //        PaymentMethod= order.PaymentMethod,
            //        Price = order.Pizza.Price
            //    };

            //   orderViewModels.Add(temporaryOrderViewModel);
            //}



            //List<OrderViewModel> orderViewModels = ordersFromDb.Select((order) => new OrderViewModel
            //{
            //    PizzaName = order.Pizza.Name,
            //    FullName = $"{order.User.FirstName} {order.User.LastName}",
            //    PaymentMethod= order.PaymentMethod,
            //    Price = order.Pizza.Price
            //}).ToList();




            //List<OrderViewModel> orderViewMOdels = ordersFromDb.Select(order =>  OrderMapper.ToViewOrderModel(order)).ToList();

            List<OrderViewModel> orderViewModel = ordersFromDb.Select(order => order.ToViewOrderModelExtension()).ToList();

            return View(orderViewModel);
        }

        public IActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return RedirectToAction("Error","Pizza");
            }

            Order order = StaticDb.Orders.FirstOrDefault(order => order.Id == Id);

            if(order == null)
            {
                return RedirectToAction("Error", "Pizza");
            }
            return View(order);
        }
    }
}
