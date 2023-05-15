using Proiect.Models;

namespace Proiect.DTO
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Cinemas = new List<Models.Cinema>();
            Actors = new List<Models.Actor>();
        }

        public List<Models.Cinema> Cinemas { get; set; }
        public List<Models.Actor> Actors { get; set; }
    }
}
