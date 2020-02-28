using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Models
{
    public class Desk
    {
        public int ID { get; set; }

        [Range(24, 96)]
        [Required]
        public decimal Width { get; set; }

        [Range(12, 48)]
        [Required]
        public decimal Depth { get; set; }

        [Range(0, 7)]
        [Display(Name = "Number of Drawers")]
        [Required]
        public decimal NumDrawers { get; set; }
        
        public int Materials { get; set; }       //This is a Foreign Key
        //[Display(Name = "Material Type")]
        //[ForeignKey("MaterialsID")]
       // public Materials Materials { get; set; }
        /* Navigation Property */
        //public Materials DesktopType { get; set; } //What does this do?
    }
}
