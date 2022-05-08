using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; } // means actor_movie have all movie and its id will be movieId above mentioned here movieId and actorId is forgin key but we will not write foreignkey annotaion cuz EF knows that data type we define here Movie and Actor is have Id in above line is foriegn key same can gor in movie class but it's our Choice but for many-to-many we have to tell the translator that this join class have forign keyv relation and also have relations with two tables

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
