using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Proiect.Data.Enums;

namespace Proiect.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Display(Name = "Movie name")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
    }
}
