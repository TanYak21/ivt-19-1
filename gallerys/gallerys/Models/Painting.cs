﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using gallerys.Models;

namespace gallerys.Models
{
    public class Painting
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1000, 3000)]
        public int Year { get; set; }
        public int Price { get; set; }
        public int status { get; set; }
<<<<<<< HEAD
        public int AuthorId { get; set; }
=======
>>>>>>> 12601dee55c3e9e0ccdc8fba1069884aa2ab34ef
        public virtual Author Author { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual List<Journal> Journals { get; set; }
    }
}
