using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Error. Please provide a name!")]
        public string Name { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Error. Please provide a logo!")]
        public string Logo { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Error. Please provide a description!")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
