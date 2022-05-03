using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Actors = new List<Actor>();
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
        }

        public List<Actor> Actors { get; set; }
        public List<Producer> Producers { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}
