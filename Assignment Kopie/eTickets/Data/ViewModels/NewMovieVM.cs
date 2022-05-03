using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Error. Please provide a name!")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Error. Please provide a description!")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Error. Please provide a price!")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Error. Please provide a film poster!")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Error. Please provide a start date!")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "Error. Please provide an end date!")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Choose a category")]
        [Required(ErrorMessage = "Error. Please choose a category!")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select the appropriate actors!")]
        [Required(ErrorMessage = "Please choose the appropriate actors!")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Error. Please select the appropriate cinema/s!")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Error. Please choose the appropriate producer!")]
        public int ProducerId { get; set; }
    }
}
