using LibrariApp1.Models;

namespace LibrariApp1
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>
      {
          new Book
          {
              Id = 1,
              Title = "Kasni Porasni"
          },
           new Book
          {
              Id = 2,
              Title = "Begalka"
          },
            new Book
          {
              Id = 3,
              Title = "Tetoviranje"
          },
             new Book
          {
              Id = 4,
              Title = "Doktor Ofboli"
          },
                new Book
          {
              Id = 5,
              Title = "GodFather"
          }
      };

    }
}
