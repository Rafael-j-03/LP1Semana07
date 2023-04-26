using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        //Color
        private Color color;
        private float radius;
        private int throwCount;

        // Constructor
        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.throwCount = 0;
        }
    }
}