using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public class LibraryLoan
    {
        [Key]
        public int LibraryLoanID { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DateOfLoan { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime LastDateToReturn { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DateOfReturn { get; set; }
        public bool IsReturned { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
