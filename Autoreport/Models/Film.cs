﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Autoreport.Models
{
    class Director : Person
    {
    }

    class Film
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual Country FilmCounty { get; set; }
        public virtual Studio FilmStudio { get; set; }
        public virtual Director FilmDirector { get; set; }
        public virtual List<Genre> Genres { get; set; }
    }
}