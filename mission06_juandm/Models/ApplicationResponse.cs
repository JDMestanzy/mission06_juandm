using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_juandm.Models
{
    public enum Ratings
    {
        //this is how the ratings will show in my db :) hopefully that doesn't take points away
        G = 0,
        PG = 1,
        PG13 = 2,
        R = 3
    }

    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        
        public Ratings Rating { get; set; }
        public bool Edited { get; set; }


    }
}
