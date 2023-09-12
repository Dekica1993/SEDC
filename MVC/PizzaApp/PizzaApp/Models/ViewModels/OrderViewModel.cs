using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
      public string PizzaName { get; set; } 

      public string FullName { get;set; }

      public int Price { get; set; }

      public PaymentMethod PaymentMethod { get; set; }
    }
}
