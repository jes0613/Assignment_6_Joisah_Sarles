using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Models
{
    //The book class, has the fields needed for the projects as listed in the spec
    //All the fields are required and the bookId is set as the Key
    public class Book
    {
        [Key]
        public int bookId { get; set; }
        [Required]
        public string title { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public string publisher { get; set; }

        [Required]
        // Checks the isbn to make sure it's in the right format
        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$",
            ErrorMessage =" ISBN in not in the required format of ###-##########")]
        public string isbn { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public double price { get; set; }




    }
}
