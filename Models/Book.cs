using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Models
{
    //The book class, has the fields needed for the projects as listed in the spec
    // I made sure to normalize the database for all the fields/variables
    //All the fields are required and the bookId is set as the Key
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }

        [Required]
        public string authorFirst { get; set; }
        public string? authorMiddle { get; set; } = "";

        [Required]
        public string authorLast { get; set; }

        [Required]
        public string publisher { get; set; }

        [Required]
        // Checks the isbn to make sure it's in the right format
        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$",
            ErrorMessage =" ISBN in not in the required format of ###-##########")]
        public string isbn { get; set; }

        [Required]
        public string classification { get; set; }

        [Required]
        public string category { get; set; }


        //Added this pages to the model
        [Required]
        public int pages { get; set; }

        [Required]
        public double price { get; set; }




    }
}
