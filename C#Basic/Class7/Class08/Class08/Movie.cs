using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08
{
    public class Movie
    {
        public string Title { get; set; }
        public int Genre { get; set; }
        public string Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, int genre, string rating, int ticketPrice)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice;
        }
    }
    
}
