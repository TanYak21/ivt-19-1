﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proekt_a4tech
{
    public class Nationality
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
