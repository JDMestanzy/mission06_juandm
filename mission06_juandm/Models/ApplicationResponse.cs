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
        [Required(ErrorMessage ="Please enter the Title for the movie")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the year the movie was released")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter the director for the movie")]
        public string Director { get; set; }
        
        public Ratings Rating { get; set; }
        public bool Edited { get; set; }

        //build foreign key relationship!!
        [Required(ErrorMessage = "Please enter the Movie Category ")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
