using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color 
    {
        // Getters and setters
        public byte Red { get; set ; }
        public byte Green { get; set ; }
        public byte Blue { get; set ; }
        public byte Alpha { get; set ; } = 255;

        // Get grey value
        public byte GetGrey { get => (byte)((Red + Green + Blue) / 3); }
    }
}