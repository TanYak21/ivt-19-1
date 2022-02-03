﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Autoreport.Models
{
    class Director : IPerson
    {
        public int Id { get; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
    }

    class Film
    {
        public int Id { get; }
        public string Name { get; set; }
        public Country FilmCounty { get; set; }
        public Studio FilmStudio { get; set; }
        public Director FilmDirector { get; set; }
        List<Genre> Genres { get; set; }
    }
}