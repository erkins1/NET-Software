using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Models
{
    public class Desk
    {
        public int ID { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal NumDrawers { get; set; }
        public int MaterialType { get; set; }       //This is a Foreign Key
    }
}
