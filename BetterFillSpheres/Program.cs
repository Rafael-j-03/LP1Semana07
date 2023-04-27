using System;

namespace BetterFillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 spheres
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 1);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 1);

            // Throw them
            sphere1.Throw();
            sphere2.Throw();

            // Pop them
            sphere1.Pop();

            // Print state including color
            Console.WriteLine("Sphere 1: radius = " + sphere1.GetRadius() + 
            ", throw count = " + sphere1.GetThrowCount() + ", color = " + 
            sphere1.GetColor().GetRed() + ", " + sphere1.GetColor().GetGreen() + 
            ", " + sphere1.GetColor().GetBlue());

            Console.WriteLine("Sphere 2: radius = " + sphere2.GetRadius() +
            ", throw count = " + sphere2.GetThrowCount() + ", color = " +
            sphere2.GetColor().GetRed() + ", " + sphere2.GetColor().GetGreen() +
            ", " + sphere2.GetColor().GetBlue());
        }
    }
}
