using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace lab_21.Models
{
    public class Movie
    {
        public int Id { get; set; }


        [StringLength(50, MinimumLength = 1, ErrorMessage = "For real? Try to shorten the title.")]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Range(1880, 2021, ErrorMessage ="Don't lie, give us the correct year. Or did you make this whole thing up?")]
        public int Year { get; set; }
        ////////Could not find a way to set a range for date. Int makes sense here anyway,
        ////////normally how people categorize movies (by year)

        public string Actors { get; set; }

        public string Director { get; set; }


    }
}