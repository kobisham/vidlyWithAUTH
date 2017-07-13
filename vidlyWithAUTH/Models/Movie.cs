using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidlyWithAUTH.Models;

namespace vidlyWithAUTH.Models
{
    public class Movie
    {
        public int Id { get;  set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name ="Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }


        public DateTime DateAdded { get; set; }

        [Display(Name ="Number in stock")]
        [Required]
        [Range(1,20)]
        public int NumberInStock { get; set; }
    }

    
}