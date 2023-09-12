using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels;

namespace PizzaApp.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToViewOrderModel(Order order)
        {
            return  new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                FullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50,
                Id = order.Id


            };
        }

        public static OrderViewModel ToViewOrderModelExtension( this Order order )
        {
            return new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                FullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50,
                Id= order.Id


            };

        }
    }
}
