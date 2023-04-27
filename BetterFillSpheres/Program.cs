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
            ", throw count = " + sphere1.GetTimesThrown() + ", color = " + 
            sphere1.GetColor().Red + ", " + sphere1.GetColor().Green + 
            ", " + sphere1.GetColor().Blue + ", " + sphere1.GetColor().Alpha);

            Console.WriteLine("Sphere 2: radius = " + sphere2.GetRadius() +
            ", throw count = " + sphere2.GetTimesThrown() + ", color = " +
            sphere2.GetColor().Red + ", " + sphere2.GetColor().Green +
            ", " + sphere2.GetColor().Blue + ", " + sphere2.GetColor().Alpha);
        }
    }
}
