using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mms_in_mvc.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }


    }

    public class Movie
    {
        
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
    }


    public class MMSDBContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}