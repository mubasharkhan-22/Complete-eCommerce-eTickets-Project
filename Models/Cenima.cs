using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Cenima
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cenima Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        //RealtionShip
        public List<Movie> Movies { get; set; } // means Cenima can have multiple movies or list of movies but movie can have only one cenima or we can have ticket of movie only from on cenima
    }
}
