using LibrariApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibrariApp1.Controllers
{
    public class BookController : Controller
    {
        

        public IActionResult Index()
        {
            List<Book> books = StaticDb.Books;
            return View(books);
        } 

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        [Route("json")]
        public IActionResult GetJson()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Kasni Porasni"
            };

            return  new JsonResult(book);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public IActionResult SecondRedirect()
        {
            return RedirectToAction("Index","Home");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Book book = StaticDb.Books.FirstOrDefault(book => book.Id == id);

            if(book == null)
            {
                return new EmptyResult();
            }


            return View(book);
        }
        [Route("Deletebook/{id?}/filter/{filterParam?}")]
        public IActionResult Delete(int? id , string filterParam)
        {
            return View();
        }

        public IActionResult ViewDataExemple ()
        {
            ViewData.Add("randomData", "some random data");

            var book = new Book
            {
                Id = 123,
                Title = "Test Book 1"
            };

            

            return View();
        }


        public IActionResult ViewBagExemple()
        {
            
            ViewBag.RandomData = "some random data";
            var book = new Book
            {
                Id = 123,
                Title = "Test Book 1"
            };

            ViewBag.Book = book;


            return View();
        }

        public IActionResult ViewModelExemple()
        {
            var book = new Book
            {
                Id = 123,
                Title = "Test Book 1"
            };

            var commic = new Commic
            {
                Id = 123,
                CommicTitle = "Test Book 1"
            };
            return View();
        }

    }
}
