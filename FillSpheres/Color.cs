using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Color 
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        // Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Constructor putting alpha to 255
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }

        // Getters
        public byte Red()
        {
            return red;
        }
        public byte Green()
        {
            return green;
        }
        public byte Blue()
        {
            return blue;
        }
        public byte Alpha()
        {
            return alpha;
        }

        // Setters
        public void SetRed(byte red)
        {
            this.red = red;
        }
        public void SetGreen(byte green)
        {
            this.green = green;
        }
        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        // Get grey value
        public byte  GetGrey()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}