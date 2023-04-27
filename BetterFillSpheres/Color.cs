using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Color 
    {
        // Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }
        
        // Constructor
        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }

        // Getters and setters
        public byte Red { get; set ; }
        public byte Green { get; set ; }
        public byte Blue { get; set ; }
        public byte Alpha { get; set ; }

        // Get grey value
        public byte GetGrey { get => (byte)((Red + Green + Blue) / 3); }
    }
}