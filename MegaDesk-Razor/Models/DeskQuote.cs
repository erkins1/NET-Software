using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Customer Name")]
        [StringLength(100)]
        [Required]
        public String CustomerName { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Desk { get; set; }               //This is a Foreign Key

        [Display(Name = "Shipping Speed")]
        public int ShippingSpeed { get; set; }      //This is a Foreign Key

        const decimal BasePrice = 200.00M;
        const decimal RateLargeDesk = 1.00M;
        const decimal RatePerDrawer = 50.00M;

        public decimal GetQuotePrice()
        {
            return 0;
        }

    }
}
