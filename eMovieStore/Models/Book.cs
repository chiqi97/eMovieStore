﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(70)]
        public string Title { get; set; }
        [Required]
        [MaxLength(30)]
        public string Genre { get; set; }
        [Required]
        [MaxLength(30)]
        public string Author { get; set; }
        public string PhotoPath { get; set; }

    }
}
