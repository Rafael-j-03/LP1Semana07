using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterFillSpheres
{
    public class Sphere
    {
        //Color
        private int throwCount;

        // Getters and setters
        public Color Color { get ; set ;}
        public float Radius { get ; set ;}

        // Pop method
        public void Pop()
        {
            Radius = 0;
        }

        // Throw method
        public void Throw()
        {
            if (Radius > 0)
            {
                throwCount++;
            }
        }

        // Get throw count
        public int GetTimesThrown { get => throwCount; }
    }
}