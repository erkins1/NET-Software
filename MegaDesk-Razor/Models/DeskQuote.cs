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
        [ForeignKey("ShippingSpeed")]
        public int ShippingSpeed { get; set; }      //This is a Foreign Key

        const decimal BasePrice = 200.00M;
        const decimal RateLargeDesk = 1.00M;
        const decimal RatePerDrawer = 50.00M;

        public decimal GetQuotePrice(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            var _context = context;
            IQueryable<Desk> deskList = _context.Desk.Where(m => m.ID == Desk).Select(m => m);
            var newDesk = deskList.ToList();
            IQueryable<Materials> typeList = _context.Materials.Where(m => m.ID == newDesk[0].Materials).Select(m => m);
            var materialsList = typeList.ToList();
            IQueryable<ShippingSpeed> shipList = _context.ShippingSpeed.Where(m => m.ID == ShippingSpeed).Select(m => m);
            var speedList = shipList.ToList();

            var deskSize = newDesk[0].Width * newDesk[0].Depth;

            var deskPrice = BasePrice;

            deskPrice += (deskSize - 1000) * RateLargeDesk;

            deskPrice += newDesk[0].NumDrawers * RatePerDrawer;

            // Get price based on material
            deskPrice += materialsList[0].Price;

            if (deskSize < 1000)
            {
                deskPrice += speedList[0].BasePrice;
            }else if (deskSize >= 1000 && deskSize < 2000)
            {
                deskPrice += speedList[0].Over1000Price;
            }
            else
            {
                deskPrice += speedList[0].Over2000Price;
            }



            return deskPrice;
        }

    }
}
