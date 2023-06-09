using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillSpheres
{
    public class Sphere
    {
        //Color
        private readonly Color color;
        private float radius;
        private int throwCount;

        // Constructor
        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.throwCount = 0;
        }

        // Pop method
        public void Pop()
        {
            this.radius = 0;
        }

        // Throw method
        public void Throw()
        {
            if (this.radius > 0)
            {
                this.throwCount++;
            }
        }

        // Get throw count
        public int GetTimesThrown()
        {
            return this.throwCount;
        }

        // Get color
        public Color GetColor()
        {
            return this.color;
        }

        // Get radius
        public float GetRadius()
        {
            return this.radius;
        }
    }
}