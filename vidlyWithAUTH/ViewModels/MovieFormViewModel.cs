﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidlyWithAUTH.Models;

namespace vidlyWithAUTH.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Required]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id!=0?  "Edit Movie": "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            ReleaseDate = movie.ReleaseDate;
            Name = movie.Name;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;

        }

    }
}