using eCommerce.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //RealtionShip
        public List<Actor_Movie> Actor_Movies { get; set; } // movie have many-tomany relation with actors for this we create join class actor_movie and in it we define the relation 
        public int CenimaId { get; set; }
        [ForeignKey("CenimaId")] // means movie have one to many relation with cenima also have with producer
        public Cenima Cenima { get; set; }
        public int Producerid { get; set; }
        [ForeignKey("Producerid")]
        public Producer Producer { get; set; }
    }
}
