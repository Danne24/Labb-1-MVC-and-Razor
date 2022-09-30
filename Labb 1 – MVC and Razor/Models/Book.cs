using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookPublishedYear { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public bool BookCurrentlyAvailableForRent { get; set; }
        public string BookImageThmbnailUrl { get; set; }

        public List<LibraryLoan> LibraryLoans { get; set; }
    }
}
