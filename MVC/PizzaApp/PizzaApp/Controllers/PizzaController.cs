using Microsoft.AspNetCore.Mvc;

namespace PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas()
        {
            var pizzas = StaticDb.Pizzaas;
            return View(pizzas);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error");
            }

            var pizza = StaticDb.Pizzaas.FirstOrDefault(pizza => pizza.Id == id);

            if(pizza == null)
            {
                return RedirectToAction("Error");
            }

           return View(pizza);
        }


        public IActionResult Error()
        {
            return View();
        }


    }
}
