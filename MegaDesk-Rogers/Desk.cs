using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Rogers
{
    public class Desk
    {

        //Enum basically assigns a number to a word
        public enum DesktopMaterial
        {
            Oak,
            Laminate, 
            Pine, 
            Rosewood, 
            Veneer
        }

        //Type prop and then hit Tab twice
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal NumDrawers { get; set; }
        public DesktopMaterial MaterialType { get; set; }



    }
}
