﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proekt_a4tech
{
    public class Judge
{
        public int Id { get; set; }
        [MaxLength(200)]
        public string FullNname { get; set; }
        [Range(1,10)]
        public string Category { get; set; }
        public DateTime Experience { get; set; }
        public virtual Competition JudgeCompetition { get; set; }
    }
}
