using Microsoft.Exchange.WebServices.Data;
using PizzaApp.Models.Domain;
using PizzaApp.Models.Enums;

namespace PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzaas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Capri",
                Price = 300,
                IsPromotion = true
            },

             new Pizza
            {
                Id = 2,
                Name = "Peperoni",
                Price = 400,
                IsPromotion = false
            },
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Bobski",
                PhoneNumber = "12345"
            },
            new User
            {
                Id = 2,
                FirstName = "Kate",
                LastName = "Katesy",
                PhoneNumber = "1234568"
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id=1,
                PizzaId=1,
                UserId=2,
                Pizza = Pizzaas[0],
                User = Users.First(user => user.Id == 1),
                PaymentMethod = PaymentMethod.Cash
            },
              new Order
            {
                Id=2,
                PizzaId=1,
                UserId=1,
                Pizza = Pizzaas[0],
                User = Users.First(user => user.Id == 1),
                PaymentMethod = PaymentMethod.Card


             }
        };   
    }
}
