using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "CustomerFirstname")]
        [StringLength(50, MinimumLength = 1)]
        public string CustomerFirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "CustomerLastname")]
        [StringLength(50, MinimumLength = 1)]
        public string CustomerLastName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerGender { get; set; }

        public List<LibraryLoan> LibraryLoans { get; set; }
    }
}
